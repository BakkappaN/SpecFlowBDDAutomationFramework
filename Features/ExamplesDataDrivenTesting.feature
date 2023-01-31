Feature: Examples Data Driven Testing

Search in the youtube

@TestersTalk
Scenario Outline:  Examples Data Driven Testing
	Given Open the browser
	When Enter the URL
	Then Search with <searchKey>
	Examples: 
	| searchKey                |
	| specflow by testers talk |
	| selenium by testers talk |
