using System;
using System.Collections.Generic;
using System.Text;

namespace E_Devlet_Uygulaması.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
