using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Human
{
    class TestClass
    {
        public static void Main()
        {
            List<Student> listStudents = new List<Student>();
            listStudents.Add(new Student("ib","as",7));
            listStudents.Add(new Student("a", "T", 4));
            listStudents.Add(new Student("y","r",3));

            var sortStudentGrade = listStudents.OrderBy(Student => Student.Grade);
            foreach (var item in sortStudentGrade)
            {
                Console.WriteLine("Grade:{0},FirstName:{1},LastName:{2}",item.Grade,item.FirstName,item.LastName);
            }
            Console.WriteLine();

            var sortStudentName = listStudents.OrderBy(Student => Student.FirstName).ThenBy(Student => Student.LastName);
            foreach (var item in sortStudentName)
            {
                Console.WriteLine("FirstName:{0},LastName:{1}",item.FirstName,item.LastName);
            }
            Console.WriteLine();

            List<Worker> listWorker = new List<Worker>();
            listWorker.Add(new Worker("er","po",150,8));
            listWorker.Add(new Worker("frea", "ivana", 185, 9));

            var moneyperhours = listWorker.OrderByDescending(Worker => Worker.MonyPerHours()).ToList();

            foreach (var item in moneyperhours)
            {
                Console.WriteLine
                    ("FirstName:{0},LastName{1},MoneyPerHours{2}",
                    item.FirstName,item.LastName,item.MonyPerHours());
            }
            Console.WriteLine();

            List<Human> human = new List<Human>();
            foreach (var students in listStudents)
            {
                human.Add(students);
            }
            foreach (var worker in listWorker)
            {
                human.Add(worker);
            }
            var sortMergeList = 
                (human.OrderBy(Human => Human.FirstName)
                .ThenBy(Human => Human.LastName));
            foreach (var mergeList in sortMergeList)
            {
                Console.WriteLine("{0}"mergeList.FirstName);
            }
        }

    }
}
