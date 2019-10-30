using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using System.Xml;
using FacebookWrapper.ObjectModel;
using FBLogic;

namespace WindowsFormsFacebook
{
    public partial class FormPostAnalyst : Form
    {
        private readonly UserManager r_UserLogedIn;
        private readonly PostTextManager r_PostsMamager;

        public FormPostAnalyst()
        {
            InitializeComponent();
            r_UserLogedIn = UserManager.Instance;
            r_UserLogedIn.AppLeave += () => Close();
            r_PostsMamager = new PostTextManager();
            initializeControls();
        }

        private void initializeControls()
        {
            Text = r_UserLogedIn.Name;
            foreach (Control control in Controls)
            {
                if (control.Name != "buttonExitApp")
                {
                    control.BackColor = Color.CornflowerBlue;
                }
            }

            chartAnalysisPostBySubjects.Titles.Add("Posts Statistics");

            radioButtonByCreatTime.CheckedChanged += radioButtons_Changed;
            radioButtonByNumOfLikes.CheckedChanged += radioButtons_Changed;
        }

        private void radioButtons_Changed(object sender, EventArgs e)
        {
            new Thread(startSortPost).Start();
        }

        private void startSortPost()
        {
            try
            {
                if (radioButtonByCreatTime.Checked)
                {
                    r_PostsMamager.SortPostsByCreatTime();
                }
                else if (radioButtonByNumOfLikes.Checked)
                {
                    r_PostsMamager.SortPostsByNumOfLikes();
                }

                startFetchPosts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPostWithWord_Click(object sender, EventArgs e)
        {
            startPostWithWord();
        }

        private void startPostWithWord()
        {
            if (string.IsNullOrEmpty(textBoxWords.Text))
            {
                MessageBox.Show("Word/Words are first requiered");
            }
            else
            {
                dataGridViewPostWithWord.ClearSelection();
                string inputUser = textBoxWords.Text;

                try
                {
                    r_PostsMamager.PostsContainWords(inputUser);
                    dataGridViewPostWithWord.DataSource = r_PostsMamager.DataTablePosts;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                textBoxWords.Clear();
            }
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            startFetchPosts();
        }

        private void startFetchPosts()
        {
            listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Clear()));
            listBoxPosts.DisplayMember = "Message";

            bool wasPost = false;
            int minLenghtPostToShow = 0;

            try
            {
                minLenghtPostToShow = int.Parse(textBoxLenghtMinPost.Text);
                r_PostsMamager.FilterToIterator = post => post.Message.Length >= minLenghtPostToShow;

                foreach (Post post in r_PostsMamager)
                {
                    wasPost = true;
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post)));
                }

                if (!wasPost)
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
            if (listBoxPosts.SelectedItems.Count == 1)
            {
                try
                {
                    Post selected = listBoxPosts.SelectedItem as Post;
                    MessageBox.Show(selected.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonAnalysisPost_Click(object sender, EventArgs e)
        {
            startStatistics();
        }

        private void startStatistics()
        {
            foreach (var series in chartAnalysisPostBySubjects.Series)
            {
                series.Points.Clear();
            }

            try
            {
                chartAnalysisPostBySubjects.Series["statistics"].Points.AddXY(
                r_PostsMamager.Analyst.SubjectsForStatictics[0],
                r_PostsMamager.Analyst.SciencePercentage);

                chartAnalysisPostBySubjects.Series["statistics"].Points.AddXY(
                r_PostsMamager.Analyst.SubjectsForStatictics[1],
                r_PostsMamager.Analyst.PoliticsPercentage);

                chartAnalysisPostBySubjects.Series["statistics"].Points.AddXY(
                r_PostsMamager.Analyst.SubjectsForStatictics[2],
                r_PostsMamager.Analyst.OtherPercentage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExitApp_Click(object sender, EventArgs e)
        {
            r_UserLogedIn.LeaveApp();
        }
    }
}