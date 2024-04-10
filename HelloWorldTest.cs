using Microsoft.Edge.SeleniumTools;

namespace itladevops_hola_mundo_final;
public class HelloWorldTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test(ExpectedResult = true)]
    public bool Test1()
    {
        bool result = true;

        var options = new EdgeOptions();
        options.UseChromium = true;
        var driver = new EdgeDriver(options);

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