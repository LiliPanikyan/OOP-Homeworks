using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StringDisperserProject
{
    public class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable<char>
    {
        private string developerName;
        private string seniorQAName;
        private string teamLiderName;

        public StringDisperser(string developerName, string seniorQAName, string teamLiderName)
        {
            this.DeveloperName = developerName;
            this.SeniorQAName = seniorQAName;
            this.TeamLiderName = teamLiderName;
        }

        public string DeveloperName { get; set; }

        public string SeniorQAName { get; set; }

        public string TeamLiderName { get; set; }

        public override bool Equals(object obj)
        {
            StringDisperser projectTeam = obj as StringDisperser;
            if (projectTeam == null)
            {
                return false;
            }
            if (!(Equals(this.DeveloperName, projectTeam.DeveloperName) ||
                !(Equals(this.SeniorQAName, projectTeam.SeniorQAName) ||
                !(Equals(this.TeamLiderName, projectTeam.TeamLiderName)))))
            {
                return false;
            }
            return true;
        }

        public static bool operator ==(StringDisperser firstProjectTeam, StringDisperser secondProjectTeam)
        {
            return Equals(firstProjectTeam, secondProjectTeam);
        }

        public static bool operator !=(StringDisperser firstProjectTeam, StringDisperser secondProjectTeam)
        {
            return !Equals(firstProjectTeam, secondProjectTeam);
        }

        public override int GetHashCode()
        {
            return
                this.DeveloperName.GetHashCode() ^
                this.SeniorQAName.GetHashCode() ^
                this.TeamLiderName.GetHashCode();
        }

        public object Clone()
        {
            return new StringDisperser(
                this.DeveloperName,
                this.SeniorQAName,
                this.TeamLiderName
                );
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(this.DeveloperName + ", ");
            output.Append(this.SeniorQAName + ", ");
            output.Append(this.TeamLiderName);

            return output.ToString();
        }

        public int CompareTo(StringDisperser other)
        {
            int firstTeam =
                this.DeveloperName.Length +
                this.SeniorQAName.Length +
                this.TeamLiderName.Length;

            int otherTeam =
                other.DeveloperName.Length +
                other.SeniorQAName.Length +
                other.TeamLiderName.Length;

            return firstTeam.CompareTo(otherTeam);
        }

        public IEnumerator<char> GetEnumerator()
        {
            string fullString = this.ToString().ToLower().Replace(", ", "");
            for (int i = 0; i < fullString.Length; i++)
            {
                yield return fullString[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
