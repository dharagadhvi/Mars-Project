using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marsprofile.Pages
{
    public class ConstantU
    {
   
       //Base Url
        public static string Url = "http://localhost:5000";

        public static string CurrantPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));

        //ScreenshotPath
        public static string ScreenshotPath = CurrantPath + @"Marsprofile\Reports\Screenshots";

        //ExtentReportsPath
        public static string ReportsPath = CurrantPath + @"Marsprofile\Reports\Test.html";

        //ReportXML Path
        public static string ReportXMLPath = CurrantPath + @"Marsprofile\Reports\ReportXMLFile.xml";

    }
}

