using Marsprofile.Pages;
using static Marsprofile.Pages.CommonMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using RelevantCodes.ExtentReports;
using TechTalk.SpecFlow;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Marsprofile.Utilities
   

{
    [Binding]
    public class Testfeatures : Driver
    {

       [BeforeScenario]
        public void SetUp()
        {
            //initialise the browser
            Initialize();

           Thread.Sleep(1000);
            //Launch page 
            
           // NavigateUrl();

            //login steps
            Login loginobj=new Login();
            loginobj.LoginSteps();
        }

        [Test]
        public void TearDown()
        {
            Thread.Sleep(5000);
            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));

            //end test. (Reports)
           CommonMethods.Extent.EndTest(CommonMethods.test);

            //calling Flush writes everything to the log file(Reports)
            CommonMethods.Extent.Flush();

            //Close the browser
            Close();
        }
    }
}




//    //  [TestFixture]
//    public class Testfeatures : Driver
//    {
//        //ExtentReports extent;
//        //ExtentTest test;
//        //IWebDriver driver;

//        // [SetUp]
//        public void setup()
//        {
//            Initialize();
//            Thread.Sleep(2000);
//            Login loginPageobj = new Login();
//            loginPageobj.LoginSteps();
//            //string pth = System.Reflection.Assembly.GetExecutingAssembly().Location;
//            //string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
//            //string projectPath = new Uri(actualPath).LocalPath;
//            //extent = new ExtentReports(projectPath);
//            //string reportPath = extent + "Reports\\ExtentScreenshot.html";
//            //extent = new ExtentReports(reportPath);
//        }


//    }
//}



//          ////  [Test]
//          //  public void CaptureScreenshot ()
//          //  {
//          //      //test = extent.StartTest("CaptureScreenshot");
//          //      //test.Log(LogStatus.Info,"Screenshot");
//          //  }

//          //  [TearDown]
//          //  public void GetResult()
//          //  {
//                //var status = TestContext.CurrentContext.Result.Outcome.Status;
//                //var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace+ "</pre>";
//                //var errorMessage = TestContext.CurrentContext.Result.Message;

//                //if (status == NUnit.Framework.Interfaces.TestStatus.Failed) ;
//                //{
//    string screenshotPath = CommonMethods.Capture(driver, "ScreenshotName");
//    test.Log(LogStatus.Fail, stackTrace + errorMessage);
//    test.Log(LogStatus.Fail,"Snapshot below:" + test.AddScreenCapture(screenshotPath));

//}
//driver.Close();
//extent.EndTest(test);
//extent.Flush();
//extent.Close();


//}

//}
//}

//[BeforeTestRun]

//public static void BeforeTestRun()
//{
//    ExtentReports();
//}

//private static void ExtentReports()
//{
//    throw new NotImplementedException();
//}

//[BeforeFeature]

//public static void BeforeFeature(FeatureContext contex)
//{
//    test = Extent.StartTest(context.FeatureInfo.Title);

//}











