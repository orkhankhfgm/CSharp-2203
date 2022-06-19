using System.Windows.Forms;

namespace WindowsFormFirstLesson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, System.EventArgs e)
        {
            TestFormWindow testFormWindow = new TestFormWindow();
            testFormWindow.Show();
        }
    }
}
