using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp
{
    static class PostCreator
    {
        public static void CreatePostHappyBirthday(User i_friendBirthday)
        {
            Manager.Post($"Happy Birthday {i_friendBirthday.FirstName}!!!");
        }
    }
}
