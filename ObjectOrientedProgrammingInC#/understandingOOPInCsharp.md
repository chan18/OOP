# Working with classes and Objects

## Types of CTS
class
interface

enumeration
delegate

struct
records


# The Principles of object-oriented design

* structure classes in object oriented way. We have to relay on principles 

4 pillars

helps with writing clean, maintainable, extendable, object-oriented code.

C# language features supports all

1. Abstraction
2. Encapsulation
3. Inheritance
4. Polymorphism

--- 

# The concept of Abstraction 

1. Think about the essential concepts, not the background details

- Think about the essential concepts, start generalizing start coming up with essential functionalities not the background details

2. Create layer of abstraction

- really creating layer of abstraction around object the item at hand.
- defining it so the only necessary details in order to work with it.
- it is important hiding the implementation details.


3. Expose simple handles to interact without knowing about the details


4. Focus on what it does, not how it does it.

- exposing class functionalities, The user of the class can interact with, without requiring that the user how the class works.

# Car
## Example - Abstraction applied on car

when we are driving a car we are working with abstraction
- steering wheel, brake pedal expose simple interface to the user
  ( those interfaces are the abstraction, simple way to interact with a car)
* This is the abstraction

- No need to know how the engine, brakes really work
* only necessary aspects are exposed
 

Benefits of Applying Abstraction

1. Reduce complexity, only simple interfaces
- we do not expect user of the class to under fully how the class works, instead we expose few simple handles
- we expose a simple interface with public properties and public methods.
- we will hide inside the class it's inner workings
- we will hide how the class works internally


2. Hide and secure important functionality
- it will improve the security, since we don't allow the users of the class to just use everything. 
- only what we deemed necessary.

3. Better for maintenance
- since we hide the details of the class, it is a win for maintainability

#### how?
- if we need to change inner workings we try not to change it's public interface.
- so we don't break how the user works with the car.


4. Updates don't break existing interface mostly
- we can update the inner working of the class constantly 
- All of the sudden public interfaces change how it works, That's how this improves maintainability of the code.



`
    - One of the main task of Thinking objects is to creating this(4 points above) abstraction.
`


`
    - Typically we get some requirements for application when we need to write. We need to start thinking abstraction
`


 we need to identify from requirements the entries which will become the classes and the characteristics which will become the class members
 

Example : Requirement to do design a application for work.

Entity  : Employee

Characteristics of Entity Employee :  we have to pick the one which are relevant for the application.

Name
Age
Weight
Address
Hair color
Perform work


Relevant for the application (ability to perform work) that will become public interface for our Employee entity, Maybe other internally functionality included in the class but won't be exposed.
- Abstracting away all that isn't relevant to what we are creating at a design level. (that's the abstraction is all about)

Age
Perform work

---
 
Structure of the class we'll need to create

# Encapsulation 
- is quit closely related to abstraction.

1. All data and functionality on this data is encapsulated inside object

- where we bring all the data in single unit together with functionality that works on that data.That unit is the object.
- We are grouping encapsulating all this together, And we can define which access given to the data.
- handling all of this together is useful. otherwise all the different parts would be separated, and if so changing something in one place could brake things else where.


2. Only certain information is exposed
- data is important which stores the state of the object and typically hidden.

3. Data is hidden inside object
- We can determine which data and which functionality is accessible and how

4. Use access modifiers
- one way to define access modifiers.like public and private. This we can control data of the object can't be changed everywhere.
- But only through a  well defined interface ( which could be properties or methods ).


# Car
## Encapsulation applied on a car

1. Defines speed, engine, drive(), speedUp().
- car encapsulate lots of data.
- it has drive functionality which works together with engine and other parts.
- defines speed of method.

2. Bound together in one unit
- All of the encapsulation is bound together in one unit.
- Encapsulation also helps us to hide which we arrant interact with.

3. Engine data must be hidden (private)
- Encapsulation gives ability to restrict access to that data and functionalities to work on that data.

4. speedUp() can be working on data but still be publicly available
- through a public interface, we invoke methods, in turn they might work in a controlled way with the internal data.


example applying encapsulation 

1. first step grouping everything together.

```c#
public class car
{
    // Private part is only useable from within the class itself
    private int id;

    // Important data can be hidden so it can’t be changed (intentionally or by mistake)
    private int temperature;

    // Public part is useable from outside
    public int Id
    {
        get { return id;}
        set {
            // We can control how the data changes
            if (id > 0)
                id = Value;
        }
    }
}
```

---

# Inheritance

1. Inherit features from other classes
* understanding dog is an animal, and poodle is a more specific type of dog

2. Create hierarchy
    • Is-A relation

- we implicitly putting in a hierarchy going from more generic to more specific.
- They will inherit features from there parents or from parent.
- we define this code in higher level so that we can reuse, instead duplicating the code.

3. Improve reuse of code between parent and child class
- child class is already built on parent has already defined.

4. Child class can extend functionality and attributes
- will also typically extend this  with it's own functionality and data.

`
    inheritance allows us to define common functionality at higher-level. thereby allowing inheritors to reuse the functionality and extend when needed.
`



# Car
Applied inheritance on  a car

```c#
public class Car
{
    private int maxSpeed;

    public int MaxSpeed { get => maxSpeed; set => maxSpeed = value; }

    public void Drive()
    {
    }
}

public class SportsCar : Car
{
    private bool isRoofOpen;
}
```


# Polymorphism

1. Allow methods to execute differently


2. virtual and override keywords in C#


3. On objects of different types, we can invoke the same methods


C# example 

```c#
public class Car
{
    public virtual void Drive()
    { }
}
public class ElectricCar : Car
{
    public override void Drive()
    {
        base.Drive(); // base keyword used to call the base class function/method.
    }
}
```


