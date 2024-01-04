using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reducto_and_Absurdum
{
    class CategoryFunctions 
    {
        public static void CategoryFind()
        {
            Console.WriteLine("Choose a category");
            for (int i = 0; i < Globals.ProductCategories.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {Globals.ProductCategories[i].Name}");
            
            }
            
        
        }
    
    }
}
