Greeting();
Menu();

void Greeting() { 
string greeting = @"Welcome to Reducto and Absurdum
Your one-stop shop for all your witchcraft and wizardry needs";
Console.WriteLine(greeting);
}

void Menu() {
    string choice = null;
    while (choice != "0") {
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
                Console.WriteLine("View All Products");
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

class Product
{
    public string name = null;
    public decimal price;
    public bool available;
    public string ProductTypeId = null;



}



