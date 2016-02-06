using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Human
{
    class Student:Human
    {
        private int grade;
        

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.grade = grade;
        }
        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentException("The grade is not valid");
                }
                this.grade = value;
            }
        }
        public override string  ToString()
            {
            sole.WriteLine("FirsNamr:{0} LastName{1}: Grade{2}:",grades.FirstName,grades.LastName,grades.Grade);
            }
        }

    }
}
