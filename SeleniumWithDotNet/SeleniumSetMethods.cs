using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithDotNet
{
    public static class SeleniumSetMethods
    {
        // enter text
        // extended method for entering text in the control
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        // click into a button, checkbox, option, etc.
        public static void Clicks(this IWebElement element)
        {
            element.Click();
        }

        // selecting a dropdown control
        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
