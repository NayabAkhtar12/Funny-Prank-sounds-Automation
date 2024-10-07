using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace Prank_Sound_App.Core
{
    [TestFixture]
    public class TestInitiallize
    {
        protected AndroidDriver<AndroidElement>? driver;
        public static ExtentReports Extent;
        private static ExtentSparkReporter _reporter;

        static TestInitiallize()
        {
            string reportPath = @"D:\Reports\PrankSoundTestReport.html";
            _reporter = new ExtentSparkReporter(reportPath);
            Extent = new ExtentReports();
            Extent.AttachReporter(_reporter);
        }
        //public TestInitiallize()
        //{
        //    var ExtentSparkReports = new ExtentSparkReporter("D:\\Reports\\PrankReports");
        //    Extent = new ExtentReports();
        //    Extent.AttachReporter(ExtentSparkReports);
        //}

        [SetUp]
        public void Setup()
        {
            try
            {
                AppiumOptions cap = new AppiumOptions();
                cap.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
                cap.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Pixel 5 API 34");
                //    cap.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Vivo Y03");

                //    cap.AddAdditionalCapability(MobileCapabilityType.Udid, "e7c7d60c");
                cap.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "14");
                cap.AddAdditionalCapability("appium:automationName", AutomationName.AndroidUIAutomator2);
                driver = new AndroidDriver<AndroidElement>(new Uri("http://192.168.100.14:4723/"), cap, TimeSpan.FromSeconds(180));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to initialize driver: {e.Message}");
                throw;
            }
        }

        [TearDown]
        public void CleanUp()
        {
            try
            {
                if (driver != null)
                {
                    driver.CloseApp();
                    driver.Quit();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to initialize driver: {e.Message}");
                throw;
            }
            Extent.Flush();

        }
    }
}
