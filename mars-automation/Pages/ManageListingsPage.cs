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
    public class ManageListingsPage
    {

        public void VerifyListings(IWebDriver driver, string titleValue)
        {

            // verify listing title
            IWebElement listingTitle = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"));
            Assert.That(listingTitle.Text == titleValue);

        }

        public void ViewListing(IWebDriver driver)
        {

            // click on view listing icon
            IWebElement viewListing = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[1]"));
            viewListing.Click();
            

        }

        public void VerifyListingTitle(IWebDriver driver, string titleValue)
        {

            // verify listing title
            IWebElement listingTitle = driver.FindElement(By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/h1/span"));
            Assert.That(listingTitle.Text == titleValue);

        }

        public void DeleteListing(IWebDriver driver)
        {

            // click on delete listing icon
            IWebElement deleteListing = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]"));

            // click on yes
            IWebElement responseYes = driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));
            responseYes.Click();
            
        }

    }
}
