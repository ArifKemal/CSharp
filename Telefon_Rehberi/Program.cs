class Program
{
    public static void Main(string[] args)
    {
        List<PhoneBook> phoneBook = new List<PhoneBook>();
        //Automatically adding 5 people to our ArrayList
        phoneBook.Add(new PhoneBook()
        {
            Name = "Arif",
            Surname = "Erdönmez",
            TelNo = "05369945787"
        });
        phoneBook.Add(new PhoneBook()
        {
            Name = "Kemal",
            Surname = "Erdönmez",
            TelNo = "05524770259"
        });
        phoneBook.Add(new PhoneBook()
        {
            Name = "Ahmet",
            Surname = "Erdönmez",
            TelNo = "05519071571"
        });
        phoneBook.Add(new PhoneBook()
        {
            Name = "Enes",
            Surname = "Erdönmez",
            TelNo = "05392658049"
        });
        phoneBook.Add(new PhoneBook()
        {
            Name = "Ertuğrul",
            Surname = "Ekren",
            TelNo = "05369651274"
        });

        
        PhoneBook myBook = new PhoneBook();
        int choice;
        do
        {
            Console.WriteLine("\nPlease choose the operation you want :) ");
            Console.WriteLine("**********************************");
            Console.WriteLine("(1) Save a new number\n(2) Delete an existing number\n(3) Update an existing number\n(4) List the book\n(5) Search in the book\n(6) Exit");
            Console.Write("Your Choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1) {
                myBook.saveNumber(phoneBook);
                Console.WriteLine("The number has been saved!");
            }
            else if (choice == 2)
                myBook.deleteNumber(phoneBook);
            else if (choice == 3)
                myBook.updateNumber(phoneBook);
            else if (choice == 4)
                myBook.listBook(phoneBook);
            else if (choice == 5)
                myBook.searchBook(phoneBook);
            else if (choice == 6)
                Console.WriteLine("Bye!!!");
            else
                Console.WriteLine("Please enter a valid choice!");
        } while (choice != 6);
    }
}