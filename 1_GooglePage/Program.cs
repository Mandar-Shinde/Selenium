using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Internal;
using System.Drawing.Imaging;
using System.Threading;

namespace _1_GooglePage
{
    class Program
    {
        static void Main(string[] args)
        {
            FirefoxDriver firefox = new FirefoxDriver();
            firefox.Navigate().GoToUrl("https://www.google.com");

            IWebElement element = firefox.FindElement(By.Name("q"));
            element.SendKeys("mandarsblog.wordpress.com");
            element.SendKeys(Keys.ArrowDown);
            element.Submit();

        }

    }
}
