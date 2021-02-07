Feature: SleepioOnboarding
	This feature is testing the onboarding process for a patient 
	looking to use the Sleep.io product

Scenario: SleepioOnboarding - Excellent Sleep workflow
	Given a user has launched the Sleepio onboarding site and clicks the Get Started button
	And answers the question 'How would you like to improve your sleep' with the following:
	| Answer                    |
	| Get to sleep more easily  |
	| Wake up feeling refreshed |
	And selects 'I don't have a problem' from the 'How long have you had a problem with sleep' dropdown question
	And answers the question 'Which of the following stops you from sleeping most often' with the following: 
	| Answer                      |
	| Worries about future events |
	And selects 'A little' from the 'To what extent has sleep troubled you in general' dropdown question
	And selects '0 nights' from the 'How many nights a week have you had a problem with your sleep' dropdown question
	And selects 'Never' from the 'How often have you felt that you were unable to control the important things in your life' dropdown question
	And selects 'No chance' from the 'How likely is it that you would fall asleep during the day' dropdown question
	And the user enters their information:
	| Key               | Value             |
	| Gender            | Female            |
	| Birthday          | April 5 1999      |
	| Employment status | Full-time student |
	And selects the guide 'Shift work and sleep' from the list of expert guides 
	When the user creates an account with a strong password and the following information:
	| Key        | Value     |
	| First name | Megan     |
	| Last name  | McCormick |
	Then the sleep score is '8.75' with a status of 'Excellent'

Scenario: SleepioOnboarding - Good Sleep path
	Given a user has launched the Sleepio onboarding site and clicks the Get Started button
	And answers the question 'How would you like to improve your sleep' with the following:
	| Answer            |
	| None of the above |
	And selects '1-2 months' from the 'How long have you had a problem with sleep' dropdown question
	And answers the question 'Which of the following stops you from sleeping most often' with the following: 
	| Answer                     |
	| Worries about not sleeping |
	And selects 'Not at all' from the 'To what extent has sleep troubled you in general' dropdown question
	And selects '3 nights' from the 'How many nights a week have you had a problem with your sleep' dropdown question
	And selects 'Almost never' from the 'How often have you felt that you were unable to control the important things in your life' dropdown question
	And selects 'Slight chance' from the 'How likely is it that you would fall asleep during the day' dropdown question
	And the user enters their information:
	| Key               | Value              |
	| Gender            | Female             |
	| Birthday          | June 15 1994       |
	| Employment status | Employed part-time |
	And selects '20%' from the 'How much did poor sleep affect your productivity while you were working' dropdown question
	And enters '0' for the question 'How many hours did you miss from your work per week because of problems associated with your sleep' question
	And selects the guide 'None of the above' from the list of expert guides 
	When the user creates an account with a strong password and the following information:
	| Key        | Value     |
	| First name | Megan     |
	| Last name  | McCormick |
	Then the sleep score is '7.5' with a status of 'Good'


Scenario: SleepioOnboarding - Fair Sleep path
	Given a user has launched the Sleepio onboarding site and clicks the Get Started button
	And answers the question 'How would you like to improve your sleep' with the following:
	| Answer                    |
	| Get to sleep more easily  |
	| Wake up feeling refreshed |
	And selects '3-6 months' from the 'How long have you had a problem with sleep' dropdown question
	And answers the question 'Which of the following stops you from sleeping most often' with the following: 
	| Answer                      |
	| Worries about future events |
	And selects 'Somewhat' from the 'To what extent has sleep troubled you in general' dropdown question
	And selects '3 nights' from the 'How many nights a week have you had a problem with your sleep' dropdown question
	And selects 'Fairly often' from the 'How often have you felt that you were unable to control the important things in your life' dropdown question
	And selects 'Slight chance' from the 'How likely is it that you would fall asleep during the day' dropdown question
	And the user enters their information:
	| Key               | Value                        |
	| Gender            | Male                         |
	| Birthday          | October 20 1990              |
	| Employment status | Full-time homemaker or carer |
	And selects the guide 'Managing your sleep as a parent' from the list of expert guides 
	When the user creates an account with a strong password and the following information:
	| Key        | Value     |
	| First name | Megan     |
	| Last name  | McCormick |
	Then the sleep score is '5.0' with a status of 'Fair'



Scenario: SleepioOnboarding - Poor Sleep path
	Given a user has launched the Sleepio onboarding site and clicks the Get Started button
	And answers the question 'How would you like to improve your sleep' with the following:
	| Answer                                          |
	| Sleep right through the night without waking up |
	| Get to sleep more easily                        |
	And selects '7-12 months' from the 'How long have you had a problem with sleep' dropdown question
	And answers the question 'Which of the following stops you from sleeping most often' with the following: 
	| Answer       |
	| Light levels |
	And selects 'Somewhat' from the 'To what extent has sleep troubled you in general' dropdown question
	And selects '4 nights' from the 'How many nights a week have you had a problem with your sleep' dropdown question
	And selects 'Sometimes' from the 'How often have you felt that you were unable to control the important things in your life' dropdown question
	And selects 'Slight chance' from the 'How likely is it that you would fall asleep during the day' dropdown question
	And the user enters their information:
	| Key               | Value              |
	| Gender            | Male               |
	| Birthday          | April 15 1979      |
	| Employment status | Employed full-time |
	And selects '20%' from the 'How much did poor sleep affect your productivity while you were working' dropdown question
	And enters '2' for the question 'How many hours did you miss from your work per week because of problems associated with your sleep' question
	And selects the guide 'Shift work and sleep' from the list of expert guides 
	When the user creates an account with a strong password and the following information:
	| Key        | Value     |
	| First name | Megan     |
	| Last name  | McCormick |
	Then the sleep score is '3.75' with a status of 'Poor'

Scenario: SleepioOnboarding - Very Poor Sleep workflow
	Given a user has launched the Sleepio onboarding site and clicks the Get Started button
	And answers the question 'How would you like to improve your sleep' with the following:
	| Answer                                          |
	| Sleep right through the night without waking up |
	| Stop waking up too early                        |
	| Wake up feeling refreshed                       |
	And selects '11 or more years' from the 'How long have you had a problem with sleep' dropdown question
	And answers the question 'Which of the following stops you from sleeping most often' with the following: 
	| Answer                    |
	| Bodily discomfort or pain |
	And selects 'Very much' from the 'To what extent has sleep troubled you in general' dropdown question
	And selects '7 nights' from the 'How many nights a week have you had a problem with your sleep' dropdown question
	And selects 'Very often' from the 'How often have you felt that you were unable to control the important things in your life' dropdown question
	And selects 'High chance' from the 'How likely is it that you would fall asleep during the day' dropdown question
	And answers the question 'Has your snoring ever bothered other people' with the following: 
	| Answer |
	| Yes    |
	And answers the question 'Has anyone noticed that you stop breathing during sleep' with the following: 
	| Answer |
	| Yes    |
	And the user enters their information:
	| Key               | Value        |
	| Gender            | Female       |
	| Birthday          | April 5 1960 |
	| Employment status | Retired      |
	And selects the guide 'None of the above' from the list of expert guides 
	When the user creates an account with a strong password and the following information:
	| Key        | Value     |
	| First name | Megan     |
	| Last name  | McCormick |
	Then the sleep score is '0.0' with a status of 'Very Poor'


