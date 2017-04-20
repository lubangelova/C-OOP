using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Extensions
{
    public static class StudentExtensions
    {
        public static void PrintStudentsOverload1( this List<Student> listOfStudents)
        {
            foreach (var student in listOfStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}- {student.Age} years old");
            }
        }
        public static void PrintStudentsOverload2(this List<Student> listOfStudents)
        {
            foreach (var student in listOfStudents)
            {
                Console.WriteLine($"Student:\t{student.FirstName} {student.LastName}\nFaculty number:\t{student.FN}\nTelephone:\t{student.Tel}\nemail:\t\t{student.Email}\nmarks:\t\t {student.Marks.PrintMarks()}\ngroup number:\t {student.Group.GroupNumber}\ndepartment name:{student.Group.DepartmentName}");
            }
        }

        public static List<Student> SortByAge(this List<Student> listOfStudents)
        {
            var sortedList = listOfStudents.Where(st => (st.Age >= 18 && st.Age <= 24)).ToList();
            return sortedList;
        }

        public static List<Student> SortByFirstBeforeLastName(this List<Student> listOfStudents)
        {
            var sortedList = listOfStudents
              .Where(st => string.Compare(st.FirstName, st.LastName) < 0)
              .OrderBy(st => st.FirstName)
              .ToList();
            return sortedList;
        }

        public static List<Student> SortByNameDescending(this List<Student> listOfStudents)
        {
            var sortedList = listOfStudents
                .OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName)
                .ToList();
            return sortedList;
        }

        public static List<Student> SelectByGroupName(this List<Student> listOfStudents)
        {
            var list = listOfStudents
                .Where(st => st.GroupNumber == 2)
                .OrderBy(st =>st.FirstName)
                .ToList();
            return list;
        }
        public static List<Student> EmailInABV(this List<Student> listOfStudents)
        {
            var list = listOfStudents
                .Where(st => st.Email.Contains("abv.bg"))
                .OrderBy(st => st.FirstName)
                .ToList();
            return list;
        }
        public static List<Student> PhoneByAreaCode(this List<Student> listOfStudents, string areacode)
        {
            var list = listOfStudents
                .Where(st => st.Tel.StartsWith(areacode))
                .OrderBy(st => st.FirstName)
                .ToList();
            return list;
        }
        public static List<Student> ExtractStudentsEnrolledInYear(this List<Student> listOfStudents,string year)
        {
            var list = listOfStudents
                .Where(st => st.FN.Contains(year))
                .OrderBy(st => st.FirstName)
                .ToList();


            return list;
        }
        public static List<Student> ExtractStudentsByGivenMark(this List<Student> listOfStudents, string mark)
        {
            var list = listOfStudents
                .Where(st => st.Marks.Any(m=>m.CompareTo(mark)==0))
                .OrderBy(st => st.FirstName)
                .ToList();


            return list;
        }
        public static List<Student> ExtractStudentsByGivenMarkCount(this List<Student> listOfStudents, int count)
        {
            var list = listOfStudents
                .Where(st => st.Marks.Count==count)
                .OrderBy(st => st.FirstName)
                .ToList();


            return list;
        }
        public static List<Student> ExtractStudentsByDepartmentName(this List<Student> listOfStudents, string departmentName)
        {
            var list = listOfStudents
                .Where(st => st.Group.DepartmentName == departmentName)
                .OrderBy(st => st.FirstName)
                .ToList();


            return list;
        }

        public static IEnumerable<IGrouping<int,Student>> GroupStudentsByGroupNumber(this List<Student> listOfStudents)
        {
            var list = listOfStudents
                .OrderBy(st => st.Group.GroupNumber)
                .GroupBy(st => st.Group.GroupNumber)
                .ToList();


            return list;
        }
        public static StringBuilder PrintMarks(this List<string> marks)
        {
            var output = new StringBuilder();
            for (int i = 0; i < marks.Count; i++)
            {
                if (i<marks.Count-1)
                {
                    output.Append(string.Format("{0},", marks[i]));
                }
                else
                {
                    output.Append(string.Format("{0}", marks[i]));
                }
            }
           
            return output;
        }

        
    }
}
