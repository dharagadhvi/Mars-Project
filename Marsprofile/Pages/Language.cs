using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marsprofile.Utilities;
using NUnit.Framework;
using Marsprofile.Utililty;
using OpenQA.Selenium.Support.UI;
using SELECT;
using RelevantCodes.ExtentReports;
using static Marsprofile.Pages.CommonMethods;

namespace Marsprofile.Pages
{
    public class Language
    {
        public void AddLanguage(IWebDriver driver, string Language, string Level)
        {
            //Adding Language to the profile
            //Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 5);
            //IWebElement SelectLanguage = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            //SelectLanguage.Click();                                 
            Thread.Sleep(4000);

            IWebElement AddNewLanguage = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));
            AddNewLanguage.Click();
            IWebElement LanguageTextBox = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > input[type=text]"));
            LanguageTextBox.SendKeys(Language);

            IWebElement ChooseLanguageLevel = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select"));
            ChooseLanguageLevel.Click();
            Thread.Sleep(3000);

            var SelectElement = new SelectElement(ChooseLanguageLevel);
            SelectElement.SelectByValue(Level);

            //SELECT LanguageLevel = new Select(driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select > option:nth-child(4)")));
            //LanguageLevel.SelectByVisualText("Fluent");

            //IWebElement SelectLevel = driver.FindElement(By.Name("Fluent"));
            //SelectLevel.Click();
            Thread.Sleep(4000);

            IWebElement ClickAdd = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > div > div.six.wide.field > input.ui.teal.button"));
            ClickAdd.Click();
            Thread.Sleep(5000);
        }


        public string Getlanguage(IWebDriver driver, string Language)
        {
            IWebElement actualLanguage = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(1)"));
            return actualLanguage.Text;


        }

        public string GetLanguageLevel(IWebDriver driver, string Level)
        {
            IWebElement actualLevel = driver.FindElement(By.CssSelector(" #account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(2)"));
            return actualLevel.Text;

        }

    }
}
    
