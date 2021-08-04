using DAL.Models;
using RepoL.Repository_pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.ReviewService
{
   public class ReviewService : IReviewService
    {
        #region Property  
        private IRepository<Review> _repository;
        #endregion

        #region Constructor  
        public ReviewService(IRepository<Review> repository)
        {
            _repository = repository;
        }
        #endregion

        public IEnumerable<Review> GetAllReviews()
        {
            return _repository.GetAll();
        }

        public Review GetReview(int id)
        {
            return _repository.Get(id);
        }

        public void InsertReview(Review review)
        {
            _repository.Insert(review);
        }
        public void UpdateReview(Review review)
        {
            _repository.Update(review);
        }

        public void DeleteReview(int id)
        {
            Review review = GetReview(id);
            _repository.Remove(review);
            _repository.SaveChanges();
        }
    }
}
