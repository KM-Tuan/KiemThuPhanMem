using System;
using BaiTapLon_45_Tuan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLogin_45_Tuan
{
	[TestClass]
	public class UnitTestLogin_45_Tuan
	{
        private static Account_45_Tuan acc_45_Tuan;

        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void setUpRegister_45_Tuan(TestContext context) //Đăng ký tài khoản đề chuẩn bị cho test đăng nhập
        {
            acc_45_Tuan = new Account_45_Tuan("Kieu@123", "Testpass@123");
            acc_45_Tuan.checkRegister_45_Tuan();
            acc_45_Tuan = new Account_45_Tuan("Minh@123", "Testpass@123");
            acc_45_Tuan.checkRegister_45_Tuan();
            acc_45_Tuan = new Account_45_Tuan("Tuan@123", "Testpass@123");
            acc_45_Tuan.checkRegister_45_Tuan();
        }


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\DataLogin_45_Tuan\TestDataLogin_45_Tuan_Successful.csv", "TestDataLogin_45_Tuan_Successful#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        //TC1: Test data đăng nhập thành công; 2 cột và 3 hàng; 3 PASS
        public void TC1_45_Tuan_TestDataLogin_Successful()
		{
            string username_45_Tuan = TestContext.DataRow[0].ToString(); //Lấy username_45_Tuan
            string password_45_Tuan = TestContext.DataRow[1].ToString(); //Lấy password_45_Tuan
            acc_45_Tuan = new Account_45_Tuan(username_45_Tuan, password_45_Tuan); //Tạo đối tượng

            bool login_45_Tuan = acc_45_Tuan.checkLogin_45_Tuan();
            Assert.IsTrue(login_45_Tuan); //Nếu trả ra True thì đăng nhập thành công; PASS
        }


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\DataLogin_45_Tuan\TestDataLogin_45_Tuan_Unsuccessful.csv", "TestDataLogin_45_Tuan_Unsuccessful#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        //TC2: Test data đăng nhập không thành công; 2 cột và 1 hàng; 1 PASS
        public void TC2_45_Tuan_TestDataLogin_Unsuccessful()
        {
            string username_45_Tuan = TestContext.DataRow[0].ToString(); //Lấy username_45_Tuan
            string password_45_Tuan = TestContext.DataRow[1].ToString(); //Lấy password_45_Tuan
            acc_45_Tuan = new Account_45_Tuan(username_45_Tuan, password_45_Tuan); //Tạo đối tượng

            bool login_45_Tuan = acc_45_Tuan.checkLogin_45_Tuan();
            Assert.IsFalse(login_45_Tuan); //Nếu trả ra False thì đăng nhập thất bại; PASS
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\DataLogin_45_Tuan\TestDataLogin_45_Tuan_ErrorPassword.csv", "TestDataLogin_45_Tuan_ErrorPassword#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        //TC3: Test data đăng nhập sai mật khẩu; 2 cột và 1 hàng; 1 PASS
        public void TC3_45_Tuan_TestDataLogin_ErrorPassword()
        {
            string username_45_Tuan = TestContext.DataRow[0].ToString(); //Lấy username_45_Tuan
            string password_45_Tuan = TestContext.DataRow[1].ToString(); //Lấy password_45_Tuan
            acc_45_Tuan = new Account_45_Tuan(username_45_Tuan, password_45_Tuan); //Tạo đối tượng

            bool login_45_Tuan = acc_45_Tuan.checkLogin_45_Tuan();
            Assert.IsFalse(login_45_Tuan); //Nếu trả ra False thì đăng nhập sai mật khẩu; PASS
        }
    }
}
