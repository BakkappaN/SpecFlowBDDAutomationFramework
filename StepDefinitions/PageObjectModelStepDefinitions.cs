using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowBDDAutomationFramework.Pages;

namespace SpecFlowBDDAutomationFramework.StepDefinitions
{
    [Binding]
    public sealed class PageObjectModelStepDefinitions
    {
        private IWebDriver driver;
        SearchPage searchPage;
        ResultPage resultPage;
        ChannelPage channelPage;

       public PageObjectModelStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"Enter the youtube URL")]
        public void GivenEnterTheYoutubeURL()
        {
            driver.Url = "https://www.youtube.com/";
            Thread.Sleep(4000);
        }

        [When(@"Search for the testers talk in youtube")]
        public void WhenSearchForTheTestersTalkInYoutube()
        {
            searchPage = new SearchPage(driver);

            resultPage = searchPage.searchText("testers talk");
            Thread.Sleep(4000);
        }

        [When(@"Navigate to channel")]
        public void WhenNavigateToChannel()
        {
            channelPage = resultPage.clickOnChannel();
            Thread.Sleep(4000);
        }

        [Then(@"Verify title of the page")]
        public void ThenVerifyTitleOfThePage()
        {
            Assert.AreEqual("Testers Talk - ", channelPage.getTitle());
        }


    }
}