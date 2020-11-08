using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductReviewManagement
{
    class ProductReviewRepository
    {
        /// <summary>
        /// UC 2:
        /// Returns the top three products with maximum rating
        /// </summary>
        /// <param name="productReviewList"></param>
        public void GetTopThreeProducts(List<ProductReview> productReviewList)
        {
            var recordedData = (from products in productReviewList
                                orderby products.Rating descending
                                select products).Take(3);
            foreach (var productReview in recordedData)
            {
                Console.WriteLine("Product ID: " + productReview.ProductID + " User ID: " + productReview.UserID + " Rating: " + productReview.Rating + " Review: " + productReview.Review);
            }
        }
    }
}
