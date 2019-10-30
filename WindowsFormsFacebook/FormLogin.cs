using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FBLogic;

namespace WindowsFormsFacebook
{
    public partial class FormLogin : Form
    {
        private readonly UserManager r_UserLogedIn;
        private AppSetting m_AppSetting;

        public FormLogin()
        {
            InitializeComponent();
            r_UserLogedIn = UserManager.Instance;
            r_UserLogedIn.AppLeave += resetUserAndPage;
        }

        private void resetUserAndPage()
        {
            MessageBox.Show(string.Format("Bye Bye {0}", r_UserLogedIn.Name));
            Text = "Welcome To FaceApp";
            checkBoxRememberMe.Checked = false;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            m_AppSetting = AppSetting.LoadFromFile();
            checkBoxRememberMe.Checked = m_AppSetting.RememberMe;

            if (m_AppSetting.RememberMe && !string.IsNullOrEmpty(m_AppSetting.AccesToken))
            {
                try
                {
                    r_UserLogedIn.Connect(m_AppSetting.AccesToken);
                    Text = r_UserLogedIn.Name;
                    startMainForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            m_AppSetting.RememberMe = checkBoxRememberMe.Checked;

            try
            {
                if (m_AppSetting.RememberMe)
                {
                    m_AppSetting.AccesToken = r_UserLogedIn.AccesToken;
                }
                else
                {
                    m_AppSetting.AccesToken = string.Empty;
                }

                r_UserLogedIn.Logout();
                m_AppSetting.SaveToFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                r_UserLogedIn.Login();
                Text = r_UserLogedIn.Name;
                startMainForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void startMainForm()
        {
            SwitcherForms.SwitchForms(this, new FormMain());
        }
    }
}