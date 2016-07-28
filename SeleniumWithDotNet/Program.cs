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
            // test
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");

            // initial
            SeleniumSetMethods.Entertext(driver, "Initial", "executeautomation", "name");

            Console.WriteLine("Teh value from Title is: " + SeleniumGetMethods.GetText(driver, "TitleId", "Id"));
            Console.WriteLine("Teh value from Initial is: " + SeleniumGetMethods.GetText(driver, "Initial", "Name"));

            // click
            SeleniumSetMethods.Click(driver, "Save", "Name");
           
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
