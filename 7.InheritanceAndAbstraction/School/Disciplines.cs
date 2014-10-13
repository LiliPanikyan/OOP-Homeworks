using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Disciplines
    {
        private string disciplinesNameID;
        private List<Student> students;
        private int numberOfLectures;
        private string details;

        public Disciplines(string disciplinesNameID, List<Student> students, int numberOfLectures, string details = null)
        {
            this.DisciplinesNameID = disciplinesNameID;
            this.Students = students;
            this.NumberOfLectures = numberOfLectures;
            this.Details = details;
        }


        public string DisciplinesNameID { get; set; }

        public List<Student> Students { get; set; }

        public int NumberOfLectures { get; set; }

        public string Details { get; set; }
    }
}
