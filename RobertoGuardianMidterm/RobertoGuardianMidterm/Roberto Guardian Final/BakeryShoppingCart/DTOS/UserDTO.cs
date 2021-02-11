using System;
namespace BakeryShoppingCart.DTOS
{
    public class UserDTO
    {
        public UserDTO()
        {
        }

        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        private string EncryptedPassword { get; set; }

        public string Email { get; set; }

        public RoleDTO Role { get; set; }
    }
}
