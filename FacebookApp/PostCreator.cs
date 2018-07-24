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
        public static void CreatePostHappyBirthday(List<User> i_friendBirthday)
        {
            foreach (User friend in i_friendBirthday)
            {
                Manager.Post($"Happy Birthday {friend.FirstName}!!!");
            }

        }
            
    }
}
