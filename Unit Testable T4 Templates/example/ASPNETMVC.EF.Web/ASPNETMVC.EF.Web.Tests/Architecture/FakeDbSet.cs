using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETMVC.EF.Web.Tests.Architecture
{
    public abstract class FakeDbSet<T> : IDbSet<T> where T : class, new()
    {
        public FakeDbSet() : this(Enumerable.Empty<T>())
        {
        }

        public FakeDbSet(IEnumerable<T> entities)
        {
            _set = new ObservableCollection<T>();
            foreach (var entity in entities)
            {
                _set.Add(entity);
            }
            _queryableSet = _set.AsQueryable();
        }

        public T Create()
        {
            return new T();
        }

        public System.Collections.ObjectModel.ObservableCollection<T> Local
        {
            get { return _set; }
        }

        public T Add(T entity)
        {
            _set.Add(entity);
            return entity;
        }

        public T Attach(T entity)
        {
            _set.Add(entity);
            return entity;
        }

        public void Detach(T entity)
        {
            _set.Remove(entity);
        }

        public T Remove(T entity)
        {
            _set.Remove(entity);
            return entity;
        }

        public TDerivedEntity Create<TDerivedEntity>() where TDerivedEntity : class, T
        {
            return Activator.CreateInstance<TDerivedEntity>();
        }

        public abstract T Find(params object[] values);

        public Type ElementType
        {
            get { return _queryableSet.ElementType; }
        }

        public Expression Expression
        {
            get { return _queryableSet.Expression; }
        }

        public IQueryProvider Provider
        {
            get { return _queryableSet.Provider; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _set.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        readonly ObservableCollection<T> _set;
        readonly IQueryable<T> _queryableSet;


        

        
    }
}
