using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriver_45_Tuan
{
    public partial class Form1_45_Tuan: Form
    {
        IWebDriver driver_45_Tuan;
        public Form1_45_Tuan()
        {
            InitializeComponent();
        }

        // TC1: đăng nhập thành công 
        private void btLogin_45_Tuan_Click(object sender, EventArgs e)
        {
            ChromeDriverService chrome_45_Tuan = ChromeDriverService.CreateDefaultService();
            chrome_45_Tuan.HideCommandPromptWindow = true;
            driver_45_Tuan = new ChromeDriver(chrome_45_Tuan);
            driver_45_Tuan.Navigate().GoToUrl("https://demo.hyva.io/default/customer/account/login/");

            IWebElement username_45_Tuan = driver_45_Tuan.FindElement(By.Name("login[username]")); //Lấy element username
            username_45_Tuan.SendKeys("2251012149tuan@ou.edu.vn");
            IWebElement password_45_Tuan = driver_45_Tuan.FindElement(By.Name("login[password]")); //Lấy element password 
            password_45_Tuan.SendKeys("Admin@123");
            IWebElement login_45_Tuan = driver_45_Tuan.FindElement(By.Name("send")); //Lấy element send
            login_45_Tuan.Click();

        }

        // TC2: Thêm sản phẩm vào giỏ hàng thành công
        private void btOrder_45_Tuan_Click(object sender, EventArgs e)
        {
            IWebElement bags_45_Tuan = driver_45_Tuan.FindElement(By.CssSelector("#header > div.container.flex.flex-wrap.lg\\:flex-nowrap.items-center.justify-between.w-full.px-6.py-3.mx-auto.mt-0 > div.z-20.order-2.sm\\:order-1.lg\\:order-2.navigation.hidden.lg\\:flex > div > nav > ul > li:nth-child(4) > span > a"));
            bags_45_Tuan.Click();
            Thread.Sleep(2000);
            IWebElement addToCart_45_Tuan = driver_45_Tuan.FindElement(By.CssSelector("#product-list > div.products.wrapper.mode-grid.products-grid > ul > li:nth-child(1) > form > div > div.mt-auto.pt-3.flex.flex-wrap.items-center.gap-y-4.gap-x-2 > button"));
            addToCart_45_Tuan.Click(); //Thêm SP 1
            Thread.Sleep(2000);
            IWebElement addToCart2_45_Tuan = driver_45_Tuan.FindElement(By.CssSelector("#product-list > div.products.wrapper.mode-grid.products-grid > ul > li:nth-child(2) > form > div > div.mt-auto.pt-3.flex.flex-wrap.items-center.gap-y-4.gap-x-2 > button"));
            addToCart2_45_Tuan.Click(); //Thêm SP 2
            Thread.Sleep(2000);
            IWebElement addToCart3_45_Tuan = driver_45_Tuan.FindElement(By.CssSelector("#product-list > div.products.wrapper.mode-grid.products-grid > ul > li:nth-child(3) > form > div > div.mt-auto.pt-3.flex.flex-wrap.items-center.gap-y-4.gap-x-2 > button"));
            addToCart3_45_Tuan.Click(); //Thêm SP 3

        }

        // TC3: Chỉnh sửa giỏ hàng
        private void btEdit_45_Tuan_Click(object sender, EventArgs e)
        {
            IWebElement cart_45_Tuan = driver_45_Tuan.FindElement(By.CssSelector("#menu-cart-icon"));
            cart_45_Tuan.Click();
            Thread.Sleep(1000);
            IWebElement editDetail_45_Tuan = driver_45_Tuan.FindElement(By.CssSelector("#cart-drawer > div > div.relative.w-screen.max-w-md.shadow-2xl > div > div:nth-child(6) > div > div:nth-child(2) > a.underline"));
            editDetail_45_Tuan.Click();

            IWebElement bag_45_Tuan = driver_45_Tuan.FindElement(By.Id("cart-93731-qty"));
            bag_45_Tuan.Clear();
            bag_45_Tuan.SendKeys("2"); //Chỉnh sửa số lượng SP 1
            IWebElement pack_45_Tuan = driver_45_Tuan.FindElement(By.Id("cart-93732-qty"));
            pack_45_Tuan.Clear();
            pack_45_Tuan.SendKeys("3"); //Chỉnh sửa số lượng SP 2
            IWebElement backpack_45_Tuan = driver_45_Tuan.FindElement(By.Id("cart-93733-qty"));
            backpack_45_Tuan.Clear();
            backpack_45_Tuan.SendKeys("4"); //Chỉnh sửa số lượng SP 3
            Thread.Sleep(1000);


            IWebElement checkout_45_Tuan = driver_45_Tuan.FindElement(By.CssSelector("#checkout-link-button"));
            checkout_45_Tuan.Click();

        }

        // TC4: Thanh toán thành công
        private void btPay_45_Tuan_Click(object sender, EventArgs e)
        {
            // Điền thông tin thanh toán
            IWebElement firstname_45_Tuan = driver_45_Tuan.FindElement(By.Name("firstname"));
            firstname_45_Tuan.Clear();
            firstname_45_Tuan.SendKeys("Kieu");
            IWebElement lastname_45_Tuan = driver_45_Tuan.FindElement(By.Name("lastname"));
            lastname_45_Tuan.Clear();
            lastname_45_Tuan.SendKeys("Tuan");
            IWebElement street_45_Tuan = driver_45_Tuan.FindElement(By.Name("street[0]"));
            street_45_Tuan.Clear();
            street_45_Tuan.SendKeys("146/23B Vo Thi Sau, Quan 3, TP Ho Chi Minh");
            IWebElement code_45_Tuan = driver_45_Tuan.FindElement(By.Name("postcode"));
            code_45_Tuan.Clear();
            code_45_Tuan.SendKeys("002");
            IWebElement city_45_Tuan = driver_45_Tuan.FindElement(By.Name("city"));
            city_45_Tuan.Clear();
            city_45_Tuan.SendKeys("HCM");
            IWebElement phone_45_Tuan = driver_45_Tuan.FindElement(By.Name("telephone"));
            phone_45_Tuan.Clear();
            phone_45_Tuan.SendKeys("0768996667");

            IWebElement order_45_Tuan = driver_45_Tuan.FindElement(By.XPath("/html/body/div[2]/main/div[4]/div/div[1]/div/div/div[3]/nav/div/button"));
            order_45_Tuan.Click(); // click nút thanh toán

        }

        private void btClose_45_Tuan_Click(object sender, EventArgs e)
        {
            driver_45_Tuan.Quit();
            Application.Exit();
        }
    }
}
