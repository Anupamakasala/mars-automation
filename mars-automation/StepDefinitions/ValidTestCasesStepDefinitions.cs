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
    public class ValidTestCasesStepDefinitions : CommonDriver
    {
        private string availabilityType;

        [Given(@"a valid user logs into the application")]
        public void GivenAValidUserLogsIntoTheApplication()
        {
            // Open Chrome browser
            ChromeDriver driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }

        [Given(@"user navigates to the Profile tab")]
        public void GivenUserNavigatesToTheProfileTab()
        {
            ProfilePage profilePageObj= new ProfilePage();
            profilePageObj.VerifyProfilePage(driver);
        }

        [When(@"clicks on the pencil icon next to Availability field")]
        public void WhenClicksOnThePencilIconNextToAvailabilityField()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.ClickOnPencilIcon(driver);
        }

        [When(@"clicks on the pencil icon next to Hours field")]
        public void WhenClicksOnThePencilIconNextToHoursField()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.ClickOnPencilIcon(driver);
        }

        [When(@"clicks on the pencil icon next to Earn Target field")]
        public void WhenClicksOnThePencilIconNextToEarnTargetField()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.ClickOnPencilIcon(driver);
        }

        [When(@"user selects '([^']*)'")]
        public void WhenUserSelects(string p0)
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.SelectAvailabilityType(driver, p0);
        }

        [Then(@"availability field is updated")]
        public void ThenAvailabilityFieldIsUpdated()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.VerifyAvailabilityType(driver, availabilityType);
        }
    }
}
