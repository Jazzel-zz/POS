//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aariaz_Workshop
{
    using System;
    using System.Collections.Generic;
    
    public partial class transferstock
    {
        public int Id { get; set; }
        public string EventNumber { get; set; }
        public System.DateTime Date { get; set; }
        public int Warehouse_id { get; set; }
        public int Shop_id { get; set; }
        public int Product_id { get; set; }
        public int ProductQuantity { get; set; }
        public int User_id { get; set; }
        public bool Status { get; set; }
    }
}
