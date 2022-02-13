using System;
using TechTalk.SpecFlow;
using Marsprofile.Pages;
using Marsprofile.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;


namespace Marsprofile.Stepdefinations
{
    [Binding]
    public class EducationStepDefinitions : CommonDriver
    {

        [Given(@"I logged into Mars portal on Education pages successfully")]
        public void GivenILoggedIntoMarsPortalOnEducationPagesSuccessfully()
        {
            driver = new ChromeDriver();

            LoginPage loginPageobj = new LoginPage();
            loginPageobj.LoginSteps(driver);
        }

        [When(@"I add education details")]
        public void WhenIAddEducationDetails()
        {
            Education educationobj = new Education();
            educationobj.AddEducation(driver);
        }

        [Then(@"education details should be able to see on profile page")]
        public void ThenEducationDetailsShouldBeAbleToSeeOnProfilePage()
        {
            Education educationobj = new Education();

            string actualCountry = educationobj.Getcountry(driver);
            string actualUniversity = educationobj.GetUniversity(driver);
            string actualTitle = educationobj.GetTitle(driver);
            string actualDegree = educationobj.GetDegree(driver);
            string actualGraduation = educationobj.GetGraduation(driver);


            Assert.That(actualCountry == "India", "Actual country and expected country do not match");
            Assert.That(actualUniversity == "A D Patel", "Actual university and expected university do not match");
            Assert.That(actualTitle == "B.Tech", "Actual title and expected title do not match");
            Assert.That(actualDegree == "IT", "Actual degree and expected degree do not match");
            Assert.That(actualGraduation == "2009", "Actual year and expected year do not match");

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
