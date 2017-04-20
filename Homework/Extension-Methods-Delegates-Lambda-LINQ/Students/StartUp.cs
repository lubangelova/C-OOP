using System;
using System.Collections.Generic;
using System.Linq;
using Students.Extensions;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var listOfStudents = new List<Student>
            {
                new Student("Ivan", "Ivanov", 25),
                new Student("Gosho", "Goshev", 22),
                new Student("Pesho", "Ivanov", 18),
                new Student("Haralampi", "Goshov", 26),
                new Student("Ivan", "Peshov", 30)
            };
            Console.WriteLine("List of students");
            listOfStudents.PrintStudentsOverload1();
          
            Console.WriteLine("-----------------------------");

            var sortedByName = listOfStudents.SortByFirstBeforeLastName();
            Console.WriteLine("Sorted by First Before Last Name");
            sortedByName.PrintStudentsOverload1();
            Console.WriteLine("-----------------------------");
            var sortedByAge = listOfStudents.SortByAge();
            Console.WriteLine("Sorted by age between 18 and 24");
            sortedByAge.PrintStudentsOverload1();

            Console.WriteLine("-----------------------------");
            var sortedByNameDescending = listOfStudents.SortByNameDescending();
            Console.WriteLine("Sorted by first name descending");
            sortedByNameDescending.PrintStudentsOverload1();
            Console.WriteLine("-----------------------------");

        
            var newListOfStudents = new List<Student>
            {
                new Student("Ivan", "Borisov", 24,"123406", "0888123456","ivan_borisov@gmail.com", new List<string>() { "Very good (5)", "Excellent(6)", "Very good (5)",  "Excellent(6)" },new Group(2,"Mathematical")),
                new Student("Gosho","Ivanov", 18,"124507", "0888258369", "goshoto@abv.bg",  new List<string>() { "Very good (5)", "Excellent(6)", "Excellent(6)" },new Group(5,"Mathematical")),
                new Student("Stamat", "Peshov",25, "125806", "0889632545", "stamatko@abv.bg",  new List<string>() { "Very good (5)", "Very good (5)", "Very good (5)", "Excellent(6)" },new Group(2,"Biological")),
                new Student("Stamat", "Goshov",22, "128905", "0889686545", "stamcho@gmail.com",  new List<string>() { "Excellent(6)",  "Excellent(6)", "Excellent(6)" },new Group(5,"Literature")),
                 new Student("Pesho", "Toshov",20, "129606", "0888545621", "pesho@abv.bg",  new List<string>() { "Excellent(6)", "Excellent(6)", "Good (4)", "Very good (5)" },new Group(5,"Literature"))
            };

            newListOfStudents.SelectByGroupName().PrintStudentsOverload2();
            Console.WriteLine("--------------------------------");
            newListOfStudents.EmailInABV().PrintStudentsOverload2();
            Console.WriteLine("--------------------------------");
            newListOfStudents.PhoneByAreaCode("0888").PrintStudentsOverload2();
            Console.WriteLine("--------------------------------");
            newListOfStudents.ExtractStudentsEnrolledInYear("06").PrintStudentsOverload2();
            Console.WriteLine("--------------------------------");
            newListOfStudents.ExtractStudentsByGivenMark("Very good (5)").PrintStudentsOverload2();
            Console.WriteLine("--------------------------------");
            newListOfStudents.ExtractStudentsByGivenMarkCount(3).PrintStudentsOverload2();
            Console.WriteLine("--------------------------------");
            newListOfStudents.ExtractStudentsByDepartmentName("Mathematical").PrintStudentsOverload2();
            Console.WriteLine("--------------------------------");
            newListOfStudents.GroupStudentsByGroupNumber();
            newListOfStudents.PrintStudentsOverload2();
            Console.WriteLine("--------------------------------");

        }
    }
}
