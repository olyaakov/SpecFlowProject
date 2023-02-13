using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TaskFinalTask.Pages
{
    public class ChooseYourLocationPage : BasePage
    {
        private string UkraineCountryXpath => "//span[@role='radiogroup']";
        private string CanadaCountryXpath => "//*[text()='Canada' and @class = 'a-dropdown-link']";
        private string DoneButtonXpath => "//button[@name = 'glowDoneButton']";
        private static ChooseYourLocationPage chooseYourLocationPage;
        public static ChooseYourLocationPage Instance => chooseYourLocationPage ?? (chooseYourLocationPage = new ChooseYourLocationPage());
        public void ClickUkraineCountryButton(string department)
        {
            var clickUkraineCountryButton = FindElements(By.XPath(UkraineCountryXpath)).First(x => x.Text.Equals(department));
            clickUkraineCountryButton.Click();
        }

        public void ClickCanadaCountryButton(string countryCanadaButton)
        {
            var clickCanadaCountryButton = FindElements(By.XPath(CanadaCountryXpath)).FirstOrDefault(x => x.Text.Equals("Canada"));
            clickCanadaCountryButton.Click();
        }
        public void ClickDoneButton(string done)
        {
            var clickDoneButton = FindElements(By.XPath(DoneButtonXpath)).First(x => x.Text.Equals(done));
            clickDoneButton.Click();
        }
    }
}
