using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_PM.Models.Repository.Infrastucture
{
    interface IUnitOfWork
    {
        void Commit();
        void RollBack();
    }
}
