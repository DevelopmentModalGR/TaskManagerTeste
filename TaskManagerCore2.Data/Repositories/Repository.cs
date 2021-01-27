using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaskManagerCore2.Data.Context;
using TaskManagerCore2.Domain.Entities;
using TaskManagerCore2.Domain.Interfaces;

namespace TaskManagerCore2.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly DataContext _context;
        public Repository(DataContext context)
        {
            this._context = context;
        }

        #region Read Methods
        public async Task<T> ObterPorId(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<ICollection<T>> ObterTodos()
        {
            return await _context.Set<T>().ToListAsync();
        }
        #endregion

        #region Save Methods

        public async Task Adicionar(T entity)
        {
            this._context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Atualizar(T entity)
        {
            this._context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
     
        public async Task Remover(Guid id)
        {
            this._context.Set<T>().Remove(await ObterPorId(id));
            await _context.SaveChangesAsync();
        }
        #endregion
    }
}
