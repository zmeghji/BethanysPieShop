using System;
using System.Collections.Generic;
using System.Text;

namespace BethanysPieShopCore.Models
{
    public class Pie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public List<Category> Categories { get; set; }
    }
}
