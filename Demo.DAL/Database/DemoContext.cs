using Demo.DAL.Entitiy;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DAL.Database
{
    public class DemoContext :DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> opt): base(opt)
        {

        }
        public DbSet<Department> Department { get; set; }
        public DbSet<Employee> Employee { get; set; }




        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=.;database=DemoDb;integrated Security=true");
        //}


    }
}
