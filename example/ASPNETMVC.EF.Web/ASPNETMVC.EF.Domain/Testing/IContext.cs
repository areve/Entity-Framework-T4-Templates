

 


//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace ASPNETMVC.EF.Domain.Testing
{
    using System;
    
    public partial interface IContext : IDisposable
    {
    	int SaveChanges();
        void SetModified(object entity);
        void SetAdded(object entity);
    }
    }
