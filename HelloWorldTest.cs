using Microsoft.Edge.SeleniumTools;
using OpenQA.Selenium.Chrome;

namespace itladevops_hola_mundo_final;
public class HelloWorldTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test(ExpectedResult = true)]
    public bool HelloWorldExists()
    {
        bool result = true;

        var options = new ChromeOptions();
        options.AddArguments("--allowed-ips", "127.0.0.1");
        var driver = new ChromeDriver(options);

        driver.Navigate().GoToUrl($"{Directory.GetCurrentDirectory()}../../../../page/index.html");
        var elementoHolaMundo = driver.FindElement(OpenQA.Selenium.By.XPath("/html/body/h1"));

        if (elementoHolaMundo != null) 
        {
            if (elementoHolaMundo.Text != "Hola mundo") result = false;
        }
        else result = false;

        driver.Close();
        return result;
    }
}