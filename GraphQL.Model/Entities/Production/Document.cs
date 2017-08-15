using System;

namespace GraphQL.Model.Entities.Production
{
    public class Document
    {
        public Document()
        {
            ChangeNumber = 0;
            ModifiedDate = DateTime.Now;
            //Products = new List<Product>();
        }

        public virtual int DocumentID { get; set; }
        public virtual string Title { get; set; }
        public virtual string FileName { get; set; }
        public virtual string FileExtension { get; set; }
        public virtual string Revision { get; set; }
        public virtual int ChangeNumber { get; set; }
        public virtual byte Status { get; set; }
        public virtual string DocumentSummary { get; set; }
        public virtual Byte[] DocumentMember { get; set; }
        public virtual DateTime ModifiedDate { get; set; }

        // public virtual ICollection<Product> Products { get; set; }
    }
}