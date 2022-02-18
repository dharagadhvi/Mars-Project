using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using SELECT;

namespace Marsprofile.Pages
{
    internal class Education
    {
        public void AddEducation(IWebDriver driver,string Country,string University,string Title,string Degree,string GraduationYear)
        {
            Thread.Sleep(6000);

            //Adding Education to the profile

            IWebElement AddEducation = driver.FindElement(By.CssSelector(" #account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(3)"));
            AddEducation.Click();

            IWebElement AddNewEducation = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));
            AddNewEducation.Click();

            IWebElement CollegeTextBox = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > div.ten.wide.field > input[type=text]"));
            CollegeTextBox.SendKeys(University);

            IWebElement countyDropdown = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > div.six.wide.field > select"));
            countyDropdown.Click();

            var SelectElement= new SelectElement(countyDropdown);
            SelectElement.SelectByValue(Country);


            IWebElement TitleDropdown = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div:nth-child(1) > select"));
            TitleDropdown.Click();

            var SelectElement1 = new SelectElement(TitleDropdown);
            SelectElement1.SelectByValue(Title);

            
            IWebElement DegreeTextBox = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div:nth-child(2) > input[type=text]"));
            DegreeTextBox.SendKeys(Degree);
           Thread.Sleep(3000);

            IWebElement YearDropdown = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div.four.wide.field > select"));
            YearDropdown.Click();

            var SelectElement2 =new SelectElement(YearDropdown);
            SelectElement2.SelectByValue(GraduationYear);
            Thread.Sleep(3000);

            IWebElement ClickToAdd = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(3) > div > input.ui.teal.button"));
            ClickToAdd.Click();
            Thread.Sleep(5000);
        }
        public string Getcountry(IWebDriver driver, string Country)
        {
            IWebElement actualcountry = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(1)"));
            return actualcountry.Text;
        }

        public string GetUniversity(IWebDriver driver, string University)
        {
            IWebElement actualuniversity = driver.FindElement(By.CssSelector(" #account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(2)"));
            return actualuniversity.Text;
        }
        public string GetTitle(IWebDriver driver,string Title)
        {
            IWebElement actualUniversity = driver.FindElement(By.CssSelector(" #account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(3)"));
            return actualUniversity.Text;
        }
        public string GetDegree(IWebDriver driver,string Degree)
        {
            IWebElement actualdegree = driver.FindElement(By.CssSelector(" #account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(4)"));
            return actualdegree.Text;
        }
        public string GetGraduation(IWebDriver driver,string GraduationYear)
        {
            IWebElement actualGraduation = driver.FindElement(By.CssSelector(" #account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(5)"));
            return actualGraduation.Text;
        }
    }
}
