using Emigrant.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Emigrant.App.Persistencia.AppRepositorios
{
    public class repositorioMigrante: iRepositorioMigrante
    {
        //bool valorRetorno=false;
        //Ingresar informacion 

        Migrante iRepositorioMigrante.AddMigrant(Migrante migrante)
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

        bool iRepositorioMigrante.DeletMigrant(int IdMigrante)
        {
         using(AppData.AppContext contexto = new AppData.AppContext()) 
          {    
            var BusquedaMigrante=(from p in contexto.migrante where p.IdMigrante==IdMigrante select p);
            if (!(BusquedaMigrante==null))
            {
             contexto.Remove(BusquedaMigrante);
             contexto.SaveChanges();
             return true; 

            }else
            {
              return false;      
            }
            
          }   
         
        }
        
        
        
    
        Migrante iRepositorioMigrante.ActualizarMigrant(Migrante migrante)
        {
            
            using(AppData.AppContext contexto = new AppData.AppContext())
            {
                var BusquedaMigrante= contexto.migrante.SingleOrDefault(o=>o.IdMigrante==migrante.IdMigrante);
                if(BusquedaMigrante!=null)
                { 
                    BusquedaMigrante.Nombre=migrante.Nombre;
                    BusquedaMigrante.Apellido=migrante.Apellido;
                    BusquedaMigrante.Direccion=migrante.Direccion;
                    BusquedaMigrante.Telefono=migrante.Telefono;
                    BusquedaMigrante.Contrasena=migrante.Contrasena;
                    contexto.SaveChanges();
                    
                 }
                return BusquedaMigrante
                ;
             }

        }

        //Consultar Medico (lista)

         IEnumerable<Migrante> iRepositorioMigrante.ConsultarMigrante()
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
        

     

          public Migrante ConsultarMigrantId(int IdMigrante){
           using (AppData.AppContext contexto = new AppData.AppContext())
            //var migranteEncontrado = contexto.migrante.FirstOrDefault(s=>s.IdMigrante==IdMigrante);
            //return migranteEncontrado;
           
            return contexto.migrante.SingleOrDefault(s=>s.IdMigrante==IdMigrante);
         }

    }   
}