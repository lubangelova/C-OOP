using System;
using System.Collections.Generic;
using Academy.Commands.Contracts;
using Academy.Core.Contracts;
using Academy.Models.Contracts;
using System.Text;

namespace Academy.Commands.Listing
{
    public class ListUsersCommand :ICommand
    {
        
        private readonly IEngine engine;
        private readonly IAcademyFactory factory;

        public ListUsersCommand(IAcademyFactory factory, IEngine engine)
        {
            
                this.factory = factory;
                this.engine = engine;
            
        }

        public string Execute(IList<string> parameters)
        {
            var trainers = this.engine.Trainers;
            var students = this.engine.Students;
            return ListUsers();
        }

        public string ListUsers()
        {
         

            var builder = new StringBuilder();

            if (this.engine.Trainers.Count!=0)
            {
                foreach (var trainer in this.engine.Trainers)
                {
                    builder.AppendLine(trainer.ToString());
                }
            }

            if (this.engine.Students.Count!=0)
            {
                foreach (var student in this.engine.Students)
                {
                    builder.AppendLine(student.ToString());
                }
            }

            if (builder.ToString().Equals(""))
            {
                return $"There are no registered users!";
            }

            return builder.ToString().TrimEnd();
        }

       
    }
    }
