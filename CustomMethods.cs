using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTesting
{
    class CustomMethods
    {
        public static void EnterText(IWebDriver driver, string element, string value, string elementtype)
        {
            if(elementtype == "Id")
          
             driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);
           
        }
        public static void Click(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).Click();
            if (elementtype == "LinkText")
                driver.FindElement((By.LinkText(element))).Click();
           
        }
        public static void Dropdown(IWebDriver driver, string element, string elementtype, string value)
        {
            if (elementtype == "Id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
        }
       
    }
}
