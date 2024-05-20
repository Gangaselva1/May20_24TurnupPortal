using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//test1124567

IWebDriver driver = new ChromeDriver();
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2fTimeMaterial");
IWebElement userNameElement = driver.FindElement(By.Id("UserName"));
userNameElement.SendKeys("hari");
IWebElement passwordElement = driver.FindElement(By.Id("Password"));
passwordElement.SendKeys("123123");
IWebElement LoginButtonElement = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
LoginButtonElement.Click();
//IWebElement StaffButtonElement = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[4]/a"));
//StaffButtonElement.Click();
IWebElement CreateNewButtonElement = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
CreateNewButtonElement.Click();
IWebElement StaffButtonElement = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[4]/a"));
StaffButtonElement.Click();