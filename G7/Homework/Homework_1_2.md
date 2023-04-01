# Quizz App ✍

A school is requesting a quiz app to be developed so that the students can log in, answer questions and get an automatic grade. The students can only solve the quiz once and the teachers can see the results of all the quizzes.

## Features 🔹

* Log in
  * A student or a teacher can log in
  * Usernames and passwords should be predefined ( created beforehand in the system )
* Student logs in
  * A quiz pops up with 5 multiple-choice questions ( 4 choices )
  * After the student picks a choice on the 5 answers a grade appears from 1 to 5
  * After that the user is logged out and another user can log in
  * If the same student tries to log in, it should say that they already did the test and log them out
* Teacher logs in
  * All students that did the quiz and have a grade show up in green
  * all the students that did not do the quiz show up in red
  * When hitting enter it logs out the teacher and another user can log in
* Validations
  * All the choices must be numbers from 1 to 4
  * Username must exist in the database
  * Username and Password must match
  * If the username and password do not match 3 times, then close the application

## Data 🔹

1) Q: What is the capital of Tasmania?
    * a: Dodoma
    * b: Hobart *
    * c: Launceston
    * d: Wellington
2) Q: What is the tallest building in the Republic of the Congo?
    * a: Kinshasa Democratic Republic of the Congo Temple
    * b: Palais de la Nation
    * c: Kongo Trade Centre
    * d: Nabemba Tower *
3) Q: Which of these is not one of Pluto's moons?
    * a: Styx
    * b: Hydra
    * c: Nix *
    * d: Lugia
4) Q: What is the smallest lake in the world?
    * a: Onega Lake
    * b: Benxi Lake *
    * c: Kivu Lake
    * d: Wakatipu Lake
5) Q: What country has the largest population of alpacas?
    * a: Chad
    * b: Peru *
    * c: Australia
    * d: Niger