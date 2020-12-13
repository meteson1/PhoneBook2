using PhoneBook2.DataAcces.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook2.Repositories.Concrete
{
    public class EfBaseRepository
    {
        public ProjectContext db;
        public EfBaseRepository() 
        {
            db = new ProjectContext();
        }
    }
}
///ProjectContext nesnesini new'lemiş olduk. Böylelikle bütün repositorylere buradan kalıtım vereceğimiz için, her bir
///sınıfta ProjectContext nesnesini new lememiş olacağız.