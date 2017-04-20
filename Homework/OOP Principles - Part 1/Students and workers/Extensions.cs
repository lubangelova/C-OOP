using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_and_workers
{
    public static class Extensions
    {
        public static List<Student> SortStudentsByGrade(this List<Student> students)
        {
            var sortedStudents = students
                .OrderBy(st => st.Grade)
                .ToList();
            return sortedStudents;
        }

        public static List<Worker> SortWorkersByMoneyPerHour(this List<Worker> workers)
        {
            var sortedworkers = workers
               .OrderByDescending(w => w.MoneyPerHour())
               .ToList();
            return sortedworkers;
        }

        public static List<Human> SortByFirstName(this List<Human> humanList)
        {
            var mergedList = humanList
               .OrderBy(p => p.FirstName)
               .ThenBy(p => p.LastName)
               .ToList();
            return mergedList;

        }

        public static void Print<T>(this IEnumerable<T> collection) where T:class
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
