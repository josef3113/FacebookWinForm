using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FBLogic;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace WindowsFormsFacebook
{
    public partial class FormMain : Form
    {
        private readonly UserManager r_UserLogedIn;

        public FormMain()
        {
            InitializeComponent();
            r_UserLogedIn = UserManager.Instance;
            r_UserLogedIn.AppLeave += () => Close();
            initializeAllControls();
            fetchAndShowUserData();
        }

        private void initializeAllControls()
        {
            foreach (Control control in Controls)
            {
                if (control.Name != "buttonExitApp")
                {
                    control.BackColor = Color.CornflowerBlue;
                }

                control.Enabled = true;
            }
        }

        private void fetchAndShowUserData()
        {
            pictureBoxPropilePhoto.LoadAsync(r_UserLogedIn.User.PictureLargeURL);
            pictureBoxPropilePhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            Text = r_UserLogedIn.Name;
        }

        private void linkFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchFriends();
        }

        private void fetchFriends()
        {
            friendBindingSource.DataSource = r_UserLogedIn.User.Friends;
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriend();
        }

        private void displaySelectedFriend()
        {
            try
            {
                if (listBoxFriends.SelectedItems.Count == 1)
                {
                    User selectedFriend = listBoxFriends.SelectedItem as User;
                    if (selectedFriend.PictureNormalURL != null)
                    {
                        pictureBoxFriendPhoto.LoadAsync(selectedFriend.PictureLargeURL);
                        pictureBoxFriendPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        pictureBoxFriendPhoto.Image = pictureBoxFriendPhoto.ErrorImage;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            postStatus();
        }

        private void postStatus()
        {
            try
            {
                Status postedStatus = r_UserLogedIn.User.PostStatus(textBoxHintProxyPost.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
                textBoxHintProxyPost.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPosts();
        }

        private void fetchPosts()
        {
            try
            {
                foreach (Post post in r_UserLogedIn.User.Posts)
                {
                    if (post.Message != null)
                    {
                        listBoxPosts.Items.Add(post.Message);
                    }
                    else if (post.Caption != null)
                    {
                        listBoxPosts.Items.Add(post.Caption);
                    }
                    else
                    {
                        listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                    }
                }

                if (r_UserLogedIn.User.Posts.Count == 0)
                {
                    MessageBox.Show("No Posts to retrieve :(");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Post selected = r_UserLogedIn.User.Posts[listBoxPosts.SelectedIndex];
                listBoxPostComments.DisplayMember = "Message";
                listBoxPostComments.DataSource = selected.Comments;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchEvents();
        }

        private void fetchEvents()
        {
            eventBindingSource.DataSource = r_UserLogedIn.User.Events;
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedItems.Count == 1)
            {
                Event selectedEvent = listBoxEvents.SelectedItem as Event;
                if (selectedEvent.PictureNormalURL != null)
                {
                    pictureBoxEvent.LoadAsync(selectedEvent.PictureNormalURL);
                }
            }
        }

        private void buttonSelectedPhotosByDateCreat_Click(object sender, EventArgs e)
        {
            SwitcherForms.SwitchForms(this, new FormSelectPhotos());
        }

        private void buttonAnalystPost_Click(object sender, EventArgs e)
        {
            SwitcherForms.SwitchForms(this, new FormPostAnalyst());
        }

        private void buttonExitApp_Click(object sender, EventArgs e)
        {
            r_UserLogedIn.LeaveApp();
        }
    }
}