using OpenQA.Selenium;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;



namespace ValtechProj1
{
    class Program
    {
        //Create the reference for our browser
        //Nb: Please ensure link to ChromeDriver is customised to suit that of devise you're running test on        
        IWebDriver driver = new ChromeDriver("C:\\Users\\GlobalLightRevival\\chromedriver_jan");

        static void Main(string[] args)
        {           
                        
        }

        [SetUp]
        public void Initialize()
        {
            //Navigate to google page
            driver.Navigate().GoToUrl("https://www.valtech.com/");

        }

        [Test]
        public void ExecuteTest()
        {
            //Assert that the “Latest News” section is displaying           

            //Nb: a separate repository/library 
            string casPath = "//a[@href='/cases/']";
            string servPath = "//a[@href='/services/']";
            string carPath = "//a[@href='/jobs/']";
            string contPath = "//div[@class='hamburger__flipper']";
            string newsSectionHeader = "//h2[@class='block-header__heading']";

            //Navigate to Cases section and assert that H1 tag is displaying the page name
            SetMethods.verifyHomePageObjects(driver, newsSectionHeader, "XPath");
            SetMethods.navToCasesPage(driver, casPath, "XPath");
            SetMethods.navToServicesPage(driver, servPath, "XPath");
            SetMethods.navToCareersPage(driver, carPath, "XPath");
            SetMethods.navigateToContactsPage(driver, contPath, "XPath");      
        }        

        

        [TearDown]
        public void CleanUp()
        {
            //Close the browser            
            driver.Close();
        }
    }
}
