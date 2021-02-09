using System;
using System.Collections.Generic;
using System.Linq;
using BakeryShoppingCart.MyClasses;

namespace BakeryShoppingCart
{
    class Program
    {
        static void Main()
        {
            try
            {
                List<User> userList = new List<User>();

                User newUser1 = new User();
                newUser1.Email = "robertoguardian1@gmail.com";
                newUser1.Password = "Password1";
                newUser1.UserId = 1;
                newUser1.UserName = "Roberto";
                userList.Add(newUser1);

                User newUser2 = new User();
                newUser2.Email = "robertoguardian2@gmail.com";
                newUser2.Password = "Password2";
                newUser2.UserId = 2;
                newUser2.UserName = "Jerry";
                userList.Add(newUser2);

                User newUser3 = new User();
                newUser3.Email = "robertoguardian3@gmail.com";
                newUser3.Password = "Password3";
                newUser3.UserId = 3;
                newUser3.UserName = "Oscar";
                userList.Add(newUser3);

                User newUser4 = new User();
                newUser4.Email = "robertoguardian4@gmail.com";
                newUser4.Password = "Password4";
                newUser4.UserId = 4;
                newUser4.UserName = "Moses";
                userList.Add(newUser4);

                User newUser5 = new User();
                newUser5.Email = "robertoguardian5@gmail.com";
                newUser5.Password = "Password5";
                newUser5.UserId = 5;
                newUser5.UserName = "George";
                userList.Add(newUser5);

                User newUser6 = new User();
                newUser6.Email = "robertoguardian6@gmail.com";
                newUser6.Password = "Password6";
                newUser6.UserId = 6;
                newUser6.UserName = "Ordish";
                userList.Add(newUser6);

                User newUser7 = new User();
                newUser7.Email = "robertoguardian7@gmail.com";
                newUser7.Password = "Password7";
                newUser7.UserId = 7;
                newUser7.UserName = "Andrez";
                userList.Add(newUser7);

                User newUser8 = new User();
                newUser8.Email = "robertoguardian8@gmail.com";
                newUser8.Password = "Password8";
                newUser8.UserId = 8;
                newUser8.UserName = "Neder";
                userList.Add(newUser8);

                User newUser9 = new User();
                newUser9.Email = "robertoguardian9@gmail.com";
                newUser1.Password = "Password9";
                newUser9.UserId = 9;
                newUser9.UserName = "Jesse";
                userList.Add(newUser9);

                User newUser10 = new User();
                newUser10.Email = "robertoguardian10@gmail.com";
                newUser10.Password = "Password10";
                newUser10.UserId = 10;
                newUser10.UserName = "NeonPoison";
                userList.Add(newUser10);


                userList = userList.Where(user => user.UserName == "Roberto").ToList();

                if (userList.Count > 0)
                {
                    Console.WriteLine("Users found and they have the following properties: ");
                    string format = "My users have these properties: " +
                                          "Email {0}, UserId {1}, Password{2}," +
                                          "UserName: {3}";
                    foreach (var user in userList)
                    {
                        Console.WriteLine(format, user.Email, user.UserId,
                                 user.Password, user.UserName);
                    }
                }
                else
                {
                    throw new UserNotFound("No users found for the specified query");
                }
            }
            catch(UserNotFound exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Program Has Ended");
            }
        }
    }
}

public class UserNotFound : Exception
{
    public UserNotFound(string errorMessage) : base(errorMessage)
    {

    }
}