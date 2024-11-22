    using System;
    class EmpLogin
    {
      private string username;
      private string password;
      
      public string Username
      {
          get { return username ;}
          set { username = value ; }
      }
      
      public string Password
      {
          get { return password; }
          set { password = value ; }
      }
      
      public bool Login(string enterUsername, string enterPassword)
      {
          return username == enterUsername && password == enterPassword;
      }
    }