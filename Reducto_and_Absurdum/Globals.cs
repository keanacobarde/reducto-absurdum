using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reducto_and_Absurdum
{
    class Globals
    {
        public static List<Product> Products = new List<Product>()
{
    new Product()
    {
        Name = "Dragonfire Wand",
        Price = 1500.00M,
        Sold = false,
        DateStocked = new DateTime(2023, 01, 02),
        ProductTypeId = "Wands",
    },
    new Product()
    {
        Name = "Robes",
        Price = 1230.00M,
        Sold = false,
        DateStocked = new DateTime(2023, 01, 02),
        ProductTypeId = "Apparel",
    },
    new Product()
    {
        Name = "Cauldron",
        Price = 1500.00M,
        Sold = false,
        DateStocked = new DateTime(2023, 01, 02),
        ProductTypeId = "Potions",
    }

};

        public static List<ProductCategory> ProductCategories = new List<ProductCategory>()
{
    new ProductCategory()
    {
        Name = "Apparel",
        Id = "1"

    },
    new ProductCategory()
    {
        Name = "Potions",
        Id = "2"

    },
    new ProductCategory()
    {
        Name = "Enchanted Objects",
        Id = "3"

    },
    new ProductCategory()
    {
        Name = "Wands",
        Id = "4"

    },

};

        public static void Greeting()
        {
            string greeting = @"Welcome to Reducto and Absurdum
    Your one-stop shop for all your witchcraft and wizardry needs";
            Console.WriteLine(greeting);
        }

        public static void Menu()
        {
            string choice = null;
            while (choice != "0")
            {
                Console.WriteLine(@"Choose an option: 
                      0. Exit
                      1. View All Products
                      2. Add a Product
                      3. Delete a Product
                      4. Update a Product");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        Console.WriteLine("Goodbye");
                        break;
                    case "1":
                        ProductFunctions.ViewProducts();
                        break;
                    case "2":
                        ProductFunctions.CreateProduct();
                        break;
                    case "3":
                        ProductFunctions.DeleteProducts();
                        break;
                    case "4":
                        ProductFunctions.UpdateProducts();
                        break;
                }
            }

        }

    }



}