﻿global using Serilog;
using System;
using HappySpoonUI;

//Implementing main menu options with menu interface
bool repeat = true;
MenuInterface menu = new MainMenu();
//LoginSignupInterface loginSignupMenu = new LoginSignupMenu();


while (repeat)
{
      menu.Display();
      string answer = menu.UserChoices();

      switch (answer)
      {
            case "SearchRestaurants":
                  Console.WriteLine("Restaurant search in progress...");
                  menu = new SearchRestaurantsMenu();
                  break;
            case "LoginSignup":
                  Console.WriteLine("Login / Signup in progress...");
                  menu = new AddUserMenu();
                  break;
            case "MainMenu":
                  menu = new MainMenu(); 
                  break;
            case "Exit":
                  repeat = false;
                  break;
            default:
                  Console.WriteLine("View not found \nPlease press <enter> to continue.");
                   //repeat = true;
                   menu.Display();
                  break;
      }
}