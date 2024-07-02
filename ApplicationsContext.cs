using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_frame
{
    public class ApplicationContext : DbContext
    {
        public DbSet<All_Info> All_Info { get; set; }

        // Конструктор, принимающий DbContextOptions
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        // Переопределение метода OnConfiguring для установки строки подключения
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=DefaultConnection.db");
            }
        }
    }
}
