using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp
{
    public abstract class connectionServiceBase : IDisposable
    {
        abstract public User Login();
        abstract public User GetLoggedInUser();

        abstract public void Dispose();
    }
}
