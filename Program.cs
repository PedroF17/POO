using System;
using POO.Classes;

public class Test{
    public static void Main(string[] args){
        // Create a new user        
        User user1 = new User(1, "John Doe", UserRole.Employee, "john@example.com", "123 Main St.");
        
        // Update user information
        user1.UpdateUserInfo("Jane Doe", "jane@example.com", "456 Elm St.");
        
        // Create a new project
        Project project1 = new Project(1, "Project A", "Client A", DateTime.Now, DateTime.Now.AddMonths(6), 10000, ProjectStatus.Active);
        
        // Add user to project
        project1.AddUserToProject(user1);
        
        // Print project information
        Console.WriteLine("Project Name: " + project1.ProjectName);
        Console.WriteLine("Client Name: " + project1.ClientName);
        Console.WriteLine("Start Date: " + project1.StartDate);
        Console.WriteLine("End Date: " + project1.EndDate);
        Console.WriteLine("Budget: " + project1.Budget);
        Console.WriteLine("Project Status: " + project1.ProjectStatus);

        // Print user information
        Console.WriteLine("\nUser Name: " + user1.UserName);
        Console.WriteLine("User Role: " + user1.UserRole);
        Console.WriteLine("User Contact Info: " + user1.UserContactInfo);
        Console.WriteLine("User Address: " + user1.UserAddress);
    
        // Create a new document
        // Document document1 = new Document(1, "Document A", "Description A", "file1.txt", DateTime.Now);
        
        // // Add document to project
        // project1.AddDocumentToProject(document1);
        
        // // Print document information
        // Console.WriteLine("\nDocument Name: " + document1.DocumentName);
        // Console.WriteLine("Description: " + document1.Description);
        // Console.WriteLine("File Path: " + document1.FilePath);
        // Console.WriteLine("Upload Date: " + document1.UploadDate);

        // Remove user from project
        project1.RemoveUserFromProject(user1);
        
        // Print updated project information
        Console.WriteLine("\nUpdated Project Information:");
        Console.WriteLine("Project Name: " + project1.ProjectName);
        Console.WriteLine("Client Name: " + project1.ClientName);
        Console.WriteLine("Start Date: " + project1.StartDate);
        Console.WriteLine("End Date: " + project1.EndDate);
        Console.WriteLine("Budget: " + project1.Budget);
        Console.WriteLine("Project Status: " + project1.ProjectStatus);

        // Print updated user information
        Console.WriteLine("\nUpdated User Information:");
        Console.WriteLine("User Name: " + user1.UserName);
        Console.WriteLine("User Role: " + user1.UserRole);
        Console.WriteLine("User Contact Info: " + user1.UserContactInfo);
        Console.WriteLine("User Address: " + user1.UserAddress);

        // // Retrieve and display users and projects
        // Console.WriteLine("\nUsers:");
        // foreach(User user in User.GetAllUsers()){
        //     Console.WriteLine(user.UserName);
        // }

        // Console.WriteLine("\nProjects:");
        // foreach(Project project in Project.GetAllProjects()){
        //     Console.WriteLine(project.ProjectName);
        // }
    }
}