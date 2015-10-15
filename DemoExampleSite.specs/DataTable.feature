Feature: DataTable
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Create dynamic instance from table with Field and Values
    When I create a dynamic instance from this table
        | Field            | Value      |
        | Name             | Marcus     |
        | Age              | 39         |
        | Birth date       | 1972-10-09 |
        | Length in meters | 1.96       |
    Then the Name property should equal 'Marcus'