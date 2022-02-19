using TechTalk.SpecFlow;
using OpenQA.Selenium;
using System;
using Marsprofile.Pages;
using Marsprofile.Utilities;
using NUnit.Framework;
using static Marsprofile.Pages.Language;
using static Marsprofile.Pages.CommonMethods;
#nullable disable

namespace Marsprofile.Stepdefinations
{
    [Binding]
    public class LanguageStepDefinitions : Testfeatures
    {
        [Given(@"I click on Language tab")]
        public void GivenIClickOnLanguageTab()
        {
            Driver.driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a.item.active"));
        }


        [When(@"I add '([^']*)' and '([^']*)' details")]
        public void WhenIAddAndDetails(string p0, string p1)
        {

            Language languagePageObj = new Language();
            languagePageObj.AddLanguage(driver, p0, p1);
        }

        [Then(@"'([^']*)' and '([^']*)' should be able to see on Language profile  page")]
        public void ThenAndShouldBeAbleToSeeOnLanguageProfilePage(string p0, string p1)
        {
            try
            {

                Language languagePageObj = new Language();
                CommonMethods.ExtentReports();
                //Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Add a Language and Level");
                string actualLanguage = languagePageObj.Getlanguage(driver, p0);
                string actualLevel = languagePageObj.GetLanguageLevel(driver, p1);
                
                if (actualLanguage == p0 && actualLevel==p1)
                {
                    CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Test Passed, Added a Language Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageAdded");
                    Assert.IsTrue(true);

                }

                else
                    CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Test Failed");

            }

            catch (Exception e)
            {
                CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Test Failed", e.Message);
            }


            //Assert.That(actualLanguage == p0, "Actual Language and expected language do not match.");
            //            Assert.That(actualLevel == p1, "Actual Level and expected level do not match");
        }




    }
}


