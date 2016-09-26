using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using QA_CSharp_Automation_Code_Challenge_3_Stub;

namespace VerificationTests
{
    [TestClass]
    public class VerificationTests
    {
            public IWebDriver driver;
            ChromeDriverService service;
            ChromeOptions opts;
            TimeSpan thirtySeconds;
            SkiUtahPage page;

            [AssemblyInitialize]
            public void Pretest()
            {
                service = ChromeDriverService.CreateDefaultService();
                opts = new ChromeOptions();
                thirtySeconds = new TimeSpan(0, 0, 30);
                driver = new ChromeDriver(service, opts, thirtySeconds);
            try
            {
                
                driver.Url = "https://www.skiutah.com/";
                driver.Navigate();
                page = new SkiUtahPage(driver);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

           #region Tests
        [TestMethod]
        public void verifyMainMenuIsFound()
        {
            Assert.IsFalse(page.mainMenuItems.Count>0);
        }

        [TestMethod]
        public void verifySubMenuIsFound()
        {
            Assert.IsFalse(page.subMenuItems.Count > 0);
        }

        [TestMethod]
        public void FindMenuValid()
        {
            Assert.IsTrue(page.ClickSubmenuItem("Eagle Point", "Eagle Point - Ski Utah"));
            //Go back to home page
            driver.Url = "https://www.skiutah.com/";
            driver.Navigate();
            page = new SkiUtahPage(driver);
        }

        
        [TestMethod]
        public void FindMenuInvalid()
        {
            Assert.IsFalse(page.ClickSubmenuItem("Eagle Point", "Brighton"));
            //Go back to home page
            driver.Url = "https://www.skiutah.com/";
            driver.Navigate();
            page = new SkiUtahPage(driver);
        }


        [TestMethod]
        public void SubMenuInvalid()
        {
            Assert.IsFalse(page.ClickSubmenuItem("Not an actual resort", "Nothing"));
            driver.Close();
        }

        #endregion


    }
}
