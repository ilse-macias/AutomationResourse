using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationResourse
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.qtptutorial.net/automation-practice/");
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(20000);

            IWebElement bottonID = driver.FindElement(By.Id("idExample"));
            bottonID.Click();
            driver.Navigate().Back();

            /*List using xPath. Indicate total of elements added in the list*/
            By xPathList = By.XPath("//*[@type='radio']");
            IList<IWebElement> radioButtonList = driver.FindElements(xPathList);
            Thread.Sleep(20000);

            Console.WriteLine("El total de elementos agregados en la lista son: " + radioButtonList.Count);


            /*Toogles*/
            By xPathToggle = By.XPath("//*[contains(text(), 'Tab 1')]");
            IWebElement toggle = driver.FindElement(xPathToggle);
            System.Threading.Thread.Sleep(20000);
            toggle.Click();

            /*Print the table in console */
            By tableID = By.Id("htmlTableId");
            IWebElement table = driver.FindElement(tableID);
            Console.WriteLine("Text ID \n" + table.Text + "\n");

            By tableXpath = By.XPath("//*[@id='htmlTableId']");
            IWebElement tables = driver.FindElement(tableXpath);
            Console.WriteLine("Table XPath \n" + tables.Text + "\n");

            try
            {
                //IWebElement radioButton = driver.FindElement(By.XPath("//*[contains(text(), 'I love HP UFT')]"));

                /*XPATH absolute*/
                //IWebElement radioButton = driver.FindElement(By.XPath("//*[@id='post-5969']/div/div[3]/div/div[1]/div[7]/div/form/input[3]"));

                /*XPATH radiobutton using index*/
                IWebElement radioButton = driver.FindElement(By.XPath("//*[@type='radio'][2]"));
                Thread.Sleep(20000);
                radioButton.Click();
            }

            catch (NoSuchElementException)
            {
                Console.WriteLine("Errores");

            }

        }
    }
}
