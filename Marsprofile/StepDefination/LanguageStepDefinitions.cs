using Marsprofile.Pages;
using Marsprofile.Utilities;
using Microsoft.VisualStudio.Services.WebPlatform;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Marsprofile.Stepdefinations
{
    [Binding]
    public class LanguageStepDefinitions  : CommonDriver
    {
        [Given(@"I lodged into Mars language portal successfully")]
        public void GivenILodgedIntoMarsLanguagePortalSuccessfully()
        {
            driver = new ChromeDriver();

            LoginPage loginPageobj = new();
            loginPageobj.LoginSteps(driver);
        }

        [When(@"I add language and Level details")]
        public void WhenIAddLanguageAndLevelDetails()
        {
            Language languagePageObj = new Language();
            Language.AddLanguage(driver);
        }

        [Then(@"Language details should be able to see on language profile  page")]
        public void ThenLanguageDetailsShouldBeAbleToSeeOnLanguageProfilePage()
        {
            Language languagePageObj = new Language();
            string actualLanguage = languagePageObj.Getlanguage(driver);
            string actualLevel = languagePageObj.GetLanguageLevel(driver);

            Assert.That(actualLanguage == "Hindi", "Actual Language and expected language do not match.");
            Assert.That(actualLevel == "Fluent", "Actual Level and expected level do not match");
        }
    }
}
