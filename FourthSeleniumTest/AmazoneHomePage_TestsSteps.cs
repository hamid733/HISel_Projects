using FourthSelenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace FourthSeleniumTest
{
    [Binding]
    [TestClass]
    public class AmazoneHomePage_TestsSteps
    {

        Amazon_HomePage objHome = new Amazon_HomePage();
        [Given(@"I have entered the correct url")]
        public void GivenIHaveEnteredTheCorrectUrl()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press Go or Enter")]
        public void WhenIPressGoOrEnter()
        {
            ScenarioContext.Current.Pending();
        }
        [TestMethod]
        [Then(@"the Home page should be displayed properly")]
        public void ThenTheHomePageShouldBeDisplayedProperly()
        {
            
            objHome.Go_To_Amazone_HomePage();
            Assert.IsTrue(objHome.Check_page_is_Correct(),"The Home page is not displayed correctly");
        }

        //scenario 2
        [Given(@"I have entered the correct url and Amazon Home page is displayed properly")]
        public void GivenIHaveEnteredTheCorrectUrlAndAmazonHomePageIsDisplayedProperly()
        {
            ScenarioContext.Current.Pending();
        }

        [TestMethod]
        [Given(@"I enter the search keyword A Game of Thrones")]
        public void GivenIEnterTheSearchKeywordAGameOfThrones()
        {
            objHome.can_search_keywords();
        }

        [When(@"I press the Search icon")]
        public void WhenIPressTheSearchIcon()
        {
            ScenarioContext.Current.Pending();
        }

        [TestMethod]
        [Then(@"Verify that the first items has the title: A Game of Thrones \(A Song of Ice and Fire, Book (.*)\)")]
        public void ThenVerifyThatTheFirstItemsHasTheTitleAGameOfThronesASongOfIceAndFireBook(int p0)
        {
            Assert.IsTrue(objHome.To_check_first_item(),"The first tile is not as expected");
        }
        [TestMethod]
        [Then(@"It has a badge “Best Seller”")]
        public void ThenItHasABadgeBestSeller()
        {
           Assert.IsTrue(objHome.To_check_badge(),"Item Badge is not dsplayed");
        }

        [TestMethod]
        [Then(@"Selected type is Paperback")]
        public void ThenSelectedTypeIsPaperback()
        {
            Assert.IsTrue(objHome.To_check_paperpack_label(),"The label is Not Paperback");
        }

        [TestMethod]
        [Then(@"And the price is £(.*)")]
        public void ThenAndThePriceIs(Decimal p0)
        {
            Assert.IsTrue(objHome.To_check_price(), "The Proce is not correct");
        }

        //Scenario 04
        [Given(@"I have searched the book ""(.*)""")]
        public void GivenIHaveSearchedTheBook(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"Navigate to book details page")]
        public void GivenNavigateToBookDetailsPage()
        {
            ScenarioContext.Current.Pending();
        }
        [TestMethod]
        [When(@"I click Add to basket button")]
        public void WhenIClickAddToBasketButton()
        {
            Assert.IsTrue(objHome.can_add_to_basket(),"Item is Not added to basket");
        }

        [Then(@"Verify that the notification is shown with the title Added to Basket")]
        public void ThenVerifyThatTheNotificationIsShownWithTheTitleAddedToBasket()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"There is one item in the basket")]
        public void ThenThereIsOneItemInTheBasket()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Click on edit the basket")]
        public void ThenClickOnEditTheBasket()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Verify that the book is shown on the list")]
        public void ThenVerifyThatTheBookIsShownOnTheList()
        {
            ScenarioContext.Current.Pending();
        }




    }
}
