using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TechTalk.SpecFlow;
using TaskFinalTask.Pages;
using NUnit.Framework;
using TaskFinalTask.Base;

namespace TaskFinalTask.Steps
{
    [Binding]
    public sealed class FooterMenuSteps
    {
        private readonly ScenarioContext context;

        public FooterMenuSteps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Given(@"User opens Amason web site")]
        public void OpenAmasonWebSite()
        {
            HomePage.Instance.OpenAmasonHomePage();
        }

        [When(@"User hovers '([^']*)' menu item from the footer menu")]
        public void HoverMenuItemFromTheFooterMenu(string menuItem)
        {
            HomePage.Instance.HoverHelloSignInFooterItem(menuItem);
        }

        [When(@"User clicks '([^']*)' option from the footer menu")]
        public void ClickOptionFromTheFooterMenu(string option)
        {
            HomePage.Instance.ClickSubMenuItem(option);
        }

        [Then(@"Page with '([^']*)' title should be opened")]
        public void PageWithTitleShouldBeOpened(string title)
        {
            Assert.IsTrue(YourAccountPage.Instance.IsPageTitleDisplayed(), "Page title for the test is not displayed");
        }




        [When(@"User clicks '([^']*)' item from on the main menu")]
        public void ClickItemFromOnTheMainMenu(string section)
        {
            HomePage.Instance.ClickSectionMenuItem(section);
        }

        [When(@"User clicks '([^']*)' item from the navigation block menu on the '([^']*)' page")]
        public void ClickItemFromTheNavigationBlockMenuOnThePage(string computer, string p2)
        {
            InternationalBestSellersPage.Instance.ClickComputersItem(computer);
        }

        [When(@"User clicks '([^']*)' cell from the '([^']*)' item from the navigation block menu on the '([^']*)' page")]
        public void ClickCellFromTheItemFromTheNavigationBlockMenuOnThePage(string hp, string p0, string p3)
        {
            ComputersTabletsAndITAccessoriesPage.Instance.ClickHPCell(hp);
        }

        [Then(@"The page '([^']*)' contains '([^']*)' product brand in the product description")]
        public void ContainProductBrandInTheProductDescription(string results, string hp)
        {
            Assert.IsTrue(ResultsPage.Instance.IsBrandDisplayed(), "Brand name for the test is not displayed");

        }




        [When(@"User clicks '([^']*)' item from the footer")]
        public void ClickItemFromTheFooter(string deliver)
        {
            HomePage.Instance.ClickDeliverTo(deliver);
        }

        [When(@"User clicks '([^']*)' button in a pop-up")]
        public void ClickButtonInAPop_Up(string country)
        {
            ChooseYourLocationPage.Instance.ClickUkraineCountryButton(country);
        }

        [When(@"User clicks '([^']*)' button in drop-down list")]
        public void ClickButtonInDrop_DownList(string userCountry)
        {
            ChooseYourLocationPage.Instance.ClickCanadaCountryButton(userCountry);
        }

        [When(@"User clicks '([^']*)' button")]
        public void ClickButton(string done)
        {
            ChooseYourLocationPage.Instance.ClickDoneButton(done);
        }

        [Then(@"Page with '([^']*)' country in footer should be open")]
        public void PageWithCountryInFooterShouldBeOpen(string changedСountry)
        {
            Assert.IsTrue(HomePage.Instance.IsCanadaCountryDisplayed(), "Country in the footer for the test is not displayed");
        }



        [When(@"User clicks '([^']*)' item from the footer menu")]
        public void ClickItemFromTheFooterMenu(string signIn)
        {
            HomePage.Instance.ClickHelloSignInFooterItem(signIn);
        }

        [When(@"User enters '([^']*)' text in the authorixation field")]
        public void EnterTextInTheAuthorixationField(string symbols)
        {
            SignInPage.Instance.EnteringSymbolsInAuthorizationField(symbols);
        }

        [When(@"User clicks '([^']*)' button on Sign in page")]
        public void ClickButtonOnSignInPage(string button)
        {
            SignInPage.Instance.ClickContinueButtom(button);
        }

        [Then(@"'([^']*)' message should be displayed on the page")]
        public void MessageShouldBeDisplayedOnThePage(string problem)
        {
            Assert.IsTrue(SignInPage.Instance.IsProblemMessageDisplayed(), "The problem message about authorization is not displayed");
        }





        [When(@"User clicks '([^']*)' item from footer")]
        public void ClickItemFromFooter(string all)
        {
            HomePage.Instance.ClickAllItem(all);
        }

        [When(@"User clicks '([^']*)' item")]
        public void Clicktem(string computers)
        {
            HelloSignInPage.Instance.ClickComputerItem(computers);
        }

        [When(@"User clicks '([^']*)' menu item")]
        public void ClickMenuItem(string printers)
        {
            HelloSignInPage.Instance.ClickPritersItem(printers);
        }

        [When(@"User clicks the '([^']*)' cell in the navigation menu")]
        public void ClickTheCellInTheNavigationMenu(string hP)
        {
            ResultsPrintersPage.Instance.ClickHPPriterCell(hP);
        }

        [Then(@"Page with the '([^']*)' text in the description of the product should be displayed")]
        public void PageWithTheTextInTheDescriptionOfTheProductShouldBeDisplayed(string hP)
        {
            Assert.IsTrue(HPPrinterFilterPage.Instance.IsHPDisplayed(), "The problem message about authorization is not displayed");
        }


        [AfterTestRun]
        public static void AfterTestRun()
        {
           //DriverManager.QuitDriver();
        }

    }

}
