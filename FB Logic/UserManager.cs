using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FBLogic
{
    public sealed class UserManager
    {
        private const string k_ErrorUserAlredyConnectMsg = "Already Exists User That Connect To System";

        private static readonly object sr_CreateInstaceContex = new object();

        private static UserManager s_Instance = null;

        public event Action AppLeave;

        public static UserManager Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_CreateInstaceContex)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new UserManager();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public User User { get; private set; }

        public string PropilePhotoURL { get; private set; }

        public string Name { get; private set; }

        public string Birthday { get; private set; }

        public string AccesToken { get; private set; }

        private UserManager()
        {
        }

        public void Login()
        {
            const string guyID = "1450160541956417";
            const string yossiID = "478629669585789";

            if (string.IsNullOrEmpty(AccesToken))
            {
                LoginResult result = FacebookService.Login(
                    yossiID,
                    "public_profile",
                    "email",
                    "publish_to_groups",
                    "user_birthday",
                    "user_age_range",
                    "user_gender",
                    "user_link",
                    "user_tagged_places",
                    "user_videos",
                    "publish_to_groups",
                    "groups_access_member_info",
                    "user_friends",
                    "user_events",
                    "user_likes",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_hometown");

                initUserAndData(result);
            }
            else
            {
                throw new Exception(k_ErrorUserAlredyConnectMsg);
            }
        }

        private void initUserAndData(LoginResult i_Result)
        {
            if (!string.IsNullOrEmpty(i_Result.AccessToken))
            {
                User = i_Result.LoggedInUser;
                AccesToken = i_Result.AccessToken;
                PropilePhotoURL = User.PictureNormalURL;
                Name = User.Name;
                Birthday = User.Birthday;
            }
            else
            {
                throw new Exception(i_Result.ErrorMessage);
            }
        }

        public void Connect(string i_AccesToken)
        {
            if (string.IsNullOrEmpty(AccesToken))
            {
                LoginResult result = FacebookService.Connect(i_AccesToken);
                initUserAndData(result);
            }
            else
            {
                throw new Exception(k_ErrorUserAlredyConnectMsg);
            }
        }

        public void Logout()
        {
            FacebookService.Logout(() => { });
            AccesToken = null;
            Birthday = null;
            Name = null;
            PropilePhotoURL = null;
            User = null;
        }

        public void LeaveApp()
        {
            onAppLeave();
            Logout();
        }

        // becouse UserManager is seald class is can't be ineretence so method private and not protected virtual
        private void onAppLeave()
        {
            if (AppLeave != null)
            {
                AppLeave.Invoke();
            }
        }
    }
}