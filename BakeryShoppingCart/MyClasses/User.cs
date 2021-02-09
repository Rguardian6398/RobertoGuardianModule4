using System;
namespace BakeryShoppingCart.MyClasses
{
    public class User
    {
        public User()
        {
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public object Password { get; internal set; }
        public string Email { get; internal set; }
    }
}
