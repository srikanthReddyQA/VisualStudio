using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium
{
    [TestFixture]
    class Automation
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void oprnbrowser()
        {
           
            driver.Navigate().GoToUrl("http://www.google.com");

          
        }
        [Test]
        public void WorkonElements()
        {
            driver.FindElement(By.XPath("//input[@name='q']")).SendKeys("HI");
        }
        [TearDown]
        public void close()
        {
            driver.Close();
        }

       static void Main(string[] args)
       {
           // Automation s = new Automation();
            //s.oprnbrowser();

        }

    }
}
