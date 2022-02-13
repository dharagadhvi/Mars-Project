using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Marsprofile.Pages;
using Marsprofile.Utilities;
using NUnit.Framework;

namespace Marsprofile.Stepdefinations
{
    [Binding]
    public class SkillStepDefinitions : CommonDriver
    {
        [Given(@"I logged into Mars skill portal successfully")]
        public void GivenILoggedIntoMarsSkillPortalSuccessfully()
        {
            driver = new ChromeDriver();

            LoginPage loginPageobj = new LoginPage();
            loginPageobj.LoginSteps(driver);

        }


        [When(@"I add Skill and Leveldetails")]
        public void WhenIAddSkillAndLeveldetails()
        {
            Skill skillobj = new Skill();
            skillobj.AddSkill(driver);
        }


        [Then(@"Profile details should be able to see on profile page")]
        public void ThenProfileDetailsShouldBeAbleToSeeOnProfilePage()
        {
            Skill skillobj = new Skill();

            string actualskill = skillobj.GetSkill(driver);
            string actualskillLevel = skillobj.GetSkillLevel(driver);

            Assert.That(actualskill == "Exellent Customer Service", "Actual skill and expected skill do not match");
            Assert.That(actualskillLevel == "Intermediate", "Actual Level and expected level do not match");
        }

        //[When(@"I add duplicate Customer Service and <Level>details")]
        //public void WhenIAddDuplicateCustomerServiceAndLevelDetails()
        //{
        //    throw new PendingStepException();
        //}

        //[Then(@"Profile details should  not be able to see on profile page and This skill is alreday exist in your skill List should be seen")]
        //public void ThenProfileDetailsShouldNotBeAbleToSeeOnProfilePageAndThisSkillIsAlredayExistInYourSkillListShouldBeSeen()
        //{
        //    throw new PendingStepException();
        //}

        //[When(@"I edit Customer Service and Excellentdetails")]
        //public void WhenIEditCustomerServiceAndExcellentdetails()
        //{
        //    throw new PendingStepException();
        //}

        //[When(@"I delete skilldetails")]
        //public void WhenIDeleteSkilldetails()
        //{
        //    throw new PendingStepException();
        //}

        //[Then(@"Profile details should not be able to see on profile page")]
        //public void ThenProfileDetailsShouldNotBeAbleToSeeOnProfilePage()
        //{
        //    throw new PendingStepException();
        //}
    
    }
}
