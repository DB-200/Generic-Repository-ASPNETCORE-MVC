using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace People.Entities
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string  ContactNo { get; set; }
    }
}
