using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    internal class ApplicationDbContext : DbContext
    {
        //connecting to the database
        // after connecting we perform migration to the database
        // add-migration <name of the migration> command
        // then add the updates to the database
        // update-database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Company;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        }

        //adding table to the database
        DbSet<Employee> Employees { set; get; }
    }
}
