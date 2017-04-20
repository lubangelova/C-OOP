using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var student1 = new Student("Ivan Ivanov", 2);
            var student2 = new Student("Pesho Georgiev", 3);
            var student3 = new Student("Stamat Haralampiev", 2);
            var student4 = new Student("Strahil Ivanov", 3);
            var math = new Disciplines("Mathematics", 10, 24);
            var library = new Disciplines("Library", 15, 30);
            var csharp = new Disciplines("CSharp", 20, 40);
            var javascript = new Disciplines("JavaScript", 22, 42);

            var teacher1 = new Teacher("Ginka Petkova", new List<Disciplines> { math, library });
            var teacher2 = new Teacher("Georgi Georgiev", new List<Disciplines> { csharp, javascript });
            var class1 = new Class("Class1", new List<Student> { student1, student2 }, new List<Teacher> { teacher1, teacher2 });
            var class2 = new Class("Class2", new List<Student> { student3, student4 }, new List<Teacher> { teacher1, teacher2 });
            var school = new School("Telerik Academy", new List<Class> { class1, class2 });

            

            class2.AddComment("Important");
            school.AddClass(class1);
            teacher1.AddComment("Hello");
            class1.AddStudent(new Student("Hristo Popov", 4));
            class1.AddTeacher(new Teacher("Stanka Draganova", new List<Disciplines> { math, csharp }));
            teacher1.AddDiscipline(new Disciplines("Biology", 15, 25));
            math.AddComment("This is very important");
            student1.AddComment("Hello");
            Console.WriteLine(math.ToString());
           
          



            
        }
    }
}
