![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/sbarnes14/EFA-Project-Finder)
![GitHub language count](https://img.shields.io/github/languages/count/sbarnes14/EFA-Project-Finder)
![GitHub commit activity](https://img.shields.io/github/commit-activity/y/sbarnes14/EFA-Project-Finder)
![GitHub last commit](https://img.shields.io/github/last-commit/sbarnes14/EFA-Project-Finder)
# Blue Badge API Group Project

## Assignment Description

This assignment is to build a .NET Framework API Web Application using n-tier architecture covering a topic of your group's choosing.

This API should include at least one custom table per member of your group with a minimum of three tables (excluding the given user table), at least one of the tables should implement Foreign Key relationship between said tables.

Initial setup should include working together as a team to work through the planning stage. This stage should include:

- A layout of what the database tables should look like and how they should interact (You might consider using a tool like dbdiagram.io (Links to an external site.))
- You will need to review your idea and whiteboard this out with an instructor
- Fill out the planning document attached to the project module
- Break out the work load into consumable chunks, from your immediate TODOs to your long term stretch goals
- Delegating a table to each team member who will be responsible for full CRUD in that table.

# EFA Project Finder

### Relevant Links

[![Trello](https://img.shields.io/badge/Trello_Board-yellow?style=flat)](https://trello.com/b/J8MjH8vN/group-project)
[![GithubRepo](https://img.shields.io/badge/Github_Repo-0?style=flat)](https://github.com/sbarnes14/EFA-Project-Finder)
[![DBDiagram](https://img.shields.io/badge/DB_Diagram-blue?style=flat)](https://dbdiagram.io/d/60be26d2b29a09603d1851e1)
[![Trello](https://img.shields.io/badge/Google_Planning_Doc-grey?style=flat)](https://docs.google.com/document/d/1Bb8RnY59PTUpYjtoDBbPcfELnNqSE1QzZkm_GThYzHA/edit#heading=h.apyy2fblhnhk)

### Description

EFA Project Finder allows the user to track students, courses, and projects while also being able to see what projects are assigned to certain students, and what course each student is in.

### Structure

This API is structured using N-Tier Architecture, or multi-tier architecture. It is structured with processing, data management, and presentation functions physically and logically separated. This ensures that services are provided without resources overlapping one another or being shared.

### Project Classes

*Used in the Data, Model, and Services layer of the project each are separated for their exact function or use.*

All the Project classes are responsible for the CRUD methods and class structure for the Project portions of EFA Project Finder.

### Course Classes

*Used in the Data, Model, and Services layer of the project each are separated for their exact function or use.*

All the Course classes are responsible for the CRUD methods and class structure for the Course portions of EFA Project Finder.

### Student Classes

*Used in the Data, Model, and Services layer of the project each are separated for their exact function or use.*

All the Student classes are responsible for the CRUD methods and class structure for the Student portions of EFA Project Finder.

## Authors

[![github](https://img.shields.io/badge/GitHub-sbarnes14-blue?style=flat&logo=GitHub&logoColor=white)](https://github.com/sbarnes14)
[![github](https://img.shields.io/badge/GitHub-RJYocham-purple?style=flat&logo=GitHub&logoColor=white)](https://github.com/RJYocham)
[![github](https://img.shields.io/badge/GitHub-theMagnificentJay-black?style=flat&logo=GitHub&logoColor=white)](https://github.com/theMagnificentJay)

# API Documentation
## Installation
In order to use this API you will need to clone the code from the GitHub Repository from above.

Make sure you navigate to the folder you would like to clone this repository into. (e.g. c:/EFAProjectFinder/)
```(powershell)
git clone https://github.com/sbarnes14/EFA-Project-Finder.git
```

## Account

### Register

*/api/Account/Register*

The user will need to register their account by entering their email and password and then confirm their password.

The body should include:
Email, Password, and ConfirmPassword

Sample Format:
```(JSON)
{
  "Email": "email@email.com",
  "Password": "Password123!",
  "ConfirmPassword": "Password123!"
}
```

### Token

*/Token*

The token is what every user needs in order to create Courses, Projects, or Students.

The body needs to include:
Email, and Password [the ones you set up during the Register]

## CRUD Methods

### Course

#### Post:
*/api/Course*

This is how the user creates a course for students and projects to be put into.  When creating a course, you will need to enter the cohort name, and the course type; choosing from 1,2,3.  1 being Web Development, 2 being Software Development, and 3 being Cyber Security.

Sample Formats:
```(json)
{
  "Cohort": "SD1 Software_Dev",
  "CourseType": 2,
  "StartDate": "2021-06-16T16:10:40.7789227-05:00"
}
```

#### Get:
*api/Course or api/Course/{ID}*

Get allows the user to search for all classes.  The details you will see are the course Id, the cohort, course type, and even the start date.

#### Put:
*/api/Course/{ID}*

Put is used to update the course.  Misspelled your cohort? Use PUT and update the name.

#### Delete:
*/api/Course/{ID}*

Delete is exactly how it sounds. It will delete the course entirely.

### Project

#### Post:
*/api/Project*

When creating a project, all you will need is the project name and description. Once you have both of those, your project can be created.

Sample Formats:
```(json)
{
  "Projectname": "Mimosa Party",
  "ProjectDescription": "A project that stores information on Mimosa's!",
  "CourseId": 2,
  "StudentId": 1
}
```

#### Get:
*/api/Project or /api/Project/{ID}*

When you get a project, it will show you the auto-generated projectId, project name, project description, and when the project was created. The user can also get each project by the ID. This allows the user to see which course the project was assigned in, the cohort, and even which students were assigned the project.

#### Put:
*/api/Project/{ID}*

When updating a project, the name and description are the only things that are able to be updated.

#### Delete:
*/api/Project/{ID}*

Use this to delete and projects.
### Student
#### Post:
*/api/Student*

In order to create a student, the user will need to enter in the student's first and last name, which course the student is enrolled in, and the project you would like to assign the student.

Sample Formats:
```(json)
{
  "StudentId": 1,
  "FirstName": "Frank",
  "LastName": "Meier",
  "CourseId": 2,
  "ProjectId": 1,
  "GithubProfile": "https://github.com/MimosaFrank1925"
}
```

#### Get:
*/api/Student or /api/Student/{ID}*

When looking at individual students, the user is able to see the student's full name, their auto-generated ID, and their start date.
#### Put:
*/api/Student/{ID}*

This allows the user to assign multiple projects to each student by changing the projectID the the correct project you would like to assign.

#### Delete:
*/api/Student/{ID}*

Kill all students (for legal purposes this is a joke)

## JSON Format

Once you have added a Course, Student, and Project and use a GET method to return one you should see a JSON like the one below.

For this example we are using the GET method for */api/Project/1*.

```(json)
{
  "ProjectId": 1,
  "ProjectName": "Mimosa Party",
  "CreatedUTC": "1925-01-01T00:00:00.7789227-05:00",
  "ModifiedUTC": "2021-01-01T00:00:00.7789227-05:00",
  "Students": [
      {
        "StudentId": 1,
        "Name": "Frank Meier",
        "GithubProfile": "https://github.com/MimosaFrank1925/",
        "EnrollDate": "1925-01-01T00:00:00.7789227-05:00",
        "Course": "SD1 Software_Dev"
      }
}
```

## Project Status
This project was actively being worked on from June 7th to June 17th. While this project was completed for an MVP for this course, there is always the possibility for future refactoring's showing off improved skills in the future.

## Resources
[![makeareadme](https://img.shields.io/badge/MakeAReadMe-blue?style=flat)](https://www.makeareadme.com/)
[![shields.io](https://img.shields.io/badge/Shields.io-green?style=flat)](shields.io)

## Acknowledgements
[![1150](https://img.shields.io/badge/Eleven_Fifty_Academy-red?style=flat)](https://elevenfifty.org/)
