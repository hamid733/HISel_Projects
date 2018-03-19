using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FourthSelenium
{
    public class Amazon_HomePage
    {
        public void Go_To_Amazone_HomePage()
        {
            BrowserDriver.Instance.Navigate().GoToUrl("https://amazon.co.uk");
            BrowserDriver.Instance.Manage().Window.Maximize();

        }

        public bool Check_page_is_Correct()
        {
            Go_To_Amazone_HomePage();
            bool expected;
            string HomeUrl = BrowserDriver.Instance.Url;
            string HomeTitle = BrowserDriver.Instance.Title;
            expected = HomeUrl == "amazon.co.uk" && HomeTitle == "Amazon.co.uk:Low prices in Electronics,Books,Sport Equipment & more";
            return expected;
        }

        public void can_search_keywords()
        {
            IWebElement searchBox=BrowserDriver.Instance.FindElement(By.Name("field-keywords"));
            searchBox.SendKeys("A Game of Thrones ");
            searchBox.SendKeys(Keys.Enter);
            
        }

        public bool To_check_first_item()
        {
            can_search_keywords();
            IList<IWebElement> bookTitle = BrowserDriver.Instance.FindElements(By.TagName("h2"));
            bool check=false;
            string firstTitle = "A Game of Thrones (A Song of Ice and Fire, Book 1)";

            if (bookTitle[0].Text==firstTitle)
            {
                check = true;
            }
            
            
            return check;
        }

        public bool To_check_badge()
        {
            can_search_keywords();
            bool firstItem = To_check_first_item();
            bool badge = false;
            bool badgeExist = false;
            badge= BrowserDriver.Instance.FindElement(By.Id("badge")).Displayed;
            if (firstItem && badge)
            {
                badgeExist = true;
            }
            return badgeExist;
        }

        public bool To_check_paperpack_label()
        {
            throw new NotImplementedException();
        }

        public bool To_check_price()
        {
            throw new NotImplementedException();
        }

        public bool can_add_to_basket()
        {
            can_search_keywords();
            Check_item_details();
            BrowserDriver.Instance.FindElement(By.Id("add to basket")).Click();
            bool isAdded = BrowserDriver.Instance.PageSource.Contains("Added to basket");
            return isAdded;
        }


        private void Check_item_details()
        {
            throw new NotImplementedException();
        }
    }
}
