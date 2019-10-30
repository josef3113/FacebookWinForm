using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FBLogic;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace WindowsFormsFacebook
{
    public partial class FormSelectPhotos : Form
    {
        private readonly UserManager r_UserLogedIn;
        private readonly PhotoManager r_PhotoManger;

        public FormSelectPhotos()
        {
            InitializeComponent();

            r_UserLogedIn = UserManager.Instance;
            r_UserLogedIn.AppLeave += () => Close();
            r_PhotoManger = new PhotoManager();
            Text = r_UserLogedIn.Name;

            initializeControls();
        }

        private void initializeControls()
        {
            foreach (Control control in Controls)
            {
                if (control.Name != "buttonExitApp")
                {
                    control.BackColor = Color.CornflowerBlue;
                }
            }

            radioButtonByTimeCreated.CheckedChanged += radioButtons_Changed;
            radioButtonByNumOfLikes.CheckedChanged += radioButtons_Changed;
        }

        private void radioButtons_Changed(object sender, EventArgs e)
        {
            new Thread(startSortPhoto).Start();
        }

        private void startSortPhoto()
        {
            try
            {
                if (radioButtonByTimeCreated.Checked)
                {
                    r_PhotoManger.SortPhotosSelectedByDateCreat();
                }
                else if (radioButtonByNumOfLikes.Checked)
                {
                    r_PhotoManger.SortPhotosSelectedByNumOfLikes();
                }

                startShowPhotosThatSelected();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonGetPhotos_Click(object sender, EventArgs e)
        {
            new Thread(getPhotosThatSelected).Start();
        }

        private void getPhotosThatSelected()
        {
            try
            {
                r_PhotoManger.SetTimeSelected(dateTimePickerStart.Value, dateTimePickerEnd.Value);
                startShowPhotosThatSelected();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void startShowPhotosThatSelected()
        {
            showPhoto(r_PhotoManger.CurrentPhoto);
        }

        private void showPhoto(Photo i_Photo)
        {
            try
            {
                pictureBoxPhotosSelected.Image = i_Photo.ImageNormal;
                pictureBoxPhotosSelected.SizeMode = PictureBoxSizeMode.StretchImage;

                labelTimeCreatedPhoto.Invoke(
                    new Action(() =>
                    labelTimeCreatedPhoto.Text = i_Photo.CreatedTime.Value.ToShortDateString()));

                labelNumOfLikes.Invoke(
                    new Action(() =>
                    labelNumOfLikes.Text = i_Photo.LikedBy.Count.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            showPhoto(r_PhotoManger.NextPhoto);
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            showPhoto(r_PhotoManger.PrevPhoto);
        }

        private void buttonDowloadImags_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(downloadImags);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void downloadImags()
        {
            try
            {
                setFormatDownload();

                SaveFileDialog saveDialog = new SaveFileDialog()
                {
                    FileName = "We Love Facebook"
                };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    r_PhotoManger.DownloadPhotosSelected(saveDialog.FileName);
                    MessageBox.Show("Imags Downloaded");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setFormatDownload()
        {
            if (radioButtonNameByDateCreate.Checked)
            {
                r_PhotoManger.SetNamePhotosDownload(eNameToPhoto.ByDateCreat);
            }
            else if (radioButtonNameByID.Checked)
            {
                r_PhotoManger.SetNamePhotosDownload(eNameToPhoto.ByID);
            }
        }

        private void buttonExitApp_Click(object sender, EventArgs e)
        {
            r_UserLogedIn.LeaveApp();
        }
    }
}