using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Lab-D-14;Database=NewUser;User Id=DOMAIN\\seminar;Integrated Security=True;TrustServerCertificate=True");
        }
        public DbSet<User> Users { get; set; } 
    
    }
}
