﻿using NUnit.Framework;
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
        //IWebDriver driver = new ChromeDriver(@"D:\apps\");
        
        static void Main(string[] args)
        {
          
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver(@"D:\apps\");
            // navigate to a page
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            ExcelLib.PopulateInCollection(@"D:\workspace\SeleniumWithDotNet\SeleniumWithDotNet\Data.xlsx");

            // login to application
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObjects pageEA = pageLogin.Login(ExcelLib.ReadData(1, "UserName"), ExcelLib.ReadData(1, "Password"));

            pageEA.FillUserForm(ExcelLib.ReadData(1, "Initial"), ExcelLib.ReadData(1, "MiddleName"), ExcelLib.ReadData(1, "FirstName"));
            //// test
            //SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            //// initial
            //SeleniumSetMethods.EnterText("Initial", "executeautomation", PropertyType.Name);

            //Console.WriteLine("The value from Title is: " + SeleniumGetMethods.GetText("TitleId", PropertyType.Id));
            //Console.WriteLine("The value from Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            //// click
            //SeleniumSetMethods.Click("Save", PropertyType.Name);
           
        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next method");
        }

        [TearDown]
        public void CLeanUp()
        {
            //PropertiesCollection.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            PropertiesCollection.driver.Close();
            Console.WriteLine("Close the browser");
        }

    }
}
