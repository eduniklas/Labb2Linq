# Labb2Linq
MVC app

# About the task:

In this task, you will build four models and connect them with navigation properties.

# What you need to do:

### Setting the Foundation

- [ ] Create a new project in Visual Studio and create four models → Teacher, Student, Class (e.g., 3A), Course (e.g., Mathematics).
- [ ] Customize the relationships between the tables → for example (a teacher has one or more courses).
- [ ] Build a database for the models and populate data in all tables using Entity Framework.
- [ ] You need a menu for each function, and when we test the program's functionality.

    Tips: You can build it very simply with, for example, a switch statement and user input that takes a number for each option. Or create an [asp.net](http://asp.net) core app with menus.

### Functionality in the System

These should exist as different functions, and one of these functions is executed by selecting an option in the menu.

**NOTE:** All queries to the database should be done using Entity Framework.

- [ ] Retrieve all teachers who teach "programming 1."
- [ ] Retrieve all students with their teachers, print both the names of the students and the names of all teachers they have.
- [ ] Retrieve all students who are studying "programming 1" and print their names along with the teachers they have in that course.
- [ ] Edit a subject from "programming 2" to "OOP."
- [ ] Update a student's teacher in "programming 1" from Reidar to Tobias.
