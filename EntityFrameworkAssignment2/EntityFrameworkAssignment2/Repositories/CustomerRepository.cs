using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameworkAssignment2.Entities;

namespace EntityFrameworkAssignment2.Repositories
{
    public class CustomerRepository
    {
        public CustomerContext db = new CustomerContext();
        public List<Customer> GetCustomers()
        {
            return db.Customers.ToList(); //return all employee records in list format
            //return db.Employees.Where(i => i.Salary == 10000).ToList(); return multiple employees using salary
        }
        public Customer GetCustomerById(String Cid)
        {
            return db.Customers.Find(Cid); //search using primary key column
                                           //  return db.Employees.SingleOrDefault(i => i.Eid == eid); //search with any column
        }
        public void Add(Customer c)
        {
            db.Customers.Add(c); //Add EMployee
            db.SaveChanges();
        }
        public void Delete(Customer c)
        {
            db.Customers.Remove(c); //Delete Employee
            db.SaveChanges();
        }
        public void Update(Customer c)
        {
            db.Customers.Update(c); 
            db.SaveChanges();
        }


    }
}
