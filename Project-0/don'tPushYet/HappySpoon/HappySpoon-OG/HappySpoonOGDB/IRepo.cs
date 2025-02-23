﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonModels;

namespace HappySpoonDL
{
    public interface IRestaurant
    {
        //**************************************~ RESTAURANT INTERFACE ~****************************************
        public RestaurantProfile AddRestaurant(RestaurantProfile Restaurant);
        public List<RestaurantProfile> GetAllRestaurants();
        

        //***************************************~ REVIEW ~********************************************

        Review AddReview(Review newReview);
        //List<Review> AverageStars { get; }
    }

    public interface IUser
    {
        public List<UserProfile> GetAllUsers();

        public UserProfile AddUser(UserProfile User);

        public List<UserProfile> GetUser();

    }

}
