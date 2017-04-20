namespace SchoolClasses
{
    public interface IPeople
    {
        void AddTeacher(Teacher teacher);

        void RemoveTeacher(Teacher teacher);

        void AddStudent(Student student);

        void RemoveStudent(Student student);

    }
}