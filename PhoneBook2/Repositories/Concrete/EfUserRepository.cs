using PhoneBook2.Entity.Concrete;
using PhoneBook2.Repositories.Inteerfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook2.Repositories.Concrete
{
    public class EfUserRepository : EfBaseRepository, IBaseRepository, IUserRepository
    {
        
        public void CreateUser(string name)
        {
            AppUser user = new AppUser();
            user.PhoneNumber = name;
            db.AppUsers.Add(user);
            db.SaveChanges();
        }

        public void DeleteUser(int ID)
        {
            throw new NotImplementedException();
        }

        public void Eraser(GroupBox groupBox)
        {
            throw new NotImplementedException();
        }

        public void FindbyID(int ID, TextBox textBox)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(int ID, string name)
        {
            throw new NotImplementedException();
        }
    }
}
