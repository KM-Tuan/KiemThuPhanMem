using System;
using BaiTapLon_45_Tuan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDeleteProduct_45_Tuan
{
    [TestClass]
    public class UnitTestDeleteProduct_45_Tuan
    {
        private static Product_45_Tuan prod_45_Tuan;

        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void setUpAddProduct_45_Tuan(TestContext context) //Thêm SP để chuẩn bị cho test xóa SP
        {
            prod_45_Tuan = new Product_45_Tuan("NU-01", "Pepsi", 10000, 20);
            prod_45_Tuan.checkAddProduct_45_Tuan();
            prod_45_Tuan = new Product_45_Tuan("NU-02", "Coca", 10000, 20);
            prod_45_Tuan.checkAddProduct_45_Tuan();
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\DataDeleteProduct_45_Tuan\TestDataDeleteProduct_45_Tuan_Successful.csv", "TestDataDeleteProduct_45_Tuan_Successful#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        //TC1: Test data xóa SP thành công; 1 cột và 2 hàng; 2 PASS
        public void TC1_45_Tuan_TestDataDeleteProduct_Successful()
        {
            string maSp_45_Tuan = TestContext.DataRow[0].ToString();//Lấy cột maSP

            Assert.IsTrue(prod_45_Tuan.deleteProduct_45_Tuan(maSp_45_Tuan)); //Nếu trả ra True thì xóa SP thành công; PASS
        }


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\DataDeleteProduct_45_Tuan\TestDataDeleteProduct_45_Tuan_Unsuccessful.csv", "TestDataDeleteProduct_45_Tuan_Unsuccessful#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        //TC2: Test data xóa SP thất bại; 1 cột và 2 hàng; 2 PASS
        public void TC2_45_Tuan_TestDataDeleteProduct_Unsuccessful()
        {
            string maSp_45_Tuan = TestContext.DataRow[0].ToString();//Lấy cột maSP

            Assert.IsFalse(prod_45_Tuan.deleteProduct_45_Tuan(maSp_45_Tuan)); //Nếu trả ra False thì xóa SP thất bại; PASS
        }
    }
}
