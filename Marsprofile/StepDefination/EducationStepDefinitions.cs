using TechTalk.SpecFlow;
using OpenQA.Selenium;
using System;
using Marsprofile.Pages;
using Marsprofile.Utilities;
using NUnit.Framework;
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
            Education educationobj = new Education();

            string actualCountry = educationobj.Getcountry(driver,p0);
            string actualUniversity = educationobj.GetUniversity(driver,p1);
            string actualTitle = educationobj.GetTitle(driver,p2);
            string actualDegree = educationobj.GetDegree(driver,p3);
            string actualGraduation = educationobj.GetGraduation(driver,p4);


            Assert.That(actualCountry == p0, "Actual country and expected country do not match");
            Assert.That(actualUniversity == p1, "Actual university and expected university do not match");
            Assert.That(actualTitle == p2, "Actual title and expected title do not match");
            Assert.That(actualDegree == p3, "Actual degree and expected degree do not match");
            Assert.That(actualGraduation == p4, "Actual year and expected year do not match");

        }


        
    }

           
}

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
