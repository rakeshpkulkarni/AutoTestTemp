using CSpector.helper;
using OpenQA.Selenium;
using System;

namespace CSpector.helper
{
    
    public class HomePage
	{
        Program program = new Program();
        public HomePage()
        {

        }

        public IWebElement SearchText()
        {
            return WebDriver.driver().FindElement(By.CssSelector("[name = 'q']"));
        }

        public IWebElement SearchTextWithPath(string path)
        {
            Console.WriteLine(path);
            return WebDriver.driver().FindElement(By.CssSelector(path));

        }
        public IWebElement SearchTextWithPath2(string path, string heyy)
        {
            Console.WriteLine(path+"Test Passed"+ heyy);
            return WebDriver.driver().FindElement(By.CssSelector(path));
        }
    }
}
