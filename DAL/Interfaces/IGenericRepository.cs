using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IGenericRepository<T> where T : Entity
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task UpdateAsync(T entity) ;
        Task DeleteAsync(int id) ;
        Task<T> GetByVehicleNumberSpecAsync(ISpecification<T> spec);
        Task<IReadOnlyList<T>> GetAllSpecAsync(ISpecification<T> spec);
        Task SaveChangesAsync();
    }
}
