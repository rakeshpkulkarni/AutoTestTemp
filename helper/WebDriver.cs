using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CSpector.helper
{
    class WebDriver
    {
        private static IWebDriver _driver;
        protected WebDriver()
        {

        }

        public static IWebDriver driver()
        {
            if(_driver == null)
            {
               return _driver = new ChromeDriver();   
            }
            return _driver;
        }

          
    }
}
