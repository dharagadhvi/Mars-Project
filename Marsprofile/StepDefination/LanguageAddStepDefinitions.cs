using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using System;
using Marsprofile.Pages;
using Marsprofile.Utilities;
using NUnit.Framework;
#nullable disable

namespace Marsprofile.Stepdefinations
{
    [Binding]
    public class LanguageStepDefinitions : CommonDriver
    {
        [Given(@"I lodged into Mars language portal successfully")]
        public void GivenILodgedIntoMarsLanguagePortalSuccessfully()
        {
            //driver = new ChromeDriver();

            Login loginPageobj = new Login();
            loginPageobj.LoginSteps();
        }
        [When(@"I add '([^']*)' and '([^']*)' details")]
        public void WhenIAddAndDetails(string p0, string p1)
        {

            Language languagePageObj = new Language();
            languagePageObj.AddLanguage(driver,p0, p1);
        }

        [Then(@"'([^']*)' and '([^']*)' should be able to see on Language profile  page")]
        public void ThenAndShouldBeAbleToSeeOnLanguageProfilePage(string p0, string p1)
        {
            Language languagePageObj = new Language();
            string actualLanguage = languagePageObj.Getlanguage(driver, p0);
            string actualLevel = languagePageObj.GetLanguageLevel(driver, p1);

            Assert.That(actualLanguage == p0, "Actual Language and expected language do not match.");
            Assert.That(actualLevel == p1, "Actual Level and expected level do not match");
        }



    }

}
