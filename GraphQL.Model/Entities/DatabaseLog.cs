namespace GraphQL.Model.Entities
{
    public class DatabaseLog
    {
        public DatabaseLog()
        {
        }

        public virtual int DatabaseLogID { get; set; }
        public virtual System.DateTime PostTime { get; set; }
        public virtual string DatabaseUser { get; set; }
        public virtual string Event { get; set; }
        public virtual string Schema { get; set; }
        public virtual string Object { get; set; }
        public virtual string Tsql { get; set; }
        public virtual string XmlEvent { get; set; }

    }
}