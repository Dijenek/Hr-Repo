using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReadyTest.Models
{
    public class Employee
    {
        public int ID { get; set; }    
        [Display(Name = "First name")]
        public string firstName { get; set; }
        [Display(Name = "Last name")]
        public string lastName { get; set; }
        [Display(Name = "Start date")]
        public DateTime startDate { get; set; }
        [Display(Name = "Sector")]
        public string sector { get; set; }
    }
}