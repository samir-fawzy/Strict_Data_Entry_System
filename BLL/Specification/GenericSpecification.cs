using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Specification
{
    public class GenericSpecification<T> : ISpecification<T>
    {
        public Expression<Func<T, bool>>? Criteria { get; }

        public ICollection<Expression<Func<T, object>>> Include { get; private set; }

        public Expression<Func<T, object>>? OrderBy { get; private set; }

        public Expression<Func<T, object>>? OrderByDescending { get; private set; }

        public int? Skip { get; private set; }

        public int? Take { get; private set; }

        public bool IsPagingEnabled { get; private set; }

        public bool AsNoTracking { get; private set; }

        public List<string> IncludeStrings { get; }

        public bool AsTracking { get; private set; }

        public GenericSpecification(Expression<Func<T, bool>>? criteria = null)
        {
            Criteria = criteria;
            Include = new List<Expression<Func<T, object>>>();
            IncludeStrings = new List<string>();
        }

        // Fluent/protected helpers intended for concrete specifications to call
        protected void AddInclude(Expression<Func<T, object>> includeExpression)
        {
            if (includeExpression != null) Include.Add(includeExpression);
        }

        protected void AddInclude(string includeString)
        {
            IncludeStrings.Add(includeString);
        }

        protected void ApplyOrderBy(Expression<Func<T, object>> orderByExpression)
        {
            OrderBy = orderByExpression;
            OrderByDescending = null;
        }

        protected void ApplyOrderByDescending(Expression<Func<T, object>> orderByDescExpression)
        {
            OrderByDescending = orderByDescExpression;
            OrderBy = null;
        }

        protected void ApplyPaging(int skip, int take)
        {
            Skip = skip;
            Take = take;
            IsPagingEnabled = true;
        }

        protected void EnableNoTracking()
        {
            AsNoTracking = true;
        }

        protected void EnableTracking()
        {
            AsTracking = true;
        }
    }
}
