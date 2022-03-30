using LibraryProject.MainEntity;
var libraryManagement = new LibraryManagement();
libraryManagement.ShowMenu();

class LibraryManagement
{
    public void ShowMenu()
    {
        Author author = new Author();
        Book book = new Book();
        Customer customer = new Customer();
        Publisher publisher = new Publisher();
        Transaction transaction = new Transaction();

        string s = new('-', 30);
        int choice = 0;

        do
        {

            Console.WriteLine(s);
            Console.WriteLine("         Main Menu         ");
            Console.WriteLine(s);

            Console.WriteLine("1. Create Author");
            Console.WriteLine("2. List Author");
            Console.WriteLine("3. Update Author");
            Console.WriteLine("4. Delete Author");
            Console.WriteLine(s);
            Console.WriteLine("5. Create Publisher");
            Console.WriteLine("6. List Publisher");
            Console.WriteLine("7. Update Publisher");
            Console.WriteLine("8. Delete Publisher");
            Console.WriteLine(s);
            Console.WriteLine("9. Add Books");
            Console.WriteLine("10. Display All Books");
            Console.WriteLine("11. Display Available Books");
            Console.WriteLine("12. Display Issued Books");
            Console.WriteLine("13. Edit Book");
            Console.WriteLine("14. Delete Book");
            Console.WriteLine("15. Search Book By ISBN");
            Console.WriteLine("16. Search Book By Title");
            Console.WriteLine("17. Search Book By Author");
            Console.WriteLine("18. Search Book By Publisher");
            Console.WriteLine(s);
            Console.WriteLine("19. Add Customer");
            Console.WriteLine("20. Display All Customers");
            Console.WriteLine("21. Display Customers Holding Book");
            Console.WriteLine("22. Edit Customer");
            Console.WriteLine("23. Search Customer By Name");
            Console.WriteLine("24. Search Customer By Email");
            Console.WriteLine("25. Search Customer By Phone");
            Console.WriteLine("26. Delete Customer");
            Console.WriteLine(s);
            Console.WriteLine("27. Issue Book");
            Console.WriteLine("28. Return Book");
            Console.WriteLine("29. Show Late Books");
            Console.WriteLine("30. Show All Transactions");
            Console.WriteLine(s);
            Console.WriteLine("31. Save Data");
            Console.Write("Enter Your Choice : ");

            choice = int.Parse(Console.ReadLine());

            Console.WriteLine(s);

            Console.WriteLine("0. Exit");

            switch (choice)
            {
                case 1:
                    author.CreateAuthor();
                    break;
                case 2:
                    author.ListAuthor();
                    break;
                case 3:
                    author.UpdateAuthor();
                    break;
                case 4:
                    author.DeleteAuthor();
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 5:
                    break;
                case 5:
                    break;
                case 5:
                    break;
                case 5:
                    break;
                case 5:
                    break;
                case 5:
                    break;
                case 5:
                    break;
                case 5:
                    break;
                case 5:
                    break;
                case 31:
                    author.SaveData();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        } while (choice != 9);


    }
}