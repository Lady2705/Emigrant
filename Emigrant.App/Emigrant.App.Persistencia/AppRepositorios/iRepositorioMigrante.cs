using Emigrant.App.Dominio;
using System.Collections.Generic;

namespace Emigrant.App.Persistencia.AppRepositorios
{
    public interface iRepositorioMigrante
    {
        Migrante AddMigrant(Migrante migrante);
        bool DeletMigrant(int IdMigrante);
        Migrante ActualizarMigrant(Migrante migrante);
        IEnumerable<Migrante> ConsultarMigrante();
        Migrante ConsultarMigrantId(int IdMigrante);  
    }
}