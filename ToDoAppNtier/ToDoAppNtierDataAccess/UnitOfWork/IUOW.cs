using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAppNtierDataAccess.Interfaces;
using ToDoAppNtierEntities.Domains;

namespace ToDoAppNtierDataAccess.UnitOfWork
{
    public interface IUOW
    {
        IRepository<T> GetRepository<T>() where T : BaseEntity;
        Task SaveChanges();
    }
}
