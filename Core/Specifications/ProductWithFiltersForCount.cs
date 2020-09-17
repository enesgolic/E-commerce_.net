using Core.Entities;

namespace Core.Specifications
{
    public class ProductWithFiltersForCount : BaseSpecification<Product>
    {
        public ProductWithFiltersForCount(ProductSpecParams productParams)
            : base(x =>
                 (!productParams.BrandId.HasValue || x.ProductBrandId == productParams.BrandId) &&
                 (!productParams.TypeId.HasValue || x.ProductTypeId == productParams.TypeId)
            )
        {
        }
    }
}