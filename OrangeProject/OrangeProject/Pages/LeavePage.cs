using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OrangeProject.Driver;

namespace OrangeProject.Pages
{
    public class LeavePage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement EmployeeName => driver.FindElement(By.CssSelector(".oxd-autocomplete-text-input--active"));
        public IWebElement LeaveType => driver.FindElement(By.CssSelector(".oxd-select-text-input"));
        public IWebElement FromDate => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[3]/div/div[1]/div/div[2]/div/div/input"));
        public IWebElement ToDate => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[3]/div/div[2]/div/div[2]/div/div/input"));
        public IWebElement Duration => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[4]/div/div/div/div[2]/div/div"));
        public IWebElement PartialDays => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[4]/div/div[1]/div/div[2]/div/div/div[1]"));
        public IWebElement Comments => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[4]/div/div/div/div[2]/textarea"));
        public IWebElement AssignButton => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[6]/button"));

        public void SelectLeave(string text)
        {
            SelectElement leave = new SelectElement(driver.FindElement(By.CssSelector(".oxd-select-text-input")));
            leave.SelectByText(text);
        }
        public void SelectDuration(string text)
        {
            SelectElement duration = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[4]/div/div/div/div[2]/div/div")));
            duration.SelectByText(text);
        }
        public void SelectPartialDays(string text)
        {
            SelectElement partialDays = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[4]/div/div[1]/div/div[2]/div/div/div[1]")));
            partialDays.SelectByText(text);
        }
        public void SelectEmployee(string text)
        {
            SelectElement employee = new SelectElement(driver.FindElement(By.CssSelector(".oxd-autocomplete-text-input--active")));
            employee.SelectByText(text);
        }
    }
}
