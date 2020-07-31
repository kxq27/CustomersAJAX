using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomersAJAX.Models;

namespace CustomersAJAX.Controllers
{
    public class CustomerController : Controller
    {

        Customer customer; // create object
        List<Customer> customers;

        public CustomerController()
        {
            customers = new List<Customer>();
            customers.Add(new Customer(0, "Sherry", 37));
            customers.Add(new Customer(1, "Elias", 23));
            customers.Add(new Customer(2, "Mad dog", 34));
            customers.Add(new Customer(3, "Iko", 12));
            customers.Add(new Customer(4, "Randi", 45));
            customers.Add(new Customer(5, "Husin", 53));

            
        } 

        // GET: Customer
        public ActionResult Index()
        {
            Tuple<List<Customer>, Customer> tuple;
            tuple = new Tuple<List<Customer>, Customer>(customers, customers[2]);


            return View("Customer", tuple);
        }

        [HttpPost]
        public ActionResult OnSelectCustomer(string CustomerNumber)
        {
            Tuple<List<Customer>, Customer> tuple;
            tuple = new Tuple<List<Customer>, Customer>(customers, customers[Int32.Parse(CustomerNumber)]);


            return PartialView("_CustomerDetails", customers[Int32.Parse(CustomerNumber)]);
        }
    }
}