using System;

namespace GraphQL.Model.Entities.Production
{
    public class BillOfMaterials
    {
        public BillOfMaterials()
        {
            StartDate = DateTime.Now;
            PerAssemblyQty = (System.Decimal)1.00;
            ModifiedDate = DateTime.Now;
        }

        public virtual int BillOfMaterialsID { get; set; }
        public virtual int? ProductAssemblyID { get; set; }
        public virtual int ComponentID { get; set; }
        public virtual System.DateTime StartDate { get; set; }
        public virtual System.DateTime? EndDate { get; set; }
        public virtual string UnitMeasureCode { get; set; }
        public virtual short BOMLevel { get; set; }
        public virtual decimal PerAssemblyQty { get; set; }
        public virtual System.DateTime ModifiedDate { get; set; }

        //public virtual Product ComponentProduct { get; set; }
        //public virtual Product AssemblyProduct { get; set; }
        public virtual UnitMeasure UnitMeasure { get; set; }
    }
}