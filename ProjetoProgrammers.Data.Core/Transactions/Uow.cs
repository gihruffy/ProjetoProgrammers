using ProjetoProgrammers.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoProgrammers.Data.Core.Transactions
{
    public class Uow : IUow
    {
        private readonly ApplicationContext _context;
        public Uow(ApplicationContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            
        }
    }
}
