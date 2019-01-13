using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryClub.Pages
{
    public class MainPage
    {
        public IWebDriver driver;
        private string MainPageUrl = "https://www.delivery-club.ru/";

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl(MainPageUrl);
        }

        private IWebElement FindRestaurantButton
        {
            get
            {
                return driver.FindElement(By.XPath($"//a[contains(text(),'Найти рестораны')]"));
            }
        }

        private IWebElement FindField
        {
            get
            {
                return driver.FindElement(By.XPath($"//input[@placeholder='Город, улица, дом']"));
            }
        }

        private IWebElement ElementAll
        {
            get
            {
                return driver.FindElement(By.XPath($"//span[contains(text(),'Все')]"));
            }
        }

        private IWebElement FindDishField
        {
            get
            {
                return driver.FindElement(By.XPath($"//input[@placeholder='Поиск блюд и ресторанов']"));
            }
        }

        private IWebElement NotFoundMessage
        {
            get
            {
                return driver.FindElement(By.CssSelector($".vendor-list-empty-message__text"));
            }
        }

        private IWebElement EntryButton
        {
            get
            {
                return driver.FindElement(By.XPath($"//button[contains(text(),'Вход')]"));
            }
        }

        private IWebElement MessageInLoginPopup
        {
            get
            {
                return driver.FindElement(By.XPath($"//a[contains(text(),'пользовательского соглашения')]"));
            }
        }

        public bool MessageInLoginPopupIsDisplayed()
        {
            var messageIsDisplayed = MessageInLoginPopup.Displayed;

            if (messageIsDisplayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ClickEntryButton()
        {
            EntryButton.Click();
        }

        public bool NotFoundMessageIsDisplayed()
        {
            var displayedMessage = NotFoundMessage.Displayed;

            if (displayedMessage)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TypeDishInField(string value)
        {
            FindDishField.SendKeys(value);
        }

        public bool DisplayedElementAll()
        {
            var elementAllIsDisplayed = ElementAll.Displayed;

            if (elementAllIsDisplayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TypeText(string value)
        {
            FindField.SendKeys(value);
        }

        public bool DisplayedMessage()
        {
            var messageIsDisplayed = driver.FindElement(By.CssSelector($".tooltip-v2.tooltip-v2-.tooltip-v2-addr-input.tooltip-v2__error")).Displayed;

            if (messageIsDisplayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ClickFindRestaurantButton()
        {
            FindRestaurantButton.Click();
        }

        public void ClickEnterButton()
        {
            FindDishField.SendKeys(Keys.Enter);
        }
    }
}
