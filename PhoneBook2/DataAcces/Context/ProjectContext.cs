using PhoneBook2.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook2.DataAcces.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"Server=TESLA/SQLEXPRESS;Database=PhoneBookDb;Integrated Security=True;";
        }
       
        public DbSet<AppUser> AppUsers { get; set; }
        
    }
}
