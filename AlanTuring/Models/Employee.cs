using System;
using System.Collections.Generic;

#nullable disable

namespace AlanTuring.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public decimal Salary { get; set; }
        public string Position { get; set; }

        public virtual User IdNavigation { get; set; }
    }
}
