﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyQuizMaker
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MQuizDBEntities : DbContext
    {
        public MQuizDBEntities()
            : base("name=MQuizDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<question_answers> question_answers { get; set; }
        public virtual DbSet<questions> questions { get; set; }
        public virtual DbSet<quizs> quizs { get; set; }
        public virtual DbSet<user_answers> user_answers { get; set; }
        public virtual DbSet<user_statistics> user_statistics { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}