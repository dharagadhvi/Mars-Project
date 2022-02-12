using System;
using TechTalk.SpecFlow;

namespace Marsprofile
{
    [Binding]
    public class SkillStepDefinitions
    {
        [Given(@"I navigate to profile page")]
        public void GivenINavigateToProfilePage()
        {
            throw new PendingStepException();
        }

        [When(@"I add Customer Service and Intermediatedetails")]
        public void WhenIAddCustomerServiceAndIntermediatedetails()
        {
            throw new PendingStepException();
        }

        [Then(@"Profile details should be able to see on profile page")]
        public void ThenProfileDetailsShouldBeAbleToSeeOnProfilePage()
        {
            throw new PendingStepException();
        }

        [When(@"I add duplicate Customer Service and <Level>details")]
        public void WhenIAddDuplicateCustomerServiceAndLevelDetails()
        {
            throw new PendingStepException();
        }

        [Then(@"Profile details should  not be able to see on profile page and This skill is alreday exist in your skill List should be seen")]
        public void ThenProfileDetailsShouldNotBeAbleToSeeOnProfilePageAndThisSkillIsAlredayExistInYourSkillListShouldBeSeen()
        {
            throw new PendingStepException();
        }

        [When(@"I edit Customer Service and Excellentdetails")]
        public void WhenIEditCustomerServiceAndExcellentdetails()
        {
            throw new PendingStepException();
        }

        [When(@"I delete skilldetails")]
        public void WhenIDeleteSkilldetails()
        {
            throw new PendingStepException();
        }

        [Then(@"Profile details should not be able to see on profile page")]
        public void ThenProfileDetailsShouldNotBeAbleToSeeOnProfilePage()
        {
            throw new PendingStepException();
        }
    }
}
