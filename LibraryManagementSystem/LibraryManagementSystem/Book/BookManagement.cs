using LibraryManagementSystem.LibraryManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.LibraryManagementSystem.Book;

enum IsDeleted { 
    True,
    False
}

public class BookManagement : IMenuActions
{

    private const string Heading = "ISBN,Title,PublisherId,AuthorId,IssuedStatus,IsDeleted\n";
    private const string FilePath = @"D:\Tejas Firodiya (Training Folder)\LibraryManagementSystem\LibraryManagementSystem\exelFiles\BookData.csv";

    public void AddBooks()
    {
        IsDeleted _isDeleted;

        Console.WriteLine("--------------------------------------");
        Console.WriteLine("---------- Add Book Details ----------");
        Console.WriteLine("--------------------------------------");
        Console.Write("Enter ISBN No. : ");
        int _isbn = int.Parse(Console.ReadLine());

        Console.Write("Enter Book Title : ");
        var _title = Console.ReadLine();

        Console.Write("Enter Publisher Id : ");
        int _publisherId = int.Parse(Console.ReadLine());

        Console.Write("Enter Author Id : ");
        int _authorId = int.Parse(Console.ReadLine());

        Console.Write("Enter Issued Status : ");
        var _issuedStatus = Console.ReadLine();

        //bool _isDeleted = false;
        Console.Write("Enter IsDeleted : ");
        var _isDeletedText = Console.ReadLine(); //True, False
        _isDeleted = (IsDeleted)Enum.Parse(typeof(IsDeleted), _isDeletedText);
    }

    public void AddCustomer()
    {
        throw new NotImplementedException();
    }

    public void CreateAuthor()
    {
        throw new NotImplementedException();
    }

    public void CreatePublisher()
    {
        throw new NotImplementedException();
    }

    public void DeleteAuthor()
    {
        throw new NotImplementedException();
    }

    public void DeleteBook()
    {
        throw new NotImplementedException();
    }

    public void DeleteCustomer()
    {
        throw new NotImplementedException();
    }

    public void DeletePublisher()
    {
        throw new NotImplementedException();
    }

    public void DisplayAllBooks()
    {
        throw new NotImplementedException();
    }

    public void DisplayAllCustomers()
    {
        throw new NotImplementedException();
    }

    public void DisplayAvailableBooks()
    {
        throw new NotImplementedException();
    }

    public void DisplayCustomerHoldingBook()
    {
        throw new NotImplementedException();
    }

    public void DisplayIssuedBooks()
    {
        throw new NotImplementedException();
    }

    public void EditBook()
    {
        throw new NotImplementedException();
    }

    public void EditCustomer()
    {
        throw new NotImplementedException();
    }

    public void IssueBook()
    {
        throw new NotImplementedException();
    }

    public void ListAuthor()
    {
        throw new NotImplementedException();
    }

    public void ListPublisher()
    {
        throw new NotImplementedException();
    }

    public void ReturnBook()
    {
        throw new NotImplementedException();
    }

    public void SearchBookByAuthor()
    {
        throw new NotImplementedException();
    }

    public void SearchBookByISBN()
    {
        throw new NotImplementedException();
    }

    public void SearchBookByPublisher()
    {
        throw new NotImplementedException();
    }

    public void SearchBookByTitle()
    {
        throw new NotImplementedException();
    }

    public void SearchCustomerByEmail()
    {
        throw new NotImplementedException();
    }

    public void SearchCustomerByName()
    {
        throw new NotImplementedException();
    }

    public void SearchCustomerByPhone()
    {
        throw new NotImplementedException();
    }

    public void ShowAllTransactions()
    {
        throw new NotImplementedException();
    }

    public void ShowLateBooks()
    {
        throw new NotImplementedException();
    }

    public void UpdateAuthor()
    {
        throw new NotImplementedException();
    }

    public void UpdatePublisher()
    {
        throw new NotImplementedException();
    }
}
