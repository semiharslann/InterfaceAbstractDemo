using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            // Gerçek bilgileri girdiğiniz zaman çalışacaktır
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1900, 9, 6), FirstName = "Semih", LastName = "Arslan", NationalityId = "11111111111" });
            Console.ReadLine();
        
        
        
        
        }
    }
}

