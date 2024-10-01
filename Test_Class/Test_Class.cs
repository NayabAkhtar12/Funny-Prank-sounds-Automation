using AventStack.ExtentReports;
using NUnit.Framework;
using Prank_Sound_App.Core;
using Prank_Sound_App.Pages;

namespace Prank_Sound_App.Test_Class
{
    [TestFixture]
    public class Test_Class : TestInitiallize
    {
        AirHorn? AirHorn;
        [Test, Order(1)]
        public void AirHornSounds()
        {
            ExtentTest test = Extent.CreateTest("AirHornSounds Report");
            AirHorn = new AirHorn(driver, test);
            AirHorn.AirHornSoundTest();
        }

        AnimalSounds? AnimalSound;
        [Test, Order(2)]
        public void AnimalSounds()
        {
            ExtentTest test = Extent.CreateTest("AnimalSounds Report");
            AnimalSound = new AnimalSounds(driver, test);
            AnimalSound.AnimalSoundTest();
        }

        FartSound? FartSound;

        [Test, Order(3)]
        public void FartSounds()
        {
            ExtentTest test = Extent.CreateTest("FartSounds Report");
            FartSound = new FartSound(driver, test);
            FartSound.FartSoundTest();
        }

        WomenCough? WomenCough;
        [Test, Order(4)]
        public void WomenCoughSound()
        {
            ExtentTest test = Extent.CreateTest("WomenCoughSound Report");
            WomenCough = new WomenCough(driver, test);
            WomenCough.WomenCoughSoundTest();
        }

        ManCough? ManCough;
        [Test, Order(5)]
        public void MenCoughSound()
        {
            ExtentTest test = Extent.CreateTest("MenCoughSound Report");
            ManCough = new ManCough(driver, test);
            ManCough.MannCoughSoundTest();
        }

        BurpSounds? BurpSound;
        [Test, Order(6)]
        public void BurpSounds()
        {
            ExtentTest test = Extent.CreateTest("BurpSounds Report");
            BurpSound = new BurpSounds(driver, test);
            BurpSound.BurpSoundTest();
        }

        FunnyPolice? FunnyPolice;
        [Test, Order(7)]
        public void FunnyPoliceSounds()
        {
            ExtentTest test = Extent.CreateTest("FunnyPoliceSounds Report");
            FunnyPolice = new FunnyPolice(driver, test);
            FunnyPolice.FunnyPoliceTest();
        }

        DoorBell? DoorBell;
        [Test, Order(8)]
        public void DoorBellSounds()
        {
            ExtentTest test = Extent.CreateTest("DoorBellSounds Report");
            DoorBell = new DoorBell(driver, test);
            DoorBell.DoorBellSoundTest();
        }


        CarHorn? CarHorn;

        [Test, Order(9)]
        public void CarHornTest()
        {
            ExtentTest test = Extent.CreateTest("CarHornTest Report");
            CarHorn = new CarHorn(driver, test);
            CarHorn.CarHornSoundTest();
        }

        GunSounds GunSounds;

        [Test, Order(10)]
        public void GunSoundsTest()
        {
            ExtentTest test = Extent.CreateTest("GunSoundsTest Report");
            GunSounds = new GunSounds(driver, test);
            GunSounds.GunSoundTest();
        }

        Breaking? Breaking;

        [Test, Order(11)]
        public void BreakingSound()
        {
            ExtentTest test = Extent.CreateTest("BreakingSound Report");
            Breaking = new Breaking(driver, test);
            Breaking.BreakingSoundTest();
        }

        HairClipper? HairClipper;

        [Test, Order(12)]
        public void HairClipperSound()
        {
            ExtentTest test = Extent.CreateTest("HairClipperSound Report");
            HairClipper = new HairClipper(driver, test);
            HairClipper.HairClipperSoundTest();
        }

        HairDryer? HairDryer;

        [Test, Order(13)]
        public void HairDryerSound()
        {
            ExtentTest test = Extent.CreateTest("HairDryerSound  Report");
            HairDryer = new HairDryer(driver, test);
            HairDryer.HairDryerSoundTest();
        }

        FartSong? FartSong;

        [Test, Order(14)]
        public void FartSongSound()
        {
            ExtentTest test = Extent.CreateTest("FartSongSound Report");
            FartSong = new FartSong(driver, test);
            FartSong.FartSongSoundTest();
        }

        WomenSneeze? WomenSneeze;

        [Test, Order(15)]
        public void WomenSneezeSound()
        {
            ExtentTest test = Extent.CreateTest("WomenSneezeSound Report");
            WomenSneeze = new WomenSneeze(driver, test);
            WomenSneeze.WomenSneezeSoundTest();
        }

        ManSneeze? ManSneeze;

        [Test, Order(16)]
        public void ManSneezeSound()
        {
            ExtentTest test = Extent.CreateTest("ManSneezeSound Report");
            ManSneeze = new ManSneeze(driver, test);
            ManSneeze.MenSneezeSoundTest();
        }

        BabySneeze? BabySneeze;

        [Test, Order(17)]
        public void BabySneezeSound()
        {
            ExtentTest test = Extent.CreateTest("BabySneezeSound Report");
            BabySneeze = new BabySneeze(driver, test);
            BabySneeze.BabySneezeSoundTest();
        }

        SleighBell? SleighBell;

        [Test, Order(18)]
        public void SleighBellSound()
        {
            ExtentTest test = Extent.CreateTest("SleighBellSound Report");
            SleighBell = new SleighBell(driver, test);
            SleighBell.SleighBellSoundTest();
        }

        SantaClaus? SantaClaus;

        [Test, Order(19)]
        public void SantaClausSound()
        {
            ExtentTest test = Extent.CreateTest("SantaClausSound Report");
            SantaClaus = new SantaClaus(driver, test);
            SantaClaus.SantaClausSoundTest();
        }

        OtherSounds? OtherSound;

        [Test, Order(20)]
        public void OtherSounds()
        {
            ExtentTest test = Extent.CreateTest("OtherSounds Report");
            OtherSound = new OtherSounds(driver, test);
            OtherSound.OtherSoundsTest();
        }

    }
}
