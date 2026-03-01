using BLL.Specification;
using DAL.Data;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Entity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dbSet = _context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            await _dbSet.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);

            if (entity == null)
                throw new KeyNotFoundException($"Entity with id {id} was not found.");

            _dbSet.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var entities = await _dbSet.AsNoTracking().ToListAsync();
            return entities;
        }

        public async Task<IReadOnlyList<T>> GetAllSpecAsync(ISpecification<T> spec)
        {
            var items = await ApplySpecification(spec).ToListAsync();

            return items;
        }

        public async Task<T> GetByVehicleNumberSpecAsync(ISpecification<T> spec)
        {
            return await QueryGenerator<T>.GenerateQuery(_dbSet.AsQueryable(), spec).FirstOrDefaultAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public Task UpdateAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            _dbSet.Update(entity);

            return Task.CompletedTask;
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return QueryGenerator<T>.GenerateQuery(_dbSet.AsQueryable(), spec);
        }
    }
}
