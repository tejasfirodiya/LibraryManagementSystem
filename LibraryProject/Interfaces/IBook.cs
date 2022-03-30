using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Interfaces
{
    public interface IBook
    {
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
    }
}
