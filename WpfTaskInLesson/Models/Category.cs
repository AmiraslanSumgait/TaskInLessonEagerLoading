using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTaskInLesson.Models
{
    public class Category:BaseEntity
    {
        public Category()
        {
            Products = new List<Product>();
        }
        public string? Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}
