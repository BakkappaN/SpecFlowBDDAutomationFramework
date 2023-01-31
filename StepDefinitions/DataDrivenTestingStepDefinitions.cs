using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowBDDAutomationFramework.StepDefinitions
{
    [Binding]
    public sealed class DataDrivenTestingStepDefinitions
    {
        private IWebDriver driver;

       public DataDrivenTestingStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Then(@"Search for '([^']*)'")]
        public void ThenSearchFor(string searchKey)
        {
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(searchKey);
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(Keys.Enter);
            Thread.Sleep(5000);
        }


    }
}