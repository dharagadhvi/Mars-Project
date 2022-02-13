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

            LoginPage loginPageobj = new LoginPage();
            loginPageobj.LoginSteps(driver);

        }
        [When(@"I add Certificate,From,Year details")]
        public void WhenIAddCertificateFromYearDetails()
        {
            Certificate ceritificateobj= new Certificate();
            ceritificateobj.AddCertificate(driver);

        }
        [Then(@"certificate  details should be able to see on profile page")]
        public void ThenCertificateDetailsShouldBeAbleToSeeOnProfilePage()
        {
            Certificate ceritificateobj = new Certificate();

            string actualCertificate = ceritificateobj.GetCertificate(driver);
            string actualfrom = ceritificateobj.Getfrom(driver);
            string actualceryear = ceritificateobj.Getyear(driver);

            Assert.That(actualCertificate == "Certificate III", "Actual certificate and expected certificate do not match");
            Assert.That(actualfrom == "Tafe", "Actual from certificate and expected from certificate do not match");
            Assert.That(actualceryear == "2018", "Actual certificate year and expected certificate year do not match");

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
}
