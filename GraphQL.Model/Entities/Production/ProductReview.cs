using System;

namespace GraphQL.Model.Entities.Production
{
    public class ProductReview
    {
        public ProductReview()
        {
            ReviewDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
        }

        public virtual int ProductReviewID { get; set; }
        public virtual int ProductID { get; set; }
        public virtual string ReviewerName { get; set; }
        public virtual System.DateTime ReviewDate { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual int Rating { get; set; }
        public virtual string Comments { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }
    }
}