using System;
using BaiTapLon_45_Tuan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestRegister_45_Tuan
{
    [TestClass]
    public class UnitTestRegister_45_Tuan
    {
        private Account_45_Tuan acc_45_Tuan;

        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\DataRegister_45_Tuan\TestDataRegister_45_Tuan_Successful.csv", "TestDataRegister_45_Tuan_Successful#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        //TC1: Test data đăng ký thành công; 2 cột và 3 hàng; 3 PASS
        public void TC1_45_Tuan_TestDataRegister_Successful()
        {
            string username_45_Tuan = TestContext.DataRow[0].ToString(); //Lấy username_45_Tuan
            string password_45_Tuan = TestContext.DataRow[1].ToString(); //Lấy password_45_Tuan
            acc_45_Tuan = new Account_45_Tuan(username_45_Tuan, password_45_Tuan); //Tạo đối tượng

            bool register_45_Tuan = acc_45_Tuan.checkRegister_45_Tuan();
            Assert.IsTrue(register_45_Tuan); //Nếu trả ra True thì đăng ký thành công; PASS
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\DataRegister_45_Tuan\TestDataRegister_45_Tuan_UsernameExist.csv", "TestDataRegister_45_Tuan_UsernameExist#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        //TC2: Test data đăng ký username đã tồn tại; 2 cột và 1 hàng; 1 PASS
        public void TC2_45_Tuan_TestDataRegister_UsernameExist()
        {
            string username_45_Tuan = TestContext.DataRow[0].ToString(); //Lấy username_45_Tuan
            string password_45_Tuan = TestContext.DataRow[1].ToString(); //Lấy password_45_Tuan
            acc_45_Tuan = new Account_45_Tuan(username_45_Tuan, password_45_Tuan); //Tạo đối tượng

            bool register_45_Tuan = acc_45_Tuan.checkRegister_45_Tuan();
            Assert.IsFalse(register_45_Tuan); //Nếu trả ra False thì đăng ký thất bại; PASS
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\DataRegister_45_Tuan\TestDataRegister_45_Tuan_Unsuccessful.csv", "TestDataRegister_45_Tuan_Unsuccessful#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        //TC3: Test data đăng ký username và password không hợp lệ; 2 cột và 1 hàng; 1 PASS
        public void TC3_45_Tuan_TestDataRegister_Unsuccessful()
        {
            string username_45_Tuan = TestContext.DataRow[0].ToString(); //Lấy username_45_Tuan
            string password_45_Tuan = TestContext.DataRow[1].ToString(); //Lấy password_45_Tuan
            acc_45_Tuan = new Account_45_Tuan(username_45_Tuan, password_45_Tuan); //Tạo đối tượng

            bool register_45_Tuan = acc_45_Tuan.checkRegister_45_Tuan();
            Assert.IsFalse(register_45_Tuan); //Nếu trả ra Fail thì đăng ký thất bại; PASS
        }

    }
}
