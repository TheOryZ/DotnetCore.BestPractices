using DotnetCore.BestPractices.Core.Entites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.BestPractices.Core.Entites.Concrete
{
    public class Product : ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public string BannerCode { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Category Category { get; set; }
    }
}
