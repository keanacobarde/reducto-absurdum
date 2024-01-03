using System;
using System.Reflection;
using System.Reflection.PortableExecutable;



class Globals {
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
                    Console.WriteLine("Delete a Product");
                    break;
                case "4":
                    ProductFunctions.UpdateProducts();
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

class ProductCategory
{ 
    public string Name { get; set; }
    public string Id { get; set; }

}

class ProductFunctions
{
    //CREATE
    public static void CreateProduct()
    {
        //Asking for User Input
        Console.WriteLine("Please supply the name of the product you wish to add.");
        string productName = Console.ReadLine();
        Console.WriteLine("Please supply the price of the product you wish to add");
        decimal productPrice = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("What is the product type?");
        string productType = Console.ReadLine();

        //Creating User Input into Object
        Product ProductToAdd = new Product();
        ProductToAdd.Name = productName;
        ProductToAdd.Price = productPrice;
        ProductToAdd.ProductTypeId = productType;

        Globals.Products.Add(ProductToAdd);
    
    }

    // READ 
    public static void ViewProducts() {
        for (int i = 0; i < Globals.Products.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Globals.Products[i].Name}");
        }
    }

    // UPDATE
    public static void UpdateProducts()
    {
        //get user input from prompt 
        Console.WriteLine("Provide the name of the product you wish to modify.");
        string productName = Console.ReadLine();
        // get the product by a specific search parameter - use where
        List<Product> userQuery = Globals.Products.Where(prod => prod.Name == productName).ToList();
        // display the product's properties
        foreach (Product prod in userQuery) {
            foreach (PropertyInfo prodInfo in prod.GetType().GetProperties())
            {
                Console.WriteLine($"{prodInfo.Name}:{prodInfo.GetValue(prod, null).ToString()}");
            }
        }

        // target property and edit it
    }
    // DELETE 


}


class Program {
static void Main(string[] args)
{
    Globals.Greeting();
    Globals.Menu();
}

}







