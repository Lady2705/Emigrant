using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Emigrant.App.Dominio
{
      
    [Table("EntidadDb")]

    public class Entidad
    {
        [Column("Id_Entidad")]
        [Key]
      
        public int Id_Entidad { get; set; }


        [Required]
        [Column("RazonSocial")]
        [StringLength(50, MinimumLength = 5)]
        public string RazonSocial { get; set; }

        [Required]
        [Column("Nit")]
        public int Nit { get; set; }

        [Required]
        [Column("Sector")]
        [StringLength(20, MinimumLength = 5)]
        public string Sector { get; set; }

        [Required]
        [Column("TipoServicio")]
        [StringLength(50, MinimumLength = 5)]
        public string TipoServicio { get; set; }

         public Entidad(int id_entidad, string razonsocial, int nit,  string sector, string tiposervicio)
        {
            this.Id_Entidad = id_entidad;
            this.RazonSocial= razonsocial;
            this.Nit = nit;
            this.Sector = sector;
            this.TipoServicio = tiposervicio;

        }
    }

    
}