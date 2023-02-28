using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBDDAutomationFramework.Pages
{
    public class ChannelPage
    {
        private IWebDriver driver;

        public ChannelPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string getTitle()
        {
           return driver.Title;
        }

    }
}
