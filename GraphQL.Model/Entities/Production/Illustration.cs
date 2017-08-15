using System;

namespace GraphQL.Model.Entities.Production
{
    public class Illustration
    {
        public Illustration()
        {
            ModifiedDate = DateTime.Now;
            //ProductModels = new List<ProductModel>();
        }

        public virtual int IllustrationID { get; set; }
        public virtual string Diagram { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        //public virtual ICollection<ProductModel> ProductModels { get; set; }
    }
}