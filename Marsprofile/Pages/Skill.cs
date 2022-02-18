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
    internal class Skill
    {
        public void AddSkill(IWebDriver driver,string skill,string level)

        {
            Thread.Sleep(3000);

            IWebElement AddSkills = driver.FindElement(By.CssSelector(" #account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(2)"));
            AddSkills.Click();

            Thread.Sleep(2000);

            IWebElement AddNewSkill = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));
            AddNewSkill.Click();

            IWebElement SkillTextBox = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > input[type=text]"));
            SkillTextBox.SendKeys("Exellent Customer Service");

            IWebElement ChooseSkillLevel = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select"));
            ChooseSkillLevel.Click();

            var selectElement= new SelectElement(ChooseSkillLevel);
            selectElement.SelectByValue("Intermediate");
            Thread.Sleep(3000);

            //IWebElement SelectSkilllevel = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
            //SelectSkilllevel.Click();

            IWebElement ClickOnAdd = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > span > input.ui.teal.button"));
            ClickOnAdd.Click();
            Thread.Sleep(5000);
        }
        public string GetSkill(IWebDriver driver,string Skill)
        {
            IWebElement actualSkill = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(1)"));
            return actualSkill.Text;                                  
        }

        public string GetSkillLevel(IWebDriver driver,string Level)
        {
            IWebElement actualskillLevel = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(2)"));
            return actualskillLevel.Text;

        }
    }
}
