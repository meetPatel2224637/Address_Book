using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBookDB.Model;

namespace AddressBookDB.Interface
{
    public interface IAddressBookRepository : IDisposable
    {

     //   IQueryable<Teacher> GetTeachers();
       
        bool IsAddressExist(string FirstName, string LastName, string Type, string ImageLink, string Address1);
        bool AddAddress(string FirstName, string LastName, string Type, string ImageLink, string Address1);
    }
}
