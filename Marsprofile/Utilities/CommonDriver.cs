using Marsprofile.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable

namespace Marsprofile.Utilities
{    
   
    public  class CommonDriver
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void LoginFunction()

        {
            driver = new ChromeDriver();

            //Login Page object initialization and defination
            LoginPage loginPageobj = new LoginPage();
            loginPageobj.LoginSteps(driver);
        }
        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }

    }
}
