using E_Devlet_Uygulaması.Abstract;
using E_Devlet_Uygulaması.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Devlet_Uygulaması.Concrete
{
    public class CheckCustomerManager : ICheckCustomer
    {
        public bool CheckCustomer(Customer customer)
        {
            return true;
        }
    }
}
