using System;
namespace RobertoGuardianMidterm.Module
{
    public class User
    {
        internal int userId;
        internal string userName;

        public User()
        {
        }

        public string Email { get; internal set; }
        public string Password { get; internal set; }
        public string UserId { get; internal set; }
        public string UserName { get; internal set; }
    }
}
