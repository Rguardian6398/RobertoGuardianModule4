using System;
namespace BakeryShoppingCart.Exceptions
{
    public class ShoppingCartException : Exception
    {
        public ShoppingCartException(string errorMessage) : base(errorMessage)
        {
        }
    }
}
