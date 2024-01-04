using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Reducto_and_Absurdum
{
    class CategoryFunctions 
    {
        public static void CategoryFind()
        {
            string choice = null;
            Console.WriteLine("Choose a category");
            for (int i = 0; i < Globals.ProductCategories.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {Globals.ProductCategories[i].Name}");
            
            }
            choice = Console.ReadLine();
            string indxChoice = Globals.ProductCategories[Int32.Parse(choice) - 1].Name;
            List<Product> searchedProduct = Globals.Products.ToList().Where(cat => cat.ProductTypeId == indxChoice).ToList();
            foreach (Product prod in searchedProduct)
            {
                Console.WriteLine(prod.Name);
            }
        
        }
    
    }
}
