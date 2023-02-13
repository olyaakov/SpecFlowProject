using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskFinalTask.Pages
{
    public class ResultsPage: BasePage
    {
        private string BrandDecsriptionHPXpath => "//span[@class='a-size-base-plus a-color-base a-text-normal' and contains(text(), 'HP')]";
        private static ResultsPage computerstablets;
        public static ResultsPage Instance => computerstablets ?? (computerstablets = new ResultsPage());

        public bool IsBrandDisplayed()
        {
            return IsDisplayed(By.XPath(BrandDecsriptionHPXpath));
        }

    }
}
