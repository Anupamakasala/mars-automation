using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mars_automation.Pages;
using mars_automation.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace mars_automation.StepDefinitions
{
    [Binding]
    public class ValidTestCasesStepDefinitions
    {

        // open chrome browser
        ChromeDriver driver = new ChromeDriver();

        // page object creation
        LoginPage loginPageObj = new LoginPage();
        ProfilePage profilePageObj = new ProfilePage();

        private string availabilityType;

        [Given(@"a valid user logs into the application")]
        public void GivenAValidUserLogsIntoTheApplication()
        {

            // Login page object initialization and definition
            loginPageObj.LoginSteps(driver);
        }

        [Given(@"user navigates to the Profile tab")]
        public void GivenUserNavigatesToTheProfileTab()
        {
            profilePageObj.VerifyProfilePage(driver);
        }

        [When(@"clicks on the pencil icon next to Availability field")]
        public void WhenClicksOnThePencilIconNextToAvailabilityField()
        {
            profilePageObj.ClickOnPencilIcon(driver);
        }

        [When(@"clicks on the pencil icon next to Hours field")]
        public void WhenClicksOnThePencilIconNextToHoursField()
        {
            profilePageObj.ClickOnPencilIcon(driver);
        }

        [When(@"clicks on the pencil icon next to Earn Target field")]
        public void WhenClicksOnThePencilIconNextToEarnTargetField()
        {
            profilePageObj.ClickOnPencilIcon(driver);
        }

        [When(@"user selects availability '([^']*)'")]
        public void WhenUserSelectsAvailability(string p0)
        {
            profilePageObj.SelectAvailabilityType(driver, p0);
        }

        [Then(@"availability field is updated")]
        public void ThenAvailabilityFieldIsUpdated()
        {
            profilePageObj.VerifyAvailabilityType(driver, availabilityType);
            driver.Quit();
        }
    }
}
