using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BookLoaning.Models
{
    public class PersonDTO
    {
        public int Id { get; set; }

        [DisplayName ("Name")]
        public string Name { get; set; }
        [DisplayName("Last name")]

        public string LastName { get; set; }
        [DisplayName("Date of birth")]
      
        public DateTime DateOfBirth { get; set; }
    }
}