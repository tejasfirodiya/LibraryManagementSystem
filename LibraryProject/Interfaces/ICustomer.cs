using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Interfaces
{
    internal interface ICustomer
    {
        void AddCustomer();
        void DisplayAllCustomers();
        void DisplayCustomerHoldingBook();
        void EditCustomer();
        void SearchCustomerByName();
        void SearchCustomerByEmail();
        void SearchCustomerByPhone();
        void DeleteCustomer();
    }
}
