using System;
using System.Threading;
using DeliveryClub.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DeliveryClub
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckMessageIfFieldIsEmpty()
        {
            IWebDriver driver = new ChromeDriver();
            MainPage mainPage = new MainPage(driver);

            mainPage.GoToPage();
            Thread.Sleep(1000);
            mainPage.ClickFindRestaurantButton();
            Thread.Sleep(1000);

            Assert.IsTrue(mainPage.DisplayedMessage(), "Message: Пожалуйста, уточните адресс is not visible");
            driver.Quit();
        }

        [TestMethod]
        public void CheckFindRestaurantButton()
        {
            IWebDriver driver = new ChromeDriver();
            MainPage mainPage = new MainPage(driver);

            mainPage.GoToPage();
            Thread.Sleep(1000);
            mainPage.TypeText("Саратов Лунная 28");
            mainPage.ClickFindRestaurantButton();

            Assert.IsTrue(mainPage.DisplayedElementAll(), "The list page isn't opened");
            driver.Quit();
        }

        [TestMethod]
        public void CheckNotFoundMessage()
        {
            IWebDriver driver = new ChromeDriver();
            MainPage mainPage = new MainPage(driver);

            mainPage.GoToPage();
            Thread.Sleep(1000);
            mainPage.TypeText("Саратов Лунная 28");
            mainPage.ClickFindRestaurantButton();
            Thread.Sleep(1000);
            mainPage.TypeDishInField("Абракадабра");
            mainPage.ClickEnterButton();
            Thread.Sleep(1000);

            Assert.IsTrue(mainPage.NotFoundMessageIsDisplayed(), "Ничего не найдено.Попробуйте выбрать меньше фильтров message is not found");
            driver.Quit();
        }

        [TestMethod]
        public void CheckEnterButton()
        {
            IWebDriver driver = new ChromeDriver();
            MainPage mainPage = new MainPage(driver);

            mainPage.GoToPage();
            Thread.Sleep(1000);
            mainPage.ClickEntryButton();

            Assert.IsTrue(mainPage.MessageInLoginPopupIsDisplayed(), "No message on login Popup");
            driver.Quit();
        }
    }
}
