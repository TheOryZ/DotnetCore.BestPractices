using DotnetCore.BestPractices.Core.Entites.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.BestPractices.Core.Entites.Concrete
{
    public class Category : ITable
    {
        public Category() //İlk oluşturulduğunda otomatik bir tane collection oluşturması için eklendi.
        {
            Products = new Collection<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
