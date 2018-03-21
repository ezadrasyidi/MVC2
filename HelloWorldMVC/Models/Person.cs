using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorldMVC.Models
{
    //Person/addPerson
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public int yob { get; set; }
        public string category { get; set; }

        public Person(string name, int yob)
        {
            this.name = name;
            this.yob = yob;
        }

        public void calculateAge()
        {
            age = DateTime.Today.Year - yob;
            category = "Adult";
        }
    }
}