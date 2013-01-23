using ASPNETMVC.EF.Domain.Architecture;
using ASPNETMVC.EF.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETMVC.EF.Domain
{

    public class UnitOfWork<T> : IUnitOfWork where T : IContext, new()
    {
        private readonly IContext _context;

        public UnitOfWork()
        {
            _context = new T();
        }

        public UnitOfWork(IContext context)
        {
            _context = context;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public IContext Context
        {
            get { return _context; }
        }

        public void Dispose()
        {
            _context.Dispose();
        }


    }

    //public class UnitOfWork : IUnitOfWork 
    //{
    //    private readonly IContext _context;
    //    private 
    //    public UnitOfWork()
    //    {
    //        _context = new ShopEntities();
    //    }

    //    public UnitOfWork(IContext context)
    //    {
    //        _context = context;
    //    }

    //    public int Save()
    //    {
    //        return _context.SaveChanges();
    //    }

    //    public IContext Context
    //    {
    //        get { return _context; }
    //    }

    //    public void Dispose()
    //    {
    //        _context.Dispose();
    //    }


    //}
}
