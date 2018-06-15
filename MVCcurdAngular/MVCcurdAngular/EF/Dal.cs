using MVCcurdAngular.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCcurdAngular.EF
{
    public class Dal:DbContext
    {
        public Dal():base("dbconnection") { }

        public DbSet<emp> emps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<emp>().ToTable("test");
            modelBuilder.Entity<emp>().HasKey(x => x.Id);
        }
    }
}