using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskFinalTask.Pages
{
    public class HPPrinterFilterPage : BasePage
    {
        private string HPPriterSectionXpath => "//span[contains(text(), 'HP')]";
        private static HPPrinterFilterPage printerHP;
        public static HPPrinterFilterPage Instance => printerHP ?? (printerHP = new HPPrinterFilterPage());
        public bool IsHPDisplayed()
        {
            return IsDisplayed(By.XPath(HPPriterSectionXpath));
        }
    }
}
