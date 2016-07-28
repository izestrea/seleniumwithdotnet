using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithDotNet
{
    class Program
    {
        // create reference for browser
        IWebDriver driver = new ChromeDriver(@"D:\apps\");
        
        static void Main(string[] args)
        {
          
        }

        [SetUp]
        public void Initialize()
        {
            // navigate to a page
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password&=&Login=Login");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            // enter text (element, value, type)
            // find element
            IWebElement element = driver.FindElement(By.Name("q"));

            // perform operations
            element.SendKeys("executeautomation");

            Console.WriteLine("Executed Test");
        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next method");
        }

        [TearDown]
        public void CLeanUp()
        {
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            driver.Close();
            Console.WriteLine("Close the browser");
        }

    }
}
