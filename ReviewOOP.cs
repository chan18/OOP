/*
Abstraction - hiding implementation details

- Abstracting away all that isn't relevant to what we are creating at a design level.

Don't need to know how classes work internally.

    * think about the essential concepts, not the background details.
    * focus on what it is, Not on how it does.
    * expose siple handles to interact without knowing about the details.
    * create layer of abstraction

    Advantages - Benefits of applying abstraction
    * hide and secure important functionality
    * reduce complexity
    * only simple interfaces
    * better for maintenance
    * updates don't break existing interface mostly.
    
Encapsulation - Data hiding

    * All data and functionality on this data is encapsulated inside object
    * only certain information is exposed
    * data is hidden inside object
    * use access modifiers

    Bound together in one unit
    engine data must be hidden (private)
    SpeedUp() can be working on data must be still publicly available

Inheritance - object taxonomy

A Family Tree

inheritance allows us to define common functionality at higher-level. thereby allowing inheritors to reuse the functionality and extend when needed.

    * inherit features from other classes
    * create hierarchy
        * is-a relationship
    * improve reuse of code between child class and parent class.
    * child class can extend functionality and attributes

Polymorphism - object interchangeability

        * allow methods to execute differently
        * virtual and override keywords in C#
        * on objects of different types, we can invoke same methods.


*/

public class Car
{
    public int id {get; set;};

    public int tank {get; set;};

    private void StartEngine()
    {

    }

    public virtual void start()
    {
        // internal workings of engine to start a car.
    }

    public void AddFuel()
    {
        // tank will be filled.
    }

    public void SpeedUp()
    {
        // speeds the car. we can move now.
    }
}


public class SportsCar : Car
{
    private bool isRoofOpen;
}

public class ElectricCar : Car
{
    public override void start()
    {
        base.start();
    }
}


// client , consumer, user
Car car = new Car();

// public api, public interface.
c.SpeedUp();

