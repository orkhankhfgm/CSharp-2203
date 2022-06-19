using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormFirstLesson
{
    public partial class SendMessage : Form
    {
        public SendMessage()
        {
            InitializeComponent();
        }

        private void sendMessageBtn_Click(object sender, EventArgs e)
        {
            string textMsgValue = txtMessage.Text;
            ShowMessage showMessageForm = new ShowMessage(textMsgValue);
            showMessageForm.Show();
        }

        private void ResetInputEvent(object sender, EventArgs e)
        {
            txtMessage.Text = "";
        }
    }
}
