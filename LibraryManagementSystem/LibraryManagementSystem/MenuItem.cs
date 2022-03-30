namespace LibraryManagementSystem.LibraryManagementSystem
{
     public enum MenuItem
    {
        //AddStudent = 1,

        CreateAuthor = 1,
        ListAuthor,
        UpdateAuthor,
        DeleteAuthor,

        CreatePublisher,
        ListPublisher,
        UpdatePublisher,
        DeletePublisher,

        AddBooks,
        DisplayAllBooks,
        DisplayAvailableBooks,
        DisplayIssuedBooks,
        EditBook,
        DeleteBook,
        SearchBookByISBN,
        SearchBookByTitle,
        SearchBookByAuthor,
        SearchBookByPublisher,

        AddCustomer,
        DisplayAllCustomers,
        DisplayCustomerHoldingBook,
        EditCustomer,
        SearchCustomerByName,
        SearchCustomerByEmail,
        SearchCustomerByPhone,
        DeleteCustomer,

        IssueBook,
        ReturnBook,
        ShowLateBooks,
        ShowAllTransactions,

        ClearScreen,
        Exit = 0
    }
}
