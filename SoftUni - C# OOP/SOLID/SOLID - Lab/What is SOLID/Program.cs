using System;

namespace What_is_SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SOLID:

            // 1. S -> Single Responsibility
            // 2. O -> Open/Closed
            // 3. L -> Liskov Substitution
            // 4. I -> Interface Segregation
            // 5. D -> Dependency Inversion

            /*
               Single Responsibility -> Every class should be responsible for only a single part of the functionality and that responsiblity
                                        should be entirely encapsulated by the class. 

               Strong Cohesion -> refers to the grouping of functionally related progresses into a particular module. 
                                  (how tightly a piece of code does a single thing)

                               -> Each task maps a single code unit
                               -> A method should do one operation

               Loose Coupling -> Тhe degree of dependence betweeen modules 
                                 (how closely connected two modules are) -> how exactly some pieces of code depend on one piece

                              -> Supports readability and maintability
                              -> Often a sign of good system disign
            */

            /*
               Open/Closed -> Software entities like classes, modules and functions should be open for extension, but closed for modification.
              
               Extensibility -> Adding a new behavior doesn't require changes over existing source code

               Reusability   -> subsystems are suitable for reusing in other projects - modularity

               OCP - Approuches:
                            1. Parameters -> Control behavior specifics via a parameter or a delegate 
                            2. Rely on abstraction, not implementation -> Inheritance / Template Method Pattern 
                            3. Strategy Pattern -> Plug in model (insert a new implementation of the interfaces
            */

            /*
               Liskov Substitution -> Derived types must be completely substitutable for their base types

                                      Derived classes: 
                                                     -> only extend functionalieties of the base class 
                                                     -> must not remove base class behavior 
               LSP - Approuches:
                            1. Tell Don't Ask -> if you need to check what is the object - move the behavior inside the object 
                            2. New Base Class -> if two classes share a common behavior, but are not substitutable, 
                                                 create a third, from which both derive
                            3. There shouldn't be any virtual methods in constructors 
            */

            /*
              Interface Segregation -> 1. Prefer small, cohesive(lean and focused) interfaces
                                       2. Devide "fat" interfaces into "role" interfaces

              ISP - Approuches:
                           1. What does the client see and use?
                           2. The "fat" interfaces implement a number of small interfaces with just what we need
                           3. All public members of a class divided in separate classes - again, could be thought of as interface 
                           4. Let the client define interfaces - "role" interfaces 
             
              Adapter Pattern -> Problem that the Adapter Pattern solves:
                                         1. Reusing classes that do not have an interface that a client requires
                                         2. Making classes with incompatible interfaces work together
                                         3. Providing an alternative interface for a class 

            */

            /*
              Dependency Inversion -> A dependency is any external component/ system 

                                   1. Constructor Inversion -> (Pros) Class' requirements are self-documenting <-> We don't have to worry about state validation 
                                                               (Cons) Too many parameters <-> Sometimes, the functionality doesn't need all of the dependencies
                                   2. Property Inversion ->    (Pros) Functionality can be changed at any time <-> That makes the code very flexible 
                                                               (Cons) State can be invalid <-> Less intuitive to use
                                   3. Parameter Inversion ->   (Pros) Changes are only localized to the method  
                                                               (Cons) Too many Parameters <-> Breaks the method signature

            */







        }
    }
}
