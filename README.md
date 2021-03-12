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

