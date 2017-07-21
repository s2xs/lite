using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


/* namespace selenium.test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
*/
class Google
{

	static void Main(string[] args)
	{
		IWebDriver driver = new ChromeDriver();
		driver.Navigate().GoToUrl("http://www.google.com/");
		driver.Quit();
	}

}