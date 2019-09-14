using BethanysPieShopCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BethanysPieShopCore
{
    public interface IPieRepository
    {
        Pie Get(int id);

    }
    public class PieRepository : IPieRepository
    {
        private static List<Pie> Pies = new List<Pie> {
            new Pie
            {
                Id = 1,
                Name = "Cherry Pie",
                ShortDescription = "A pie with cherries",
                Description = "A pie with cherries. What more do you want me to say? It has cherries and it is a pie. It is a pie and it has cherries",
                Price=10.50,
                ImageUrl="https://www.thespruceeats.com/thmb/KzYv8HGt29aoPg19YWritWGeNIU=/960x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/slice-of-cherry-pie-with-cherry-on-side-on-plate-169960522-67fcb3cdc8024ea48f2f5a8cd3d2fd8c.jpg",
                Categories = new List<Category>{ new Category { Name="Fruit"} }
            },
            new Pie
            {
                Id = 2,
                Name = "Blueberry Pie",
                ShortDescription = "A pie with blueberries",
                Description = "A pie with blueberries. What more do you want me to say? It has blueberries and it is a pie. It is a pie and it has blueberries",
                Price=13.95,
                ImageUrl="https://www.simplyrecipes.com/wp-content/uploads/2009/07/blueberry-pie-vertical-a-18001.jpg",
                Categories = new List<Category>{ new Category { Name="Fruit"} }

            },
             new Pie
            {
                Id = 3,
                Name = "Apple Pie",
                ShortDescription = "A pie with apples",
                Description = "A pie with apples. What more do you want me to say? It has apples and it is a pie. It is a pie and it has apples",
                Price=12.00,
                ImageUrl="https://preppykitchen.com/wp-content/uploads/2015/12/Apple-Pie-Feature.jpg",
                Categories = new List<Category>{ new Category { Name="Fruit"} }

            }
             ,
             new Pie
            {
                Id = 4,
                Name = "Pumpkin Pie",
                ShortDescription = "A pie with pumpkins",
                Description = "A pie with pumpkins. What more do you want me to say? It has pumpkins and it is a pie. It is a pie and it has pumpkins",
                Price=12.00,
                ImageUrl="https://www.meals.com/imagesrecipes/18470lrg.jpg",
                Categories = new List<Category>{ new Category { Name="Fruit"} }

            },
             new Pie
            {
                Id = 5,
                Name = "Key Lime Pie",
                ShortDescription = "A pie with key limes",
                Description = "A pie with key limes. What more do you want me to say? It has key limes and it is a pie. It is a pie and it has key limes",
                Price=12.00,
                ImageUrl="https://i1.wp.com/www.livewellbakeoften.com/wp-content/uploads/2018/01/Classic-Key-Lime-Pie-2-copy.jpg?fit=1360%2C1360&ssl=1",
                Categories = new List<Category>{ new Category { Name="Fruit"} }

            },
              new Pie
            {
                Id = 6,
                Name = "Sugar Pie",
                ShortDescription = "A pie with sugar",
                Description = "A pie with sugar. What more do you want me to say? It has sugar and it is a pie. It is a pie and it has sugar",
                Price=12.00,
                ImageUrl="https://images.media-allrecipes.com/userphotos/720x405/4571409.jpg",
                Categories = new List<Category>{ new Category { Name="Other"} }

            },
              new Pie
            {
                Id = 7,
                Name = "Pecan Pie",
                ShortDescription = "A pie with pecans",
                Description = "A pie with pecans. What more do you want me to say? It has pecans and it is a pie. It is a pie and it has pecans",
                Price=12.00,
                ImageUrl="https://realhousemoms.com/wp-content/uploads/Pecan-Pie-Recipe-Easy-Dessert-Recipe-HERO.jpg",
                Categories = new List<Category>{ new Category { Name="Other"} }

            }
        };

        public Pie Get(int id)
        {
            return Pies.First(p => p.Id == id);
        }
        public List<Pie> Get()
        {
            return Pies.ToList();
        }
        public List<Pie> GetByCategory(string categoryName)
        {
            return Pies.Where(p => p.Categories.Any(c => c.Name == categoryName)).ToList();
        }
    }
}
