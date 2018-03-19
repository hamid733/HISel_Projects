using FourthSelenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthSeleniumTest
{
    [TestClass]
    public class TestSetup
    {

        public Amazon_HomePage Hpage = new Amazon_HomePage();
        [TestInitialize]

        public void Initialize_Browser()
        {
            var driver = new BrowserDriver();
            driver.Initialise();
            Hpage.Go_To_Amazone_HomePage();
            
        }
        [TestCleanup]

        public void Cleanup()
        {
            //UserLogin.CloseBrowser();

        }
    }
}
