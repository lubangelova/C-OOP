using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Teacher:People, IComment, IDisciplines
    {
        private List<Disciplines> disciplines=new List<Disciplines>();

        public Teacher(string name,List<Disciplines> disciplines):base(name)
        {
            this.Disciplines=disciplines;
        }

        public List<Disciplines> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            private set
            {
                this.disciplines = value;
            }
        }

        public void AddDiscipline(Disciplines discipline)
        {
            this.Disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Disciplines discipline)
        {
            this.Disciplines.Remove(discipline);
        }
       
       
    }
}
