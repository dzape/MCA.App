namespace MCA.App.Services
{
    using System.Collections.Generic;
    using MCA.App.Data;
    public interface IProductService
    {
        public void GetStats(List<Product> products);
        public void IsDomestic(List<Product> products);
        public IEnumerable<Product> GetProductsByName(List<Product> products);
    }
}
