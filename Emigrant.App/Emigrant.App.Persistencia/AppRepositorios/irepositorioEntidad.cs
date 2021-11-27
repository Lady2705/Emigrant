using Emigrant.App.Dominio;
using System.Collections.Generic;

namespace Emigrant.App.Persistencia.AppRepositorios
{
    public interface irepositorioEntidad
    {
        bool Addentidad(Entidad entidad);
        bool DeletEntidad(int Nit);
        bool ActualizarEntidad(Entidad entidad);
        IEnumerable<Entidad> ConsultarEntidad();
        Entidad ConsultarEntidad(int Nit);  
    }
}