using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Service
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {


        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public Repositorio(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        public async Task<IQueryable<T>> Consultar(Expression<Func<T, bool>> filtro = null)
        {
            IQueryable<T> query = _dbSet;

            if (filtro != null)
            {
                query = query.Where(filtro);
            }

            return query;
        }

        public async Task<T> ObtenerPorId(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }
    }
}
