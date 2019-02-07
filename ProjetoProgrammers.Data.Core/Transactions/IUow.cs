using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoProgrammers.Data.Core.Transactions
{
    public interface IUow
    {
        void Commit();

        void Rollback(); 
    }
}
