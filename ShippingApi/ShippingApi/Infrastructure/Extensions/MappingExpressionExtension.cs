using AutoMapper;

namespace ShippingApi.Infrastructure.Extensions
{
    public static class MappingExpressionExtension
    {
        public static IMappingExpression<TSource, TDest> IgnoreAllUnmapped<TSource, TDest>(this IMappingExpression<TSource, TDest> expression)
        {
            expression.ForAllMembers(opt => opt.Ignore());

            return expression;
        }
    }
}
