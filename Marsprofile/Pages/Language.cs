using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marsprofile.Pages
{
    internal class Language
    {
        public void AddLanguage(IWebDriver driver)
        {
            //Adding Language to the profile

            IWebElement SelectLanguage = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            SelectLanguage.Click();

            IWebElement AddNewLanguage = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewLanguage.Click();

            IWebElement LanguageTextBox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            LanguageTextBox.SendKeys("Hindi");

            IWebElement ChooseLanguageLevel = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            ChooseLanguageLevel.Click();

            IWebElement SelectLevel = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
            SelectLevel.Click();

            IWebElement ClickAdd = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            ClickAdd.Click();



            //IWebElement actualLanguage = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            //IWebElement actualLevel = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[Last()]/tr/td[2]"));

            //Assert.That(actualLanguage.Text == "Hindi", "Actual Language and expected language do not match.");
            //Assert.That(actualLevel.Text == "Fluent", "Actual Level and expected level do not match.");

        }
        public string Getlanguage(IWebDriver driver)
        {
            IWebElement actualLanguage = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return actualLanguage.Text;
        }

        public string GetLanguageLevel(IWebDriver driver)
        {
            IWebElement actualLevel = driver.FindElement(By.XPath(" //*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[2]"));
            return actualLevel.Text;
        }

    }
}
