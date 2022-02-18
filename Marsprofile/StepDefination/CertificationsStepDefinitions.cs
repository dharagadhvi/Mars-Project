using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Marsprofile.Pages;
using Marsprofile.Utilities;
using NUnit.Framework;

namespace Marsprofile.Stepdefinations
{
    [Binding]
    public class CertificationsStepDefinitions : CommonDriver
    {

        [Given(@"I logged into Mars Logo portal successfully")]
        public void GivenILoggedIntoMarsLogoPortalSuccessfully()
        {
            driver = new ChromeDriver();

            Login loginPageobj = new Login();
            loginPageobj.LoginSteps();

        }
        [When(@"I add '([^']*)','([^']*)','([^']*)' details")]
        public void WhenIAddDetails(string p0, string p1, string p2)
        {

            Certificate ceritificateobj = new Certificate();
            ceritificateobj.AddCertificate(driver, p0, p1, p2);
        }
        [Then(@"added '([^']*)','([^']*)','([^']*)'  details should be able to see on profile page")]
        public void ThenAddedDetailsShouldBeAbleToSeeOnProfilePage(string p0, string p1, string p2)
        {
           
        Certificate ceritificateobj = new Certificate();

            string actualCertificate = ceritificateobj.GetCertificate(driver,p0);
            string actualfrom = ceritificateobj.Getfrom(driver,p1);
            string actualceryear = ceritificateobj.Getyear(driver,p2);

            Assert.That(actualCertificate == p0, "Actual certificate and expected certificate do not match");
            Assert.That(actualfrom == p1, "Actual from certificate and expected from certificate do not match");
            Assert.That(actualceryear == p2, "Actual certificate year and expected certificate year do not match");

        }

    }

              //[When(@"I edit ITIL,DEF,(.*) details")]
        //public void WhenIEditITILDEFDetails(int p0)
        //{
        //    throw new PendingStepException();
        //}

        //[When(@"I delete Certificate details")]
        //public void WhenIDeleteCertificateDetails()
        //{
        //    throw new PendingStepException();
        //}
    
}
