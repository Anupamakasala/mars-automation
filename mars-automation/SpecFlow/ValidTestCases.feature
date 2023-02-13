Feature: This features captures all valid test cases for the below mentioned acceptance criteria

	* Seller is able to add the Profile Details.
	* Seller is able to see the seller's details on the profile page.


@Test
Scenario: Verify user is able to update his/her first and last name details
	Given a valid user logs into the application
	Given user navigates to the Profile tab
	Given clicks on their name
	When user updates existing values of First Name and Last Name field
	When clicks Save button
	Then first and last name details are updated

@Test
Scenario Outline: Verify user is able to update his/her availability details
	Given a valid user logs into the application
	Given user navigates to the Profile tab
	When clicks on the pencil icon next to Availability field
	When user selects '<availability type>'
	Then availability field is updated

	Examples:
	| availability type |
	| "Part time"	    |
	| "Full time"       |

@Test
Scenario Outline: Verify user is able to update his/her Hours details
	Given a valid user logs into the application
	Given user navigates to the Profile tab
	When clicks on the pencil icon next to Hours field
	When user selects '<hours type>'
	Then Hours field is updated

	Examples:
	| hours type				 |
	| "Less than 30hours a week" |
	| "More than 30hours a week" |
	| "As needed"				 |

@Test
Scenario Outline: Verify user is able to update his/her Earn Target details
	Given a valid user logs into the application
	Given user navigates to the Profile tab
	When clicks on the pencil icon next to Earn Target field
	When user selects '<earn target type>'
	Then Earn Target field is updated

	Examples:
	| earn target type					 |
	| "Less than $500 per month"		 |
	| "Between $500 and $1000 per month" |
	| "More than $1000 per month"		 |

@Test
Scenario: Verify user is able to add/update his/her Description details
	Given a valid user logs into the application
	Given user navigates to the Profile tab
	Given clicks on their Description
	When user adds/updates value in the Description field less than or equal to 600 characters
	When clicks Save button
	Then Description details are saved/updated

@Test
Scenario Outline: Verify user is able to add Languages details
	Given a valid user logs into the application
	Given user navigates to the Profile tab
	Given clicks on Add New button under Languages tab
	When user selects adds a '<language>' and selects a '<language level>'
	When clicks Save button
	Then Language details are saved

	Examples:
	| language  | language level     |
	| "English" | "Basic"            |
	| "Hindi"   | "Conversational"   |
	| "Chinese" | "Fluent"           |
	| "Latin"   | "Native/Bilingual" |

	
@Test
Scenario Outline: Verify user is able to add skills details
	Given a valid user logs into the application
	Given user navigates to the Profile tab
	Given clicks on Add New button under Skills tab
	When user selects adds a '<skill>' and selects a '<skill level>'
	When clicks Save button
	Then Language details are saved

	Examples:
	| skill				   | skill level    |
	| "Functional Testing" | "Beginner"     |
	| "Automation Testing" | "Intermeditae" |
	| "Selenium"		   | "Expert"       |

@Test
Scenario Outline: Verify user is able to add Education details
	Given a valid user logs into the application
	Given user navigates to the Profile tab
	Given clicks on Add New button under Education tab
	When user selects adds a '<College/University Name>', selects a '<Country>', selects a '<Title>', adds a '<Degree>' and selects a '<Year of graduation>'
	When clicks Save button
	Then Education details are saved

	Examples:
	| College/University Name | Country        | Title    | Degree			  | Year of graduation |
	| "Auckland Univeristy"   | "New Zealand"  | "B.Tech" | "Graduation"	  | "2011"             |
	| "Victoria Univeristy"   | "New Zealand"  | "M.Tech" | "Post Graduation" | "2015"             |

@Test
Scenario Outline: Verify user is able to add Certifications details
	Given a valid user logs into the application
	Given user navigates to the Profile tab
	Given clicks on Add New button under Certifications tab
	When user selects adds a '<Certificate or Award>', selects a '<Certified From>', and selects a '<Year>'
	When clicks Save button
	Then Education details are saved

	Examples:
	| Certificate or Award | Certified From | Year   | 
	| ".Net"			   | "Microsoft"    | "2016" |           
	| "SalesForce Admin"   | "SalesForce"   | "2018" |           

# Automated
@Test
Scenario Outline: Verify user is able to add a skill via share skill page
	Given a valid user logs into the application
	Given user clicks on Share Skill button
	Given user populates '<Title>', '<Description>', '<Category>', '<Sub Category>', '<Tags>', '<Service Type>', '<Location Type>', '<Start Date>', '<End Date>', '<Skill Trade>', '<Skill-Exchange>', '<Credit>', '<Active>' fields
	When user clicks on save button
	Then Listing details are saved

	Examples:
	| Title               | Description          | Category             | Sub Category | Tags                 | Service Type           | Location Type | Start Date   | End Date     | Skill Trade      | Skill-Exchange | Credit | Active   |
	| "Automation Testing | "Sample Description" | "Programming & Tech" | "QA"         | "Selenium"           | "Hourly basis service" | "On-site"     | "01/06/2023" | "01/12/2023" | "Skill-exchange" | "Testing"      | ""     | "Active" |
	| "Manual Testing"    | "Sample Description" | "Programming & Tech" | "QA"         | "Functional Testing" | "One-off service"      | "Online"      | "01/06/2023" | "01/12/2023" | "Credit"         | ""             | "100"  | "Hidden" |

# Automated
@Test
Scenario Outline: Verify user is able to view a listing
	Given a valid user logs into the application
	Given user clicks on Manage Listing tab
	When user clicks on view listing icon
	Then listing details are loaded correctly

	Examples:
	| Title            |
	| "Manual Testing" |

# Automated
@Test
Scenario Outline: Verify user is able to delete a listing
	Given a valid user logs into the application
	Given user clicks on Manage Listing tab
	When user clicks on delete listing icon
	Then listing details are deleted

	Examples:
	| Title            |
	| "Manual Testing" |