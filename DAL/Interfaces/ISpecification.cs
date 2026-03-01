using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ISpecification<T> 
    {
        Expression<Func<T, bool>>? Criteria { get; }
        ICollection<Expression<Func<T, object>>> Include { get; }
        public List<string> IncludeStrings { get; }
        // Optional ordering
        Expression<Func<T, object>>? OrderBy { get; }
        Expression<Func<T, object>>? OrderByDescending { get; }

        // Optional paging
        int? Skip { get; }
        int? Take { get; }
        bool IsPagingEnabled { get; }

        // Optional optimization flags
        bool AsNoTracking { get; }
        bool AsTracking { get; }
    }
}
