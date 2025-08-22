using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaiTapLon_45_Tuan
{
    public partial class FormMain_45_Tuan: Form
    {
        Product_45_Tuan prod_45_Tuan;
        public FormMain_45_Tuan()
        {
            InitializeComponent();
        }

        private void btThem_45_Tuan_Click(object sender, EventArgs e)
        {
            string maSP_45_Tuan = tbMaSP_45_Tuan.Text;
            string tenSP_45_Tuan = tbTenSP_45_Tuan.Text;
            double giaSP_45_Tuan = double.Parse(tbGiaSP_45_Tuan.Text);
            int soLuong_45_Tuan = int.Parse(tbSoLuong_45_Tuan.Text);
            prod_45_Tuan = new Product_45_Tuan(maSP_45_Tuan, tenSP_45_Tuan, giaSP_45_Tuan, soLuong_45_Tuan);

            if (prod_45_Tuan.checkAddProduct_45_Tuan())
            {
                tbMaSP_45_Tuan.Text = "";
                tbTenSP_45_Tuan.Text = "";
                tbGiaSP_45_Tuan.Text = "";
                tbSoLuong_45_Tuan.Text = "";

                ListViewItem item_45_Tuan = new ListViewItem(maSP_45_Tuan);
                item_45_Tuan.SubItems.Add(tenSP_45_Tuan);
                item_45_Tuan.SubItems.Add(giaSP_45_Tuan.ToString());
                item_45_Tuan.SubItems.Add(soLuong_45_Tuan.ToString());

                lvResult_45_Tuan.Items.Add(item_45_Tuan);
            }
        }

        private void btXoa_45_Tuan_Click(object sender, EventArgs e)
        {
            if (lvResult_45_Tuan.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvResult_45_Tuan.SelectedItems)
                {
                    string idx_45_Tuan = item.SubItems[0].Text;
                    prod_45_Tuan.deleteProduct_45_Tuan(idx_45_Tuan);
                    lvResult_45_Tuan.Items.Remove(item);
                }
                MessageBox.Show("Xóa SP thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateListView_45_Tuan(string maSP, string tenMoi, double giaMoi, int soLuongMoi)
        {
            foreach (ListViewItem item in lvResult_45_Tuan.Items)
            {
                if (item.SubItems[0].Text == maSP)
                {
                    item.SubItems[1].Text = tenMoi;
                    item.SubItems[2].Text = giaMoi.ToString();
                    item.SubItems[3].Text = soLuongMoi.ToString();
                    break;
                }
            }
        }
    }
}
