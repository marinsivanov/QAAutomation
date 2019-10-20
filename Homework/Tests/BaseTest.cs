using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace Homework

{
    [TestFixture]
    public class BaseTest
    {
        public IWebDriver Driver { get; private set; }

        [OneTimeSetUp]
        public void InitializeTests()
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            //var name = TestContext.CurrentContext.Test.Name;
            //var result = TestContext.CurrentContext.Result.Outcome;

            //if (result != ResultState.Success)
            //{
            //    var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
            //    var directory = Directory.GetCurrentDirectory();
            //    var fullPath = Path.GetFullPath("..\\..\\..\\ScreenShots\\");
            //    screenshot.SaveAsFile(fullPath + name + ".png", ScreenshotImageFormat.Png);
            //}

            Driver.Quit();
        }
    }
}
