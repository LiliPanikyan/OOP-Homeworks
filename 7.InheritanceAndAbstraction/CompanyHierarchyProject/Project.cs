using System;

namespace CompanyHierarchyProject
{
    public class Project
    {
        private string projectName;
        private string projectStartDate;
        private string details;
        private State state;

        public Project(string projectName, string projectStartDate, string details, State state)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.Details = details;
            this.State = state;
        }

        public string ProjectName
        {
            get
            {
                return this.projectName;
            }
            set
            {
                this.projectName = ValidationMethods.CheckForEmptyString(value);
            }
        }

        public string ProjectStartDate
        {
            get
            {
                return this.projectStartDate;
            }
            set
            {
                this.projectStartDate = ValidationMethods.ValidateDate(value);
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                this.details = ValidationMethods.CheckForEmptyString(value);
            }
        }

        public State State { get; private set; }

        private void CloseProject()
        {
            if (this.State == State.Open)
            {
                this.State = State.Close;
            }
        }
    }
}
