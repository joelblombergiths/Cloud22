using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v38mon
{
    internal class User
    {
        public string Name;
        private string Password = "abc123";

        public void SetPassword(string newPassword, string currentPassword)
        {
            if(currentPassword.Equals(Password))
            {
                Password = newPassword;
                Console.WriteLine("Password changed.");
            }
            else Console.WriteLine("current password does not match!");
        }
    }
}
