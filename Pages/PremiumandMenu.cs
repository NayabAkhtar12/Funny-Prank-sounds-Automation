using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class PremiumandMenu
    {
        private AppiumDriver<AndroidElement> driver;
        ExtentReports Extent = new ExtentReports();
        Reusablemethods ReusableMethods;
        //private WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Constructor
        public PremiumandMenu(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            ReusableMethods = new Reusablemethods(driver, test);
        }


        public void PremiumandMenuMethod()
        {
            ReusableMethods.ElementClick(Menu, "Menu");
            Thread.Sleep(3000);
            ReusableMethods.ElementClick(PrivacyPolicy, "PrivacyPolicy");
            Thread.Sleep(7000);
            ReusableMethods.NavigateBack("Back");

            Thread.Sleep(1000);
            ReusableMethods.ElementClick(MoreApps, "MoreApps");
            ReusableMethods.NavigateBack("Back");


            Thread.Sleep(1000);
            ReusableMethods.ElementClick(RateUs, "RateUs");
            Thread.Sleep(3000);
            ReusableMethods.NavigateBack("Back");

            Thread.Sleep(1000);
            ReusableMethods.ElementClick(ExitApp, "ExitApp");
            ReusableMethods.ElementClick(No, "No");
            ReusableMethods.NavigateBack("Back");

        }

        public IWebElement? Pro => ReusableMethods.FindElement(By.Id("com.holyquran.alquran.majeed.qibla.prayertimes.tasbeeh.hisnulmuslim:id/ivPurchaseBtn"), "Pro");

        public IWebElement? Menu => ReusableMethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/menuBtn"), "Menu");

        public IWebElement? PrivacyPolicy => ReusableMethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/titleprivacy"), "PrivacyPolicy");

        public IWebElement? MoreApps => ReusableMethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/moreappsBtn"), "MoreApps");

        public IWebElement? RateUs => ReusableMethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/titlerate"), "RateUs");

        public IWebElement? ExitApp => ReusableMethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/exitBtn"), "ExitApp");

        public IWebElement? Yes => ReusableMethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/yes"), "Yes");  // No XPath provided, please update if necessary

        public IWebElement? No => ReusableMethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/no"), "No");



    }
}
