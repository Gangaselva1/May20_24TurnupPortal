using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//Test1234

IWebDriver driver = new ChromeDriver();
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2fTimeMaterial");
IWebElement userNameElement = driver.FindElement(By.Id("UserName"));
userNameElement.SendKeys("hari");
IWebElement passwordElement = driver.FindElement(By.Id("Password"));
passwordElement.SendKeys("123123");
IWebElement LoginButtonElement = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
LoginButtonElement.Click();