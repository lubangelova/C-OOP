using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_and_workers
{
    class StartUp
    {
        static void Main(string[] args)
        {

            var students = new List<Student>
            {
                new Student("Petko", "Petkov", 2),
                new Student("Stamat", "Georgiev", 6),
                new Student("Ivan", "Ivanov", 4),
                new Student("Haralampi", "Haralampiev", 4),
                new Student("Stamat", "Stamatov", 5),
                new Student("Hristo", "Peshov", 5),
                new Student("Pesho", "Peshov", 6),
                new Student("Gosho", "Petrov", 3),
                new Student("Petyr", "Petrov", 6),
                new Student("Ivanka", "Ivanova", 5)
            };

            var workers = new List<Worker>
            {
                new Worker("Petko", "Georgiev",200,8),
                new Worker("Stamat", "Georgiev",250,9),
                new Worker("Ivan", "Ivanov", 300,10),
                new Worker("Haralampi", "Nikolaev", 150,8),
                new Worker("Stamat", "Stamatov", 500,10),
                new Worker("Hristo", "Haralampiev", 350,8),
                new Worker("Pesho", "Peshov", 400,8),
                new Worker("Gosho", "Toshov", 450,9),
                new Worker("Petyr", "Petrov", 325,8),
                new Worker("Ivanka", "Ginkova", 275,9)
            };

            var sortedStudents = students.SortStudentsByGrade();
            var sortedworkers = workers.SortWorkersByMoneyPerHour();
           


            var humanList = new List<Human>();
            humanList.AddRange(sortedStudents);
            humanList.AddRange(sortedworkers);

            var mergedList = humanList.SortByFirstName();

            Console.WriteLine("Sorted students by grade!\n");
            sortedStudents.Print();
        
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Sorted workers by money per hour descending\n");
            sortedworkers.Print();
           
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Merged list sorted by first name and last name\n");
            mergedList.Print();
            
            Console.WriteLine("---------------------------------");
        }
    }
}
