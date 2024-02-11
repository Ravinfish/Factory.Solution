# DreamWorks Unlimited

#### By Ravin Fisher

### Technologies Used

* C#
* .NET 6
* ASP.NET Core MVC
* Entity Framework Core
* MySQL
* MySQL Database
* Git
* Viewbag
* MVC Raxor

### Description
This is a fictional site for a Dream Factory demontrating skills in managing Many to Many relationships.


## Instalation/Setup

Currently now viewable on gh-pages. Please follow the below steps to set  up locally

1. Navigate to my github repository `https://github.com/Ravinfish/Factory.Solution.git`
2. Click the Fork button and you wil be taken to a new page where you can give your repository a new name and description. Choose "create fork"
3. Click the "Code" button and copy the url for HTTPS
4. On your local coputer, create a working directory for my files and name appropriatly.
5. In your terminal, type  `$ git clone 'url'` using the URL from step 3.
6. Once you have this on your local directory, if you ever want to push it to GitHub, you need to do these steps first so Git knows to ignore the desired directories and files:
`$ git init` to initialize Git (if cloning, this step already automatically happened)
`$ touch .gitignore` adds .gitignore file in the root directory. 

7. On your terminal, type `$ code .` to open in VS Code.  If you do not have VS Code Editor, you may download [here](https://code.visualstudio.com/)
8. In the .gitignore file, add 
    ```
    bin
    obj
    appsettings.json
    ```
    (SAVE this file if you do not have Auto-Save set up in VSCode).
    In the Terminal:
    ```
    $ git add .gitignore
    $ git commit -m 'add .gitignore'
    $ git push origin main
    ```
(Now these three items will not be seen or pushed to your GitHub remote repository.)

#### You must add and commit this .gitignore BEFORE creating obj, bin or appsetting.json file!

_You can now see all my files, but FIRST it is time for you to set up your database and protect the database connection string with appsettings.json_



Install Tools:

This project assumes you have MySQL Server and MySQL Workbench installed on your system. If you do not have these tools installed, follow along with the installation steps for the the necessary tools introduced in the series of lessons found here `(https://full-time.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)`.

Set Up the Database: 

And an appsetting.json with the following contents, replacing the following values with your own:

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}

[YOUR-USER-HERE] with your username
[YOUR-PASSWORD-HERE] with your password
[YOUR-DB-NAME] with the name of your database

## Import my .sql file to MySQL Workbench

1. Open MySQL Workbench
2. Download the ravin_fisher.sql file from this project to your local computer. The file is located at `SalonSerenity.Solution.ravin_fisher.sql`
3. In the Navigator > Administration window, select Data Import/Restore.
4. In Import Options select Import from Self-Contained File.
5. Navigate to the file you just downloaded.
6. Under Default Schema to be Imported To, select the New button. (Enter the name of your database as you would like.) Click Ok.
7. Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window.
8. After you are finished with the above steps, reopen the Navigator > Schemas tab. Right click and select Refresh All. Our new test database will appear.

## Known Bugs
I have not added in the function to "DeleteJoin" to the controller, but I have added it to the details page, coded out. Stretch goal to add that in. Also would like to update the CSS and give it a bit more style.

## Licence
Code Licenced under GPL

Copyright (c) February 2024 Ravin Fisher