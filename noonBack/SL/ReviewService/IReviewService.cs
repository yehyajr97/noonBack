using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.ReviewService
{
    interface IReviewService
    {
        IEnumerable<Review> GetAllReviews();
        Review GetReview(int id);
        void InsertReview(Review review);
        void UpdateReview(Review review);
        void DeleteReview(int id);
    }
}
