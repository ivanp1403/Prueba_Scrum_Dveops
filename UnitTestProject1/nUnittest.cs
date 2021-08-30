using System;
using System.Collections.Generic;
using System.Text;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using NUnit.Framework;

namespace UnitTestProject1
{
    class nUnittest
    {

        public IWebDriver driver = new ChromeDriver(@"C:\Pruebas\");
        public string url = "https://demoqa.com/automation-practice-form";

        [Test]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("firstName"));
            driver.FindElement(By.Id("firstName")).Click();

            driver.FindElement(By.Id("firstName")).SendKeys("Ivan");

           // WebDriverWait wait = new WebDriverWait(driver, new System.TimeSpan(0, 0, 5));

            driver.FindElement(By.Id("firstName")).SendKeys("Ivan");

            driver.Close();

        }
    }
}
