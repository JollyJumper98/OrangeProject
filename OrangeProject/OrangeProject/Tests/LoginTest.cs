using OrangeProject.Driver;
using OrangeProject.Pages;

namespace OrangeProject.Tests
{
    public class Tests
    {
        LoginPage loginPage;
        DashboardPage dashboardPage;

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            dashboardPage = new DashboardPage();
        }
        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUp();
        }

        [Test]
        public void TC01_LoginWithValidCredentials_UserShouldBeLogedIn()
        {
            loginPage.Login("Admin", "admin123");
            Assert.That("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index", Is.EqualTo(dashboardPage.HomeUrl));
        }
        [Test]
        public void TC02_LoginWithValidUsernameAndInvalidPassword_UserShouldNotBeLogged()
        {
            loginPage.Login("Admin", "Admin");
            Assert.That(loginPage.ErrorMsg.Displayed);
        }
        [Test]
        public void TC03_LoginWithInvalidUsernameAndValidPassword_UserShouldNotBeLogged()
        {
            loginPage.Login("admin", "admin123");
            //bug found
        }
        [Test]
        public void TC04_LoginWithInvalidCredentials_UserShouldNotBeLogged()
        {
            loginPage.Login("123", "123");
            Assert.That(loginPage.ErrorMsg.Displayed);
        }
        [Test]
        public void TC05_LoginWithoutCredentials_UserShouldNotBeLogged()
        {
            loginPage.Login("", "");
            Assert.That(loginPage.UsernameError.Displayed);
            Assert.That(loginPage.PasswordError.Displayed);
        }

    }
}