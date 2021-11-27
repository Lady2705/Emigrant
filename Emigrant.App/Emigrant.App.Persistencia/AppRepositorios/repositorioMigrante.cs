using Emigrant.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Emigrant.App.Persistencia.AppRepositorio
{
    public class repositorioMigrante: iRepositorioMigrante
    {
        bool valorRetorno=false;
        //Ingresar informacion 

        public Migrante AddMigrant(Migrante migrante)
        { 
          //Abriendo y Liebrando Recursos
          using(AppData.AppContext contexto = new AppData.AppContext())
         { 
            //Variable de tipo anonima con var
            contexto.migrante.Add(migrante);
            contexto.SaveChanges();
             return migrante;
         }
        }
            //Borrar Medico

        public bool DeletMigrat(int IdMigrante)
        {
         using(AppData.AppContext contexto = new AppData.AppContext()) 
          {    
            var BusquedaMigrante=(from p in contexto.migrante where p.IdMigrante==IdMigrante select p);
            if (!(BusquedaMigrante==null))
            {
             contexto.Remove(BusquedaMigrante);
             contexto.SaveChanges();
             valorRetorno=true; 

            }
            return valorRetorno;
          }   
         
        }
        
        
        
        public Migrante ActualizarMigrant(Migrante migrante)
        {
            
            using(AppData.AppContext contexto = new AppData.AppContext())
            {
                var BusquedaMigrante= contexto.migrante.SingleOrDefault(o=>o.IdMigrante==migrante.IdMigrante);
                if(BusquedaMigrante!=null)
                { 
                    BusquedaMigrante.Nombre=migrante.Nombre;
                    BusquedaMigrante.Apellido=migrante.Apellido;
                    BusquedaMigrante.Direccion=medicos.Direccion;
                    BusquedaMigrante.Telefono=medicos.Telefono;
                    BusquedaMigrante.contrasena=migrante.Contrasena;
                    contexto.SaveChanges();
                    
                 }
                return BusquedaMigrante
                ;
             }

        }

        //Consultar Medico (lista)

        public IEnumerable<Migrante> ConsultarMigrante()
        {
            //Var Listas Medicos
          
            using(AppData.AppContext contexto = new AppData.AppContext())
             {
               //return contexto.medico;
               //linq
               var ListaMigrante=(from p in contexto.migrante select p).ToList();
               return ListaMigrante;


             }
         
        }
        //Consultar medico

        public Migrante ConsultarMigrante(int IdMigrante)
        { 
        
            using(AppData.AppContext contexto = new AppData.AppContext())
            {
              var ListaMigrante=(from p in contexto.migrante where p.IdMigrante==IdMigrante select p).First();
              return ListaMigrante;
              
             }
         }

         public Migrante BuscarMigrantePorId(int IdMigrante){
           using (AppData.AppContext contexto = new AppData.AppContext())
           return contexto.migrate.SingleOrDefault(s=>s.IdMigrante==IdMigrante);
         }

    }   
}