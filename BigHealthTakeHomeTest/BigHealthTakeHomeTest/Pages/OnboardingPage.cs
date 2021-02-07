using Boa.Constrictor.WebDriver;
using OpenQA.Selenium;
using static Boa.Constrictor.WebDriver.WebLocator;

namespace BigHealthTakeHomeTest
{
    public static class OnboardingPage
    {
        public static string OnboardingUrl = "https://onboarding.sleepio.com/sleepio/big-health";

        public static IWebLocator GetStartedButton => L("Get Started Button",By.CssSelector("input[value='Get started']"));

        public static IWebLocator ContinueButton => L("Continue Button", By.XPath("//button[contains(text(), 'Continue')]"));

        public static IWebLocator ImproveSleepAnswers => L("Improve Sleep Answers",By.ClassName("sl-option"));

        public static IWebLocator HowLongProblemSleepDropDown => L("How Long Problem Sleep Dropdown", By.CssSelector("div[data-semantic-id='problem_sleep'] select"));

        public static IWebLocator StopSleepingMostOftenAnswers => L("Stops You From sleeping most often answers", By.CssSelector("div[data-semantic-id='stop_sleeping'] label"));

        public static IWebLocator TroubledSleepExtentDropdown => L("Troubled Sleep Extent Dropdown", By.CssSelector("div[data-semantic-id='troubled_in_general'] select"));
        public static IWebLocator NightsAWeekSleepingProblemDropdown => L("How Many Nights A Week Sleeping Problem Dropdown", By.CssSelector("div[data-semantic-id='problem_nights'] select"));
        public static IWebLocator UnableToControlDropDown => L("Unable To Control Important Things Dropdown", By.CssSelector("div[data-semantic-id='unable_to_control'] select"));
        public static IWebLocator FallAsleepDuringDayDropDown => L("How often fall asleep during the day", By.CssSelector("div[data-semantic-id='fall_asleep_stay_awake'] select"));
        public static IWebLocator SnoringBotheredPeopleAnswers => L("Has your snoring ever bothered other people question", By.CssSelector("div[data-semantic-id='snoring'] label"));

        public static IWebLocator StopBreathingAnswers => L("Has anyone noticed that you stop breathing", By.CssSelector("div[data-semantic-id='stop_breathing'] label"));

        public static IWebLocator GenderOptions => L("Gender Options Buttons", By.CssSelector("div[data-semantic-id='gender'] label"));
        public static IWebLocator BirthdateMonth => L("Birthdate Month", By.Id("select-month"));
        public static IWebLocator BirthdateDay => L("Birthdate Month", By.Id("select-day"));
        public static IWebLocator BirthdateYear => L("Birthdate Month", By.Id("select-year"));
        
        public static IWebLocator EmploymentStatusDropdown => L("Employment Status Dropdowns", By.CssSelector("div[data-semantic-id='employment_status'] select"));

        public static IWebLocator HoursMissedInput => L("Hours Missed Input", By.CssSelector("div[data-semantic-id='hours_missed'] input"));
        public static IWebLocator ProductivityAffectedDropdown => L("Work Productivity Affected Dropdown", By.CssSelector("div[data-semantic-id='affect_productivity'] select"));
        public static IWebLocator ExpertGuidesOptions => L("Expert Guide Options", By.CssSelector("div[data-semantic-id='expert_guides'] label"));        
    }




}
