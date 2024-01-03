using System;
using System.Reflection.PortableExecutable;



class Globals {
    public static List<Product> Products = new List<Product>()
{
    new Product()
    {
        Name = "Wand",
        Price = 1500.00M,
        Sold = false,
        DateStocked = new DateTime(2023, 01, 02),
        ProductTypeId = "Utility",
    },
    new Product()
    {
        Name = "Robes",
        Price = 1230.00M,
        Sold = false,
        DateStocked = new DateTime(2023, 01, 02),
        ProductTypeId = "Clothing",
    },
    new Product()
    {
        Name = "Cauldron",
        Price = 1500.00M,
        Sold = false,
        DateStocked = new DateTime(2023, 01, 02),
        ProductTypeId = "Utility",
    }

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
                    Console.WriteLine("Add a Product");
                    break;
                case "3":
                    Console.WriteLine("Delete a Product");
                    break;
                case "4":
                    Console.WriteLine("Update a Product");
                    break;
            }
        }

    }



}
class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool Sold { get; set; }
    public string ProductTypeId { get; set; }
    public DateTime DateStocked { get; set; }

    public int DaysOnShelf
    {
        get
        {
            TimeSpan timeOnShelf = DateTime.Now - DateStocked;
            return timeOnShelf.Days;
        }
    }

}

class ProductFunctions
{
    public static void ViewProducts() {
    for (int i = 0; i < Globals.Products.Count; i++) {
            Console.WriteLine($"{i + 1}. {Globals.Products[i].Name}");
        }
    }


}


class Program {
static void Main(string[] args)
{
    Globals.Greeting();
    Globals.Menu();
}

}







