using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAppNtierDataAccess.Context;
using ToDoAppNtierDataAccess.Interfaces;
using ToDoAppNtierDataAccess.Repositories;
using ToDoAppNtierEntities.Domains;

namespace ToDoAppNtierDataAccess.UnitOfWork
{
    public class UOW : IUOW
    {
        private readonly ToDoContext _context;

        public UOW(ToDoContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
           return new Repository<T>(_context);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
