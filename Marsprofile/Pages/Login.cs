using Marsprofile.Utililty;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable



namespace Marsprofile.Pages
{
    public  class Login

    {
        public void LoginSteps()

        {
            //Driver.NavigateUrl();       

            Thread.Sleep(1000);

            Driver.driver.FindElement(By.XPath("//a[contains(.,'Sign In')]")).Click();
            //Enter Username
            Driver.driver.FindElement(By.XPath("//input[@name='email']")).SendKeys("dharagadhvi@gmail.com");
            //Enter password
            Driver.driver.FindElement(By.XPath("//input[contains(@name,'password')]")).SendKeys("Pass@word123");
            Thread.Sleep(1000);
            //Click on Login Button
            Driver.driver.FindElement(By.XPath("//button[contains(.,'Login')]")).Click();

            Thread.Sleep(3000);
            //button[contains(.,'Sign Out')]
            //Validate if user logged in or not
            IWebElement loggedin = Driver.driver.FindElement(By.CssSelector("#account-profile-section > div > div.ui.secondary.menu > div.right.item > div > span"));
            Assert.AreEqual(loggedin.Text, "Hi Dhara");
            Thread.Sleep(2000);

        }

    }
}

