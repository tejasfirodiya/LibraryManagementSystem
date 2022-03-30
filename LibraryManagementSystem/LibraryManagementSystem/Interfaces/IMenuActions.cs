using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.LibraryManagementSystem.Interfaces
{
    public interface IMenuActions
    {
        void CreateAuthor();
        void ListAuthor();
        void UpdateAuthor();
        void DeleteAuthor();

        void CreatePublisher();
        void ListPublisher();
        void UpdatePublisher();
        void DeletePublisher();

        void AddBooks();
        void DisplayAllBooks();
        void DisplayAvailableBooks();
        void DisplayIssuedBooks();
        void EditBook();
        void DeleteBook();
        void SearchBookByISBN();
        void SearchBookByTitle();
        void SearchBookByAuthor();
        void SearchBookByPublisher();
        
        void AddCustomer();
        void DisplayAllCustomers();
        void DisplayCustomerHoldingBook();
        void EditCustomer();
        void SearchCustomerByName();
        void SearchCustomerByEmail();
        void SearchCustomerByPhone();
        void DeleteCustomer();

        void IssueBook();
        void ReturnBook();
        void ShowLateBooks();
        void ShowAllTransactions();
    }
}
