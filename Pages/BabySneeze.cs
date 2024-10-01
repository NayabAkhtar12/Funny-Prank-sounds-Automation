using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class BabySneeze
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        Reusablemethods Reusablemethods;
        //Constructor
        public BabySneeze(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            //this.adHelper = new AdHelperC(driver);
            Reusablemethods = new Reusablemethods(driver, test);

        }

        public void BabySneezeSoundTest1()
        {
            Reusablemethods.ScrollToElementByText("Baby Sneeze");
            ExtentTest test = Extent.CreateTest("Baby Sneeze Sound Test");
            try
            {
                // Baby Sneeze Menu
                try
                {
                    BabySneezeMenu.Click();
                    Reusablemethods.InterAdHandle();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Baby Sneeze Menu", ex);
                }

                // Baby Sneeze 1
                try
                {
                    BabySneeze1.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Baby Sneeze 1", ex);
                }

                // Baby Sneeze 2
                try
                {
                    BabySneeze2.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Baby Sneeze 2", ex);
                }

                // Baby Sneeze 3
                try
                {
                    BabySneeze3.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Baby Sneeze 3", ex);
                }
            }
            catch (Exception ex)
            {
                Reusablemethods.HandleException("Baby Sneeze Sound Test", ex);
            }
        }
        public void BabySneezeSoundTest()
        {
            // Scroll to Baby Sneeze menu
            Reusablemethods.ScrollToElementByText("Baby Sneeze");

            // Click on the Baby Sneeze menu and handle ads
            Reusablemethods.ClickwithAd(BabySneezeMenu, "BabySneezeMenu");

            // Baby Sneeze 1
            Reusablemethods.ClickwithAd(BabySneeze1, "BabySneeze1");
            Reusablemethods.SoundPlayScreen("Baby Sneeze 1");

            // Baby Sneeze 2
            Reusablemethods.ClickwithAd(BabySneeze2, "BabySneeze2");
            Reusablemethods.SoundPlayScreen("Baby Sneeze 2");

            // Baby Sneeze 3
            Reusablemethods.ClickwithAd(BabySneeze3, "BabySneeze3");
            Reusablemethods.SoundPlayScreen("Baby Sneeze 3 and back to main screen");

            // Navigate back to the main screen
            Reusablemethods.NavigateBack("Main screen Back");
        }

        IWebElement? BabySneezeMenu => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Baby Sneeze\"]"), "BabySneezeMenu");

        IWebElement? BabySneeze1 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Baby Sneeze 1\"]"), "BabySneeze1");

        IWebElement? BabySneeze2 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Baby Sneeze 2\"]"), "BabySneeze2");

        IWebElement? BabySneeze3 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Baby Sneeze 3\"]"), "BabySneeze3");

        IWebElement? VolumeUp => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus"), "VolumeUp");

        IWebElement? VolumeDown => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus"), "VolumeDown");

        IWebElement? Loop => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck"), "Loop");

        IWebElement? PlayButton => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]"), "PlayButton");

        IWebElement? AddtoBookmark => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite"), "AddtoBookmark");


    }
}
