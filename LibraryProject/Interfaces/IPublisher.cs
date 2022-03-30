using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Interfaces
{
    internal interface IPublisher
    {
        void CreatePublisher();
        void ListPublisher();
        void UpdatePublisher();
        void DeletePublisher();
    }
}
