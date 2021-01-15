using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NPOI.SS.UserModel;
using System.Threading;
using NPOI.Util;
using NPOI.XSSF.UserModel;
using NUnit.Framework;
using System.IO;
using System.Reflection;
using Assert = NUnit.Framework.Assert;


namespace Azure_demo
{

    public class class1
    {
        [Test]
        public void SearchForWord()
        {
            var driver = new ChromeDriver();

            {
              
                driver.Navigate().GoToUrl("https://google.com");

                Console.WriteLine(driver.Title + " coming from test 1,hello ");

                driver.Quit();
               


            }
        }
    }
}
