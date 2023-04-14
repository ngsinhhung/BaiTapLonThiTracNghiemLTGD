using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BaiTapLon_ThiTracNghiem
{
    public partial class Form_Welcome : Form
    {
        private static int time;
        public string pathIcon;
        public static bool flagExit = true;
        public Form_Welcome()
        {
            InitializeComponent();
        }
        private void BtnVaoThi_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Form_Question.tenThiSinh = txtName.Text;
                Form_Question.thoiGianThi = int.Parse(txtTime.Text);
                flagExit = false;
                this.Close();
            }
        }
        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                errorProviderName.SetError(txtName, "Vui lòng nhập tên");
            }
            else
            {
                e.Cancel = false;
                errorProviderName.SetError(txtName, null);
            }
        }

        private void txtTime_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtTime.Text) || !int.TryParse(txtTime.Text.Trim(), out time))
            {
                e.Cancel = true;
                txtTime.Focus();
                errorProviderTime.SetError(txtTime, "Vui lòng nhập số");
            }
            else
            {
                e.Cancel = false;
                errorProviderTime.SetError(txtTime, null);
            }
        }
        private void Form_Welcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(flagExit == true)
            {
                Application.Exit();
            }
        }
    }
}
