using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_ThiTracNghiem
{
    public partial class Form_Result : Form
    {
        public Form_Result()
        {
            InitializeComponent();
        }

        private void Form_Result_Load(object sender, EventArgs e)
        {
            int soCauHoi = Form_Question.soCauHoi;
            int soCauDung = Form_Question.soCauDung;
            double diem = soCauDung*(10 / (double) soCauHoi);

            lbTenThiSinh.Text += Form_Question.tenThiSinh;
            lbTrueAnswer.Text += soCauDung.ToString();
            lbFalseAnswer.Text += (soCauHoi - soCauDung).ToString();
            lbScores.Text += String.Format("{0:N2}", diem);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Result_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}