public class PhoneBook {
    private string name;
    private string surname;
    private string telNo;

    public string Name { get => name; set => name = value; }
    public string Surname { get => surname; set => surname = value; }
    public string TelNo { get => telNo; set => telNo = value; }

    public  void saveNumber(List<PhoneBook> phoneBook) {
        Console.Write("Please enter name: ");
        string name = Console.ReadLine();
        Console.Write("Please enter surname: ");
        string surname = Console.ReadLine();
        Console.Write("Please enter telNo: ");
        string telNo = Console.ReadLine();
        phoneBook.Add(new PhoneBook(){
            Name = name,
            Surname = surname,
            TelNo = telNo
        });
    }

    public void deleteNumber(List<PhoneBook> phoneBook) {
        int myChoice = 2;
        do{
            Console.Write("\nPlease enter the name of the person you want to delete: ");
            string name = Console.ReadLine();
            Console.Write("Please enter the surname of the person you want to delete: ");
            string surname = Console.ReadLine();

            int foundFlag = 0;
            foreach(var item in phoneBook) {
                if(item.Name.Equals(name) && item.Surname.Equals(surname)) {
                    foundFlag = 1;
                    Console.Write("{0} {1} will be deleted from your phoneBook. Do you approve? (y/n): ", name, surname);
                    string choice = Console.ReadLine();
                    if(choice.ToLower().Equals("y")) {
                        phoneBook.Remove(item);
                        Console.WriteLine("{0} {1} is deleted from your phoneBook.", name, surname);
                        myChoice = 1; //for exiting the outer loop directly since the operation is already done.
                        break;
                    }
                    else if(choice.ToLower().Equals("n")) {
                        Console.WriteLine("Resetting the operation...");
                        break;
                    }
                    else
                        Console.WriteLine("Please enter a valid choice");
                }
            }
            if (foundFlag == 0) {

                Console.WriteLine("\nThe data matching your search criteria could not be found in the phoneBook. Please make a selection.");
                Console.WriteLine("* To end the deletion : (1)\n* To try again : (2)");
                Console.Write("Your choice: ");
                myChoice = int.Parse(Console.ReadLine());
                if (myChoice == 1) {
                    Console.WriteLine("Finishing the deletion operation...");
                     break;
                }
                else if(myChoice == 2)
                    Console.WriteLine("Trying again...");
                else{
                    Console.WriteLine("Please make a valid selection.");
                    break;
                }
            }
        }while(myChoice != 1);
    }

    public void updateNumber(List<PhoneBook> phoneBook) {
        int myChoice = 2;
        do{
            Console.Write("Please enter the name of the person you want to update: ");
            string name = Console.ReadLine();
            Console.Write("Please enter the surname of the person you want to update: ");
            string surname = Console.ReadLine();

            int foundFlag = 0;
            foreach(var item in phoneBook) {
                if (item.Name.Equals(name) && item.Surname.Equals(surname)) {
                    foundFlag = 1;
                    Console.Write("Please enter the new tel number: ");
                    string telNo = Console.ReadLine();
                    item.TelNo = telNo;
                    Console.WriteLine("Update for {0} {1} successull!", name, surname);
                    myChoice = 1;
                    break;
                }
            }

            if (foundFlag == 0) {
                Console.WriteLine("\nThe data matching your search criteria could not be found in the phoneBook. Please make a selection.");
                Console.WriteLine(" * To finish the update process : (1)\n* To try again : (2)");
                Console.Write("Your choice: ");
                if (myChoice == 1) {
                    Console.WriteLine("Finishing the update operation...");
                    break;
                }
                else if(myChoice == 2)
                    Console.WriteLine("Trying again...");
                else{
                    Console.WriteLine("Please make a valid selection.");
                    break;
                }
            }
        }while(myChoice != 1);
    }

    public void listBook(List<PhoneBook> phoneBook) {
        Console.WriteLine("Telephone Book");
        Console.WriteLine("**********************************");
        foreach(var item in phoneBook) {
            Console.WriteLine("Name: {0}",item.Name);
            Console.WriteLine("Surname: {0}",item.Surname);
            Console.WriteLine("TelNo: {0}",item.TelNo);
            Console.WriteLine("----------------------------------");
        }
    }

    public void searchBook(List<PhoneBook> phoneBook) {
        Console.WriteLine("Select the type you want to search.");
        Console.WriteLine("***************************************\n");
        Console.WriteLine("To search by first and last name: (1)");
        Console.WriteLine("To search by telNo: (2)");
        int choice;
        string name = "smth", surname = "smth", telNo = "smth"; //giving default values for comparing
        do{
            Console.Write("Your Choice: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1) {
                Console.Write("Enter the name of the person you want to search: ");
                name = Console.ReadLine();
                Console.Write("Enter the surname of the person you want to search: ");
                surname = Console.ReadLine();

            }
            else if (choice == 2) {
                Console.Write("Enter the telNo of the person you want to search: ");
                telNo = Console.ReadLine();
            }
            else
                Console.WriteLine("Please enter a valid choice!");
        }while(choice != 1 && choice != 2);

        Console.WriteLine("Your search results:");
        Console.WriteLine("***************************************\n");
        int foundFlag = 0;
        if (choice == 1) {
            foreach(var item in phoneBook) {
                if (item.Name.Equals(name) && item.Surname.Equals(surname)) {
                    Console.WriteLine("Searching by the name and surname you entered...");
                    Console.WriteLine("Name: {0}",item.Name);
                    Console.WriteLine("Surname: {0}",item.Surname);
                    Console.WriteLine("TelNo: {0}",item.TelNo);
                    Console.WriteLine("----------------------------------");
                    foundFlag = 1;    
                }  
            }
        }
        else if (choice == 2) {
            foreach(var item in phoneBook) {
                if (item.TelNo.Equals(telNo)) {
                    Console.WriteLine("Searching by telNo you entered...");
                    Console.WriteLine("Name: {0}",item.Name);
                    Console.WriteLine("Surname: {0}",item.Surname);
                    Console.WriteLine("TelNo: {0}",item.TelNo);
                    Console.WriteLine("----------------------------------");
                    foundFlag = 1;    
                }
            }
        }

        if (foundFlag == 0)
            Console.WriteLine("The contact is not found in the phoneBook!");
    }
}