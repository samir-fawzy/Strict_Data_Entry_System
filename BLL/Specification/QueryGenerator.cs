using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BLL.Specification
{
    internal static class QueryGenerator<T> where T : class
    {
        public static IQueryable<T> GenerateQuery(IQueryable<T> table, ISpecification<T>? spec)
        {
            if (spec == null) return table;

            var query = table;

            if (spec.AsNoTracking)
            {
                query = query.AsNoTracking();
            }
            if(spec.AsTracking)
            {
                query = query.AsTracking();
            }

            if (spec.Criteria != null)
            {
                query = query.Where(spec.Criteria);
            }

            if (spec.Include != null)
            {
                foreach (var include in spec.Include)
                {
                    query = query.Include(x => include);
                }
            }

            if (spec.IncludeStrings != null)
            {
                foreach (var include in spec.IncludeStrings)
                {
                    query = query.Include(include);
                }
            }

            if (spec.OrderBy != null)
            {
                query = query.OrderBy(spec.OrderBy);
            }
            else if (spec.OrderByDescending != null)
            {
                query = query.OrderByDescending(spec.OrderByDescending);
            }

            if (spec.IsPagingEnabled)
            {
                if (spec.Skip.HasValue)
                    query = query.Skip(spec.Skip.Value);
                if (spec.Take.HasValue)
                    query = query.Take(spec.Take.Value);
            }

            return query;
        }
    }
}
