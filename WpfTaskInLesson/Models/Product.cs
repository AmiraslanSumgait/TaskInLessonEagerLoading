using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTaskInLesson.Models
{
    public class Product:BaseEntity
    {
        public string? ProductName { get; set; }
        public double Price { get; set; }
        public int Units { get; set; }

        public Category? Category { get; set; }
    }
}
