using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Service
{
    public interface IRepositorio<T> where T : class
    {
        Task<IQueryable<T>> Consultar(Expression<Func<T, bool>> filtro = null);
        Task<T> ObtenerPorId(Guid id);
    }
}
