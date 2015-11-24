using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    class Student : Human
    {
        protected int facultyNumber;

        public Student(string firstName, string lastName, int facultyNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = facultyNumber;
        }

        public int FacultyNumber  
        {
            get 
            {
                return this.facultyNumber;
            }
            set
            {
                if (value.ToString().Length < 5 && value.ToString().Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Faculty number is range 5 to 10 letter");
                }
                this.facultyNumber = value;
            }
        }

    }
}
