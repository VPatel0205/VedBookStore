Name : Vedkumar Patel
ID : 0822391
Subject : Asp.net
Date : 2023-10-30
Project : Vedic Book Store

2023-10-30
1440
Initiated Project

1444
Made README.txt and README.md

1446
Tested the project

1457
Updated Startup.cs [Commented (options => options.SignIn.RequireConfirmedAccount = true)] on line 35

1507
Created Git Repository named Vedic_Book_Store 

1514
Added breakpoint in HomeController.cs file on line 22 & 27 

1529
Downloaded bootstrap.css (Cyborg theme)

1532
Rename old css bootstrap_old.css from bootstrap.css

1533
Added new theme css file in bootstrap.css

1536
Changed css/site.css

1542
Updated _Layout.cshtml line 7 to ("~/lib/bootstrap/dist/css/bootstrap.css")

1543
Updated _Layout.cshtml navbar-dark bg-primary on line 12

1545
Removed 'text-dark' on line 22 & 25 in _Layout.cshtml file

1550
Tested the project (Run successful!)

1556
On line 39 added 'text-white-50 bg-primary' in _Layout.cshtml file

1558
Removed text-dark from line 9,20 & 23 in _LoginPartial.cshtml

1600
Run test successful

1610
added <link rel="stylesheet" href="https://cdn.datatables.net/1.10.16/css/jquery.dataTables.min.css" />
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css" />
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css" /> on line 9 , 10 , & 11

and <script src="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
<script src="https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js"></script>
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js"></script>
<script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
<script src="https://kit.fontawesome.com/e19c476714.js"></script> on line 50 , 51 , 52 , 53 , & 54 
in _Layout.cshtml file

1624
Added dropdown menu code in _Layout.cshtml

1625
Run test successful

1703
Created new projects named Vedic_Book_Store.DataAccess , Vedic_Book_Store.Models , Vedic_Book_Store.Utility 

1917
Moved Data folder to Vedic_Book_Store.DataAccess 

Date : 2023-10-31

1114
Initiated project from start cause I placed Project and solution in the same directory, cause I misunderstood the slide so I selected to place Project and solution in the same directory. 

1217
Done all the steps till creating new projects.

1245
By Mistake deleted the data folder from the dataAccess project so started whole new project.

1255
Completed upto Bootstrap and created all three new projects

1257
Moved the Data folder and deleted the migration folder

1259
Installed the package which was defined in the slides

1302
Modify the namespace to reflect the project

Delete default Class1.cs file in all projects

1305
Move Models in to AndrewsBooks.Models (delete original)

1307
Project - Add - Project Reference - .DataAccess and .Models Rename Models folder to ViewModels Change the ErrorViewModels.cs namespace .Models.ViewModels

1310
When ran the project gave me error the type or namespace "ApplicationDbContext" could not be found in Startup.cs

1311
When i hover above it and click on light bulb and added using VedBookStore.DataAccess.Data;

1313
Correct any default reference to ErrorViewModel to the new .Models.ViewModels.ErrorViewModels

1317
In the Utility project, create a static details class called SD.cs
Modify the properties of the class
Add project reference to the main project

1320
Added a ‘Customers’ area to Areas
Changed the routes in Startup.cs like the one outlined in the ScaffoldingReadMe.txt
Moved the HomeController.cs to the Area > Customer > Controller folder and delete Data and Models.
Edited the HomeController.cs to explicitly define that the controller is in the Customer Area
Moved Views > Home and modify the HomeController namespace

1321
Copied _ViewImport and _ViewStart to Customer Area, Modified the _ViewStart.cshtml to reflect the new path

1325
Added a new Admin area in Areas
Added the proper view files and delete the Data and Models folder

1326
Deleted the Controllers folder

2023-11-04

1317
Cloned the old repository, NuGet package manager added new migration with name "AddDefaultMigration" but it gave me error 
then from ppt I changed Defaul Project to VedBookStore.DataAccess

1322
Updated Database and review the changes in SQL SOE 

1325
ran migration 20231104175243_AddDefaultMigration.cs
Added the new class in .Models project and modified according to ppt 

1327
Again added the migration 20231104175537_AddCategory.cs ,new migration file was empty and added the code in 
ApplicationDbContext and reran the migration to see the review changes

1355
Again ran migration 20231104175733_AddCategories.cs
At first code was not added even after adding migration cloned again the whole project and this time code worked 

1400
Update database 

1524
Created new folder in .DataAccess project called Repository and inside it IRepository folder added new interface file in IRepository
folder

1527
Created IRepository.cs and added Repository.cs from the blackboard

1538
Created new file name CategoryRepository.cs and ICategoryRepository.cs
To solve the error added 
"using VedBookStore.DataAccess.Data;
using VedBookStore.DataAccess.Repository.IRepository;
using VedBookStore.Models;"

1552
Created 4 files named ISP_Call.cs , SP_Call.cs , IUnitOfWork.cs and UnitOfWork.cs gave errors but resolved by adding specific 
Using statement

1556
To make it accessible by project registered it Startup.cs in the configur services method and added respective using statements

2023-11-06

1750
Added the new Controller CategoryController.cs and modified the code to use IUnitOfWork.cs and again added respective using statements

1755
Modified Index.cshtml file

1800
Created category.js and called it to Index.cshtml

1807
Applied code to Edit, Delete, and Create New Category buttons using upsert action 

1815
Created partial views _CreateAndBackToListButton.cshtml and _EditAndBackToListButton 

1822
Modified Upsert.cshtml

1837
Added delete functionality in category.js

1705
Had some error with onclick event to the delete function. Delete function was not working  (added space between onclick event and class)
then it started working properly.

1740
Checked the application and tested Edit, Delete, and Create New Category   

2023-11-20

1416
Cloned the project from the github and test the project to check for any errors

1515
Created new CoverType.cs in model folder

1523
Created new CoverTypeRepository and ICoverTypeRepository and added them to UnitOfWork and in IUnitOfWork and created migration - 20231120202424_AddCoverType

1533
Added CoverType to NavBar and CoverType Controller with required methods and added Index and Upsert file in area > Admin > Views > CoverType

1537
Tested the application and run perferctly with update and delete function properly

1540
Created new product class in model file and added the reference to ApplicationDbContext.cs

1542
Added the migration - 20231120204156_addProductToDb and update the database 