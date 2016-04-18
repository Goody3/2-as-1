using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2as1AutoFramework
{
    public class Driver
    {
        public static IWebDriver Instance { get; internal set; }

        public static void Initialize()
        {
            //Instance = new FirefoxDriver();
            Instance = new ChromeDriver();
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }

        public static void Close()
        {
            Instance.Close();
        }
    }
}
