using DerekCore21MVC_Contoso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DerekCore21MVC_Contoso.Data
{
    public static class DbInitialiser
    {
        public static void Initialise(ApplicationDbContext context)
        {
            InitialiseCustomers(context);
            //InitialiseAddresses(context);
        }

        private static void InitialiseAddresses(ApplicationDbContext context)
        {
            if(context.Customers.Any())
            {
                return;
            }
            var customers = new Customer[]
            {
                new Customer
                {
                    FirstName = "Alex",
                    LastName = "Carson",
                    EmailAddress = "Alex@gmail.com",
                    TelephoneNo = "07123 456 789",

                }
            };

            foreach(Customer c in customers)
            {
                context.Customers.Add(c);
            }

            context.SaveChanges();
        }

        private static void InitialiseCustomers(ApplicationDbContext context)
        {

        }
    }
}
