using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppPart3
{
    public partial class CustomerApp : Form
    {
        public CustomerApp()
        {
            InitializeComponent();
        }

        #region Private methods
        private void addCustomerBtn_Click(object sender, System.EventArgs e)
        {
            Customer newCustomer = new Customer()
            {
                Id = Guid.NewGuid(),
                Name = nameTxtBx.Text,
                Surname = surnameTxtBx.Text,
                FatherName = fatherNameTxtBx.Text,
                Email = emailTxtBx.Text,
                PhoneNumber = phoneNumberTxtBx.Text
            };

            int result = AddNewCustomer(newCustomer);

            if(result > 0)
            {
                DialogResult answer = MessageBox.Show(
                                                        "Yeni müştəri əlavə olundu! Başqa müştəri əlavə etmək istəyirsiniz?",
                                                        "Məlumat",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);

                if(answer == DialogResult.Yes)
                {
                    winNotification = new NotifyIcon();
                    winNotification.BalloonTipText = "Toplam müştəri sayı: " + VirtualDatabase.Customers.Count.ToString();
                    winNotification.BalloonTipTitle = "Müştəri ədəd məlumatı";
                    winNotification.Visible = true;
                    winNotification.ShowBalloonTip(4000);

                    winNotification.Icon = SystemIcons.Information;
                }
                else
                {
                    FillCustomersList();
                    addCustomerBtn.Enabled = false;
                }
                ClearInputs();
            }
        }
        
        private int AddNewCustomer(Customer customer)
        {
            VirtualDatabase.Customers.Add(customer);
            return 1;
        }

        private void ClearInputs()
        {
            nameTxtBx.Text = string.Empty;
            surnameTxtBx.Text = string.Empty;
            fatherNameTxtBx.Text = string.Empty;
            emailTxtBx.Text = string.Empty;
            phoneNumberTxtBx.Text = string.Empty;
        }

        private void FillCustomersList()
        {
            customerList.DataSource = VirtualDatabase.Customers;
        }
        #endregion
    }
}
