using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskFinalTask.Pages
{
    public class YourAccountPage : BasePage
    {
        
        private string TitleXpath => "//h1[contains(text(), 'Your Account')]";

        private static YourAccountPage yourAccountPage;
        public static YourAccountPage Instance => yourAccountPage ?? (yourAccountPage = new YourAccountPage());

        public bool IsPageTitleDisplayed()
        {
            return IsDisplayed(By.XPath(TitleXpath));   
        }
    }
}
