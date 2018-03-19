using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver client = new ChromeDriver();
            client.Navigate().GoToUrl("https://ineffabletots.wordpress.com/");
            client.Manage().Window.Maximize();
            // Next lines of command will click the about page and scroll to read the content
            client.FindElement(By.CssSelector(".page_item > a:nth-child(1)")).Click();
            ((IJavaScriptExecutor)client).ExecuteScript("window.scrollTo(0, 300)");
            Thread.Sleep(3000);
            ((IJavaScriptExecutor)client).ExecuteScript("window.scrollTo(0, 450)");
            Thread.Sleep(3000);
            ((IJavaScriptExecutor)client).ExecuteScript("window.scrollTo(0, 600)");
            Thread.Sleep(3000);
            ((IJavaScriptExecutor)client).ExecuteScript("window.scrollTo(0, 750)");
            Thread.Sleep(3000);
            // The next lines navigates back to the mainpage and scrolls to first story, clicks and reads through
            client.FindElement(By.CssSelector(".site-title > a:nth-child(1)")).Click();
            Thread.Sleep(3000);
            ((IJavaScriptExecutor)client).ExecuteScript("window.scrollTo(0, 300)");
            Thread.Sleep(3000);
            ((IJavaScriptExecutor)client).ExecuteScript("window.scrollTo(0, 450)");
            Thread.Sleep(3000);
            ((IJavaScriptExecutor)client).ExecuteScript("window.scrollTo(0, 600)");
            client.FindElement(By.CssSelector("#post-2190 > header:nth-child(1) > h2:nth-child(1) > a:nth-child(1)")).Click();
            ((IJavaScriptExecutor)client).ExecuteScript("window.scrollTo(0, 300)");
            Thread.Sleep(3000);
            ((IJavaScriptExecutor)client).ExecuteScript("window.scrollTo(0, 450)");
            Thread.Sleep(3000);
            ((IJavaScriptExecutor)client).ExecuteScript("window.scrollTo(0, 600)");
            Thread.Sleep(3000);
            ((IJavaScriptExecutor)client).ExecuteScript("window.scrollTo(0, 750)");
            Thread.Sleep(3000);
            ((IJavaScriptExecutor)client).ExecuteScript("window.scrollTo(0, 900)");
            Thread.Sleep(7000);
            ((IJavaScriptExecutor)client).ExecuteScript("window.scrollTo(0, 1050)");
            Thread.Sleep(3000);
            // End Automation process by closing the browser
            client.Quit();
        }
    }
}
