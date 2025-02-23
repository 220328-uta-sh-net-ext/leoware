﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonUI;
using HappySpoonModels;
using HappySpoonDL;
using HappySpoonBL;

namespace HappySpoonUI
{
    public class LoginMenu : IMenu
    {
        private readonly List<UserProfile> users = new List<UserProfile>();
        private readonly List<Admin> admins = new List<Admin>();
        readonly ILogic logic;
        readonly IRepo repo;
        public LoginMenu(ILogic logic, IRepo repo)
        {
            this.logic = logic;
            this.repo = repo;
        }

        public void Display()
        {
            Console.WriteLine("Welcome back, user!");
            Console.WriteLine("Please log in to continue");
            Console.WriteLine("Press <1> Enter your account information" );
            Console.WriteLine("Press <2> Back to Main Menu");
            Console.WriteLine("Press <0> Exit Program");
        }

        public string UserChoices()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Log.Debug("Prompting login username");
                    Console.WriteLine("Enter your username: ");
                    string uName = Console.ReadLine();
                    Log.Debug("Prompting password");
                    Console.WriteLine("Enter Password: ");
                    string uPassword = Console.ReadLine();
                    var info = logic.GetUser(uName, uPassword);
                    foreach(var i in info)
                    {
                        if (uName == i.UserName && uPassword == i.UserPassword)
                        {
                            Log.Information($"User, {uName}, has logged in");
                            Console.WriteLine($"User, { uName}, is logged in");
                            return "AddReviewMenu";
                        }
                        else
                        {
                            Log.Debug("User login failed");
                            throw new InvalidDataException ("UserName or Password is invalid. Try again...");
                        }
                    }
                    var admin = logic.GetAdmin();
                    foreach (var a in admin)
                    {
                        if (uName == a.AdminName && uPassword == a.AdminPassword)
                        {
                            Log.Information($"What's up, {uName}?!");
                            Console.WriteLine($"What's up, {uName}?!");
                            return "AdminMenu";
                        }
                        else
                        {
                            Log.Debug("User login failed");
                            throw new InvalidDataException("UserName or Password is invalid. Try again...");
                        }
                    }
                    return "LoginMenu";
                case "2":
                    Log.Debug("Returning user to main menu");
                Console.WriteLine("Returning to Main Menu.....");
                    return "MainMenu";
                case "0":
                    Log.Debug("User has exited program");
                    return "ExitProgram";
                default:
                    Log.Debug("User input was invalid. Returning to Login Menu");
                    Console.WriteLine("Please enter a valid option.");
                    Console.WriteLine("Press <Enter> to continue");
                    Console.ReadLine();
                    return "LoginMenu";
            }
        }

    }
}
