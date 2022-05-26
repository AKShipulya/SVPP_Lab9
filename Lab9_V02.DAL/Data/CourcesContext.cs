using Lab9_V02.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_V02.DAL.Data
{
    public class CourcesContext : DbContext
    {
        public CourcesContext(DbContextOptions<CourcesContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}
