using CSpector.helper;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Reflection;

namespace CSpector
{
    public class Program
    {

        public Program()
        {

        }
        static void Main(string[] args)
        {

            //InvokeHelper.InvokeWebElement("CSpector.helper.HomePage", "SearchText");
            //InvokeHelper.InvokeWebElement("CSpector.helper.HomePage", "SearchTextWithPath", new object[] { "Hello" });
            //InvokeHelper.InvokeWebElement("CSpector.helper.HomePage", "SearchTextWithPath2", new object[] { "Hello", "Hi" });


            String test_url = "https://www.google.com";
            WebDriver.driver().Manage().Window.Maximize();
            WebDriver.driver().Url = test_url;
            System.Threading.Thread.Sleep(2000);
            //IWebElement searchText = WebDriver.driver().FindElement(By.CssSelector("[name = 'q']"));
            //HomePage homePage = new HomePage();
            //IWebElement searchText = homePage.SearchText();
            IWebElement searchText = InvokeHelper.InvokeWebElement("HomePage", "SearchText");
            searchText.SendKeys("rk");
            IWebElement CloseAutoFill = WebDriver.driver().FindElement(By.XPath("//img[@alt='Google']"));
            CloseAutoFill.Click();
            IWebElement searchButton = WebDriver.driver().FindElement(By.XPath("//div[@class='FPdoLc tfB0Bf']//input[@name='btnK']"));
            searchButton.Click();
            System.Threading.Thread.Sleep(6000);
            Console.WriteLine("Test Passed");
        }
    }
}
