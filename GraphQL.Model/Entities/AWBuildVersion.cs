using System;

namespace GraphQL.Model.Entities
{
    public class AWBuildVersion
    {
        public AWBuildVersion()
        {
            ModifiedDate = DateTime.Now;
        }

        public virtual byte SystemInformationID { get; set; }
        public virtual string DatabaseVersion { get; set; }
        public virtual System.DateTime VersionDate { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

    }
}