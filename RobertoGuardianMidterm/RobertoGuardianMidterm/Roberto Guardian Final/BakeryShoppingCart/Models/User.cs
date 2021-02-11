using System;

namespace BakeryShoppingCart.Models
{
    public class User
    {
        internal int userId;
        internal string userName;

        public User()
        {
        }

        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        private string EncryptedPassword { get; set; }

        public string Email { get; set; }

        public Role Role { get; set; }

        public override string ToString()
        {
            string format = "User Id: [{0}], User Name[{1}], Password[{2}], Email[{3}]";

            return String.Format(format, UserId, UserName, Password, Email);
        }
    }
}
