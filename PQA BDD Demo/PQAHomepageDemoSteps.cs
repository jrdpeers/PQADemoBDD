using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PQA_BDD_Demo
{
    [Binding]
    public class PQAHomepageDemoSteps
    {
        ChromeDriver driver = new ChromeDriver();

        public ChromeDriver Driver { get => driver; set => driver = value; }

        [Given(@"I am on the PQA homepage")]
        public void GivenIAmOnThePQAHomepage()
        {
            Driver.Navigate().GoToUrl("http://www.pqatesting.com/");
        }

        [When(@"I select Our Ideas")]
        public void WhenISelectOurIdeas()
        {
            Driver.FindElement(By.XPath("//a[@rel='our_ideas']")).Click();
        }

        [Then(@"I should see the Our Ideas page")]
        public void ThenIShouldSeeTheOurIdeasPage()
        {
            Assert.AreEqual("Blog - PQA Testing - Professional Quality Assurance Ltd.", driver.Title.ToString());
        }
    }
}
