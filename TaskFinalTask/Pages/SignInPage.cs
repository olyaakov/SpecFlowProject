using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TaskFinalTask.Pages
{
    public class SignInPage : BasePage
    {
        private string AuthorizationFieldXpath => "//input[@type='email']";
        private string InputButtonXpath => "//input[@class = 'a-button-input']";
        private string ProblemMessageXpath => "//span[@class='a-list-item']";

        private static SignInPage signInPage;
        public static SignInPage Instance => signInPage ?? (signInPage = new SignInPage());
        public void EnteringSymbolsInAuthorizationField(string signIn)
        {
            var enteringSymbolsInAuthorizationField = FindElement(By.XPath(AuthorizationFieldXpath)); 
            enteringSymbolsInAuthorizationField.SendKeys("Hobgislgsdpfkgpasfgbvijo");
            Thread.Sleep(2000);
        }
        public void ClickContinueButtom(string item)
        {
            var subMenuItem = FindElement(By.XPath(InputButtonXpath));
            subMenuItem.Click();
        }
        public bool IsProblemMessageDisplayed()
        {
            return IsDisplayed(By.XPath(ProblemMessageXpath));
        }
    }
}
