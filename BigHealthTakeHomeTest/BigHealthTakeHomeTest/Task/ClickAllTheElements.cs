using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigHealthTakeHomeTest.Task
{
    public class ClickAllTheElements : ITask
    {
        public IWebLocator Locator { get; }

        public ClickAllTheElements(IWebLocator locator)
        {
            Locator = locator;
        }

        public static ClickAllTheElements On(IWebLocator locator) => 
            new ClickAllTheElements(locator);

        public void PerformAs(IActor actor)
        {
            var driver = actor.Using<BrowseTheWeb>().WebDriver;
            actor.WaitsUntil(Existence.Of(Locator), IsEqualTo.True());
            var elements = driver.FindElements(Locator.Query).ToList();
            elements.ForEach(e => e.Click());
        }
    }
}
