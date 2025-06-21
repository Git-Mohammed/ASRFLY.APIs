using ASRFLY.Domain.Entities.CategoryEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASRFLY.Infrastructure.EntityFrameworkCore.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base()
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string con = @"Server=.; Database=ASRFLYDb; Trusted_Connection=True; TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(con);
        }
    }
}
