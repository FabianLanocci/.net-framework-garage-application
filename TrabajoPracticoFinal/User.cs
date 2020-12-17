using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoFinal
{
    public class User
    {
        private string userName;
        private string password;
        private string question;
        private string answer;
        private DateTime lastAccess;

        public string UserName
        {
            set
            {
                this.userName = value;
            }
            get
            {
                return this.userName;
            }
        }

        public string Password
        {
            set
            {
                this.password = value;
            }
            get
            {
                return this.password;
            }
        }

        public string Question
        {
            set
            {
                this.question = value;
            }
            get
            {
                return this.question;
            }
        }

        public string Answer
        {
            set
            {
                this.answer = value;
            }
            get
            {
                return this.answer;
            }
        }

        public DateTime LastAcess
        {
            set
            {
                this.lastAccess = value;
            }
            get
            {
                return this.lastAccess;
            }
        }

        public override string ToString()
        {
            return userName;
        }
    }
}
