using _2as1AutoFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2as1.Tests
{
    public class UITests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }


        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }

    }
}
