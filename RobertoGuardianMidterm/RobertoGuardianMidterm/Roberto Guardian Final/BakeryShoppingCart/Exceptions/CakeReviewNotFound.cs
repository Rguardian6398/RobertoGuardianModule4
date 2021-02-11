using System;
namespace BakeryShoppingCart.Exceptions
{
    public class CakeReviewNotFound : ShoppingCartException
    {
        public CakeReviewNotFound(string errorMessage) : base(errorMessage)
        {
        }
    }
}
