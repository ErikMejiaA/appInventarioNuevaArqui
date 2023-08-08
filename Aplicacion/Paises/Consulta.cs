
using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Paises;

public class Consulta
{
    public class ListaPais : IRequest<List<Pais>>{}

    public class Manejador : IRequestHandler<ListaPais, List<Pais>>
    {
        private readonly appInventarioNuevaArquiContext _context;

        public Manejador(appInventarioNuevaArquiContext context) {

            _context = context;
        }

        public async Task<List<Pais>> Handle(ListaPais request, CancellationToken cancellationToken)
        {
            var paises = await _context.Paises.ToListAsync();
            return paises;
        }
    }

}
