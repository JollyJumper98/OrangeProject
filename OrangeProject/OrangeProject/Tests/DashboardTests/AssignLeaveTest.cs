using OrangeProject.Driver;
using OrangeProject.Pages;

namespace OrangeProject.Tests.DashboardTests
{
    public class AssignLeaveTest
    {
        LoginPage loginPage;
        DashboardPage dashboardPage;
        LeavePage leavePage;
        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            dashboardPage = new DashboardPage();
            leavePage = new LeavePage();
        }
        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUp();
        }
        [Test]
        public void TC01_AssignLeave_LeaveShouldBeAssigned()
        {
            loginPage.Login("Admin", "admin123");
            dashboardPage.klikninadugme("Assign Leave");
            leavePage.SelectEmployee("Odis Adalwin");
            leavePage.SelectLeave("CAN - Vacation");
            leavePage.FromDate.SendKeys("2023-01-18");
            leavePage.ToDate.SendKeys("2023-01-20");
            leavePage.SelectPartialDays("All days");
            leavePage.SelectDuration("Half Day - Afternoon");
            leavePage.Comments.SendKeys("Senora lo siento");
            leavePage.AssignButton.Submit();
        }
    }
}
