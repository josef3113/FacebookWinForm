using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsFacebook
{
    public static class SwitcherForms
    {
        public static void SwitchForms(Form i_From, Form i_To)
        {
            i_To.Location = i_From.Location;
            i_To.StartPosition = FormStartPosition.Manual;
            i_To.FormClosing += delegate { BackForm(i_From, i_To); };
            //i_To.Width = i_From.Width;
            //i_To.Height = i_From.Height;
            i_From.Hide();
            i_To.Show();
        }

        private static void BackForm(Form i_Original, Form i_FormBack)
        {
            i_Original.Location = i_FormBack.Location;
            i_Original.Show();
        }
    }
}
