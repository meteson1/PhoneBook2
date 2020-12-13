using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook2.Repositories.Inteerfaces
{
    public interface IUserRepository
    {
        void CreateUser(string name);
        void UpdateUser(int ID, string name);
        void DeleteUser(int ID);
        void FindbyID(int ID, TextBox textBox);
    }
}
