# Course Sign-up System

## Case description

You start working at Chama Online University that offers online courses.
For each of the courses, there is one lecturer, and for each of courses there is a maximum number of students that can participate. 
To sign up, students need to supply their email, name and date of birth.

### Part 1: Massive growth

There are many courses and millions of sign-ups.

Create a logic that will sign up students for a course. 
If a course is full, it should not be possible to sign up anymore (even with concurrent requests).

Create a bombastic facility that defers the actual processing to a 
worker process: signing up is processed asynchronously via a message bus. The worker tries to sign up the student then notifies the student whether signing up succeeded or not.

### Part 2: Aggregating & Querying data

For analysis purposes, the company needs to know the minimum, maximum and average age of the students for all courses.
Consider that this needs to keep working efficiently when there are millions
of sign-ups per day. Calculating this statistic at every request is not feasible. 




## Implementation

The architecture of the project is to be separated into 5 different layers, respecting the SOLID principles and applying Design Patterns whenever needed. The external packets used are Serilog for logging and AutoMapper to map and project entities to dtos.
The layers are:
  ### Adapters:
    Here is where the entities will be kept. As well as the ModelContext and BaseDbContext, which will be the tools to access the Database. There's also a generic EntityRepository classe that will be used as main implementation of both Get and Crude methods through inheritance in the repositories of the actual entities.
  ### Api:
    This is the API, with just the controllers (which will get information from the Services layer - no logic is to be applied in this layer), Program and Startup.
  ### Common:
    This is a layer to be used in most of other projects, since it's where most commonly used tools are kept. For now, the only classes there are the interfaces for Entity and Repository (to be used in the actual classes as a way to avoid coupling and providing common behavior), and the Logging class which is to be used throughout the application to log events - this is still to be implemented.
  ### Repositories:
    This is where the repositories will be kept. 
  ### Services:
    This is where the DTOs are kept, along with the contracts used in the services (that will make calls to the Repository layer) and the Mapping profile from AutoMapper. All calls from the controllers for data will be strictly for services in this layer.
