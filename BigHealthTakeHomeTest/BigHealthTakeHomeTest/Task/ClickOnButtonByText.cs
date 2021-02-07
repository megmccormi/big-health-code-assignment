using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigHealthTakeHomeTest.Task
{
    public class ClickOnButtonByText : ITask
    {
        public string ButtonText { get; }
        public IWebLocator Locator { get; }

        public ClickOnButtonByText(string buttonText, IWebLocator locator)
        {
            ButtonText = buttonText;
            Locator = locator;
        }

        public static ClickOnButtonByText On(string buttonText, IWebLocator locator) => 
            new ClickOnButtonByText(buttonText, locator);

        public void PerformAs(IActor actor)
        {
            var driver = actor.Using<BrowseTheWeb>().WebDriver;
            actor.WaitsUntil(Existence.Of(Locator), IsEqualTo.True());
            var element = driver.FindElements(Locator.Query).FirstOrDefault(e => e.Text == ButtonText);
            element.Click();
        }
    }
}
