using DotnetCore.BestPractices.Core.Entites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.BestPractices.Core.Entites.Concrete
{
    public class Person : ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
