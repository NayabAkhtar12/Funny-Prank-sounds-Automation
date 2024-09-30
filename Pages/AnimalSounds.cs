using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class AnimalSounds
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        Reusablemethods Reusablemethods;

        //Constructor
        public AnimalSounds(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            Reusablemethods = new Reusablemethods(driver, test);

        }

        public void AnimalSoundTest1()
        {
            Reusablemethods.ScrollToElementByText("Animal Sounds");

            ExtentTest test = Extent.CreateTest("NearBy Places Report 1");
            try
            {
                try
                {
                    AnimalSoundMenu.Click();

                    Reusablemethods.InterAdHandle();

                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Air Horn Menu", ex);
                }



                try
                {
                    AnimalSound1.Click();

                    Reusablemethods.InterAdHandle();

                    //  Loop.Click();

                    PlayButton.Click();
                    Thread.Sleep(3000);
                    // VolumeUp.Click();
                    //   VolumeDown.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                    //  Thread.Sleep(3000);


                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("AnimalSound1", ex);
                }

                //AnimalSound2

                try
                {
                    AnimalSound2.Click();

                    Reusablemethods.InterAdHandle();

                    PlayButton.Click();
                    Thread.Sleep(3000);
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("AnimalSound2", ex);
                }

                //AnimalSound3

                try
                {
                    AnimalSound3.Click();

                    Reusablemethods.InterAdHandle();

                    PlayButton.Click();
                    Thread.Sleep(3000);
                    AddtoBookmark.Click();
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("AnimalSound 3", ex);
                }


                //AnimalSound4


                try
                {
                    AnimalSound4.Click();

                    Reusablemethods.InterAdHandle();

                    PlayButton.Click();
                    Thread.Sleep(3000);
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("AnimalSound4", ex);
                }

            }
            catch (Exception ex)
            {
                Reusablemethods.HandleException("Air Horn ", ex);
            }

        }
        public void AnimalSoundTest()
        {
            // Animal Sound Menu
            Reusablemethods.ScrollToElementByText("Animal Sounds");
            Reusablemethods.ClickwithAd(AnimalSoundMenu, "AnimalSoundMenu");

            // Animal Sound 1
            Reusablemethods.ClickwithAd(AnimalSound1, "AnimalSound1");
            Reusablemethods.SoundPlayScreen("Animal Sound 1");

            // Animal Sound 2
            Reusablemethods.ClickwithAd(AnimalSound2, "AnimalSound2");
            Reusablemethods.SoundPlayScreen("Animal Sound 2");

            // Animal Sound 3
            Reusablemethods.ClickwithAd(AnimalSound3, "AnimalSound3");
            Reusablemethods.SoundPlayScreen("Animal Sound 3");

            // Animal Sound 4
            Reusablemethods.ClickwithAd(AnimalSound4, "AnimalSound4");
            Reusablemethods.SoundPlayScreen("Animal Sound 4 and back to Animal Sounds main screen");
            Reusablemethods.NavigateBack("Main screen Back");
        }


        IWebElement AnimalSoundMenu => driver.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Animal Sounds\"]"));

        IWebElement AddtoBookmark => driver.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite"));

        IWebElement BackButton1 => driver.FindElementByAccessibilityId("Navigate up");
        IWebElement VolumeUp => driver.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus"));
        IWebElement VolumeDown => driver.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus"));
        IWebElement Loop => driver.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck"));
        IWebElement PlayButton => driver.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]"));

        IWebElement AnimalSound1 => driver.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]"));
        IWebElement AnimalSound2 => driver.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Lion\"]"));
        IWebElement AnimalSound3 => driver.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Monkey\"]"));
        IWebElement AnimalSound4 => driver.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Mouse\"]"));
        IWebElement AnimalSound5 => driver.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Snake\"]"));
        IWebElement AnimalSound6 => driver.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Chicken\"]"));
        IWebElement AnimalSound7 => driver.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Dog\"]"));
        IWebElement AnimalSound8 => driver.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Cat\"]"));
        IWebElement AnimalSound9 => driver.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Wolf\"]"));
        IWebElement AnimalSound10 => driver.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Horse\"]"));
        IWebElement AnimalSound11 => driver.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Frog\"]"));
        IWebElement AnimalSound12 => driver.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Duck\"]"));
        IWebElement AnimalSound13 => driver.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Bird\"]"));




    }
}
