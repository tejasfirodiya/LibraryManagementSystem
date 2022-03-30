using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Interfaces
{
    internal interface ITransaction
    {
        void IssueBook();
        void ReturnBook();
        void ShowLateBooks();
        void ShowAllTransactions();
    }
}
