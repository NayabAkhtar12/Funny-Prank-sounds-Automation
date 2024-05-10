using AventStack.ExtentReports;
using Prank_Sound_App.Core;
using Prank_Sound_App.Pages;

namespace Prank_Sound_App.Test_Class
{
    [TestClass]
    public class Test_Class : TestInitiallize
    {
        AirHorn AirHorn;
        [TestMethod]
        public void AirHornSounds()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            AirHorn = new AirHorn(driver, test);
            AirHorn.AirHornSoundTest();
        }

        AnimalSounds AnimalSound;
        //   [TestMethod]
        public void AnimalSounds()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            AnimalSound = new AnimalSounds(driver, test);
            AnimalSound.AnimalSoundTest();
        }

        FartSound FartSound;

        //  [TestMethod]
        public void FartSounds()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            FartSound = new FartSound(driver, test);
            FartSound.FartSoundTest();
        }

        WomenCough WomenCough;
        //  [TestMethod]
        public void WomenCoughSound()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            WomenCough = new WomenCough(driver, test);
            WomenCough.WomenCoughSoundTest();
        }

        ManCough ManCough;
        //  [TestMethod]
        public void MenCoughSound()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            ManCough = new ManCough(driver, test);
            ManCough.MenCoughTest();
        }

        BurpSounds BurpSound;
        //  [TestMethod]
        public void BurpSounds()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            BurpSound = new BurpSounds(driver, test);
            BurpSound.BurpSoundsTest();
        }

        FunnyPolice FunnyPolice;
        [TestMethod]
        public void FunnyPoliceSounds()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            FunnyPolice = new FunnyPolice(driver, test);
            FunnyPolice.FunnyPoliceTest();
        }

        DoorBell DoorBell;
        [TestMethod]
        public void DoorBellSounds()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            DoorBell = new DoorBell(driver, test);
            DoorBell.DoorBellTest();
        }


        CarHorn CarHorn;

        [TestMethod]
        public void CarHornTest()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            CarHorn = new CarHorn(driver, test);
            CarHorn.CarHornTest();
        }

        GunSounds GunSounds;

        [TestMethod]
        public void GunSoundsTest()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            GunSounds = new GunSounds(driver, test);
            GunSounds.GunSoundsTest();
        }

        Breaking Breaking;

        [TestMethod]
        public void BreakingSound()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            Breaking = new Breaking(driver, test);
            Breaking.BreakingSoundTest();
        }

        HairClipper HairClipper;

        [TestMethod]
        public void HairClipperSound()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            HairClipper = new HairClipper(driver, test);
            HairClipper.HairClipperSoundTest();
        }

        HairDryer HairDryer;

        [TestMethod]
        public void HairDryerSound()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            HairDryer = new HairDryer(driver, test);
            HairDryer.HairDryerSoundTest();
        }

        FartSong FartSong;

        [TestMethod]
        public void FartSongSound()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            FartSong = new FartSong(driver, test);
            FartSong.FartSongSoundTest();
        }

        WomenSneeze WomenSneeze;

        [TestMethod]
        public void WomenSneezeSound()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            WomenSneeze = new WomenSneeze(driver, test);
            WomenSneeze.WomenSneezeSoundTest();
        }

        ManSneeze ManSneeze;

        [TestMethod]
        public void ManSneezeSound()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            ManSneeze = new ManSneeze(driver, test);
            ManSneeze.ManSneezeSoundTest();
        }

        BabySneeze BabySneeze;

        [TestMethod]
        public void BabySneezeSound()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            BabySneeze = new BabySneeze(driver, test);
            BabySneeze.BabySneezeSoundTest();
        }

        SleighBell SleighBell;

        [TestMethod]
        public void SleighBellSound()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            SleighBell = new SleighBell(driver, test);
            SleighBell.SleighBellSoundTest();
        }

        SantaClaus SantaClaus;

        [TestMethod]
        public void SantaClausSound()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            SantaClaus = new SantaClaus(driver, test);
            SantaClaus.SantaClausTest();
        }

        OtherSounds OtherSound;

        [TestMethod]
        public void OtherSounds()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            OtherSound = new OtherSounds(driver, test);
            OtherSound.OtherSoundsTest();
        }

    }
}
