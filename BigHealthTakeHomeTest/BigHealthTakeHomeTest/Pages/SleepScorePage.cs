using Boa.Constrictor.WebDriver;
using OpenQA.Selenium;
using static Boa.Constrictor.WebDriver.WebLocator;

namespace BigHealthTakeHomeTest.Pages
{
    public static class SleepScorePage
    {
        public static IWebLocator SleepReportScore = L("Sleep Report Score", By.ClassName("sl-score"));
        public static IWebLocator SleepScoreGraphic = L("Sleep Report Score", By.ClassName("sl-arrow-box"));

    }
}
