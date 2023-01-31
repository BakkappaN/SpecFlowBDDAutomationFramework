using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowBDDAutomationFramework.StepDefinitions
{
    [Binding]
    public sealed class ExamplesDataDrivenTestingStepDefinitions
    {
        private IWebDriver driver;

       public ExamplesDataDrivenTestingStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }


        [Then(@"Search with (.*)")]
        public void ThenSearchWithSpecflowByTestersTalk(string searchKey)
        {
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(searchKey);
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(Keys.Enter);
            Thread.Sleep(5000);
        }


    }
}