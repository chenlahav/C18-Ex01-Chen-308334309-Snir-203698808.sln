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
        internal static bool CreateHappyBirthdayPost(User i_PosedUser, User i_friendBirthday)
        {
            bool postSucsses;
            string textToPost= "Happy Birthday!!!";

            try
            {
                i_PosedUser.PostStatus(textToPost, i_TaggedFriendIDs: i_friendBirthday.Id);
                postSucsses = true;
            }
            catch (Exception e)
            {
                postSucsses = false;
            }

            return postSucsses;
        }
    }
}
