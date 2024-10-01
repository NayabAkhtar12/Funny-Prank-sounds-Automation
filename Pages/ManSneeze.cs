using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class ManSneeze
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        Reusablemethods Reusablemethods;

        //Constructor
        public ManSneeze(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            Reusablemethods = new Reusablemethods(driver, test);

        }

        public void MenSneezeSoundTest1()
        {
            Reusablemethods.ScrollToElementByText("Men Sneeze");
            Test = Extent.CreateTest("Men Sneeze Sound Test");
            try
            {
                // Men Sneeze Menu
                try
                {
                    MenSneezeMenu.Click();
                    Reusablemethods.InterAdHandle();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Men Sneeze Menu", ex);
                }

                // Men Sneeze 1
                try
                {
                    MenSneeze1.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Men Sneeze 1", ex);
                }

                // Men Sneeze 2
                try
                {
                    MenSneeze2.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Men Sneeze 2", ex);
                }

                // Men Sneeze 3
                try
                {
                    MenSneeze3.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Men Sneeze 3", ex);
                }
                driver.Navigate().Back();

            }
            catch (Exception ex)
            {
                Reusablemethods.HandleException("Men Sneeze Sound Test", ex);
            }
        }
        public void MenSneezeSoundTest()
        {
            // Scroll to Men Sneeze menu
            Reusablemethods.ScrollToElementByText("Men Sneeze");

            // Click on the Men Sneeze menu and handle ads
            Reusablemethods.ClickwithAd(MenSneezeMenu, "MenSneezeMenu");

            // Men Sneeze 1
            Reusablemethods.ClickwithAd(MenSneeze1, "MenSneeze1");
            Reusablemethods.SoundPlayScreen("Men Sneeze 1");

            // Men Sneeze 2
            Reusablemethods.ClickwithAd(MenSneeze2, "MenSneeze2");
            Reusablemethods.SoundPlayScreen("Men Sneeze 2");

            // Men Sneeze 3
            Reusablemethods.ClickwithAd(MenSneeze3, "MenSneeze3");
            Reusablemethods.SoundPlayScreen("Men Sneeze 3 and back to main screen");

            // Navigate back to the main screen
            Reusablemethods.NavigateBack("Main screen Back");
        }

        IWebElement? MenSneezeMenu => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Men Sneeze\"]"), "MenSneezeMenu");

        IWebElement? MenSneeze1 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Man Sneeze 1\"]"), "MenSneeze1");

        IWebElement? MenSneeze2 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Man Sneeze 2\"]"), "MenSneeze2");

        IWebElement? MenSneeze3 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Man Sneeze 3\"]"), "MenSneeze3");

        IWebElement? MenSneeze4 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Man Sneeze 4\"]"), "MenSneeze4");

        IWebElement? MenSneeze5 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Man Sneeze 5\"]"), "MenSneeze5");

        IWebElement? VolumeUp => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus"), "VolumeUp");

        IWebElement? VolumeDown => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus"), "VolumeDown");

        IWebElement? Loop => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck"), "Loop");

        IWebElement? PlayButton => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]"), "PlayButton");

        IWebElement? AddtoBookmark => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite"), "AddtoBookmark");


    }
}
