using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Emigrant.App.Dominio
{
    
    
           [Table("MigranteDb")]
    public class Migrante:Persona
    {

        [Column("IdMigrante")]

        public int IdMigrante { get; set; }

       // [ForeignKey("Idaf")]
       //public virtual AmigosyFamilia { get; set; }
        
        [ForeignKey("IdEntidad")]
        public virtual Entidad Entidad { get; set; }

         public Migrante(int Id, string Nombre, string Apellido, string Direccion, string Telefono, int idMigrante, string Contrasena):base(Id,  Nombre, Apellido, Direccion, Telefono, Contrasena)
        {
            this.IdMigrante = idMigrante;
            

        }

        

    } 
    
}