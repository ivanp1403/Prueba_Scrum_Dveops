using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public IWebDriver driver = new ChromeDriver(@"C:\Pruebas\");
        public string url = "https://www.openfactapp.com"; 
        [TestMethod]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("LoginUser_UserName"));
             driver.FindElement(By.Id("LoginUser_UserName")).Click();

            driver.FindElement(By.Id("LoginUser_UserName")).SendKeys("demo");

            driver.FindElement(By.Id("LoginUser_UserPasword"));
            driver.FindElement(By.Id("LoginUser_UserPasword")).Click();

            driver.FindElement(By.Id("LoginUser_UserPasword")).SendKeys("0430");
            

             
             
            driver.FindElement(By.Id("LoginUser_LoginButton")).Click();


            if (driver.Url == "https://admin-sysnnova.com/OpenFact/Default.aspx")
            {
                driver.Navigate().GoToUrl("https://admin-sysnnova.com/OpenFact/FastFactEmisor/frmCliente.aspx");
                 if (driver.Url == "https://admin-sysnnova.com/OpenFact/FastFactEmisor/frmCliente.aspx")
                 {
                    driver.FindElement(By.Id("MainContent_btnAdd"));
                    driver.FindElement(By.Id("MainContent_btnAdd")).Click();


                    driver.FindElement(By.Id("MainContent_txtNombreCliente"));
                    driver.FindElement(By.Id("MainContent_txtNombreCliente")).SendKeys("IVAN PONCE");
                    driver.FindElement(By.Id("MainContent_txtIdentificacion")).SendKeys("1234567890");
                    driver.FindElement(By.Id("MainContent_txtTelefonoConvecnional")).SendKeys("0987654321");
                    driver.FindElement(By.Id("MainContent_txtMailDefecto")).SendKeys("ivan_scrum@gmail.com");
                    driver.FindElement(By.Id("MainContent_txtDireccion")).SendKeys("SAN VICENTE");
                    driver.FindElement(By.Id("MainContent_btnGuardarCliente")).Click();
                    driver.Navigate().GoToUrl("https://admin-sysnnova.com/OpenFact/FastFactEmisor/frmCliente.aspx");
                 }
            }

            WebDriverWait wait = new WebDriverWait(driver, new System.TimeSpan(0, 0, 5));

            driver.Close();

        }

        [TestMethod]
        public void TestMethod2()
        {
            //WebDriverWait wait = new WebDriverWait(driver, new System.TimeSpan(0, 0, 5));
            //driver.Close();
        }
    }
}
