using Emigrant.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Emigrant.App.Persistencia.AppRepositorios
{
    public class repositorioEntidad : irepositorioEntidad
    {
       bool valorRetorno=false;
        //Ingresar informacion 

        public bool Addentidad(Entidad entidad)
        { 
          //Abriendo y Liebrando Recursos
          using(AppData.AppContext contexto = new AppData.AppContext())
         { 
            //Variable de tipo anonima con var
            var RegistroEntidad=contexto.Add(entidad);
            contexto.SaveChanges();
            if(contexto.SaveChanges()>=1)
            {
                valorRetorno=true;
             }
            return valorRetorno;
         }
        }
            //Borrar Medico

        public bool DeletEntidad(int Nit)
        {
         using(AppData.AppContext contexto = new AppData.AppContext()) 
          {    
            var BusquedaEntidad=(from p in contexto.entidad where p.Nit==Nit select p);
            if (!(BusquedaEntidad==null))
            {
             contexto.Remove(BusquedaEntidad);
             contexto.SaveChanges();
             valorRetorno=true;

            }
            return valorRetorno;
          }   
         
        }
        
        ///<summary> 
        ///Actualizar Empresa para, actualizar informacion de Empresa segun sus datos 
        /// </summary>
        /// </param name="Entidad"></param>
        /// <returns>bool</returns>
        
        public bool ActualizarEntidad(Entidad entidad)
        {
            
            using(AppData.AppContext contexto = new AppData.AppContext())
            {
                var BusquedaEntidad= contexto.entidad.SingleOrDefault(o=>o.Nit==entidad.Nit);
                if(!(BusquedaEntidad==null))
                { 
                    BusquedaEntidad.RazonSocial=entidad.RazonSocial;
                    BusquedaEntidad.Sector=entidad.Sector;
                    BusquedaEntidad.TipoServicio=entidad.TipoServicio;
                    valorRetorno=true;
                 }
                return valorRetorno;
             }

        }

        //Consultar Empresa (lista)

        public IEnumerable<Entidad> ConsultarEntidad()
        {
            //Var Listas Empresa
          
            using(AppData.AppContext contexto = new AppData.AppContext())
             {
               //return contexto.medico;
               //linq
               var ListaEntidad=(from p in contexto.entidad select p).ToList();
               return ListaEntidad;


             }
         
        }
        //Consultar Empresa

        public Entidad ConsultarEntidad(int Nit)
        { 
        
            using(AppData.AppContext contexto = new AppData.AppContext())
            {
              var ListaEntidad=(from p in contexto.entidad where p.Nit==Nit select p).First();
              return ListaEntidad;
              
             }
         }
  
    }
}