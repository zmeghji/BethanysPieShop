using BethanysPieShopCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BethanysPieShopCore.Repositories
{
    public class CategoryRepository
    {
        public List<Category> Get()
        {
            return new List<Category>
            {
                new Category
                {
                    Name = "Fruit"
                },
                new Category
                {
                    Name="Other"
                }
            };
        }
    }
}
