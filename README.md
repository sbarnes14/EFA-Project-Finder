# Blue Badge API Group Project
## Assignment Description
This is an EFA Blue Badge project that is supposed to test how we work together while making an API.
## EFA Project Finder
### Relevant Links
[Trello Board](https://trello.com/b/J8MjH8vN/group-project)
[GitHub Repo](https://github.com/sbarnes14/EFA-Project-Finder)
[Db Diagram](https://dbdiagram.io/d/60be26d2b29a09603d1851e1)
[Google Planning Doc](https://docs.google.com/document/d/1Bb8RnY59PTUpYjtoDBbPcfELnNqSE1QzZkm_GThYzHA/edit#heading=h.apyy2fblhnhk)
### Description
EFA Project Finder allows the user to track students, courses, and projects while also being able to see what projects are assigned to certain students, and what course each student is in.
### Structure
### Project Classes
### Course Classes
### Student Classes
## Authors
jay does this part
# API Documentation
## Installation
In order to use this API you will need to clone the code from the GitHub Repository from above.
## Account
### Register
The user will need to register their account by entering their email and password and then confirm their password.
### Token
The token is what every user needs in order to create Courses, Projects, or Students.
## CRUD Methods
### Course
#### Post:
This is how the user creates a course for students and projects to be put into.  When creating a course, you will need to enter the cohort name, and the course type; choosing from 1,2,3.  1 being Web Development, 2 being Software Development, and 3 being Cyber Security.
#### Get:
Get allows the user to search for all classes.  The details you will see are the course Id, the cohort, course type, and even the start date.
#### Put:
Put is used to update the course.  Misspelled your cohort? Use PUT and update the name.
#### Delete:
Delete is exactly how it sounds. It will delete the course entirely.
### Project
#### Post:
When creating a project, all you will need is the project name and description. Once you have both of those, your project can be created.
#### Get:
When you get a project, it will show you the auto-generated projectId, project name, project description, and when the project was created. The user can also get each project by the ID. This allows the user to see which course the project was assigned in, the cohort, and even which students were assigned the project.
#### Put:
When updating a project, the name and description are the only things that are able to be updated.
#### Delete:
Use this to delete and projects.
### Student
#### Post:
In order to create a student, the user will need to enter in the student's first and last name, which course the student is enrolled in, and the project you would like to assign the student.
#### Get:
When looking at individual students, the user is able to see the student's full name, their auto-generated ID, and their start date.
#### Put:
This allows the user to assign multiple projects to each student by changing the projectID the the correct project you would like to assign.
#### Delete:
Kill all students (for legal purposes this is a joke)
## How to use with PostMan
## Project Status
## Resources
## Acknowledgements
