using SupportSaler.Model.Abstractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportSaler.Model
{
    public class MyAccount : IAccount
    {
        public string UserID { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FACode { get; set; }
        public string Profile { get; set; }

        public void GetAccountInfo()
        {

        }
    }
}
