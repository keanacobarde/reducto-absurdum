using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reducto_and_Absurdum
{
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
        public static void ViewProducts()
        {
            for (int i = 0; i < Globals.Products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Globals.Products[i].Name}");
            }
        }

        // UPDATE
        public static void UpdateProducts()
        {
            string choice = null;

            while (choice != "0")
            {
                try
                {
                    // loop through products but create a ReadLine
                    Console.WriteLine("0. Goodbye");
                    for (int i = 0; i < Globals.Products.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {Globals.Products[i].Name}");

                    }
                    Console.WriteLine("Choose the item you wish to edit.");
                    choice = Console.ReadLine();
                    object IndxChoice = Globals.Products[Int32.Parse(choice) - 1];

                    // view the properties of the object that you're looking to edit
                    foreach (PropertyDescriptor desc in TypeDescriptor.GetProperties(IndxChoice))
                    {
                        string name = desc.Name;
                        object value = desc.GetValue(IndxChoice);
                        Console.WriteLine(name + ": " + value);
                    }
                    string propToEdit = Console.ReadLine();

                    Console.WriteLine("What value would you like to change it to?");

                    string valueToChange = Console.ReadLine();

                    foreach (PropertyDescriptor desc in TypeDescriptor.GetProperties(IndxChoice))
                    {
                        if (desc.Name == propToEdit) 
                        {
                            desc.SetValue(IndxChoice, valueToChange);
                        }
                    }

                }
                catch
                {
                    break;
                }
            }
        }
        // DELETE 
        public static void DeleteProducts()
        {
            string choice = null;

            while (choice != "0")
            {
                try
                {
                    // loop through products but create a ReadLine
                    Console.WriteLine("0. Goodbye");
                    for (int i = 0; i < Globals.Products.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {Globals.Products[i].Name}");

                    }
                    choice = Console.ReadLine();
                    Globals.Products.RemoveAt(Int32.Parse(choice));
                }
                catch {
                    break;
                }

            }
        }

    }
}