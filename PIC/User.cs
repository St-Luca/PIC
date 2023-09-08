using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    public class User
    {
        int Id { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        Organization Organization { get; set; }

        public int PermissionCode { get; set; }

        public User(int id, string login, string password)
        {
            Id = id;
            Login = login;
            Password = password;
            PermissionController.GivePermissions(this);
        }

        public User(Dictionary<string, string> data)
        { //разбить словарь и проинициализировать поля
            data.Add("id", "1");
            data.Add("login", "1");
            data.Add("password", "1");
            new User(int.Parse(data["id"]), data["login"], data["password"]);
        }
    }
}
