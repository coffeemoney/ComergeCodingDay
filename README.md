# Coding Day - Backend

This is a simple project to help you get going with the backend coding day.

It's a C# application with sqlite database and entity-framework to access the database in a type safe way.

Development will happen in IntelliJ, the project is already added and can be easily run from there.

## Project structure

* Source code is located under `CodingDay Folder`. Add your code there.
* Tests are located under `CodingDay.Tests` projects. Add your unit tests there.
* Running the application will create a file-based database (very simple DB with some tables)
* Database models are already prepared and can be found in package `CodingDay.Entities` Project.
* See controllers package (`CodingDay.Controllers`) to add new REST end-points.
* If you change the database schema and want to regenerate models with EF: 
    * In Package Manager Console
    * Type in > add-migration <some comments>
* You can add additional dependencies using NuGet if you want to use some external library.

## Running the application

Running `CodingDay` is all you need.

C# will then start an embedded iis server and deploy the application there.

Using Postman (https://www.getpostman.com/) instead of the browser allows you to also send data via HTTP POST to the backend.

### Running the unit tests

Open the test explorer (View > Test Explorer) tab and run the unit test from there.

## Assessment

Non exhaustive list of items that will be assessed:

* App architecture
* API consumption 
* Understanding of object-oriented programming principles
* Unit tests
* Code readability/correctness
* Time management
* ...

## Your tasks

Context: We received a request from one of our international clients that they need an app that shows company-internal 
news. The user should also be able to view different teams and their members. For this the backend needs to provide the 
necessary data.

You will implement the backend based on the design/data model present and the required endpoints.

Implement the following endpoints as far as the time allows:

1. `GET /public/users/{id}`
        Should deliver a JSON object of a single user with the given id (all fields).
2. `POST /public/users`
        Should create a new user. Keep in mind that the database will create a primary key (ID) for you.
3. `GET /public/teams`
        Should deliver a list of teams with three fields per team: id, name and number of users in the team.
        First fetch all teams and then count the number of users for each team separately. Performance is not a issue here.
4. `GET /public/teams/{id}`
        Should deliver a JSON object of a single team with the given id (all fields) together with a list of users of the team.
5. `GET /public/news`
        Should deliver a list of news with all fields, sorted by created_at descending.
6. `GET /public/news/{id}`
        Should deliver a JSON object of a single news with the given id (all fields).
7. Extend the `GET /public/users`
        It should be possible to optionally filter the user list by username (or username parts). Use query parameters
        to send the optional filter, e.g. `/public/users?username=rico`
8. Extend the `GET /public/news`
        It should be possible to optionally filter the news list by title or message (or parts of them) or by author id.
        Use query parameters for the optional filters, e.g. `/public/news?authorId=3&filter=foo`

For each endpoint write integration tests. 

## Some helpful links

* https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio
* https://docs.microsoft.com/en-us/dotnet/api/nunit.framework.assert?view=xamarin-ios-sdk-12