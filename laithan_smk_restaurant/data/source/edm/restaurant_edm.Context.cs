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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_restaurantEntities : DbContext
    {
        public db_restaurantEntities()
            : base("name=db_restaurantEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<detailorder> detailorders { get; set; }
        public virtual DbSet<headerorder> headerorders { get; set; }
        public virtual DbSet<msemployee> msemployees { get; set; }
        public virtual DbSet<msmember> msmembers { get; set; }
        public virtual DbSet<msmenu> msmenus { get; set; }
    }
}
