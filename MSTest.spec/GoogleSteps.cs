using System;
using TechTalk.SpecFlow;
using Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest.spec
{
    [Binding]
    public class GoogleSteps
    {
        private GoogleMainPage googlemainpage = new GoogleMainPage();

        [Given(@"I started web browser")]
        public void GivenIStartedWebBrowser()
        {
            googlemainpage.startChrome();
        }
        
        [When(@"I navigate to google\.com")]
        public void WhenINavigateToGoogle_Com()
        {
            googlemainpage.navigateGoogleMainPage();
        }
        
        [Then(@"Google landing page will be shown")]
        public void ThenGoogleLandingPageWillBeShown()
        {
            //bool gevonden = googlemainpage.checkElement("//img[@alt]='Google'");
            //googlemainpage.checkElement("//img[@alt]='Google'");
            googlemainpage.findGoogleLogo();
            //Assert.AreEqual(true, gevonden);
        }

        [AfterScenario]
        public void CleanUp()
        {
            googlemainpage.closeChrome();
        }
    }
}
