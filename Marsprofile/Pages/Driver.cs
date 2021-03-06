using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

#nullable disable

namespace Marsprofile
{
    public class Driver
    {
        //Initialize the browser
        public static IWebDriver driver { get; set; }

        public static void Initialize()
        {
            try
            {
                //Defining the browser
                driver = new ChromeDriver();
                //TurnOnWait();

                //Maximise the window
                driver.Manage().Window.Maximize();
                //TurnOnWait();
                //Thread.Sleep(10000);

                //driver.Navigate().GoToUrl(BaseUrl);

            }
            catch (TimeoutException e)
            {
                
                Console.WriteLine(e);
            }
        }

        public  static string BaseUrl
        {
            get { return Pages.ConstantU.Url; }
        }


        //Implicit Wait
        public static void TurnOnWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7000);

        }

        public static void NavigateUrl()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        //Close the browser
        public static void Close()
        {
            driver.Close();
        }

    }
}
