using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReadyTest.Models;

namespace ReadyTest.Models
{
    public class EmployessDbInitializer : System.Data.Entity.DropCreateDatabaseAlways<EmplyessDB>
    {
        protected override void Seed(EmplyessDB context)
        {
            context.Employees.Add(new Employee
            {
                sector = "Hr",
                firstName = "Neven",
                lastName = "Milakara",
                startDate = DateTime.Now
            });

            context.Employees.Add(new Employee
            {
                sector = "Hr",
                firstName = "Ivan",
                lastName = "Nemes",
                startDate = DateTime.Now
            });

            context.FieldTypes.Add(new FieldTypes { Name = "Text field" });
            context.FieldTypes.Add(new FieldTypes { Name = "Numeric field" });
            context.FieldTypes.Add(new FieldTypes { Name = "Option list field" });

            base.Seed(context);
        }
    }
}