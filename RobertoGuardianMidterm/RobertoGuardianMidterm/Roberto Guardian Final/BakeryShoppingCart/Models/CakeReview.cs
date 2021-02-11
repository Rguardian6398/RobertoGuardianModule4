using System;
namespace BakeryShoppingCart.Models
{
    public class CakeReview
    {
        public CakeReview()
        {
        }

        public int CakeReviewId { get; set; }

        public string Review { get; set; }

        public int CakeId { get; set; }

        public override string ToString()
        {
            string format = "Review Id: [{0}], The Review: [{1}]]";

            return String.Format(format, CakeReviewId, Review, CakeId);
        }
    }
}
