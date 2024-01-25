using backEnd_Lubee.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace backEnd_Lubee.Service
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        private readonly DBContexLubee _dbContext;

        public Repositorio(DBContexLubee dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> Consultar(Expression<Func<T, bool>> filtro = null)
        {
            IQueryable<T> queryEntidad = filtro == null ? _dbContext.Set<T>() : _dbContext.Set<T>().Where(filtro);
            return queryEntidad;
        }

    }
}
