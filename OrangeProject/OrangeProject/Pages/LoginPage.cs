using OpenQA.Selenium;
using OrangeProject.Driver;

namespace OrangeProject.Pages
{
    public class LoginPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement UserName => driver.FindElement(By.Name("username"));
        public IWebElement Password => driver.FindElement(By.Name("password"));
        public IWebElement LoginButton => driver.FindElement(By.CssSelector(".oxd-button "));
        public IWebElement ErrorMsg => driver.FindElement(By.CssSelector(".oxd-alert-content-text"));
        public IWebElement UsernameError => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[1]/div/span"));
        public IWebElement PasswordError => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[2]/div/span"));

        public void Login(string user, string pass)
        {
            UserName.SendKeys(user);
            Password.SendKeys(pass);
            LoginButton.Submit();
        }
    }
}
