using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReadyTest.Models.Fields
{
    public class TextField
    {
        public int Id { get; set; }
        public Employee employee { get; set; }
        public string name { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Max length must be an integer value")]
        public int? maxLength { get; set; }
    }
}