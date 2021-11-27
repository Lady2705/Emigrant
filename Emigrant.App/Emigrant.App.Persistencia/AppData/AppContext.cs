using System;
using Microsoft.EntityFrameworkCore;
using Emigrant.App.Dominio;

namespace Emigrant.App.Persistencia.AppData
 {


    public class AppContext: DbContext
    {
        public DbSet<Migrante> migrante {get;set;}
        public DbSet<Entidad> entidad {get;set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           if(!optionsBuilder.IsConfigured) 
           {
               optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Grupo24R2D2;Integrated Security=True");
           }
        }
    }
}