using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace mars_automation.Pages
{
    public class ProfilePage
    {
        public void VerifyProfilePage(IWebDriver driver)
        {

            // navigate to profile page and check if user has logged in Successfully
            IWebElement hiAnupama = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/spana"));

            Assert.That(hiAnupama.Text == "Hi Anupama", "login failed, Test failed");

        }

        public void ClickOnPencilIcon(IWebDriver driver)
        {

            // click on the pencil icon
            IWebElement editAvailability = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            editAvailability.Click();

        }

        public void SelectAvailabilityType(IWebDriver driver, string p0)
        {

            // select a value from the Availability dropdown
            IWebElement selectAvailability = driver.FindElement(By.XPath("//*[@id='account-profile-section\']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));
            selectAvailability.Click();

        }

        public void VerifyAvailabilityType(IWebDriver driver, string availabilityType)
        {

            // assert that Availability field value is updated correctly
            IWebElement getAvailability = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span"));
            Assert.That(getAvailability.Text == availabilityType);

        }

        public void ClickOnShareSkillButton(IWebDriver driver)
        {

            // click on the pencil icon
            IWebElement shareSkillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a"));
            shareSkillButton.Click();

        }
        public void ClickOnManageListingsTab(IWebDriver driver)
        {

            // click on Manage Listings tab
            IWebElement manageListingsTab = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/section[1]/div/a[3]"));
            manageListingsTab.Click();

        }
    }
}
