﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class xfvkxruc_phonebookEntities : DbContext
    {
        public xfvkxruc_phonebookEntities()
            : base("name=xfvkxruc_phonebookEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Club> Club { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<FootballPlayerPosition> FootballPlayerPosition { get; set; }
        public virtual DbSet<Phone> Phone { get; set; }
        public virtual DbSet<PhoneType> PhoneType { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Season> Season { get; set; }
        public virtual DbSet<Stadium> Stadium { get; set; }
        public virtual DbSet<TypeOfLeague> TypeOfLeague { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserAdress> UserAdress { get; set; }
        public virtual DbSet<UserContact> UserContact { get; set; }
        public virtual DbSet<UserHistory> UserHistory { get; set; }
        public virtual DbSet<UserStatistic> UserStatistic { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
        public virtual DbSet<UserValueHistory> UserValueHistory { get; set; }
        public virtual DbSet<State> State { get; set; }
    }
}