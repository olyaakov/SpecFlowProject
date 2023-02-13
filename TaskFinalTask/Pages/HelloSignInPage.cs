using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskFinalTask.Pages
{
    public class HelloSignInPage : BasePage
    {
        private string ComputerItemXpath => "//div[contains(text(), 'Computers')]";
        private string PritersItemXpath => "//a[contains(text(), 'Printers')]";
        private static HelloSignInPage helloSignInPage;
        public static HelloSignInPage Instance => helloSignInPage ?? (helloSignInPage = new HelloSignInPage());
        public void ClickComputerItem(string computers)
        {
            var clickComputerItem = FindElements(By.XPath(ComputerItemXpath)).First(x => x.Text.Equals(computers));
            clickComputerItem.Click();
        }
        public void ClickPritersItem(string printers)
        {
            var clickPritersItem = FindElements(By.XPath(PritersItemXpath)).First(x => x.Text.Equals(printers));
            clickPritersItem.Click();
        }
    }
}
