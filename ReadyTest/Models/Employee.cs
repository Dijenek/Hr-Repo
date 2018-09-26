using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ReadyTest.Common;

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
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [CurrentDateValidator]
        public DateTime startDate { get; set; }
        [Display(Name = "Sector")]
        public string sector { get; set; }
    }
}