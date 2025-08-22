using System;
using BaiTapLon_45_Tuan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAddProduct_45_Tuan
{
	[TestClass]
	public class UnitTestAddProduct_45_Tuan
	{
        private Product_45_Tuan prod_45_Tuan;

        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\DataAddProduct_45_Tuan\TestDataAddProduct_45_Tuan_Successful.csv", "TestDataAddProduct_45_Tuan_Successful#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        //TC1: Test data thêm SP thành công; 4 cột và 4 hàng; 4 PASS
        public void TC1_45_Tuan_TestDataAddProduct_Successful()
        {
            string maSp_45_Tuan = TestContext.DataRow[0].ToString(); //Lấy cột maSP
            string tenSP_45_Tuan = TestContext.DataRow[1].ToString(); //Lấy cột tenSP
            double giaSP_45_Tuan = double.Parse(TestContext.DataRow[2].ToString()); //Lấy cột giaSP
            int soLuong_45_Tuan = int.Parse(TestContext.DataRow[3].ToString()); //Lấy cột soLuong
            prod_45_Tuan = new Product_45_Tuan(maSp_45_Tuan, tenSP_45_Tuan, giaSP_45_Tuan, soLuong_45_Tuan);
            
            bool register_45_Tuan = prod_45_Tuan.checkAddProduct_45_Tuan();
            Assert.IsTrue(register_45_Tuan); //Nếu trả ra True thì thêm SP thành công; PASS
        }


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\DataAddProduct_45_Tuan\TestDataAddProduct_45_Tuan_ErrorMaSP.csv", "TestDataAddProduct_45_Tuan_ErrorMaSP#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        //TC2: Test data thêm SP thất bại vì maSP không hợp lệ; 4 cột và 1 hàng; 1 PASS
        public void TC2_45_Tuan_TestDataAddProduct_ErrorMaSP()
        {
            string maSp_45_Tuan = TestContext.DataRow[0].ToString(); //Lấy cột maSP
            string tenSP_45_Tuan = TestContext.DataRow[1].ToString(); //Lấy cột tenSP
            double giaSP_45_Tuan = double.Parse(TestContext.DataRow[2].ToString()); //Lấy cột giaSP
            int soLuong_45_Tuan = int.Parse(TestContext.DataRow[3].ToString()); //Lấy cột soLuong
            prod_45_Tuan = new Product_45_Tuan(maSp_45_Tuan, tenSP_45_Tuan, giaSP_45_Tuan, soLuong_45_Tuan);

            bool register_45_Tuan = prod_45_Tuan.checkAddProduct_45_Tuan();
            Assert.IsFalse(register_45_Tuan); //Nếu trả ra False thì thêm SP thất bại; PASS
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\DataAddProduct_45_Tuan\TestDataAddProduct_45_Tuan_ErrorQuantity.csv", "TestDataAddProduct_45_Tuan_ErrorQuantity#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        //TC3: Test data thêm SP thất bại vì đơn giá và số lượng không hợp lệ; 4 cột và 2 hàng; 2 PASS
        public void TC3_45_Tuan_TestDataAddProduct_ErrorQuantity()
        {
            string maSp_45_Tuan = TestContext.DataRow[0].ToString(); //Lấy cột maSP
            string tenSP_45_Tuan = TestContext.DataRow[1].ToString(); //Lấy cột tenSP
            double giaSP_45_Tuan = double.Parse(TestContext.DataRow[2].ToString()); //Lấy cột giaSP
            int soLuong_45_Tuan = int.Parse(TestContext.DataRow[3].ToString()); //Lấy cột soLuong
            prod_45_Tuan = new Product_45_Tuan(maSp_45_Tuan, tenSP_45_Tuan, giaSP_45_Tuan, soLuong_45_Tuan);

            bool register_45_Tuan = prod_45_Tuan.checkAddProduct_45_Tuan();
            Assert.IsFalse(register_45_Tuan); //Nếu trả ra False thì thêm SP thất bại; PASS
        }
    }
}
