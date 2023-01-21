using OpenQA.Selenium;
using OrangeProject.Driver;

namespace OrangeProject.Pages
{
    public class DashboardPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        //QuickLaunch
        public IWebElement AssignLeave => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[3]/div/div[2]/div/div[1]/button"));
        public IWebElement LeaveList => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[3]/div/div[2]/div/div[2]/button"));
        public IWebElement TimeSheets => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[3]/div/div[2]/div/div[3]/button"));
        public IWebElement ApplyLeave => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[3]/div/div[2]/div/div[4]/button"));
        public IWebElement MyLeave => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[3]/div/div[2]/div/div[5]/button"));
        public IWebElement MyTimesheet => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[3]/div/div[2]/div/div[6]/button"));
        //MyActions
        public IWebElement TimesheetsApproval => driver.FindElement(By.ClassName("oxd-icon-button oxd-icon-button--warn orangehrm-report-icon"));


        public string HomeUrl = "https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index";
        public void klikninadugme(string title)
        {
            string titlelocator = $"//button[@title='{title}']";
            By locator = By.XPath(titlelocator);
            driver.FindElement(locator).Click();
        }
    }
}
