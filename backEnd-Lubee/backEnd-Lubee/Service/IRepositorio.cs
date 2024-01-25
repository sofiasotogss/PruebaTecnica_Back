using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace backEnd_Lubee.Service
{
    public interface IRepositorio<T> where T : class
    {
        IQueryable<T> Consultar(Expression<Func<T, bool>> filtro = null);
    }
}
