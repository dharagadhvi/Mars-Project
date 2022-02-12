using Marsprofile.Pages;
using Marsprofile.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;


namespace Marsprofile.StepDefinations
{
   
    [Binding]
    public class LanguageStepDefinitions : CommonDriver
    {
       
            
        [Given(@"I lodged into Mars Logo portal successfully")]
        public void GivenILodgedIntoMarsLogoPortalSuccessfully()
        {
            driver = new ChromeDriver();
           
            LoginPage loginPageobj = new LoginPage();
            loginPageobj.LoginSteps(driver);

        }

        [When(@"I add language details")]
        public void WhenIAddProfileDetails()
        {
            Language languagePageObj = new Language();
            languagePageObj.AddLanguage(driver);
        }

        [Then(@"Language details should be able to see on profile page")]
        public void ThenProfileDetailsShouldBeAbleToSeeOnProfilePage()
        {
            Language languagePageObj = new Language();
            string actualLanguage = languagePageObj.Getlanguage(driver);
            string actualLevel = languagePageObj.GetLanguageLevel(driver);

            Assert.That(actualLanguage == "Hindi", "Actual Language and expected language do not match.");
            Assert.That(actualLevel == "Fluent", "Actual Level and expected level do not match");
        }
    }
}
