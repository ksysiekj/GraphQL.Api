using System;
using System.Collections.Generic;

namespace GraphQL.Model.Entities.Production
{
    public class ProductPhoto
    {
        public ProductPhoto()
        {
            ModifiedDate = DateTime.Now;
            Products = new List<Product>();
        }

        public virtual int ProductPhotoID { get; set; }
        public virtual System.Byte[] ThumbNailPhoto { get; set; }
        public virtual string ThumbnailPhotoFileName { get; set; }
        public virtual System.Byte[] LargePhoto { get; set; }
        public virtual string LargePhotoFileName { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}