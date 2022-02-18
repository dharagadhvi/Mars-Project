using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Marsprofile.Pages;
using Marsprofile.Utilities;
using NUnit.Framework;
#nullable disable

namespace Marsprofile.Stepdefinations
{
    [Binding]
    public class SkillStepDefinitions : CommonDriver
    {
        [Given(@"I logged into Mars skill portal successfully")]
        public void GivenILoggedIntoMarsSkillPortalSuccessfully()
        {
            driver = new ChromeDriver();

            Login loginPageobj = new Login ();
            loginPageobj.LoginSteps();

        }


        [When(@"I add Customer Service and Intermediatedetails")]
            public void WhenIAddCustomerServiceAndIntermediatedetails(string p0,string p1)
        {
               
            Skill skillobj = new Skill();
            skillobj.AddSkill(driver,p0,p1);
        }


        [Then(@"Customer Service and Intermediate details should be able to see on profile page")]
        public void ThenCustomerServiceAndIntermediateDetailsShouldBeAbleToSeeOnProfilePage(string p0,string p1)
        {
            
        Skill skillobj = new Skill();

            string actualskill = skillobj.GetSkill(driver,p0);
            string actualskillLevel = skillobj.GetSkillLevel(driver,p1);

            Assert.That(actualskill == p0, "Actual skill and expected skill do not match");
            Assert.That(actualskillLevel == p1, "Actual Level and expected level do not match");
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
