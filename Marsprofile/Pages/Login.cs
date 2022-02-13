using Marsprofile.Utililty;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Marsprofile.Pages
{
    public class LoginPage



    {
        public void LoginSteps(IWebDriver driver)

        {
            //open web driver

            driver.Manage().Window.Maximize();


            //launch mars portal

            driver.Navigate().GoToUrl("http://localhost:5000/");

            IWebElement SigninObj = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            SigninObj.Click();

            //identify username textbox and enter valid textbox

            try
            {

                IWebElement UserNameTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                UserNameTextBox.SendKeys("dharagadhvi@gmail.com");

                //identify password textbox and enter valid password
                IWebElement PasswordTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                PasswordTextBox.SendKeys("Pass@word123");

                //click on login button
                IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                LoginButton.Click();

            }
            catch (Exception ex)
            {
                Assert.Fail("Mars portal login page did not launch", ex.Message);
            }

        }
    }
}

