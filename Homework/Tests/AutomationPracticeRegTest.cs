using Homework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Linq;

namespace Homework
{
    [TestFixture]
    [Category("3. Automationpractice registration page")]
    public class AutomationPracticeRegTest : BaseTest
    {
        private LoginPage _loginPage;
        private HomePage _homePage;

        [SetUp]
        public void ClassInit()
        {
            _loginPage = new LoginPage(Driver);
            _homePage = new HomePage(Driver);
        }
        [Test]
        public void NavigateToRegistrationForm()
        {
            _homePage.NavigateToRegPage(_loginPage);

            _homePage.AssertErrorMessage("zeustest@gmail.com");

        }
        //[Test]
        //public void TestSwitchWindows()
        //{
        //    Driver.Url = "http://toolsqa.com/automation-practice-switch-windows/";
        //    var newTabBtoon = Driver.FindElement(By.XPath("//*[@id='content']/div[1]/div[2]/div/div/div/div/p[5]/button"));
        //    newTabBtoon.Click();
        //    string newTabName = Driver.WindowHandles.Last();
        //    var newTab = Driver.SwitchTo().Window(newTabName);

        //    Assert.AreEqual("Free QA Automation Tools Tutorial for Beginners with Examples", Driver.Title);
        //    newTab.Close();
        //    Assert.IsTrue(Driver.WindowHandles.Count == 1);
        //}
    }
}
