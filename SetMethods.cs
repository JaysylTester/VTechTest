using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace ValtechProj1
{
    class SetMethods
    {        
        public static void navToCasesPage(IWebDriver driver, string element, string elementtype)
        {
            driver.FindElement(By.XPath(element)).Click();
            var caseSection = driver.FindElement(By.XPath("//*[h1='Work']"));
            Assert.IsTrue(caseSection.Text.Contains("Work"));            
        }

        public static void navToServicesPage(IWebDriver driver, string element, string elementtype)
        {
            driver.FindElement(By.XPath(element)).Click();
            var caseSection = driver.FindElement(By.XPath("//*[h1='Services']"));
            Assert.IsTrue(caseSection.Text.Contains("Services"));
        }

        public static void navToCareersPage(IWebDriver driver, string element, string elementtype)
        {
            driver.FindElement(By.XPath(element)).Click();
            var caseSection = driver.FindElement(By.XPath("//*[h1='Careers']"));
            Assert.IsTrue(caseSection.Text.Contains("Careers"));
        }        

        public static void navigateToContactsPage(IWebDriver driver, string element, string elementtype)
        {
            driver.FindElement(By.XPath(element)).Click();
            int iCount = driver.FindElements(By.XPath("//i[@class='office__map__icon glyph']")).Count;
            Console.WriteLine(iCount);
        }

        public static void verifyHomePageObjects(IWebDriver driver, string element, string elementtype)
        {
            var newsSection = driver.FindElement(By.XPath(element));
            Assert.IsTrue(driver.PageSource.Contains("Latest news"));
            Console.WriteLine("Latest News validated");
        }
    }
}

