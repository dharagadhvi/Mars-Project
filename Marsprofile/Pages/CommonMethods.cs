using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelevantCodes.ExtentReports;
#nullable disable


namespace Marsprofile.Pages
{
    public class CommonMethods
    {
        //Screenshots
        #region screenshots
        public class SaveScreenShotClass
        {
            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
            {
                var folderLocation = (ConstantU.ScreenshotPath);

                if (!System.IO.Directory.Exists(folderLocation))
                {
                    System.IO.Directory.CreateDirectory(folderLocation);
                }

                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                var fileName = new StringBuilder(folderLocation);

                fileName.Append(ScreenShotFileName);
                fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
                //fileName.Append(DateTime.Now.ToString("dd-mm-yyyym_ss"));
                fileName.Append(".jpeg");
                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Jpeg);
                return fileName.ToString();
            }

            //internal static string SaveScreenshot(object driver, string v)
            //{
            //    throw new NotImplementedException();
            //}
        }
        #endregion

        //ExtentReports
        #region reports

        public static ExtentTest test;
        public static ExtentReports Extent;


        public static void ExtentReports()
        {
            Extent = new ExtentReports(ConstantU.ReportsPath, true, DisplayOrder.NewestFirst);
            Extent.LoadConfig(ConstantU.ReportXMLPath);
        }

        #endregion
    
        





    }
}
