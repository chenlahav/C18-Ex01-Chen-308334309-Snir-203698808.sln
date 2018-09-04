using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp
{
    public class CommandLogin : ICommand
    {
        public bool Result { get; private set; }
        public string AppId { get; internal set; }

        public CommandLogin()
        {
        }

        public void Execute()
        {
            Result = Manager.GetInstance().Login();
        }
    }
}
