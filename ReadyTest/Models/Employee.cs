using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadyTest.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime startDate { get; set; }
        public string sector { get; set; }
    }
}