using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_tutorial
{
    internal class CQRS
    {
        /*public static void Main(string[] args)
        {
            Repo repo = new Repo();
            //1.
            Customer cust = new Customer();
            cust.Name = "Roshan";
            repo.Save(cust);
            //2.
            cust.Name = "Shivam";
            repo.Save(cust);
            //3.
            cust.Name = "Mukesh";
            repo.Save(cust);
            List<Customer> customers = repo.Get_All_Customers();

        }*/
    }
    public class Repo
    {
        public List<Customer> custs = new List<Customer>();
        public void Save(Customer cust)
        {
            custs.Add(cust);
        }
        public List<Customer> Get_All_Customers()
        {
            return custs;
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Item_Name { get; set; }
        public decimal Price { get; set; }


    }
}
