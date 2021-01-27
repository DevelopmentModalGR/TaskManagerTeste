using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaskManagerCore2.Domain.Entities;

namespace TaskManagerCore2.Domain.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        Task<ICollection<T>> ObterTodos();
        Task<T> ObterPorId(Guid id);
        Task Adicionar(T entity);
        Task Atualizar(T entity);
        Task Remover(Guid id);
    }
}
