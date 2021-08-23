Feature: Model
As a user
I want to get models

@prod
Scenario: Get the Model
	When User call GetModelsAPI
	Then User see Multiple Models