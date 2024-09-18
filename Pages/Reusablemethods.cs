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

        public void HandleInterstitialAdNew()
        {
            Thread.Sleep(35000);

            try
            {
                By closeButton = By.XPath("//android.widget.TextView[@text='Close' or @text='Cerrar' or @text='Fechar' or @text='закрыть' or @text='CLOSE' or @text='ਬੰਦ ਕਰੋ' ]");
                By crossButton = By.XPath("//android.widget.Button | //android.widget.ImageView[@content-desc='Ad closed']");
                By handleAdButton = By.XPath("//android.widget.Button | //android.widget.ImageView[@content-desc='Ad closed'] | //android.widget.TextView[@text='Close' or @text='Cerrar' or @text='Fechar' or @text='закрыть' or @text='CLOSE' or @text='ਬੰਦ ਕਰੋ' ]");

                // Attempt to find and click the ad close button
                IWebElement adButton = driver.FindElement(handleAdButton);

                if (adButton != null)
                {
                    adButton.Click();
                }
                else
                {
                    Console.WriteLine("No Interstitial Ad found");
                }
            }
            catch (Exception ex)
            {
                HandleException("99 names inter Ad", ex);
            }
        }


        public void InterAdHandleBackUp()
        {
            Thread.Sleep(40000);
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
                HandleException("  inter Ad", ex);
            }
        }

        public void InterAdHandle()
        {
            Thread.Sleep(35000);
            try
            {
                By handleAdButton = By.XPath(
            "//android.widget.Button | " +
            "//android.widget.ImageView[@content-desc='Ad closed'] | " +
            "//android.widget.TextView[@text='Close' or @text='Cerrar' or @text='Fechar' or @text='закрыть' or @text='CLOSE' or @text='ਬੰਦ ਕਰੋ']"
        );

                // By closeButton = By.XPath("//android.widget.TextView[@text='Close' or @text='Cerrar' or @text='Fechar' or @text='закрыть' or @text='CLOSE' or @text='ਬੰਦ ਕਰੋ' ]");
                // By crossButton = By.XPath("//android.widget.Button | //android.widget.ImageView[@content-desc='Ad closed']");
                //    By handleAdButton = By.XPath("//android.widget.Button | //android.widget.ImageView[@content-desc='Ad closed'] | //android.widget.TextView[@text='Close' or @text='Cerrar' or @text='Fechar' or @text='закрыть' or @text='CLOSE' or @text='ਬੰਦ ਕਰੋ' ]");

                IWebElement adButton = null;

                // Check if any of the locators are present
                if (IsElementPresent(handleAdButton))
                {
                    adButton = driver.FindElement(handleAdButton);
                    if (adButton != null)
                    {
                        adButton.Click();
                    }
                    else
                    {
                        Console.WriteLine("No Interstitial Ad found");
                    }
                }
                else
                {
                    Console.WriteLine("No ad close button found");
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("No ad close button found");
            }
            catch (Exception ex)
            {
                HandleException("inter Ad", ex);
            }
        }

        // Helper method to check if an element is present
        private bool IsElementPresent(By locator)
        {
            try
            {
                return driver.FindElements(locator).Count > 0;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void SoundPlayScreen()
        {
            try
            {
                PlayButton.Click();

            }
            catch (Exception ex)
            {
                HandleException("Fart Sound 1 Play Button", ex);
            }
            try
            {
                AddtoBookmark.Click();

            }
            catch (Exception ex)
            {
                HandleException("Add to Bookmark", ex);
            }

            try
            {
                driver.Navigate().Back();
            }
            catch (Exception ex)
            {
                HandleException("Fart Sound 1 Back Navigation", ex);
            }
        }
        IWebElement Continue => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/getStarted");
        IWebElement PlayButton => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]");
        IWebElement AddtoBookmark => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite");


    }
}
