using E_Devlet_Uygulaması.Abstract;
using E_Devlet_Uygulaması.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Devlet_Uygulaması.Concrete
{
    public class CustomerManager : ICustomer
    {
        private readonly ICheckCustomer _customer;

        public CustomerManager(CheckCustomerManager customer)
        {
            _customer = customer;
        }
        public void Add(Customer customer)
        {
                Console.WriteLine("{0} {1} müşteri eklendi...", customer.FirstName, customer.LastName);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("{0} {1} müşteri silindi..", customer.FirstName, customer.LastName);
        }

        public void Update(Customer customer)
        {
            if (_customer.CheckCustomer(customer))
            {
                Console.WriteLine("{0} {1} müşteri güncellendi..", customer.FirstName, customer.LastName);
            }

            else
            {
                Console.WriteLine("Gerçek müşteri değil!");
            }
            
        }
    }
    
}
