using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace TestApplication.Models
{
    public class EmpDetails
    {
        [Display(Name="Name")]
        public string Name { get; set; }
        [Display(Name="Number")]
        public double Number { get; set; }
    }
}