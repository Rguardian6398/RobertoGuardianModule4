using System;
namespace BakeryShoppingCart.DTOS
{
    public class CakeReviewDTO
    {
        public CakeReviewDTO()
        {
        }

        public int CakeReviewId { get; set; }

        public string Review { get; set; }

        public int CakeId { get; set; }
    }
}
