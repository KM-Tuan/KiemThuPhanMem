using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_45_Tuan
{
    public partial class FormLogin_45_Tuan : Form
    {
        public FormLogin_45_Tuan()
        {
            InitializeComponent();
        }

        private void btLogin_45_Tuan_Click(object sender, EventArgs e)
        {
            string username_45_Tuan = tbUsername_45_Tuan.Text;
            string password_45_Tuan = tbPassword_45_Tuan.Text;
            Account_45_Tuan acc_45_Tuan = new Account_45_Tuan(username_45_Tuan, password_45_Tuan);

            if (acc_45_Tuan.checkLogin_45_Tuan())
            {
                tbUsername_45_Tuan.Text = "";
                tbPassword_45_Tuan.Text = "";
                FormMain_45_Tuan main_45_Tuan = new FormMain_45_Tuan();
                main_45_Tuan.Show();
                this.Hide();
                main_45_Tuan.FormClosed += (s, args) => this.Close();
            }
            else
            {
                tbUsername_45_Tuan.Text = "";
                tbPassword_45_Tuan.Text = "";
            }
        }

        private void btRegister_45_Tuan_Click(object sender, EventArgs e)
        {
            FormRegister_45_Tuan register_45_Tuan = new FormRegister_45_Tuan();
            register_45_Tuan.Show();
            this.Hide();
            register_45_Tuan.FormClosed += (s, args) => this.Show();
        }
    }
}
