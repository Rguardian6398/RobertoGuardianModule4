using System;
using BakeryShoppingCart.Models;
using BakeryShoppingCart.DTOS;
using BakeryShoppingCart.Exceptions;
using System.Collections.Generic;

namespace BakeryShoppingCart
{
    class Program
    {
        static void Main()
        {
            try
            {
                ShoppingCart myShoppingCart = new ShoppingCart();

                myShoppingCart.ExecuteMainMenu();
            }
            catch (ShoppingCartException exception)
            {
                Console.WriteLine(exception.Message);
            }
            string response = "";
            List<User> userList = new List<User>();
            List<Comment> commentList = new List<Comment>();

            while (response != "5")
            {
                Console.WriteLine("1. Create a User");
                Console.WriteLine("2. Create a Comment");
                Console.WriteLine("3. Print the List of Users");
                Console.WriteLine("4. Print the List of Comments");
                Console.WriteLine("5. Exit");

                Console.WriteLine("");
                Console.WriteLine("Please select an option");
                response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        User user = new User();
                        user.Email = "robertoguardian154@gmail.com";
                        user.Password = "PassW0rrd";
                        user.userId = 1;
                        user.userName = "Roberto";

                        userList.Add(user);
                        break;
                    case "2":
                        Comment myComment = new Comment();
                        myComment.CommentId = 1;
                        myComment.TheComment = "hello";

                        commentList.Add(myComment);
                        break;
                    case "3":
                        Console.WriteLine("This is a List of Users created:");

                        foreach (var insideUser in userList)
                        {
                            Console.WriteLine("The user Email is: " + insideUser.Email);
                            Console.WriteLine("The user Password is: " + insideUser.Password);
                            Console.WriteLine("The user id is: " + insideUser.UserId);
                            Console.WriteLine("The user Name is: " + insideUser.UserName);
                        }
                        break;
                    case "4":
                        Console.WriteLine("This is a List of Comments created:");

                        foreach (var insideComment in commentList)
                        {
                            Console.WriteLine("The comment id is: " + insideComment.CommentId);
                            Console.WriteLine("The actual comment is: " + insideComment.TheComment);
                        }
                        break;
                }
            }
        }
    }
}