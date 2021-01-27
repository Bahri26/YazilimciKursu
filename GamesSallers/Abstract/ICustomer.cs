using E_Devlet_Uygulaması.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Devlet_Uygulaması.Abstract
{
    interface ICustomer
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
