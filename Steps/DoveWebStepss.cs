using System;
using TechTalk.SpecFlow;
using DoveWeb.Pages;
using DoveWeb.Utilities;
using System.Threading;

namespace DoveWeb.Steps
{
    [Binding]
    public class DoveWebFeaturesSteps
    {
        [Given(@"I opened the dove home url")]
        public void GivenIOpenedTheDoveHomeUrl()
        {
            Search.OpenUrl();
        }
        
        [When(@"I Click on search")]
        public void WhenIClickOnSearch()
        {
            Search.ClickOnSearch();
        }
        
        [When(@"I entered search text shampoo ans searched")]
        public void WhenIEnteredSearchTextShampooAnsSearched()
        {
            Search.SearchingShampoo();
            
        }
        
        [Then(@"I verify the text Shampoo text in the page")]
        public void ThenIVerifyTheTextShampooTextInThePage()
        {
            Search.VerifyShampoo();
            Screenshot.Sshot("Shampoo");
        }
        [Given(@"I opened the dove home url of dove")]
        public void GivenIOpenedTheDoveHomeUrlOfDove()
        {
            Search.OpenUrl();
        }

        [When(@"I click on discover more")]
        public void WhenIClickOnDiscoverMore()
        {
            DiscoveMore.ClickOnDiscoverMore();
        }

        [Then(@"I verify the text “The Real Women behind \#StopTheBeautyTest in page")]
        public void ThenIVerifyTheTextTheRealWomenBehindStopTheBeautyTestInPage()
        {
            DiscoveMore.VerifyDiscoverMoreText();
            Screenshot.Sshot("DiscoverMore");
        }
        [Given(@"I opened the dove home url of dove Web application")]
        public void GivenIOpenedTheDoveHomeUrlOfDoveWebApplication()
        {
            Search.OpenUrl();
        }

        [When(@"I Clicked on terms of use")]
        public void WhenIClickedOnTermsOfUse()
        {
            TermsOfUse.ClickOnTermsOfUse();
        }

        [Then(@"I Verify the section Prohibited uses")]
        public void ThenIVerifyTheSectionProhibitedUses()
        {
            TermsOfUse.VerfiyTermsOfUseText();
            Screenshot.Sshot("TermsOfUse");
        }


    }
}
