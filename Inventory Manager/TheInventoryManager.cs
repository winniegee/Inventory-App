using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    
   public static class TheInventoryManager
    {
        public static IEnumerable<Inventory> FreshInventories()
        {
            List<Inventory> inventories = new List<Inventory>()
            {
                new Inventory()
                {
                    Name = "Classic eye pallete",
                    Price=15000
                },

                new Inventory()
                {
                    Name = "Iman Lip Set",
                    Price=15000
                },

                 new Inventory()
                {
                    Name = "Tala contour set",
                    Price=12500
                },
                  new Inventory()
                {
                    Name = "Tala eyeshadow set",
                    Price=10000
                },
                   new Inventory()
                {
                    Name = "Mac pro concealer set",
                    Price=18500
                },
                    new Inventory()
                {
                    Name = "Essence bronzer set",
                    Price=12800
                }
            };

            return inventories;

        }
        public static IEnumerable<Inventory> GetInventories()
        {
        List<Inventory> inventories = new List<Inventory>()
            {

                new Inventory()
                {
                    Id = 1,
                    Name = "Mac pro concealer",
                    Categories = new List<Category>{ GetCategories()[1] , GetCategories()[2] },
                    Price= 1500,
                    EntryDate=DateTime.Now
                },

                new Inventory()
                {
                    Id = 2,
                    Name = "Mac mineral foundation",
                    Categories = new List<Category>{ GetCategories()[0] },
                    Price=2500,
                    EntryDate=DateTime.Now
                },
    

                 new Inventory()
                {
                    Id = 3,
                    Name = "Classic mineral foundation",
                    Categories = new List<Category>{ GetCategories()[0] },
                    Price=4500,
        EntryDate = DateTime.Now,
    },
                  new Inventory()
                {
                    Id = 4,
                    Name = "Iman loose powder",
                    Categories = new List<Category>{ GetCategories()[2] },
                    Price=3000,
                    EntryDate=DateTime.Now
    },
                   new Inventory()
                {
                    Id = 5,
                    Name = "Tara primer",
                    Categories = new List<Category>{ GetCategories()[1], GetCategories()[2] },
                    Price=1800,
                    EntryDate=DateTime.Now
    },
                    new Inventory()
                {
                    Id = 6,
                    Name = "Allure mineral foundation",
                    Categories = new List<Category>{ GetCategories()[0],GetCategories()[2] },
                    Price=2700,
                    EntryDate=DateTime.Now
    },
                     new Inventory()
                {
                    Id = 7,
                    Name = "Essence eye primer",
                    Categories = new List<Category>{ GetCategories()[1] },
                    Price=1000,
                    EntryDate=DateTime.Now
    },
                      new Inventory()
                {
                    Id = 8,
                    Name = "Mac eye shadow",
                    Categories = new List<Category>{ GetCategories()[2] },
                    Price=1560,
                    EntryDate=DateTime.Now
    },
                       new Inventory()
                {
                    Id = 9,
                    Name = "Tala eyeshadow",
                    Categories = new List<Category>{ GetCategories()[0] },
                    Price=2800,
                    EntryDate=DateTime.Now
    },
                        new Inventory()
                {
                    Id = 10,
                    Name = "BB lipstick",
                    Categories = new List<Category>{ GetCategories()[1] },
                    Price=500,
                    EntryDate=DateTime.Now
    }

            };

            return inventories;

        }

        public static List<Category> GetCategories()
        {
            Category[] categories = new Category[3]
            {
                new Category(){ Name = "Mineral Products"},
                 new Category(){ Name = "Non-mineral products"},
                    new Category(){ Name = "Matte Products"},
            };

            return categories.ToList();

        }
    }

