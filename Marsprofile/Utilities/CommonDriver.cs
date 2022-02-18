using Marsprofile.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static Marsprofile.Pages.CommonMethods;
using RelevantCodes.ExtentReports;
#nullable disable


namespace Marsprofile.Utilities
{
    [Binding]

    public class CommonDriver : Driver
    {
        //    [BeforeTestRun]

        //    public static void BeforeTestRun()
        //    {
        //        ExtentReports();
        //    }


        //    [BeforeFeature]

        //    public static void BeforeFeature(FeatureContext contex)
        //    {
        //        test = Extent.StartTest(contex.FeatureInfo.Title);

        //    }

        [BeforeScenario]

        //public IWebDriver driver;

        //    public object LogStatus { get; private set; }
        //    public static object Extent { get; private set; }
        //    public IWebDriver Driver { get => driver; set => driver = value; }

        public void SetUp()
        {
            Initialize();
            Thread.Sleep(2000);

            //ExcellibHelper.PopulateInCollection()

            Marsprofile.Pages.Login.LoginSteps(); ;

        }


        [AfterScenario]
        public void TearDown()
        {
            Thread.Sleep(500);
            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));

            // end test. (Reports)
            CommonMethods.Extent.EndTest(CommonMethods.test);

            // calling Flush writes everything to the log file (Reports)
            CommonMethods.Extent.Flush();

            //Close the browser
            driver.Quit();
        }
    }
           
    
}
