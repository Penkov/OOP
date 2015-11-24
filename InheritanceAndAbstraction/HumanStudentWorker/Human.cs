using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    abstract class Human
    {
        protected string firstName;

        protected string lastName;

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
