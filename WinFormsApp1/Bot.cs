using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public static class Bot
    {
        // setting the variables
        public static string tckn;
        public static string sifre;
        public static IWebDriver driver;
        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        public static void Times(this int count, Action action)
        {
            // repetition legitimizes.
            for (int i = 0; i < count; i++)
            {
                action();
            }
        }
        public static void launch()
        {
            // Setting the driver options.

            ChromeOptions options = new ChromeOptions();
            options.AddArgument($@"user-data-dir="+path+@"\Local\Google\Chrome\UserData\Default");
            
           //  launching the driver and checking the version           
            IWebDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("chrome://version");

            while (true)
            {
                int hour = DateTime.Now.Hour;
                int minute = DateTime.Now.Minute;
             
                if (hour == 09 && minute > 30) 
                { 
                   break;
                }
                else
                {
                    Thread.Sleep(5);
                };
                
            }

            // logging in
            driver.Navigate().GoToUrl("https://giris.eba.gov.tr/EBA_GIRIS/giris.jsp");
            driver.FindElement(By.XPath("//*[@id=\"tckn\"]")).SendKeys(tckn);
            driver.FindElement(By.XPath("//*[@id=\"password\"]")).SendKeys(sifre);
            driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div/div[2]/form/div[5]/button")).Click();


// this is a terrible way of doing this. Too bad!

            // joining the lesson
            driver.Navigate().GoToUrl("https://eba.gov.tr/#/anasayfa");
            driver.FindElement(By.XPath("/html/body/app-root/app-anasayfa-page/div[2]/div/div/div[1]/div[2]/div[3]/div[3]/a[2]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(("//*[@id=\"joinMeeting\"]"))).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("join")).Click();
            Thread.Sleep(605000);
            // joining the lesson
            driver.Navigate().GoToUrl("https://eba.gov.tr/#/anasayfa");
            driver.FindElement(By.XPath("/html/body/app-root/app-anasayfa-page/div[2]/div/div/div[1]/div[2]/div[3]/div[3]/a[2]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(("//*[@id=\"joinMeeting\"]"))).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("join")).Click();
            Thread.Sleep(605000);
            // joining the lesson
            driver.Navigate().GoToUrl("https://eba.gov.tr/#/anasayfa");
            driver.FindElement(By.XPath("/html/body/app-root/app-anasayfa-page/div[2]/div/div/div[1]/div[2]/div[3]/div[3]/a[2]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(("//*[@id=\"joinMeeting\"]"))).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("join")).Click();
            Thread.Sleep(605000);
            // joining the lesson
            driver.Navigate().GoToUrl("https://eba.gov.tr/#/anasayfa");
            driver.FindElement(By.XPath("/html/body/app-root/app-anasayfa-page/div[2]/div/div/div[1]/div[2]/div[3]/div[3]/a[2]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(("//*[@id=\"joinMeeting\"]"))).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("join")).Click();
            Thread.Sleep(605000);
            // joining the lesson
            driver.Navigate().GoToUrl("https://eba.gov.tr/#/anasayfa");
            driver.FindElement(By.XPath("/html/body/app-root/app-anasayfa-page/div[2]/div/div/div[1]/div[2]/div[3]/div[3]/a[2]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(("//*[@id=\"joinMeeting\"]"))).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("join")).Click();
            Thread.Sleep(605000);
            // joining the lesson
            driver.Navigate().GoToUrl("https://eba.gov.tr/#/anasayfa");
            driver.FindElement(By.XPath("/html/body/app-root/app-anasayfa-page/div[2]/div/div/div[1]/div[2]/div[3]/div[3]/a[2]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(("//*[@id=\"joinMeeting\"]"))).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("join")).Click();
            Thread.Sleep(605000);
            // joining the lesson
            driver.Navigate().GoToUrl("https://eba.gov.tr/#/anasayfa");
            driver.FindElement(By.XPath("/html/body/app-root/app-anasayfa-page/div[2]/div/div/div[1]/div[2]/div[3]/div[3]/a[2]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(("//*[@id=\"joinMeeting\"]"))).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("join")).Click();
            Thread.Sleep(605000);
            // joining the lesson
            driver.Navigate().GoToUrl("https://eba.gov.tr/#/anasayfa");
            driver.FindElement(By.XPath("/html/body/app-root/app-anasayfa-page/div[2]/div/div/div[1]/div[2]/div[3]/div[3]/a[2]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(("//*[@id=\"joinMeeting\"]"))).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("join")).Click();
            Thread.Sleep(605000);


        }
    }
}
