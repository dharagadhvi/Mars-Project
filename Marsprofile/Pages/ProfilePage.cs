using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marsprofile.Pages
{
    public  class ProfilePage
    {
        public void ABC(IWebDriver driver)
        {
            //Adding  Skills to the profile


            IWebElement AddSkills = driver.FindElement(By.XPath(" //*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            AddSkills.Click();

            IWebElement AddNewSkill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewSkill.Click();

            IWebElement SkillTextBox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            SkillTextBox.SendKeys("Exellent Customer Service");

            IWebElement ChooseSkillLevel = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            ChooseSkillLevel.Click();

            IWebElement SelectSkilllevel = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
            SelectSkilllevel.Click();

            IWebElement ClickOnAdd = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            ClickOnAdd.Click();



            //Adding Education to the profile

            IWebElement AddEducation = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            AddEducation.Click();

            IWebElement AddNewEducation = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            AddNewEducation.Click();

            IWebElement CollegeTextBox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            CollegeTextBox.SendKeys("A D Patel");

            IWebElement countyrDropdown = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            countyrDropdown.Click();

            IWebElement chooseCountry = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[66]"));
            chooseCountry.Click();

            IWebElement TitleDropdown = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            TitleDropdown.Click();

            IWebElement ChooseTitle  = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[7]"));
            ChooseTitle.Click();

            IWebElement DegreeTextBox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            DegreeTextBox.SendKeys("IT");

            IWebElement YearDropdown = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            YearDropdown.Click();

            IWebElement ChooseYear = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[16]"));
            ChooseYear.Click();

            IWebElement ClickToAdd = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            ClickToAdd.Click();


            //add certificate to the profile

            IWebElement AddCertification = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            AddCertification.Click();

            IWebElement AddNewCertifications = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            AddNewCertifications.Click();

            IWebElement AwardTextBox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            AwardTextBox.SendKeys("Certificate III");

            IWebElement certiFromBox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            certiFromBox.SendKeys("Tafe");

            IWebElement YearAwardDropDown = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            YearAwardDropDown.Click();

            IWebElement chooseyearAward = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[6]"));
            chooseyearAward.Click();

            IWebElement pressAdd = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            pressAdd.Click();











        }
    }   
}
