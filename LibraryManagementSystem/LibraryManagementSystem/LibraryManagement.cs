using LibraryManagementSystem.LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem.LibraryManagementSystem;

class LibraryManagement : IMenuActions
{
    private readonly Menu _menu;

    public LibraryManagement()
    {
        _menu = new Menu(ConsoleColor.Red, ConsoleColor.Green);
    }

    public void Start()
    {
        _menu.Show(this);
    }

    public void AddBooks()
    {
        throw new NotImplementedException();
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