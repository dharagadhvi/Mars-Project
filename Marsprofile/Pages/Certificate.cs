using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Marsprofile.Utilities;
using OpenQA.Selenium.Support.UI;
using SELECT;

namespace Marsprofile.Pages
{
    public class Certificate
    {
        public void AddCertificate(IWebDriver driver,string Certificate,string From, string Year)
        {
            Thread.Sleep(6000);
            //add certificate to the profile

            IWebElement AddCertification = driver.FindElement(By.CssSelector(" #account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(4)"));
            AddCertification.Click();

            IWebElement AddNewCertifications = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));
            AddNewCertifications.Click();

            IWebElement AwardTextBox = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > div > input"));
            AwardTextBox.SendKeys(Certificate);

            IWebElement certiFromBox = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div.eight.wide.field > input"));
            certiFromBox.SendKeys(From);

            IWebElement YearAwardDropDown = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div.three.wide.field > select"));
            YearAwardDropDown.Click();

            var SelecteElement = new SelectElement(YearAwardDropDown);
            SelecteElement.SelectByValue(Year);
            Thread.Sleep(3000);
                                                          
            IWebElement pressAdd = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div.five.wide.field > input.ui.teal.button"));
            pressAdd.Click();
            Thread.Sleep(5000);

        }
        public string GetCertificate(IWebDriver driver, string Cerificate)
        {
            IWebElement actualcertificate = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(1)"));
            return actualcertificate.Text;
        }

        public string Getfrom(IWebDriver driver,string From)
        {

            IWebElement actualfrom = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(2)"));
            return actualfrom.Text;
        }
        public string Getyear(IWebDriver driver, string Year)
        {
            IWebElement actualceryear = driver.FindElement(By.CssSelector(" #account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(3)"));
            return actualceryear.Text;
        }


    }
}


