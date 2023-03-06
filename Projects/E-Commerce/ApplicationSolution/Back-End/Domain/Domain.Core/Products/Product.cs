using Domain.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Products
{
    public class Product : AggregationRootFullAudit<long>
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public ProductPrice Price { get; private set; }
        public decimal TotalCountOfViewers { get; private set; }
        public decimal TotalCountOfLikes { get; private set; }

        private readonly List<ProductViewer> _productViewers = new List<ProductViewer>();
        public IReadOnlyCollection<ProductViewer> ProductViewers => _productViewers.AsReadOnly();
        
        private readonly List<ProductLike> _productLikes = new List<ProductLike>();
        public IReadOnlyCollection<ProductLike> ProductLikes => _productLikes.AsReadOnly();

        private readonly List<ProductAttribute> _productAttributes = new List<ProductAttribute>();
        public IReadOnlyCollection<ProductAttribute> ProductAttributes => _productAttributes.AsReadOnly();

        public Product() { }

        public Product(string name , string description , decimal price) 
        {
            this.Name = name;
            this.Description = description;
            this.Price = new ProductPrice(price);
        }
    }
}
