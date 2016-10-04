"Refer to the Git_Procedure_Step_By_Step document, which contains detailed instructions for accessing code stubs and submitting completed work from/to GitHub." 
automation challenge 3 (Navigation SubMenu class):  

Go to https://www.skiutah.com 

If you hover over the main menu items, you'll trigger the hover event, which displays the submenus. Some items in the menu have submenus, and some don't.  

Write a method that will allow me to navigate to the submenu by triggering the hover event, and then clicking on the item in the submenu that I want to navigate to. 

Reusing code from your previous challenges is permissible.

You are encouraged to use your imagination, and there is no "wrong" way to complete the challenge. However, your code does need to contain the following:

A publicly accesible method called "ClickSubmenuItem", which accepts two String arguments:

The first String argument must include the test of the submenu that you want to open, i.e. "Deals"

The second string argument represents the expected "title" value of the expected page, i.e. "Ski Utah Deal."

The method GoToPage method must return a boolean, indicating whether or not title matches the second String argument.

You can use any other methods, classes, or other libraries you wish. 


Helpful Hint: Consider using the Selenium Page Object Model for your automation. The POM is an "Object Repository" design pattern. It is considered a best practice for Selenium WebDriver automation. 

The basic use of the pattern is to create an object, called a page, which acts as a liason between your automated tests and the actual user interface. The page Object takes care of identifying and storing the web elements, as well as the interactions between them. That way, your tests don't need to worry about finding a web element: They simply call the page object.

Introductions to the Page Object Model can be found here:

https://www.seleniumeasy.com/selenium-tutorials/page-object-model-framework-introduction

http://toolsqa.com/selenium-webdriver/page-object-model/
