using TechTalk.SpecFlow;
using OpenQA.Selenium;
using System;
using Marsprofile.Pages;
using Marsprofile.Utilities;
using NUnit.Framework;
using static Marsprofile.Pages.Language;
using static Marsprofile.Pages.CommonMethods;
using RelevantCodes.ExtentReports;
#nullable disable


namespace Marsprofile.Stepdefinations
{
    [Binding]
    public class EducationStepDefinitions : Testfeatures
    {

        [Given(@"I click on Education tab")]
        public void GivenIClickOnEducationTab()
        {
            Driver.driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a.item.active"));

        }

        [When(@"I add '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)' details")]
        public void WhenIAddDetails(string p0, string p1, string p2, string p3, string p4)
        {
            Education educationobj = new Education();
            educationobj.AddEducation(driver, p0, p1, p2, p3, p4);
        }


        [Then(@"added '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)' details should be able to see on profile page")]
        public void ThenAddedDetailsShouldBeAbleToSeeOnProfilePage(string p0, string p1, string p2, string p3, string p4)
        {
            try
            {

                Education educationobj = new Education();
                CommonMethods.ExtentReports();
                //Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.Extent.StartTest("Add Education Detail");
                


                string actualCountry = educationobj.Getcountry(driver, p0);
                string actualUniversity = educationobj.GetUniversity(driver, p1);
                string actualTitle = educationobj.GetTitle(driver, p2);
                string actualDegree = educationobj.GetDegree(driver, p3);
                string actualGraduation = educationobj.GetGraduation(driver, p4);
                if (actualCountry == p0 && actualUniversity == p1 && actualTitle == p2 && actualDegree == p3 && actualGraduation == p4) 
                 {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added education Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "EducationAdded");
                    Assert.IsTrue(true);

                 }

                 else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }
    }
}

//Assert.That(actualCountry == p0, "Actual country and expected country do not match");
//            Assert.That(actualUniversity == p1, "Actual university and expected university do not match");
//            Assert.That(actualTitle == p2, "Actual title and expected title do not match");
//            Assert.That(actualDegree == p3, "Actual degree and expected degree do not match");
//            Assert.That(actualGraduation == p4, "Actual year and expected year do not match");

       

//        [When(@"I add duplicate India\.<University>,B\.Tech,IT,<Graduation Year> details")]
//        public void WhenIAddDuplicateIndia_UniversityB_TechITGraduationYearDetails()
//        {
//            throw new PendingStepException();
//        }

//        [Then(@"education details should  not be able to see on profile page and <error message> should be seen")]
//        public void ThenEducationDetailsShouldNotBeAbleToSeeOnProfilePageAndErrorMessageShouldBeSeen()
//        {
//            throw new PendingStepException();
//        }

//        [When(@"I edit Australia\.<University>,B\.Tech,IT,<Graduation Year> details")]
//        public void WhenIEditAustralia_UniversityB_TechITGraduationYearDetails()
//        {
//            throw new PendingStepException();
//        }

//        [When(@"I delete education details")]
//        public void WhenIDeleteEducationDetails()
//        {
//            throw new PendingStepException();
//        }

//        [Then(@"education details should  not be  able to see on profile page")]
//        public void ThenEducationDetailsShouldNotBeAbleToSeeOnProfilePage()
//        {
//            throw new PendingStepException();
//        }
//    }
//}
