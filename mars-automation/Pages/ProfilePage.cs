using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mars_automation.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace mars_automation.Pages
{
    public class ProfilePage
    {
        public void VerifyProfilePage(IWebDriver driver)
        {

            // navigate to profile page and check if user has logged in Successfully
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/div[1]/div[2]/div/span", 5);
            IWebElement hiAnupama = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));

            Assert.That(hiAnupama.Text == "Hi Anupama", "login failed, Test failed");

        }

        public void ClickOnPencilIconNextToAvailabilityField(IWebDriver driver)
        {

            // click on the pencil icon next to availability field
            IWebElement editAvailability = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            editAvailability.Click();

        }
        public void ClickOnPencilIconNextToHoursField(IWebDriver driver)
        {

            // click on the pencil icon next to hours field
            IWebElement editAvailability = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
            editAvailability.Click();

        }
        public void ClickOnPencilIconNextToEarnTargetField(IWebDriver driver)
        {

            // click on the pencil icon next to earn target field
            IWebElement editAvailability = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
            editAvailability.Click();

        }

        public void SelectAvailabilityType(IWebDriver driver, string availability)
        {

            // select a value from the Availability dropdown
            IWebElement selectAvailabilityType = driver.FindElement(By.XPath("//*[@id='account-profile-section\']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));
            selectAvailabilityType.Click();

            if (availability == "Part Time")
            {
                //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[2]
                IWebElement partTime = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[2]"));
                partTime.Click();
                Thread.Sleep(5000);

            }


            if (availability == "Full Time")
            {

                IWebElement fullTime = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[3]"));
                fullTime.Click();
                Thread.Sleep(5000);

            }

        }

        public void VerifyAvailabilityType(IWebDriver driver, string availability)
        {
            //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/text()
            // assert that Availability field value is updated correctly
            string getAvailabilityType = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span")).Text;
            Assert.That(getAvailabilityType == availability);

        }

        public void SelectHoursType(IWebDriver driver, string hours)
        {

            // select a value from the Hours dropdown
            IWebElement selectHoursType = driver.FindElement(By.XPath("//*[@id='account-profile-section\']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select"));
            selectHoursType.Click();


            if (hours == "Less than 30hours a week")
            {

                IWebElement lessThan30HoursAWeek = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[2]"));
                lessThan30HoursAWeek.Click();
                Thread.Sleep(5000);

            }

            if (hours == "More than 30hours a week")
            {
                
                IWebElement moreThan30HoursAWeek = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[3]"));
                moreThan30HoursAWeek.Click();
                Thread.Sleep(5000);

            }

            if (hours == "As needed")
            {

                IWebElement asNeeded = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[4]"));
                asNeeded.Click();
                Thread.Sleep(5000);

            }

        }

        public void VerifyHoursType(IWebDriver driver, string hours)
        {

            // assert that Hours field value is updated correctly
            string getHoursType = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span")).Text;
            Assert.That(getHoursType == hours);

        }

        public void SelectEarnTargetType(IWebDriver driver, string earnTarget)
        {

            // select a value from the Earn Target dropdown
            IWebElement selectEarnTargetType = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
            selectEarnTargetType.Click();

            if (earnTarget == "Less than $500 per month")
            {

                IWebElement lessThan500PerMonth = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[2]"));
                lessThan500PerMonth.Click();
                Thread.Sleep(5000);

            }

            if (earnTarget == "Between $500 and $1000 per month")
            {

                IWebElement between500And1000PerMonth = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[3]"));
                between500And1000PerMonth.Click();
                Thread.Sleep(5000);

            }

            if (earnTarget == "More than $1000 per month")
            {

                IWebElement moreThan100PerMonth = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[4]"));
                moreThan100PerMonth.Click();
                Thread.Sleep(5000);

            }

        }

        public void VerifyEarnTargetType(IWebDriver driver, string earnTarget)
        {

            // assert that Earn Target field value is updated correctly
            string getEarnTargetType = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span")).Text;
            Assert.That(getEarnTargetType == earnTarget);

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
