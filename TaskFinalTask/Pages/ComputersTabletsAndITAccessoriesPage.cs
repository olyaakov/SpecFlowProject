using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskFinalTask.Pages
{
    public class ComputersTabletsAndITAccessoriesPage : BasePage
    {
        private string CellHPXpath => "//div[@class='a-checkbox a-checkbox-fancy aok-float-left apb-browse-refinements-checkbox']//following-sibling::span[contains(text(), 'HP')]";

        private static ComputersTabletsAndITAccessoriesPage computerstablets;
        public static ComputersTabletsAndITAccessoriesPage Instance => computerstablets ?? (computerstablets = new ComputersTabletsAndITAccessoriesPage());
     
        public void ClickHPCell(string department)
        {
            var cellBrand = FindElements(By.XPath(CellHPXpath)).First(x => x.Text.Equals(department));
            cellBrand.Click();
        }

    }
}
