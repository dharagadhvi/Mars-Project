using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Marsprofile.Pages
{
    public class LoginPage

    {
        public  void LoginSteps(IWebDriver driver)

        {
            //open web driver

            driver.Manage().Window.Maximize();


            //launch mars portal

            driver.Navigate().GoToUrl("http://localhost:5000/");

            //identify username textbox and enter valid textbox

            try
            {

                IWebElement UserNameTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                UserNameTextBox.SendKeys("dharagadhvi@gmail.com");

                //identify password textbox and enter valid password
                IWebElement PasswordTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                PasswordTextBox.SendKeys("Pass@word123");

                //click on login button
                IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                LoginButton.Click();



                //check if user logeed in successfully

                IWebElement HiDhara = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/div[1]/div[2]/div/span"));

                if (HiDhara.Text == "Hi Dhara")

                {
                    Console.WriteLine("logged in Successfully, test Passed");

                }
                else
                {

                    Console.WriteLine("Login failed,Test Failed");

                }
            }
            catch (Exception ex)
            {
                Assert.Fail("Mars portal login page did not launch", ex.Message);
            }
            
        }
    }
}
    

