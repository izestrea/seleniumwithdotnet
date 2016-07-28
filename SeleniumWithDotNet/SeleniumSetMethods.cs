using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithDotNet
{
    class SeleniumSetMethods
    {
        // enter text
        public static void EnterText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        // click into a button, checkbox, option, etc.
        public static void Click(IWebElement element)
        {
            element.Click();
        }

        // selecting a dropdown control
        public static void SelectDropDown(IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
