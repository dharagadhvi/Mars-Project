using System;
using TechTalk.SpecFlow;

namespace Marsprofile
{
    [Binding]
    public class EducationStepDefinitions
    {
        [When(@"I add India\.<University>,B\.Tech,IT,<Graduation Year> details")]
        public void WhenIAddIndia_UniversityB_TechITGraduationYearDetails()
        {
            throw new PendingStepException();
        }

        [Then(@"education details should be able to see on profile page")]
        public void ThenEducationDetailsShouldBeAbleToSeeOnProfilePage()
        {
            throw new PendingStepException();
        }

        [When(@"I add duplicate India\.<University>,B\.Tech,IT,<Graduation Year> details")]
        public void WhenIAddDuplicateIndia_UniversityB_TechITGraduationYearDetails()
        {
            throw new PendingStepException();
        }

        [Then(@"education details should  not be able to see on profile page and <error message> should be seen")]
        public void ThenEducationDetailsShouldNotBeAbleToSeeOnProfilePageAndErrorMessageShouldBeSeen()
        {
            throw new PendingStepException();
        }

        [When(@"I edit Australia\.<University>,B\.Tech,IT,<Graduation Year> details")]
        public void WhenIEditAustralia_UniversityB_TechITGraduationYearDetails()
        {
            throw new PendingStepException();
        }

        [When(@"I delete education details")]
        public void WhenIDeleteEducationDetails()
        {
            throw new PendingStepException();
        }

        [Then(@"education details should  not be  able to see on profile page")]
        public void ThenEducationDetailsShouldNotBeAbleToSeeOnProfilePage()
        {
            throw new PendingStepException();
        }
    }
}
