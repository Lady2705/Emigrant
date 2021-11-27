using Emigrant.App.Dominio;
using System.Collections.Generic;

namespace Emigrant.App.Persistencia.AppRepositorios
{
    public interface iRepositorioMigrante
    {
        bool Addmigrant(Migrante migrante);
        bool DeletMigrant(int Nit);
        bool ActualizarMigrant(Migrante migrante);
        IEnumerable<Migrante> ConsultarMigrante();
        Migrante ConsultarMigrant(int Nit);  
    }
}