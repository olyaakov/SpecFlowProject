using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskFinalTask.Pages
{
    public class InternationalBestSellersPage : BasePage
    {
        private string ComputersXpath => "//h3[contains(text(), 'Department')]/following-sibling::ul/li[8]/child::a";

        private static InternationalBestSellersPage internalBestSellers;
        public static InternationalBestSellersPage Instance => internalBestSellers ?? (internalBestSellers = new InternationalBestSellersPage());

        public void ClickComputersItem(string department)
        {
            var cellBrand = FindElements(By.XPath(ComputersXpath)).First(x => x.Text.Equals(department));
            cellBrand.Click();
        }
    }
}
