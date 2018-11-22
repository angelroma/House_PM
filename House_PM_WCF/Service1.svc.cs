using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace House_PM_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IProduct
    {
        public List<Product> GetAll()
        {
            //List<Product> lista = new List<Product>();
            //lista.Add(new Product() { Id = 1, Name = "Javier" });
            //lista.Add(new Product() { Id = 2, Name = "Angel" });
            //lista.Add(new Product() { Id = 3, Name = "Octavio" });
            //lista.Add(new Product() { Id = 4, Name = "Ciro" });
            //return lista;
            List<Product> lista = new List<Product>
            {
                new Product() { Id = 1, Name = "Javier" },
                new Product() { Id = 2, Name = "Angel" },
                new Product() { Id = 3, Name = "Octavio" },
                new Product() { Id = 4, Name = "Ciro" }
            };
            return lista;
        }

        public Product GetById(int id)
        {
           if(id == 1)
            {
                return new Product() { Id = 1, Name = "Javier" };
            }
            if (id == 2)
            {
                return new Product() { Id = 2, Name = "Angel" };
            }
            if (id == 3)
            {
                return new Product() { Id = 3, Name = "Octavio" };
            }
            else 
            {
                return new Product() { Id = 4, Name = "Ciro" };
            }
        }
    }
}
