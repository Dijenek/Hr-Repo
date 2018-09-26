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
<<<<<<< HEAD
        public string name { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Max length must be an integer value")]
        public int? maxLength { get; set; }
=======
        public string Name { get; set; }
        public FieldTypes fieldType { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Maximum length must be numeric")]
        public int maxLength { get; set; }
        public string defaultValue { get; set; }
>>>>>>> b8274feebaf7e5fa4fb23179a6d55d341674da01
    }
}