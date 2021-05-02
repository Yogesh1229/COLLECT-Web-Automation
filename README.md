# COLLECT-Web-Automation
Pre-requisites
•	Visual Studio for C# and Selenium
•	Sql Server management studio [It’s up-to you if you want data driven from SQL Database or Excel or CSV]. I have used SQL database so far.
What is POM?[Page object Model]
•	Page Object Model is a design pattern to create Object Repository for web UI elements
•	Under this model, for each web page in the application, there should be corresponding page class
•	This Page class will find the WebElements of that web page and contains Page methods which perform operations on those WebElements
Why POM?

Starting an UI Automation in Selenium WebDriver is NOT a tough task. You just need to find elements, perform operations on it.
Consider this simple script to login into a website
 

As you can observe, all we are doing is finding elements and filling values for those elements.
This is a small script. Script maintenance looks easy. But with time test suite will grow. As you add more and more lines to your code, things become tough.
The chief problem with script maintenance is that if 10 different scripts are using the same page element, with any change in that element, you need to change all 10 scripts. This is time consuming and error prone.
A better approach to script maintenance is to create a separate class file which would find web elements, fill them or verify them. This class can be reused in all the scripts using that element. In future, if there is a change in the web element, we need to make the change in just 1 class file and not 10 different scripts.
This approach is called Page Object Model(POM). It helps make the code more readable, maintainable, and reusable.
Basically, our POM framework contains below files. If you understand the purpose of each file, you can create your own test case by taking the references.
Designing strategy

Text Files
•	Let’s use the Login page as an example for this, as it is easy to conceptualize what would go in to testing such a page.
•	First off, we think about what types of tests will be needed for the page….
o	Object verification – if desired element is present on the page or not
o	Actions – Performing any action one the element, for instance clicking on login button
o	Security maybe (roles based entry?)  - for example, CSP
•	Then we create a TXT file inside our solution for each type of tests, this will be our scenario document, where we detail out what tests we want to build, and give them a consistent naming pattern. 

 

•	After the TXT files, we begin the overall test case design, by creating what we call Test Stub class files.  What this means to us is, we create a .CS unit test case class which pertains Test case setup along with all the test cases mentioned in TXT file, and that matches the name of test class defined in TXT file beginning.

For instance, if you observe TXT file, Test class name is “WhenUserIsOnAccountSignupPageObjects”

 
Test Classes
•	So, if you have the 2 TXT files in the example above, you will now have 2 test CS classes named like so:
	WhenUserIsOnAccountLogonPageObjects.cs
	WhenUserIsOnAccountLogonPageActions.cs
Similarly, we can have 3rd class as well for security purpose [not created in project yet]
	WhenUserIsOnAccountLogonPageScurity.cs

•	You might be asking yourself, WHY split them out?  Why not have 1 test class for the page?
	We can split them out, but when we will move heavily to a database driven test data model, we will notice that we can gain some major efficiencies by splitting them out.
	Most notably, when split out, objects tests need far less data than action or security tests; typically, they need only the information to verify and the information to get you to the desired page (which could be provided outside the test data, since it doesn’t matter HOW you get there, since that is not the goal of the test).
	So, this allowed us to create a generic approach to tackling object verifications, that has a very small dataset
	Actions and security tests need extra data to enter the desired page typically, so they have a separate data structure 
	The other huge advantage to splitting them out is:
	When testing, you know EXACTLY what type of test it is. So, if let’s say the developers changed only text on the screen, or a label of a field, etc., then for functional testing you run the Objects tests.  Yes, for regression you would still want to run the Actions and Security tests, but in theory nothing should have been affected in those.  This helps make planning story vs regression testing much simpler / quicker.

•	This approach also gives us some quick advantages to standing up the test stubs as I mentioned earlier.  Each of these class files need not be fully flushed out to be ready.  In other words, you have all the test names detailed out in the TXT files, so now you can create a stub for each test method in the class file, that has no actual steps in it yet.  And then, you can go ahead and build out whatever ClassSetup, TestSetup, TestCleanup, and ClassCleanup is needed for each class.  At that point, we can be ahead of dev without having to rely on them for a functional application yet.
Below are the attributes which are common for each test stub class and will be written in each test class.

•	ClassSetup: This is basically used to initialize the driver and open the chrome browser.
•	TestSetup: This is being used to get the test data from database and store it into DB fields 
•	TestMethod: Written over on each test case in class file
•	TestCleanup: Once the test case will be executed completely, it will clean up the test data 
•	ClassCleanup: It will close all the browser windows if opened
DB Field classes
After the TXT and CS files, we jump into the more ‘in depth’ side of the design.  This is typically when we ask ourselves, “Does the existing Page Model have everything I need to perform my tests?”
•	If the Page Model is missing something you need, now is when you update the model as you see fit.
•	By the time this step is completed, you should know that all the interactions with the application CAN be accomplished, though you may still be missing some key elements for your tests like:
What data do I need and how am I providing it?
o	To meet this need, we use SQL Database, DB field class and SQL files
o	Now the question arises are, how these 3 things collaborate with each other? How do we get the data from Database to our test case?

	It’s .CS file which will contain all your input and output parameters. 
	For example, if your input parameters are username and password and, output parameter is result, so this is how you will define your fields in DB fields.
Input
Public string UserName {get; set;}
Public string Password {get; set;}
Output
Public string Result {get; set}
 

	Now another question jumps up over here is, how will we provide values to these fields and the answer is “SQL files” 
SQL Files [Test Data]
	For our approach, we have already mentioned that we create test data classes that define what information will be needed, but we have not discussed the HOW.
	Firstly, we will create a SQL file pertaining all the fields equivalent to DB fields.

 
If we had not split out the TYPES of tests into separate TXT and CS files, we wouldn’t be able to gain advantages here too, where we can split out the SQL files by TYPES of tests using the same logic.
Also, since we are not using the same data classes for each type of test, the SQL inserts are simpler and some require very little data beyond the generic data we require for ALL test cases.
The specifics here are better shown in an existing SQL file, so when you are ready we can review this together.
The scripts provide the foundation for everything, and changes to data are as simple as running the script which will drop the table, and re-insert all rows again (which we do directly via Visual Studio, since they are created as SQL files).
Later we run this SQL file, it will create a table in automation database and store all the values in it.
Now we have data in database, DB fields in our code wherein we should map the value from database once you run the code. This will be the first step. Remember an attribute called “Test Initialization” which will help us to map the data from database to DB fields. These values will be mapped with the help of “Helper classes.”
Helper Classes

 

How to run Test Cases

•	First build the code and verify if it’s getting successfully built
•	Then Go to Test in Headers >> Windows >> Test Explorer
•	You will see a window of Test Explorer on the Left side bar containing all the test cases

 

•	Right click on COLLECT Regression and run all the test cases at the same time


Closing Thoughts
•	Why was this approach taken, and what are the main advantages of it that we have seen so far?
•	This approach has been years in the making, and we have tweaked it with each application we have worked on, and finally feel like we are in the right balance with complexity vs simplicity of design for whatever project we have worked upon.
•	We all came from environments where tests were not as 1 to 1 in nature as they should have been; they covered too many verifications, and if one failed, everything failed.  This meant extra initial test execution time, extra debugging time, and extra re-execution time.  We also wanted a framework that made verification easier, capturing verification errors without failing tests, and reporting helpful debug messages back to the user.
•	We also wanted a flexible framework that allowed for quick changes, hence the page model.  If the ID of an element changes, we update it in one place, in less than a minute.  If a field is added to a form submission page, we add the FindBy/Get/Set/BoolCheck/Action/PageHelpers that are needed to the Page Model, tweak the Test Level Helpers (if needed), and if necessary tweak data (add a property to data class and edit sql data inserts).  All of this though now takes considerably less time due to the way the framework is split up.
And the kicker, reusability.  Test Classes are 100% independent from each other.  Most Page Models and Helper Classes are 100% independent of each other. This means that changes to almost any section of our code should not cause a break in other sections.  
So, that is how the approach is. So, if creating the Test Scenario TXT document done, then create the Test Scenario CS Stubs, and if you are done with that as well, try creating a Page Model for the page desired, and then the Test Level Helper, and finally tie it all together with a Data Class and SQL Data. For now, I have just created a Blueprint of the solution. There are many hard coded data on the page which will we driven through database later.
