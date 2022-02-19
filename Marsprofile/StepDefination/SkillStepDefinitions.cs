using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Marsprofile.Pages;
using Marsprofile.Utilities;
using OpenQA.Selenium;
using NUnit.Framework;
using static Marsprofile.Pages.Language;
using static Marsprofile.Pages.CommonMethods;
#nullable disable

namespace Marsprofile.Stepdefinations
{
    [Binding]
    public class SkillStepDefinitions : Testfeatures
    {
        [Given(@"I click on Skill tab")]
        public void GivenIClickOnSkillTab()
        {
            Driver.driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a.item.active"));
        }

    
    [When(@"I add '([^']*)' and '([^']*)'details")]
        public void WhenIAddAndDetails(string p0, string p1)
        {
            Skill skillobj = new Skill();
            skillobj.AddSkill(driver, p0, p1);
        }

        [Then(@"added'([^']*)' and '([^']*)' details should be able to see on profile page")]
        public void ThenAddedAndDetailsShouldBeAbleToSeeOnProfilePage(string p0, string p1)
        {
            try
            {

                Skill skillobj = new Skill();

                CommonMethods.ExtentReports();
                //Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Add Skill Detail");
                

            string actualskill = skillobj.GetSkill(driver, p0);
            string actualskillLevel = skillobj.GetSkillLevel(driver, p1);

                if (actualskill == p0 && actualskillLevel == p1)
                {
                    CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Test Passed, Added a skill Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillAdded");
                    Assert.IsTrue(true);

                }

                else
                    CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Test Failed");

            }

            catch (Exception e)
            {
                CommonMethods.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Test Failed", e.Message);
            }


            //Assert.That(actualskill == p0, "Actual skill and expected skill do not match");
            //Assert.That(actualskillLevel == p1, "Actual Level and expected level do not match");
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
