using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using mars_automation.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using static System.Collections.Specialized.BitVector32;
using TechTalk.SpecFlow.Assist;

namespace mars_automation.Pages
{
    public class ShareSkillPage
    {

        public void EnterATitle(IWebDriver driver, string titleValue)
        {

            // enter a value in title field
            IWebElement titleInputBox = driver.FindElement(By.CssSelector("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            titleInputBox.SendKeys(titleValue);
        }

        public void EnterADescription(IWebDriver driver, string descriptionValue)
        {

            // enter a value in title field
            IWebElement descriptionInputBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            descriptionInputBox.SendKeys(descriptionValue);
        }

        public void SelectACategory(IWebDriver driver, string p0)
        {

            // select a value from category dropdown
            IWebElement categoryDropdown = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div/select"));
            categoryDropdown.Click();
        }

        public void SelectASubCategory(IWebDriver driver, string p0)
        {

            // enter a value from sub category dropdown
            IWebElement subCategoryDropdown = driver.FindElement(By.XPath("//*[@id=\"service - listing - section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));
            subCategoryDropdown.Click();
        }

        public void EnterATag(IWebDriver driver, string tagValue)
        {

            // enter a value from sub category dropdown
            IWebElement tagInputBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
            tagInputBox.SendKeys(tagValue);
            tagInputBox.SendKeys("{ENTER}");
        }

        public void SelectServiceType(IWebDriver driver, string serviceType)
        {

            if(serviceType == "Hourly basis service")
            {

                // select hourly basis service radio button
                IWebElement hourlyBasisServiceRadioButton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));
                hourlyBasisServiceRadioButton.Click();

            }
            else if(serviceType == "One-off service")
            {

                // select One-off service radio button
                IWebElement oneOffServiceRadioButton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
                oneOffServiceRadioButton.Click();

            }

        }

        public void LocationType(IWebDriver driver, string locationType)
        {

            if (locationType == "On-site")
            {

                // select on-site radio button
                IWebElement onsiteRadioButton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));
                onsiteRadioButton.Click();

            }
            else if (locationType == "Online")
            {

                // select online radio button
                IWebElement onlineRadioButton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
                onlineRadioButton.Click();


            }

        }

        public void EnterAvailableDays(IWebDriver driver, string startDate, string endDate)
        {

            // enter a start date value
            IWebElement startDateInputBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
            startDateInputBox.SendKeys("01/06/2023");

            // enter a end date value
            IWebElement endDateInputBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
            endDateInputBox.SendKeys("01/06/2024");
        }

        public void SkillTrade(IWebDriver driver, string skillTradeType, string skillExchange, string creditAmount)
        {

            if (skillTradeType == "Skill-exchange")
            {

                // select skill exchange radio button
                IWebElement skillExchangeRadioButton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));
                skillExchangeRadioButton.Click();

                // enter a skill exchange value
                IWebElement skillExchangeTag = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
                skillExchangeTag.SendKeys(skillExchange);

            }
            else if (skillTradeType == "Credit")
            {

                // select credit radio button
                IWebElement creditRadioButton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));
                creditRadioButton.Click();

                // Enter a credit amount value
                IWebElement creditInputBox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/input"));
                creditInputBox.SendKeys(creditAmount);


            }

        }

        public void ActiveType(IWebDriver driver, string active)
        {

            if (active == "Active")
            {

                // select active radio button
                IWebElement skillExchangeRadioButton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"));
                skillExchangeRadioButton.Click();

            }
            else if (active == "Hidden")
            {

                // select hidden radio button
                IWebElement creditRadioButton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input"));
                creditRadioButton.Click();


            }

        }

        public void ClickOnSaveButton(IWebDriver driver)
        {

            // click on save button
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
            saveButton.Click();

        }

        public void ClickOnCancelButton(IWebDriver driver)
        {

            // click on save button
            IWebElement cancelButton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[2]"));
            cancelButton.Click();

        }

    }
}
