Feature: This features captures all valid test cases for the below mentioned acceptance criteria

	* Seller is able to add the Profile Details.
	* Seller is able to see the seller's details on the profile page.


@Test
Scenario: verify user is able to update his/her first and last name details
	Given a valid user logs into the application
	Given user navigates to the profile tab
	Given clicks on their name
	When user updates existing values of first name and last name field
	When clicks save button
	Then first and last name details are updated

# Automated
@Test
Scenario Outline: Verify user is able to update his/her availability details
	Given a valid user logs into the application
	Given user navigates to the Profile tab
	When clicks on the pencil icon next to Availability field
	When user selects availability '<availability_type>'
	Then availability field is updated to '<availability_type>'

Examples:
	| availability_type |
	| Part Time         |
	| Full Time         |

# Automated
@Test
Scenario Outline: Verify user is able to update his/her Hours details
	Given a valid user logs into the application
	Given user navigates to the Profile tab
	When clicks on the pencil icon next to Hours field
	When user selects hours type '<hours_type>'
	Then hours field is updated to '<hours_type>'

Examples:
	| hours_type               |
	| Less than 30hours a week |
	| More than 30hours a week |
	| As needed                |

# Automated
@Test
Scenario Outline: Verify user is able to update his/her Earn Target details
	Given a valid user logs into the application
	Given user navigates to the Profile tab
	When clicks on the pencil icon next to Earn Target field
	When user selects earn target type '<earn_target_type>'
	Then earn target field is updated to '<earn_target_type>'

Examples:
	| earn_target_type                 |
	| Less than $500 per month         |
	| Between $500 and $1000 per month |
	| More than $1000 per month        |

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
	When user selects adds a '<language>' and selects a '<language_level>'
	When clicks Save button
	Then Language details are saved

Examples:
	| language | language_level   |
	| English  | Basic            |
	| Hindi    | Conversational   |
	| Chinese  | Fluent           |
	| Latin    | Native/Bilingual |

	
@Test
Scenario Outline: Verify user is able to add skills details
	Given a valid user logs into the application
	Given user navigates to the Profile tab
	Given clicks on Add New button under Skills tab
	When user selects adds a '<skill>' and selects a '<skill_level>'
	When clicks Save button
	Then Language details are saved

Examples:
	| skill              | skill_level  |
	| Functional Testing | Beginner     |
	| Automation Testing | Intermediate |
	| Selenium           | Expert       |

@Test
Scenario Outline: Verify user is able to add Education details
	Given a valid user logs into the application
	Given user navigates to the Profile tab
	Given clicks on Add New button under Education tab
	When user selects adds a '<College/University_Name>', selects a '<Country>', selects a '<Title>', adds a '<Degree>' and selects a '<Year_of_graduation>'
	When clicks Save button
	Then Education details are saved

Examples:
	| College/University_Name | Country     | Title  | Degree          | Year_of_graduation |
	| Auckland Univeristy     | New Zealand | B.Tech | Graduation      | 2011               |
	| Victoria Univeristy     | New Zealand | M.Tech | Post Graduation | 2015               |

@Test
Scenario Outline: Verify user is able to add Certifications details
	Given a valid user logs into the application
	Given user navigates to the Profile tab
	Given clicks on Add New button under Certifications tab
	When user selects adds a '<Certificate_or_Award>', selects a '<Certified_From>', and selects a '<Year>'
	When clicks Save button
	Then Education details are saved

Examples:
	| Certificate_or_Award | Certified_From | Year |
	| DotNet               | Microsoft      | 2016 |
	| SalesForce Admin     | SalesForce     | 2018 |