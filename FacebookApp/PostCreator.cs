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
        public static void CreateHappyBirthdayPost(User i_friendBirthday)
        {
            string textToPost= $"Happy Birthday {i_friendBirthday.FirstName}!!!";

            Manager.Post($"Happy Birthday {i_friendBirthday.FirstName}!!!",i_friendBirthday);
        }
    }
}
