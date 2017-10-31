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
        public string Name { get; set; }
        public FieldTypes fieldType { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Maximum length must be numeric")]
        public int maxLength { get; set; }
        public string defaultValue { get; set; }
    }
}