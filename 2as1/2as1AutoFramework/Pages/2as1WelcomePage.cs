using _2as1AutoFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2as1.AutoFramework.Pages
{
    public class _2as1WelcomePage
    {
        public static bool IsAt
        {
            get
            {
                var standingsHeader = Driver.Instance.FindElement(By.Id("IterationDetailHeader"));
                return (standingsHeader.Text.Contains("Iteration Detail"));
            }
        }

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("http://2-as-1.com");
        }
    }
}
