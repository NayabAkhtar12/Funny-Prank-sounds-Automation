using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;

namespace Prank_Sound_App.Pages
{
    class Reusablemethods
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        private AdHelperC adHelper;
        TouchAction touchAction;

        //private WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Constructor
        public Reusablemethods(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            this.adHelper = new AdHelperC(driver); // Initialize AdHelper with the correct driver type
            touchAction = new TouchAction(driver);
        }

        public void SplashHandling2ndsessiont()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(Continue)).Click();
            }
            catch (Exception ex)
            {
                HandleException("Clicking Continue", ex);
            }

            InterAdHandle();

        }
        private void HandleCBanner(string context)
        {
            try
            {
                Thread.Sleep(2000); // Optional: Adjust or remove as needed
                adHelper.CBanner();
                // Thread.Sleep(2000); // Optional: Adjust or remove as needed
            }
            catch (Exception ex)
            {
                HandleException($"C Banner not Found on {context}", ex);
            }
        }
        public void InterAdHandle()
        {
            try
            {
                if (adHelper.IsCrossButtonPresent())
                {
                    adHelper.HandleAdCrossButton();
                }

                else if (adHelper.IsCloseButtonPresent())
                    adHelper.HandleAdCloseButton();
                else
                    Console.WriteLine("No Interstial  Ad found");
            }
            catch (Exception ex)
            {
                HandleException("99 names  inter Ad", ex);
            }
        }

        public void HandleException(string action, Exception ex)
        {
            Console.WriteLine($"Exception occurred during {action}: {ex.Message}");
            Test.Log(Status.Fail, $"Test failed during {action} due to: {ex.Message}");
        }

        public void Swipe()
        {
            TouchAction act = new TouchAction(driver);
            act.LongPress(200, 180).Wait(5000).MoveTo(900, 180).Release().Perform();
        }

        public IWebElement ScrollToElementByText(string text)
        {
            return driver.FindElement(MobileBy.AndroidUIAutomator(
                $"new UiScrollable(new UiSelector().scrollable(true)).scrollIntoView(new UiSelector().text(\"{text}\"))"));
        }
        public void WaitForElement(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => element.Displayed);
        }

        public void CBanner()
        {

            //**************Code to close c banner ***********
            try
            {

                var x = 667;
                var y = 850;

                touchAction.Tap(x, y).Perform();

                // new TouchAction(driver)
                //.Tap(PointOption.Point(x, y))
                //.Perform();
                Console.WriteLine("Tap performed successfully at coordinates: (" + x + ", " + y + ")");
            }
            catch (Exception ex)
            {
                HandleException("C Banner nt closeable", ex);
            }
        }

        public void Prank2ndSession()
        {
            Continue.Click();
            Thread.Sleep(4000);
            InterAdHandle();
            Thread.Sleep(6000);

        }
        IWebElement Continue => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/getStarted");
    }
}
