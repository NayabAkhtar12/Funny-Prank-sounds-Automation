using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class FartSound
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        Reusablemethods Reusablemethods;

        //Constructor
        public FartSound(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            Reusablemethods = new Reusablemethods(driver, test);

        }

        public void FartSoundTest1()
        {


            ExtentTest test = Extent.CreateTest("Fart Sound Test");
            try
            {
                try
                {
                    //   Reusablemethods.Prank2ndSession();
                    Reusablemethods.ScrollToElementByText("Fart Sound");
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Fart Sound Menu", ex);
                }
                // FartSoundMenu
                try
                {
                    FartSoundMenu.Click();
                    Reusablemethods.InterAdHandle();

                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Fart Sound Menu Ad", ex);
                }

                // Fart Sound 1
                try
                {
                    try
                    {
                        FartSound1.Click();

                        Reusablemethods.InterAdHandle();
                    }
                    catch (Exception ex)
                    {
                        Reusablemethods.HandleException("Fart Sound 1 Ad ", ex);
                    }

                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Fart Sound 1", ex);
                }
                //Playscreen Actions
                Reusablemethods.SoundPlayScreen("sound play");

                // Fart Sound 2
                try
                {
                    try
                    {
                        FartSound2.Click();
                        Reusablemethods.InterAdHandle();
                    }
                    catch (Exception ex)
                    {
                        Reusablemethods.HandleException("Fart Sound 2 Ad", ex);
                    }

                    //Playscreen Actions
                    Reusablemethods.SoundPlayScreen("sound play");

                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Fart Sound 2", ex);
                }

                // Fart Sound 3
                try
                {
                    try
                    {
                        FartSound3.Click();
                        Reusablemethods.InterAdHandle();

                    }
                    catch (Exception ex)
                    {
                        Reusablemethods.HandleException("Fart Sound 3 Ad", ex);
                    }


                    Reusablemethods.SoundPlayScreen("sound play");

                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Fart Sound 3", ex);
                }

                // Fart Sound 4
                try
                {
                    try
                    {
                        FartSound4.Click();
                        Reusablemethods.InterAdHandle();

                    }
                    catch (Exception ex)
                    {
                        Reusablemethods.HandleException("Fart Sound 4 Ad", ex);
                    }


                    Reusablemethods.SoundPlayScreen("sound play");


                    try
                    {
                        driver.Navigate().Back();
                    }
                    catch (Exception ex)
                    {
                        Reusablemethods.HandleException("Fart Sound  Back Navigation to main screen", ex);
                    }
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Fart Sound 4", ex);
                }
            }
            catch (Exception ex)
            {
                Reusablemethods.HandleException("Fart Sound Test", ex);
            }
        }

        public void FartSoundTest()
        {
            // Start the Fart Sound test
            //  Reusablemethods.ScrollToElementByText("Fart Sound");
            Reusablemethods.ClickwithAd(FartSoundMenu, "FartSoundMenu");

            // Fart Sound 1
            Reusablemethods.ClickwithAd(FartSound1, "FartSound1");
            Reusablemethods.SoundPlayScreen("Fart Sound 1");

            // Fart Sound 2
            Reusablemethods.ClickwithAd(FartSound2, "FartSound2");
            Reusablemethods.SoundPlayScreen("Fart Sound 2");

            // Fart Sound 3
            Reusablemethods.ClickwithAd(FartSound3, "FartSound3");
            Reusablemethods.SoundPlayScreen("Fart Sound 3");

            // Fart Sound 4
            Reusablemethods.ClickwithAd(FartSound4, "FartSound4");
            Reusablemethods.SoundPlayScreen("Fart Sound 4 and back to main screen");

            // Navigate back to the main screen
            Reusablemethods.NavigateBack("Main screen Back");
        }



        public IWebElement? FartSoundMenu => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound\"]"), "FartSoundMenu");
        public IWebElement? FartSound1 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 1\"]"), "FartSound1");
        public IWebElement? FartSound2 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 2\"]"), "FartSound2");
        public IWebElement? FartSound3 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 3\"]"), "FartSound3");
        public IWebElement? FartSound4 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 4\"]"), "FartSound4");
        public IWebElement? FartSound5 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 5\"]"), "FartSound5");
        public IWebElement? FartSound6 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 6\"]"), "FartSound6");
        public IWebElement? FartSound7 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 7\"]"), "FartSound7");
        public IWebElement? FartSound8 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 8\"]"), "FartSound8");
        public IWebElement? FartSound9 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 9\"]"), "FartSound9");
        public IWebElement? FartSound10 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 10\"]"), "FartSound10");
        public IWebElement? FartSound11 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 11\"]"), "FartSound11");
        public IWebElement? FartSound12 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 12\"]"), "FartSound12");
        public IWebElement? FartSound13 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 13\"]"), "FartSound13");
        public IWebElement? FartSound14 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 14\"]"), "FartSound14");
        public IWebElement? FartSound15 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 15\"]"), "FartSound15");
        public IWebElement? FartSound16 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 16\"]"), "FartSound16");
        public IWebElement? FartSound17 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 17\"]"), "FartSound17");

        public IWebElement? AddtoBookmark => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite"), "AddtoBookmark");
        public IWebElement? BackButton1 => Reusablemethods.FindElement(By.Id("Navigate up"), "BackButton1");
        public IWebElement? VolumeUp => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus"), "VolumeUp");
        public IWebElement? VolumeDown => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus"), "VolumeDown");
        public IWebElement? Loop => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck"), "Loop");
        public IWebElement? PlayButton => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]"), "PlayButton");

    }
}
