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
    public partial class FormRegister_45_Tuan: Form
    {
        FormLogin_45_Tuan login_45_Tuan = new FormLogin_45_Tuan();
        public FormRegister_45_Tuan()
        {
            InitializeComponent();
        }

        private void btRegister_45_Tuan_Click(object sender, EventArgs e)
        {
            string username_45_Tuan = tbRegisterU_45_Tuan.Text;
            string password_45_Tuan = tbRegisterP_45_Tuan.Text;
            string confirmPass_45_Tuan = tbRegisterCP_45_Tuan.Text;

            if (!password_45_Tuan.Equals(confirmPass_45_Tuan))
            {
                MessageBox.Show("Mật khẩu không trùng khớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRegisterP_45_Tuan.Text = "";
                tbRegisterCP_45_Tuan.Text = "";
            }
            else
            {
                Account_45_Tuan acc_45_Tuan = new Account_45_Tuan(username_45_Tuan, password_45_Tuan);
                if (acc_45_Tuan.checkRegister_45_Tuan())
                    this.Close();
            }    
        }
    }
}
