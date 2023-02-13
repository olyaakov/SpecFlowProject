using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TaskFinalTask.Base;

namespace TaskFinalTask.Pages
{
    public class HomePage : BasePage
    {
        public HomePage()
        {

        }
        private string URL => "https://www.amazon.com";
        private string HelloSignInXpath => "//span[contains(text(), 'Hello, sign in')]";
        private string SubMenuItemXpath => "//span[@class='nav-text']";
        private string SectionMenuItemXpath => "//div[@class='a-cardui-footer']";
        private string DeliverToCountryXpath => "//span[contains(text(), 'Deliver to')]";
        private string CanadaHomePageXpath => "//span[contains(text(), 'Canada')]";
        private string CartItemXPath => "//span[contains(text(), 'Cart')]";
        private string AllItemXpath => "//span[text()='All' and @class = 'hm-icon-label']";
        private string SearchFieldXpath => ".//div[@class='nav-search-field ']";

        private static HomePage homePage;
        public static HomePage Instance => homePage ?? (homePage = new HomePage()); 

        public void OpenAmasonHomePage()
        {
            DriverManager.Instance().Navigate().GoToUrl(URL);
            Thread.Sleep(10000);
        }

        public void HoverHelloSignInFooterItem(string item)
        {
            var actions = new Actions(DriverManager.Instance());
            var menuItem = FindElements(By.XPath(HelloSignInXpath)).First(x => x.Text.Equals(item));
            actions.MoveToElement(menuItem).Perform();
        }

        public void ClickSubMenuItem(string item)
        {
            var subMenuItem = FindElements(By.XPath(SubMenuItemXpath)).First(x => x.Text.Equals(item));
            subMenuItem.Click();
        }

        public void ClickSectionMenuItem(string section)
        {
            var sectionMenuItem = FindElements(By.XPath(SectionMenuItemXpath)).FirstOrDefault(x => x.Text.Equals(section));
            sectionMenuItem.Click();
            Thread.Sleep(2000);
        }

        public void ClickDeliverTo(string deliver)
        {
            var clickDeliverTo = FindElements(By.XPath(DeliverToCountryXpath)).First(x => x.Text.Equals(deliver));
            clickDeliverTo.Click();
            Thread.Sleep(2000);
        }

        public bool IsCanadaCountryDisplayed()
        {
            return IsDisplayed(By.XPath(CanadaHomePageXpath));
        }

        public void ClickHelloSignInFooterItem(string signIn)
        {
            var clickHelloSignInFooterItem = FindElements(By.XPath(HelloSignInXpath)).First(x => x.Text.Equals(signIn));
            clickHelloSignInFooterItem.Click();
            Thread.Sleep(2000);
        }

        public void ClickAllItem(string all)
        {
            var clickAllItem = FindElements(By.XPath(AllItemXpath)).First(x => x.Text.Equals(all));
            clickAllItem.Click();
            Thread.Sleep(2000);
        }
        public void ClickSearchField(string search)
        {
            var clickSearchField = FindElement(By.XPath(SearchFieldXpath));
            clickSearchField.SendKeys("Logitech G502 SE Hero High Performance RGB Gaming Mouse with 11 Programmable Buttons");
            clickSearchField.Click();   
            Thread.Sleep(2000);
        }
    }
}
