﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABIdea
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ABIDEAEntities : DbContext
    {
        public ABIDEAEntities()
            : base("name=ABIDEAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Auth_Category> Auth_Category { get; set; }
        public virtual DbSet<Auth_Credentials> Auth_Credentials { get; set; }
        public virtual DbSet<Blog_Author> Blog_Author { get; set; }
        public virtual DbSet<Blog_Category> Blog_Category { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserCred> UserCreds { get; set; }
    }
}
