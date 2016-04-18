using System;
using _2as1.AutoFramework;
using _2as1.AutoFramework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2as1.Tests.Features;

namespace _2as1.Tests.Features
{
    [TestClass]
    public class WelcomePageTests : UITests
    {

        /// <summary>
        /// Generic Starter UI Tests for Basic Controller/Views
        /// </summary>
        [TestMethod]
        public void UI_Welcome_01_WelcomePage_BasicValidation()
        {
            StoryBasics.AsA(Role.Delivery_Lead)
                .IWant("ACCESS TO AN EMPLOYEE DETAILS PAGE")
                .SoThat("SO I CAN MANAGE MY STAFF");
            _2as1WelcomePage.GoTo();

            Assert.IsTrue(_2as1WelcomePage.IsAt, "The user is not at the Home Page");

        }
    }
}
