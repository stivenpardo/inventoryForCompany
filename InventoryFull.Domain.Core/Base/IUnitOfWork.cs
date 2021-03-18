using Microsoft.EntityFrameworkCore;
using System;

namespace InventoryFull.Domain.Core.Base
{
    public interface IUnitOfWork : IDisposable
    {
        public int Commit();
        public void RollBack();
        public DbSet<T> Set<T>() where T : class;
        public void Attach<T>(T item) where T : class;
        public void SetModified<T>(T item) where T : class;
        public void SetDeatached<T>(T item) where T : class;
    }
}
