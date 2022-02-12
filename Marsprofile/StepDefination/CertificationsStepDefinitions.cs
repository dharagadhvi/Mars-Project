using System;
using TechTalk.SpecFlow;

namespace Marsprofile
{
    [Binding]
    public class CertificationsStepDefinitions
    {
        [When(@"I add ITIL,DEF,(.*) details")]
        public void WhenIAddITILDEFDetails(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"I edit ITIL,DEF,(.*) details")]
        public void WhenIEditITILDEFDetails(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"I delete Certificate details")]
        public void WhenIDeleteCertificateDetails()
        {
            throw new PendingStepException();
        }
    }
}
