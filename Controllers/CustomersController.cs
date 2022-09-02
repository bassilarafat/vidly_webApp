using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using vidly.Models;


namespace vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ViewResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            //SingleOrDefault used to return the single value or null of the IEnumerable<> 
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);         //Lambda expression c refers to all elements in the list  
                                                                                    // we searchig ABOUT    INPUT ID id that came from user (argument  int id) and find the equal id in the list 


            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            //anymouse type 
            return new List<Customer>
            {
                new Customer{Id=1 ,Name ="john Smith"},  //using objecy initialization syntax   to initalize propeties

                new Customer{Id=2 ,Name="mary williams"}
            };
        }

        
    }
}