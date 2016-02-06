using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Human
{
    abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Human(string firstName, string LastName)
        {
            this.FirstName = firstName;
            this.LastName = LastName;
        }
    }
}
