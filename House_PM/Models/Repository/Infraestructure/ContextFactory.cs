using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace House_PM.Models.Repository.Infrastucture
{
    public class ContextFactory
    {
        internal static ApplicationDbContext context = null;
        internal static ApplicationDbContext GetContext()
        {
            return context = context ?? new ApplicationDbContext();
        }
    }
}