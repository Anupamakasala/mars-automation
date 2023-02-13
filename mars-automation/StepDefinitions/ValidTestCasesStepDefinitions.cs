﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
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

        [Given(@"user clicks on Share Skill button")]
        public void GivenUserClicksOnShareSkillButton()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.ClickOnShareSkillButton(driver);
        }

        [Given(@"user populates '([^']*)' fields")]
        public void GivenUserPopulatesAllMandatoryFields(string p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9, string p10, string p11, string p12)
        {
            ShareSkillPage shareSkillPageObj = new ShareSkillPage();
            shareSkillPageObj.EnterATitle(driver, p0);
            shareSkillPageObj.EnterADescription(driver, p1);
            shareSkillPageObj.SelectACategory(driver, p2);
            shareSkillPageObj.SelectASubCategory(driver, p3);
            shareSkillPageObj.EnterATag(driver, p4);
            shareSkillPageObj.SelectServiceType(driver, p5);
            shareSkillPageObj.LocationType(driver, p6);
            shareSkillPageObj.EnterAvailableDays(driver, p7, p8);
            shareSkillPageObj.SkillTrade(driver, p9, p10, p11);
            shareSkillPageObj.ActiveType(driver, p12);

        }

        [When(@"user clicks on save button")]
        public void WhenUserClicksOnSaveButton()
        {
            ShareSkillPage shareSkillPageObj = new ShareSkillPage();
            shareSkillPageObj.ClickOnSaveButton(driver);
        }

        [Then(@"listings details are saved")]
        public void ThenListingDetailsAreSaved(string p0)
        {

            ManageListingsPage manageListingPageObj = new ManageListingsPage();
            manageListingPageObj.VerifyListings(driver, p0);

        }

        [Given(@"user clicks on Manage Listings tab")]
        public void GivenUserClicksOnManageListingTab(string p0)
        {

            ManageListingsPage manageListingPageObj = new ManageListingsPage();
            manageListingPageObj.VerifyListings(driver, p0);

        }

        [When(@"user clicks on view listings icon")]
        public void WhenUserClicksOnViewListingIcon()
        {

            ManageListingsPage manageListingPageObj = new ManageListingsPage();
            manageListingPageObj.ViewListing(driver);

        }

        [Then(@"listing details are loaded correctly")]
        public void ThenListingDetailsAreLoadedCorrectly(string p0)
        {

            ManageListingsPage manageListingPageObj = new ManageListingsPage();
            manageListingPageObj.VerifyListingTitle(driver, p0);

        }

        [When(@"user clicks on delete listings icon")]
        public void WhenUserClicksOnDeleteListingIcon()
        {

            ManageListingsPage manageListingPageObj = new ManageListingsPage();
            manageListingPageObj.DeleteListing(driver);

        }

        [Then(@"listing details are deleted")]
        public void ThenListingDetailsAreDeleted(string p0)
        {

            ManageListingsPage manageListingPageObj = new ManageListingsPage();
            manageListingPageObj.VerifyListings(driver, p0);

        }
    }
}
