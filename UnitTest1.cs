using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System.Windows.Forms;
using NUnit.Framework;

namespace SoftwareTesting
{
    [TestClass]
    public class UnitTest1

    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Setup()

        {
            driver.Url = "http://newtours.demoaut.com/mercuryregister.php";
            driver.Manage().Window.Maximize();

        }

        [Test]

        public void Registration()
        {

            //REGISTRATION 
            CustomMethods.EnterText(driver, "firstName", "Geeta", "Name");
            CustomMethods.EnterText(driver, "lastName", "Parshotam", "Name");

            //DropDown
            CustomMethods.Dropdown(driver, "country", "Name", "PAKISTAN");

         
            //UserInformation
            CustomMethods.EnterText(driver, "email", "Geeta Parshotam", "Name");

            CustomMethods.EnterText(driver, "password", "Admin123", "Name");
            CustomMethods.EnterText(driver, "confirmPassword", "Admin123", "Name");

            //Submit
            CustomMethods.Click(driver, "register", "Name");

            //Assertion 
            string text = "Your user name is Geeta Parshotam.";
            try
            {
                NUnit.Framework.Assert.IsTrue(driver.FindElement(By.TagName("body")).Text.Contains(text));
                MessageBox.Show("assertion pass");
            }

            catch
            {
                MessageBox.Show("asseration fail");
            }


            //LinkTest
            CustomMethods.Click(driver, "sign-in", "LinkText");

            //Login

            CustomMethods.EnterText(driver, "userName", "GeetaParshotam", "Name");

            CustomMethods.EnterText(driver, "password", "Admin123", "Name");
            CustomMethods.Click(driver, "login", "Name");

            //Radio button 
           
           IWebElement webElement = driver.FindElement(By.CssSelector("input[type = 'radio'][value = 'oneway']"));

           webElement.Click();

            //Continue

            CustomMethods.Click(driver, "findFlights", "Name");
            CustomMethods.Click(driver, "reserveFlights", "Name");
            CustomMethods.Click(driver, "buyFlights", "Name");

            //LOGOUT
            driver.FindElement(By.XPath("//img[contains(@src, 'images/forms/Logout.gif')]")).Click();

        }
       [TearDown]
        public void Close()
        {
            driver.Close();
        }

    }
}
    





