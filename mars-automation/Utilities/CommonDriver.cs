using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mars_automation.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace mars_automation.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;


        // Page object initialization
        LoginPage loginPageObject = new LoginPage();

        [OneTimeSetUp]
        public void LoginActions()
        {
            // open chrome browser
            driver = new ChromeDriver();

            // login page object initialization and definition

            loginPageObject.LoginSteps(driver);

        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();

        }
    }
}
