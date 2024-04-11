using HtmlAgilityPack;

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
        var document = new HtmlDocument();
        document.LoadHtml(File.ReadAllText($"{Directory.GetCurrentDirectory()}../../../../page/index.html"));
        //Change for reload
        var h1 = document.DocumentNode.SelectSingleNode("/html/body/h1");

        if (h1 == null) return false;
        if (h1.InnerText != "Hola mundo") return false;
        return true;
    }
}