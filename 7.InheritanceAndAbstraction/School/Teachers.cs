using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Teachers : Person
    {        
        private IList<Disciplines> teacherDisciplines;

        public Teachers(string firstName, string lastName, IList<Disciplines> teacherDisciplines, string details = null)
            : base(firstName, lastName, details)
        {
            this.TeacherDisciplines = teacherDisciplines;
        }

        public IList<Disciplines> TeacherDisciplines { get; set; }
    }
}
