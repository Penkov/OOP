using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    class HumanStudentWorker
    {
        static void Main()
        {
            List<Student> listStudent = new List<Student>(){
                new Student("Ivo", "Prokopiev", 11111),
                new Student("Asq", "Stefanova", 31245),
                new Student("Iskra", "Urumova", 44444),
                new Student("Zlati", "Zlatev", 67895),
                new Student("Encho", "Chakyrov", 34256),
                new Student("Stoil", "Stoilov", 93452),
                new Student("Katq", "Petrova", 71234),
                new Student("Minka", "Furiqta", 69856),
                new Student("Pesho", "Kaskata", 78743),
                new Student("Sami", "Vinkela", 77889)
            };

            listStudent = new List<Student>(listStudent.OrderBy(s => s.FacultyNumber));

            foreach (var student in listStudent)
            {
                Console.WriteLine("{0} {1} Faculty Number: {2}",student.FirstName, student.FirstName, student.FacultyNumber);
            }
            Console.WriteLine();
            List<Worker> listWorker = new List<Worker>()
            {
                new Worker("Sasho", "Yovkov", 200, 8),
                new Worker("Bash", "Maistora", 1000, 8),
                new Worker("Jelqzko", "Sopata", 600, 8),
                new Worker("Masha", "Grigorova", 1200, 8),
                new Worker("Kyncho", "Minchev", 300, 8),
                new Worker("Pepi", "Dunkov", 160, 8),
                new Worker("Bate", "Goiko", 720, 8),
                new Worker("Marselo", "Mastroiani", 4000, 8),
                new Worker("Jim", "Black", 50, 8),
                new Worker("Sheila", "Max", 670, 8)
            };

            listWorker = new List<Worker>(listWorker.OrderBy(w => w.MoneyPerHour()));
            foreach (var worker in listWorker)
            {
                Console.WriteLine(worker.FirstName + " " + worker.LastName + " " + worker);
            }
            Console.WriteLine();


            List<Human> allHumans = new List<Human>();

            listStudent.ForEach(student => allHumans.Add(student));
            listStudent.ForEach(worker => allHumans.Add((worker)));

            allHumans = new List<Human>(allHumans.OrderBy(a => a.FirstName));
            foreach (var human in allHumans)
            {
                Console.WriteLine(human.FirstName + " " + human.LastName + " - " + human.GetType().Name);
            }
        }
    }
}
