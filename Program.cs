﻿using System;

namespace RestaurantReviews.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            do
            {
                //have another do while loop and switch case, where it asks if you are a user or an admin, and gives an option to go to the next method. 
                //case 1 is user where you call a method and either create a new user or access an already existing user, case two is admin and log in either using default user and pass or access one that already exists, case three is exit
                //

                /*
                Adduser, AddAdmin, 
                AddReview, SearchUser, SearchRestaurant, SearchReview
                - add a new user AddUser
                - ability to search user as admin SearchUser
                - display details of a restaurant for user SearchRestaurant
                - add reviews to a restaurant as a user AddReview
                - view details of restaurants as a user SearchRestaurant
                - view reviews of restaurants as a user SearchRestaurant
                - calculate reviews’ average rating for each restaurant SearchRestuarant
                - search restaurant (by name, rating, zip code, etc.)  SearchRestaurant.
                */
                Console.WriteLine("Welcome to Scream, your local guide to anything Restaurant Reviews!");
                Console.WriteLine("[0] Exit");
                Console.WriteLine("[1] Add a User");
                Console.WriteLine("[2] Add a Admin");
                Console.WriteLine("[3] Add a Restaurant");
                Console.WriteLine("[4] Add a Review");
                Console.WriteLine("[5] Search a User");
                Console.WriteLine("[6] Search a Restaurant");
                Console.WriteLine("[7] Search a Review");



                switch (Console.ReadLine())
                {
                    case "0":
                        Console.WriteLine("Thanks for using Scream! Remember that whenever you need to Scream into the void about a Restaurant, think about Scream!");
                        repeat = false;
                        break;

                    case "1": //adding a new user
                        break;

                    case "2": //adding a new admin
                        break;

                    case "3": //adding a new restaurant
                        break;

                    case "4": //adding a new review
                        break;

                    case "5": //search user work in progress
                        break;

                    case "6": //search restaurant
                        break;

                    case "7":
                        break;

                    default:
                        Console.WriteLine("We don't understand what you're doing");
                        break;
                }
            } while (repeat);
        }
        /// <summary>
        /// This adds a user to the database 
        /// </summary>
        private void AddUser()
        {


        }
        /// <summary>
        /// This takes a username, finds all the users in the database and returns true if the user with the certain username exists or false if not
        /// </summary>
        /// <param name="username"></param>
        /// <returns>True if string username exists, False if string username doesn't exist</returns>
        private bool SearchUsernameID(string username)
        {
            return true;
        }
        /// <summary>
        /// This first asks for the default admin password and then adds a user as an admin with changing the default password for them. 
        /// </summary>
        private void AddAdmin()
        {
        }
        /// <summary>
        /// This adds a review to the database, but first checks if the Restaurant exists in the database
        /// </summary>
        private void AddReview()// I want to take the user information here too. Make the connection in the ReviewJoin table here. 
        {
        }
        private void SearchUserID(string username)
        {
        }
        /// <summary>
        /// This adds a Restaurant into the database
        /// </summary>
        private void AddRestaurant()
        {
        }

        /// <summary>
        /// This returns a Restaurant with the given name and null if it is not found. 
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Restaurant at given name</returns>
        private void SearchRestaurantID(string name)
        {
        }
        /// <summary>
        /// This method displays the restaurant that the user requests information for.  
        /// </summary>
        private void DisplayRestaurant()
        {
        }
        /// <summary>
        /// This method takes a name and returns if a Restaurant exists with that name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>True if Restaurant exists or False if it doesn't exist.</returns>
        private bool SearchRestaurantName(string name)
        {
            return false;
        }
        /// <summary>
        /// helper method to return restaurants with their name, zipcode and rating 
        /// </summary>
        /// <returns>List of all Restaurants</returns>
        private void AllRestaurants()
        {

        }
        /// <summary>
        /// Helper method to return all Reviews with their attached information
        /// </summary>
        /// <returns></returns>
        private void AllReviews() //helper method to return reviews with title, body, rating, name, restaurant name
        {

            //this will need to grab the name of the restaurant and name of the user for that restaurant
        }
        /// <summary>
        /// Allows Admin to search Users
        /// </summary>
        private void SearchUser() //to implement
        {

        }
        /// <summary>
        /// Helper method to search by Username
        /// </summary>
        /// <param > List of Users</param>
        private void SearchByUsername() //searches users by username
        {

        }
        /// <summary>
        /// Helper method to search by name
        /// </summary>
        /// <param List of Users></param>
        private void SearchByName() //searches users by name
        {


        }
        /// <summary>
        /// Helper method to search by if someone is an admin
        /// </summary>
        /// <param List of Users="users"></param>
        private void SearchByAdmin() //searches users by if they are an Admin
        {


        }
        /// <summary>
        /// Helper method to search by Username
        /// </summary>
        /// <param username="username"></param>
        /// <returns></returns>
        private bool SearchUserName(string username)//takes a username and checks if that username is an admin
        {
            return false;
        }
        private void AllUsers()
        {
        }
        /// <summary>
        /// Displays all of the reviews for a restaurant
        /// </summary>
        private void DisplayReviewsofRestaurants()
        {
        }
        /// <summary>
        /// Search for a restaurant by Name, Rating and Zipcode
        /// </summary>
        private void SearchRestaurant()
        {
        }
        /// <summary>
        /// Prints out the Review Rating for the wanted Restaurant
        /// </summary>
        private void SeeReviewRating()//reimplement
        {

        }
        //potential join method for ReviewJoin? Include id of Review, id of User, id of Restaurant.
        /// <summary>
        /// Helper method to return all ReviewJoin matches
        /// </summary>
        /// <returns></returns>
        private void AllReviewJoin() //helper method to return reviews with title, body, rating, name, restaurant name
        {

            //this will need to grab the name of the restaurant and name of the user for that restaurant
        }
        private void SearchReview()
        {

        }
    }
    
}

