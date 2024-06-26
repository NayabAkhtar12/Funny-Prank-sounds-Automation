﻿using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace Prank_Sound_App.Core
{
    public class TestInitiallize
    {
        public AndroidDriver<IWebElement> driver;
        public ExtentReports Extent;


        public TestInitiallize()
        {
            //    var ExtentSparkReports = new ExtentSparkReporter("D:\\Automation-Projects");
            Extent = new ExtentReports();
            // Extent.AttachReporter(ExtentSparkReports);
        }

        [TestInitialize]
        public void Setup()
        {
            try
            {
                AppiumOptions cap = new AppiumOptions();
                cap.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
                cap.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Galaxy C7");
                cap.AddAdditionalCapability(MobileCapabilityType.Udid, "e7c7d60c");
                cap.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "8.0");
                cap.AddAdditionalCapability("appium:automationName", AutomationName.AndroidUIAutomator2);
                driver = new AndroidDriver<IWebElement>(new Uri("   http://192.168.100.5:4723/"), cap, TimeSpan.FromSeconds(180));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to initialize driver: {e.Message}");
                throw;
            }
        }

        [TestCleanup]
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
