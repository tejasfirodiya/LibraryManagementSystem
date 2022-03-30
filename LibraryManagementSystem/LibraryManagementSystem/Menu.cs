using LibraryManagementSystem.LibraryManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.LibraryManagementSystem;

public class Menu
{
    private MenuItem _selectedMenuItem;

    protected readonly ConsoleColor ForeColor;
    protected readonly ConsoleColor BackColor;

    protected readonly string[] MenuItems =
    {
       "-------------Author-------------",
       " 1) Create Author",
       " 2) List Author",
       " 3) Update Author",
       " 4) Delete Author",
       "--------------------------------",

       "                             ",

       "-----------Publisher------------",
       " 5) Create Publisher",
       " 6) List Publisher",
       " 7) Update Publisher",
       " 8) Delete Publisher",
       "--------------------------------",

       "                             ",

       "-----------Books------------",
       " 9) Add Books",
       " 10) Display All Books",
       " 11) Display Available Books",
       " 12) Display Issued Books",
       " 13) Edit Book",
       " 14) Delete Book",
       " 15) Search Book By ISBN",
       " 16) Search Book By Title",
       " 17) Search Book By Author",
       " 18) Search Book By Publisher",
        "--------------------------------",

       "                             ",

       "-----------Customer------------",
       " 19) Add Customer",
       " 20) Display All Customers",
       " 21) Display Customer Holding Book",
       " 22) Edit Customer",
       " 23) Search Customer By Name",
       " 24) Search Customer By Email",
       " 25) Search Customer By Phone",
       " 26) Delete Customer",
        "--------------------------------",

       "                             ",

       "-----------Other------------",
       " 27) Issue Book",
       " 28) Return Book",
       " 29) Show Late Books",
       " 30) Show All Transactions",
        "--------------------------------",

       "                             ",
       " 0) Exit",
       " x) Clear Screen",

       "                             ",

       "Enter Your Choice (0 to 30): "
};

    public Menu(ConsoleColor foreColor, ConsoleColor backColor)
    {
        ForeColor = foreColor;
        BackColor = backColor;
    }

    public virtual void Show(IMenuActions menuActions)
    {
        do
        {
            DisplayMenuText();
            WaitForMenuItemKeyPressed();

            switch (_selectedMenuItem)
            {
                case MenuItem.CreateAuthor:
                    menuActions.CreateAuthor();
                    break;
                case MenuItem.ListAuthor:
                    menuActions.ListAuthor();
                    break;
                case MenuItem.UpdateAuthor:
                    menuActions.UpdateAuthor();
                    break;
                case MenuItem.DeleteAuthor:
                    menuActions.DeleteAuthor();
                    break;

                case MenuItem.CreatePublisher:
                    menuActions.CreatePublisher();
                    break;
                case MenuItem.ListPublisher:
                    menuActions.ListPublisher();
                    break;
                case MenuItem.UpdatePublisher:
                    menuActions.UpdatePublisher();
                    break;
                case MenuItem.DeletePublisher:
                    menuActions.DeletePublisher();
                    break;

                case MenuItem.AddBooks:
                    menuActions.AddBooks();
                    break;
                case MenuItem.DisplayAllBooks:
                    menuActions.DisplayAllBooks();
                    break;
                case MenuItem.DisplayAvailableBooks:
                    menuActions.DisplayAvailableBooks();
                    break;
                case MenuItem.DisplayIssuedBooks:
                    menuActions.DisplayIssuedBooks();
                    break;
                case MenuItem.EditBook:
                    menuActions.EditBook();
                    break;
                case MenuItem.DeleteBook:
                    menuActions.DeleteBook();
                    break;
                case MenuItem.SearchBookByISBN:
                    menuActions.SearchBookByISBN();
                    break;
                case MenuItem.SearchBookByTitle:
                    menuActions.SearchBookByTitle();
                    break;
                case MenuItem.SearchBookByAuthor:
                    menuActions.SearchBookByAuthor();
                    break;
                case MenuItem.SearchBookByPublisher:
                    menuActions.SearchBookByPublisher();
                    break;

                case MenuItem.AddCustomer:
                    menuActions.AddCustomer();
                    break;
                case MenuItem.DisplayAllCustomers:
                    menuActions.DisplayAllCustomers();
                    break;
                case MenuItem.DisplayCustomerHoldingBook:
                    menuActions.DisplayCustomerHoldingBook();
                    break;
                case MenuItem.EditCustomer:
                    menuActions.EditCustomer();
                    break;
                case MenuItem.SearchCustomerByName:
                    menuActions.SearchCustomerByName();
                    break;
                case MenuItem.SearchCustomerByEmail:
                    menuActions.SearchCustomerByEmail();
                    break;
                case MenuItem.SearchCustomerByPhone:
                    menuActions.SearchCustomerByPhone();
                    break;
                case MenuItem.DeleteCustomer:
                    menuActions.DeleteCustomer();
                    break;

                case MenuItem.IssueBook:
                    menuActions.IssueBook();
                    break;
                case MenuItem.ReturnBook:
                    menuActions.ReturnBook();
                    break;
                case MenuItem.ShowLateBooks:
                    menuActions.ShowLateBooks();
                    break;
                case MenuItem.ShowAllTransactions:
                    menuActions.ShowAllTransactions();
                    break;

                case MenuItem.ClearScreen:
                    Console.Clear();
                    break;
                case MenuItem.Exit:
                    return;
            }
        } while (true);
    }

    protected virtual void DisplayMenuText()
    {
        Console.ForegroundColor = ForeColor;
        Console.ForegroundColor = BackColor;

        Array.ForEach(MenuItems, Console.WriteLine);

        Console.ResetColor();
    }

    protected virtual void WaitForMenuItemKeyPressed()
    {
        var keyInfo = Console.ReadKey(true);

        if (keyInfo.KeyChar is >= '0' and <= '9')
        {
            var asciiOfKeyChar = keyInfo.KeyChar - '0';
            _selectedMenuItem = (MenuItem)asciiOfKeyChar;
        }
        else
            _selectedMenuItem = keyInfo.Key switch
            {
                ConsoleKey.Escape => MenuItem.Exit,
                ConsoleKey.X => MenuItem.ClearScreen,
                _ => _selectedMenuItem
            };
    }
}
