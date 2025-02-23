﻿namespace HappySpoonModels
{
    public class UserProfile 
	{
		public int UserID { get; set; }
		public string UserName { get; set; }
		public string UserEmail { get; set; }
		public string UserPassword { get; set; }
		public string UserAccess { get; set; }
		private string AdminAccess { get; }
		private int AdminID { get; }
		public string AdminName { get; set; }
		public string AdminPassword { get; set; }


		public UserProfile()
		{
			UserAccess = "B";
            UserName = "";
			UserEmail = "";
			UserID = ++UserID;
			UserPassword = "";
			
			AdminAccess = "A";
			AdminID = 0;
			AdminName = "El Jefe";
			AdminPassword = "1234";
		}

        public override string ToString()
        {
            return $"UserID: {UserID}\nUsername: {UserName}\nEmail: {UserEmail} \nPassword: {UserPassword}";
        }

        public string AdminToString()
        {
			return $"AdminID: {AdminID}\nAdminName: {AdminName}\nAdmin Password: {AdminPassword}";
		}

	}

}

