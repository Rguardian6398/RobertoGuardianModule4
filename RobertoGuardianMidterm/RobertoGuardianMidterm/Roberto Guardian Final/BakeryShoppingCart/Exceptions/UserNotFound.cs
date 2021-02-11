using System;
namespace BakeryShoppingCart.Exceptions
{
    public class UserNotFound : ShoppingCartException
    {
        public UserNotFound(string errorMessage) : base(errorMessage)
        {
        }
    }
}
