using AutoFixture;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using ShippingApi.Infrastructure;

namespace ShippingApi.Tests.Services
{
    public class BaseServiceTest
    {
        private const string shippingTestDbName = "ShippingTestDb";

        protected readonly ShippingDbContext _dbContext;
        protected readonly Fixture _fixture;
        protected readonly Mapper _mapper;

        public BaseServiceTest()
        {
            var dbContextOptions = new DbContextOptionsBuilder<ShippingDbContext>()
                .UseInMemoryDatabase(shippingTestDbName, new InMemoryDatabaseRoot())
                .Options;
            var mapperConfig = new MapperConfiguration(cfg => cfg.AddProfile(new MapperConfig()));

            _dbContext = new ShippingDbContext(dbContextOptions);
            _fixture = new Fixture();
            _mapper = new Mapper(mapperConfig);

            _fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList()
                .ForEach(b => _fixture.Behaviors.Remove(b));
            _fixture.Behaviors.Add(new OmitOnRecursionBehavior());
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
