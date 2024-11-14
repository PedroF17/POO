using System;
using System.Collections.Generic;

namespace POO.Classes
{
    public class Project
    {

        #region Private Properties
        private int _projectId;
        private string _projectName;
        private string _clientName;
        private DateTime _startDate;
        private DateTime _endDate;
        private decimal _budget;
        private ProjectStatus _projectStatus;
        private List<User> _assignedUsers;
        // private List<Document> _documents;
        private List<Project> _projects = new ();
        #endregion

        #region Public Properties
        public int ProjectId
        {
            get { return _projectId; }
            set { _projectId = value; }
        }
        public string ProjectName
        {
            get { return _projectName; }
            set { _projectName = value; }
        }
        public string ClientName
        {
            get { return _clientName; }
            set { _clientName = value; }
        }
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }
        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }
        public decimal Budget
        {
            get { return _budget; }
            set { _budget = value; }
        }
        public ProjectStatus ProjectStatus
        {
            get { return _projectStatus; }
            set { _projectStatus = value; }
        }
        public List<User> AssignedUsers
        {
            get { return _assignedUsers; }
            set { _assignedUsers = value; }
        }
        // public List<Document> Documents{
        //     get { return _documents; }
        //     set { _documents = value; }
        // }
        #endregion       

        #region Constructors
        public Project(int projectId, string projectName, string clientName, DateTime startDate, DateTime endDate, decimal budget, ProjectStatus projectStatus)
        {
            _projectId = projectId;
            _projectName = projectName;
            _clientName = clientName;
            _startDate = startDate;
            _endDate = endDate;
            _budget = budget;
            _projectStatus = projectStatus;
            _assignedUsers = new List<User>();
            // _documents = new List<Document>();
        }
        #endregion

        #region Methods
        public void UpdateProjectInfo(string newProjectName, string newClientName, DateTime newStartDate, DateTime newEndDate, decimal newBudget, ProjectStatus newProjectStatus)
        {
            _projectName = newProjectName;
            _clientName = newClientName;
            _startDate = newStartDate;
            _endDate = newEndDate;
            _budget = newBudget;
            _projectStatus = newProjectStatus;
        }
        public void AddUserToProject(User user)
        {
            _assignedUsers.Add(user);
        }
        public void RemoveUserFromProject(User user)
        {
            _assignedUsers.Remove(user);
        }
        // public void AddDocumentToProject(Document document)
        // {
        //     _documents.Add(document);
        // }
        // public void RemoveDocumentFromProject(Document document){
        //     _documents.Remove(document);
        // }

        public void GetAllProjects(){
            Console.WriteLine("Projects");
            foreach(Project project in _projects){
                Console.WriteLine("--------------------");
                Console.WriteLine(project.ProjectName);
                Console.WriteLine(project.ClientName);
                Console.WriteLine(project.StartDate);
                Console.WriteLine(project.EndDate);
                Console.WriteLine(project.Budget);
                Console.WriteLine(project.ProjectStatus);
                Console.WriteLine("--------------------");
            }
        }
        #endregion
    }
    public enum ProjectStatus
    {
        Active,
        InProgress,
        Completed,
        Cancelled
    }
}