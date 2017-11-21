using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using RubyOnRailsUsingSeleniumWebDriver.Initialization;

namespace RubyOnRailsUsingSeleniumWebDriver
{
    [TestClass]
    public class CoupaHomePage : AssemblySetUp
    {
        [TestMethod]
        public void CoupaHomePage_SolutionsPage()
        {
            TestContext.WriteLine("Launch Coupa Home Page");
            SeleniumDriver.Navigate("https://www.coupa.com/");

            TestContext.WriteLine("Navigate to Solutions Link");
            var solutionsLink = SeleniumDriver.Driver.FindElement(By.XPath("//a[contains(@href,'solutions')]"));
            solutionsLink.SendKeys(Keys.Enter);

            TestContext.WriteLine("Verify expected text on Solution Page");
            string expectedText = "SPEND MANAGEMENT SOLUTIONS THAT WILL CHANGE YOUR BUSINESS";
            var textOnWebElement = SeleniumDriver.Driver.FindElement(By.TagName("h1"));
            Assert.AreEqual(textOnWebElement.Text, expectedText);
            textOnWebElement.Text.Equals(expectedText, StringComparison.OrdinalIgnoreCase).Should().BeTrue();
            expectedText.Should().Be(textOnWebElement.Text);
        }
    }
}
