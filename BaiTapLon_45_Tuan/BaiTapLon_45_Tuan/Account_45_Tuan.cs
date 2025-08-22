using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BaiTapLon_45_Tuan
{
    public class Account_45_Tuan
    {
        private string username_45_Tuan;
        private string password_45_Tuan;
        private static List<Account_45_Tuan> listAcc_45_Tuan = new List<Account_45_Tuan>();

        public Account_45_Tuan(string username_45_Tuan, string password_45_Tuan)
        {
            this.username_45_Tuan = username_45_Tuan;
            this.password_45_Tuan = password_45_Tuan;
        }

        public bool checkLogin_45_Tuan()
        {
            bool userExists_45_Tuan = false;

            foreach (var acc_45_Tuan in listAcc_45_Tuan)
            {
                if (acc_45_Tuan.username_45_Tuan.Equals(this.username_45_Tuan))
                {
                    userExists_45_Tuan = true;
                    if (acc_45_Tuan.password_45_Tuan.Equals(this.password_45_Tuan))
                    {
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
            }

            if (userExists_45_Tuan)
            {
                MessageBox.Show("Sai mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Username không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return false;
        }

        public bool checkRegister_45_Tuan()
        {
            if (this.username_45_Tuan.Length < 7 || this.password_45_Tuan.Length < 7)
            {
                MessageBox.Show("Độ dài không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            string pattern_45_Tuan = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]+$";
            if (!Regex.IsMatch(this.username_45_Tuan, pattern_45_Tuan) || !Regex.IsMatch(this.password_45_Tuan, pattern_45_Tuan))
            {
                MessageBox.Show("Username và Password phải bao gồm chữ thường, chữ hoa, số và ký tự đặc biệt!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                foreach (var acc_45_Tuan in listAcc_45_Tuan)
                {
                    if (acc_45_Tuan.username_45_Tuan.Equals(this.username_45_Tuan))
                    {
                        MessageBox.Show("Username đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                listAcc_45_Tuan.Add(new Account_45_Tuan(this.username_45_Tuan, this.password_45_Tuan));
                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }
    }
}
