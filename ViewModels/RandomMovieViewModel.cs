using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidly.Models;

namespace vidly.ViewModels
{
    public class RandomMovieViewModel
    {
        //create two properties from type models i need to use 
        public Movies Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}