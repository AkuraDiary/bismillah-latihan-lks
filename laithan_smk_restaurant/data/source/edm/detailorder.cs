//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace laithan_smk_restaurant.data.source.edm
{
    using System;
    using System.Collections.Generic;
    
    public partial class detailorder
    {
        public int detail_id { get; set; }
        public string order_id { get; set; }
        public int menu_id { get; set; }
        public int qty { get; set; }
        public int price { get; set; }
        public string status { get; set; }
    
        public virtual headerorder headerorder { get; set; }
        public virtual msmenu msmenu { get; set; }
    }
}
