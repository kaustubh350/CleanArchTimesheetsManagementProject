using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimesheetsManagementProject.Domain.Models;

namespace TimesheetsManagementProject.Infra.Data.Context
{
    public class DataContext : DbContext
    {
       
        public DataContext(DbContextOptions<DataContext> options) :  base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Designations> Designations { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<ProjectUsers> ProjectUsers { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
    }
}
