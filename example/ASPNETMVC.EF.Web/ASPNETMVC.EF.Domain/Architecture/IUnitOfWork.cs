﻿using ASPNETMVC.EF.Domain.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETMVC.EF.Domain.Architecture
{
    public interface IUnitOfWork : IDisposable
    {
        int Save();
        IContext Context { get; }
    }
}
