using Microsoft.EntityFrameworkCore;

namespace ShippingApi.Infrastructure.Extensions
{
    public static class DbMigratorExtension
    {
        public static async Task MigrateAsync(this IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<ShippingDbContext>();

            await context.Database.MigrateAsync();
        }
    }
}
