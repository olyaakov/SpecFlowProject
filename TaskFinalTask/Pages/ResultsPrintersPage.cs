using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TaskFinalTask.Pages
{
    public class ResultsPrintersPage : BasePage
    {
        private string FirstPriterSectionXpath => "//*[@id='p_89/HP']/span/a/span";
        private static ResultsPrintersPage resultsPrintersPage;
        public static ResultsPrintersPage Instance => resultsPrintersPage ?? (resultsPrintersPage = new ResultsPrintersPage());
        public void ClickHPPriterCell(string printer)
        {
            var firstPriterSection = FindElements(By.XPath(FirstPriterSectionXpath)).First(x => x.Text.Equals(printer));
            firstPriterSection.Click();
        }
    }
}
