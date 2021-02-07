using BigHealthTakeHomeTest.Helper;
using BigHealthTakeHomeTest.Pages;
using BigHealthTakeHomeTest.Task;
using Boa.Constrictor.Logging;
using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Xunit;

namespace BigHealthTakeHomeTest.StepDefinitions
{
    [Binding]
    public sealed class SleepioOnboardingSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private IActor _actor;

        public SleepioOnboardingSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _actor = new Actor(logger: new ConsoleLogger());
            _actor.Can(BrowseTheWeb.With(new ChromeDriver()));
        }

        [Given(@"a user has launched the Sleepio onboarding site and clicks the Get Started button")]
        public void GivenAUserHasLaunchedTheSleepioOnboardingSiteAndClicksTheGetStartedButton()
        {
            _actor.AttemptsTo(Navigate.ToUrl(OnboardingPage.OnboardingUrl));
            _actor.AttemptsTo(Click.On(OnboardingPage.GetStartedButton));
        }

        [Given(@"answers the question '(.*)' with the following:")]
        public void GivenAnswersTheQuestionWithTheFollowing(string question, Table table)
        {
            List<string> answers = TableExtensions.ToList(table);
            IWebLocator locator = GetLocatorByQuestion(question);

            foreach(string answer in answers)
            {
                _actor.AttemptsTo(ClickOnButtonByText.On(answer, locator));
            }

            _actor.AttemptsTo(Click.On(OnboardingPage.ContinueButton));
        }

        [Given(@"selects '(.*)' from the '(.*)' dropdown question")]
        public void GivenSelectsFromTheDropdownQuestion(string answer, string question)
        {
            IWebLocator locator = GetLocatorByQuestion(question);
            _actor.AttemptsTo(Select.ByText(locator, answer));
            _actor.AttemptsTo(Click.On(OnboardingPage.ContinueButton));
        }

        [Given(@"the user enters their information:")]
        public void GivenTheUserEntersTheirInformation(Table table)
        {
            Dictionary<string, string> userInformation = TableExtensions.ToDictionary(table);
            // Gender page
            _actor.AttemptsTo(ClickOnButtonByText.On(userInformation["Gender"], OnboardingPage.GenderOptions));
            _actor.AttemptsTo(Click.On(OnboardingPage.ContinueButton));

            // Birthdate page
            List<string> birthdate = userInformation["Birthday"].Split(" ").ToList();
            _actor.AttemptsTo(Select.ByText(OnboardingPage.BirthdateMonth, birthdate[0]));
            _actor.AttemptsTo(Select.ByText(OnboardingPage.BirthdateDay, birthdate[1]));
            _actor.AttemptsTo(Select.ByText(OnboardingPage.BirthdateYear, birthdate[2]));
            _actor.AttemptsTo(Click.On(OnboardingPage.ContinueButton));

            // Employment status
            _actor.AttemptsTo(Select.ByText(OnboardingPage.EmploymentStatusDropdown, userInformation["Employment status"]));
            _actor.AttemptsTo(Click.On(OnboardingPage.ContinueButton));
        }

        [Given(@"selects the guide '(.*)' from the list of expert guides")]
        public void GivenSelectsTheGuideFromTheListOfExpertGuides(string expertGuide)
        {
            _actor.AttemptsTo(ClickOnButtonByText.On(expertGuide, OnboardingPage.ExpertGuidesOptions));
            _actor.AttemptsTo(Click.On(OnboardingPage.ContinueButton));
        }

        [Given(@"enters '(.*)' for the question '(.*)' question")]
        public void GivenEntersForTheQuestionQuestion(string answer, string question)
        {
            IWebLocator locator = GetLocatorByQuestion(question);
            _actor.AttemptsTo(SendKeys.To(OnboardingPage.HoursMissedInput, answer));
            _actor.AttemptsTo(Click.On(OnboardingPage.ContinueButton));
        }


        [When(@"the user creates an account with a strong password and the following information:")]
        public void WhenTheUserCreatesAnAccountWithTheFollowingInformation(Table table)
        {
            Dictionary<string, string> accountInformation = TableExtensions.ToDictionary(table);
            _actor.AttemptsTo(SendKeys.To(CreateAccountPage.FirstNameInput, accountInformation["First name"]));
            _actor.AttemptsTo(SendKeys.To(CreateAccountPage.LastNameInput, accountInformation["Last name"]));

            List<string> email = CreateAccountPage.Email.Split('@').ToList();
            Random random = new Random();
            int number = random.Next(0, 100);
            string emailToCreate = $"{email[0]}+{number}@{email[1]}";

            _actor.AttemptsTo(SendKeys.To(CreateAccountPage.EmailInput, emailToCreate));
            _actor.AttemptsTo(SendKeys.To(CreateAccountPage.PasswordInput, CreateAccountPage.Password));

            // Privacy policy and insomnia disorder acknowledgement
            _actor.AttemptsTo(ClickAllTheElements.On(CreateAccountPage.PrivacyCheckboxes));

            _actor.AttemptsTo(Click.On(CreateAccountPage.SignUpButton));
        }

        [Then(@"the sleep score is '(.*)' with a status of '(.*)'")]
        public void ThenTheSleepScoreIsWithAStatusOf(string expectedScore, string expectedStatus)
        {
            string actualScore = _actor.AsksFor(Text.Of(SleepScorePage.SleepReportScore));
            string actualStatus = _actor.AsksFor(Text.Of(SleepScorePage.SleepScoreGraphic));

            Assert.Contains(expectedScore, actualScore);
            Assert.Contains(expectedStatus.ToUpper(), actualStatus);
        }

        [AfterScenario]
        public void TearDownWebDriver()
        {
            _actor.AttemptsTo(QuitWebDriver.ForBrowser());
        }


        private IWebLocator GetLocatorByQuestion(string question)
        {
            switch (question)
            {
                case "How would you like to improve your sleep":
                    return OnboardingPage.ImproveSleepAnswers;

                case "How long have you had a problem with sleep":
                    return OnboardingPage.HowLongProblemSleepDropDown;

                case "Which of the following stops you from sleeping most often":
                    return OnboardingPage.StopSleepingMostOftenAnswers;

                case "To what extent has sleep troubled you in general":
                    return OnboardingPage.TroubledSleepExtentDropdown;

                case "How many nights a week have you had a problem with your sleep":
                    return OnboardingPage.NightsAWeekSleepingProblemDropdown;

                case "How often have you felt that you were unable to control the important things in your life":
                    return OnboardingPage.UnableToControlDropDown;

                case "How likely is it that you would fall asleep during the day":
                    return OnboardingPage.FallAsleepDuringDayDropDown;

                case "Has your snoring ever bothered other people":
                    return OnboardingPage.SnoringBotheredPeopleAnswers;
                
                case "Has anyone noticed that you stop breathing during sleep":
                    return OnboardingPage.StopBreathingAnswers;

                case "How much did poor sleep affect your productivity while you were working":
                    return OnboardingPage.ProductivityAffectedDropdown;

                case "How many hours did you miss from your work per week because of problems associated with your sleep":
                    return OnboardingPage.HoursMissedInput;

                default:
                    throw new ArgumentException("Not a valid question based on Sleepio form");
            }
        }
    }
}
