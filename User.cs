using System;
using System.Collections.Generic;

public class User
{
    #region Private Properties
    private int _userId;
    private string _userName;
    private UserRole _userRole;
    private string _userContactInfo;
    private string _userAddress;
    private List<User> _users = new List<User>();
    #endregion
    #region Public Properties
    public int UserID
    {
        get { return _userId; }
        set { _userId = value; }
    }
    public string UserName
    {
        get { return _userName; }
        set { _userName = value; }
    }
    public UserRole UserRole
    {
        get { return _userRole; }
        set { _userRole = value; }
    }
    public string UserContactInfo
    {
        get { return _userContactInfo; }
        set { _userContactInfo = value; }
    }
    public string UserAddress
    {
        get { return _userAddress; }
        set { _userAddress = value; }
    }
    public User(int userId, string userName, UserRole userRole, string userContactInfo, string userAddress)
    {
        _userId = userId;
        _userName = userName;
        _userRole = userRole;
        _userContactInfo = userContactInfo;
        _userAddress = userAddress;
    }
    public List<User> Users{
        get { return _users; }
        set { _users = value; }
    }
    #endregion
    #region Methods
    /// <summary>
    /// Updates the user's information with new values.
    /// </summary>
    /// <param name="newUserName">The new name to be assigned to the user.</param>
    /// <param name="newUserContactInfo">The new contact information for the user.</param>
    /// <param name="newUserAddress">The new address for the user.</param>
    public void UpdateUserInfo(string newUserName, string newUserContactInfo, string newUserAddress)
    {
        _userName = newUserName;
        _userContactInfo = newUserContactInfo;
        _userAddress = newUserAddress;
    }

    private void UpdateUserRole(UserRole newUserRole){
        _userRole = newUserRole;
    }

    private void GetAllUsers(){
        foreach(User user in _users){
            Console.WriteLine(user.UserName);
        }
    }
    #endregion
}
/// <summary>
/// List of possible user roles.
/// </summary>
public enum UserRole
{
    Employee,
    Contractor,
    Client
}