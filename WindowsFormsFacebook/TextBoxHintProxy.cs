using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsFacebook
{
    public class TextBoxHintProxy : TextBox
    {
        private string m_HintText = string.Empty;

        protected override void OnCreateControl()
        {
            m_HintText = Text;
            base.OnCreateControl();
        }

        protected override void OnLeave(EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Text))
            {
                Text = m_HintText;
            }

            base.OnLeave(e);
        }

        protected override void OnClick(EventArgs e)
        {
            Text = string.Empty;
            base.OnClick(e);
        }

        public override void Refresh()
        {
            Text = m_HintText;
            base.Refresh();
        }
    }
}