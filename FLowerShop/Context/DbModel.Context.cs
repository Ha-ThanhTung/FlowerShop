﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlowerShop.Context
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FlowerShopEntities : DbContext
    {
        public FlowerShopEntities()
            : base("name=FlowerShopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DISCOUNTCODE> DISCOUNTCODES { get; set; }
        public virtual DbSet<FLOWER> FLOWERS { get; set; }
        public virtual DbSet<FLOWERTYPE> FLOWERTYPES { get; set; }
        public virtual DbSet<ORDERDETAIL> ORDERDETAILS { get; set; }
        public virtual DbSet<ORDERHISTORY> ORDERHISTORies { get; set; }
        public virtual DbSet<ORDER> ORDERS { get; set; }
        public virtual DbSet<SHOPPINGCART> SHOPPINGCARTs { get; set; }
        public virtual DbSet<USERDISCOUNT> USERDISCOUNTs { get; set; }
        public virtual DbSet<USER> USERS { get; set; }
    }
}
