using System.Threading.Tasks;
using ProAgil.Domain;

namespace ProAgil.Repository
{
    public interface IProAgilRepository
    {
        // Geral
         void Add<T>(T entity) where T: class;
         void Update<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;

         Task<bool> SaveChangeAsync();

         // Eventos
         Task<Evento[]> GetAllEventoAsyncByTema(string tema, bool includePalestrante);
         Task<Evento[]> GetAllEventoAsync(bool includePalestrante);
         Task<Evento> GetAllEventoAsyncById(int EventoId, bool includePalestrante);

         // Palestrante
         Task<Palestrante[]> GetAllPalestranteAsyncByName(string name, bool includeEventos);
         Task<Palestrante> GetAllPalestranteAsyncById(int PalestranteId, bool includeEventos);
    }
}