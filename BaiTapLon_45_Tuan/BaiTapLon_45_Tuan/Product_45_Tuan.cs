using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_45_Tuan
{
    public class Product_45_Tuan
    {
        private string maSP_45_Tuan;
        private string tenSP_45_Tuan;
        private double giaSP_45_Tuan;
        private int soLuong_45_Tuan;
        private static List<Product_45_Tuan> listProd_45_Tuan = new List<Product_45_Tuan>();

        public Product_45_Tuan(string maSP_45_Tuan, string tenSP_45_Tuan, double giaSP_45_Tuan, int soLuong_45_Tuan)
        {
            this.maSP_45_Tuan = maSP_45_Tuan;
            this.tenSP_45_Tuan = tenSP_45_Tuan;
            this.giaSP_45_Tuan = giaSP_45_Tuan;
            this.soLuong_45_Tuan = soLuong_45_Tuan;
        }

        public bool checkAddProduct_45_Tuan()
        {
            string pattern_45_Tuan = @"^[A-Z]{2}-\d{2}$";
            if (!Regex.IsMatch(this.maSP_45_Tuan, pattern_45_Tuan))
            {
                MessageBox.Show("Mã SP không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (this.tenSP_45_Tuan.Equals(""))
            {
                MessageBox.Show("Tên SP không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (this.giaSP_45_Tuan <= 0 || this.soLuong_45_Tuan < 0)
            {
                MessageBox.Show("Giá SP hoặc Số lượng không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                foreach (var prod_45_Tuan in listProd_45_Tuan)
                {
                    if (prod_45_Tuan.maSP_45_Tuan.Equals(this.maSP_45_Tuan))
                    {
                        MessageBox.Show("SP đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }

                MessageBox.Show("Thêm SP thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listProd_45_Tuan.Add(new Product_45_Tuan(this.maSP_45_Tuan, this.tenSP_45_Tuan, this.giaSP_45_Tuan, this.soLuong_45_Tuan));
                return true;
            }
        }

        public bool deleteProduct_45_Tuan(string idx_45_Tuan)
        {

            if (!listProd_45_Tuan.Any(p_45_Tuan => p_45_Tuan.maSP_45_Tuan == idx_45_Tuan))
            {
                MessageBox.Show("Sản phẩm không tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            int beforeSP_45_Tuan = listProd_45_Tuan.Count; // Số lượng sản phẩm trước khi xóa
            listProd_45_Tuan.RemoveAll(p_45_Tuan => p_45_Tuan.maSP_45_Tuan == idx_45_Tuan);
            int afterCount_45_Tuan = listProd_45_Tuan.Count; // Số lượng sau khi xóa

            if (beforeSP_45_Tuan > afterCount_45_Tuan)
            {
                MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Xóa SP thất bại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
