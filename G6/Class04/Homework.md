# Homework

## Task 1

* Create a class Shape that has Id and methods GetArea and GetPerimeter
* Create a class Circle, with property radius that inherits from Shape.
* Create a class Rectangle, with properties sideA and sideB that inherits from Shape.
* Create a generic Db that holds a list of generic objects, that have a type that inherits from Shape.
* Create methods in the generic db that print the areas and perimeters of all shapes in the list.
* Create generic db for both types and call the methods of the db.
* Add extension methods for Circle and Rectangle, that print info for these types.

## Task 2
Create 4 classes:
* Pet( abstract ) with Name, Type, Age and abstract PrintInfo()
* Dog( from Pet ) with FavoriteFood
* Cat( from Pet ) with Lazy and LivesLeft
* Fish( from Pet ) with Color, Size

Create a PetStore generic class with:
* Generic list of pets - Dogs, Cats or Fish depending on what is passed as T
* Generic method PrintsPets() - Prints Dogs, Cats or Fish depending on what is passed as T
* BuyPet() - Method that takes ‘name’ as parameter, find the first pet by that name, removes it from the list and gives a success message. If there is no pet by that name, inform the customer
* Create a Dog, Cat and fish store with 2 pets each
* Buy a dog and a cat from the Dog and Cat store
* Call PrintPets() method on all stores


