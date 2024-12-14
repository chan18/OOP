
In C#, the definition of a type—a `class`, `struct`, or `record`—is like a `blueprint` that specifies what the type can do.

An `object` is basically a block of memory that has been allocated and configured according to the blueprint. 
 


# Encapsulation

Encapsulation is sometimes referred to as the `first pillar` or `principle`of object-oriented programming.

A class or struct can specify how `accessible` each of its `members` is to code outside of the class or struct

Methods and variables that aren't intended to be used from outside of the class or assembly can be `hidden` to limit the potential for coding errors or malicious exploits


# Members

The members of a type include all methods, fields, constants, properties, and events. In C#


# Accessibility

Some methods and properties are meant to be called or accessed from code outside a class or struct, known as client code.


# Inheritance

Classes (but `not structs`) support the concept of inheritance.

A class that `derives` from another class, called the `base class`, automatically contains all the `public`, `protected`, and ``internal` members of the `base class` except its constructors and finalizers.


Classes may be declared as `abstract`, which means that one or more of their methods have no implementation

Although abstract classes cannot be instantiated directly, they can serve as base classes for other classes that provide the missing implementation.

Classes can also be declared as `sealed` to prevent other classes from inheriting from them.

# Interface


# Generic Types


# Static Types


# Nested Types
 
# Partial Types


# Object Initializers


# Anonymous Types


# Implicitly Typed Local Variable 
 
# Records

--

# Objects

A class or struct definition is like a blueprint that specifies what the type can do.

Objects are also called instances,

they can be stored in either a named variable or in an array or collection. 

`Client code` is the code that uses these variables to call the methods and access the public properties of the object.

## structu instances vs class instances

### class instances

Because classes are reference types,

A variable of a class object holds a reference to the address of the object on the managed heap.

If a second variable of the same type is assigned to the first variable, then both variables refer to the object at that address.


### structu instances 

Because structs are value types

A variable of a struct object holds a copy of the entire object.



## object identity vs value equality

When you compare two objects for equality



--


# Inheritance

Inheritance, together with encapsulation and polymorphism, is one of the `three primary` characteristics of object-oriented programming.

Inheritance enables you to create new classes that reuse, extend, and modify the behavior defined in other classes


The class whose members are inherited is called the `base class`, 

The class that inherits those members is called the `derived class`.

A derived class can have only `one direct` base class

inheritance is `transitive`.

classC : classB

classB : classA

than classC inherites all the properties from classA and classB


1. Abstract and virtual methods
2. Abstract base classes
3. Interfaces
4. preventing forther derivation
5. derived class hiding of base class memebers

--

# Polymorphisms

Polymorphism is often referred to as the `third pillar `of object-oriented programming

after encapsulation and inheritance. 

Polymorphism is a Greek word that means "many-shaped" and it has two distinct aspects


## Run-time polymorphism

At run time, objects of a derived class may be treated as objects of a base class in places such as method parameters and collections or arrays.

When this polymorphism occurs, the object's declared type is no longer identical to its run-time type.


## compile-time polymorphism

Base classes may define and implement `virtual methods`, and `derived classes` can `override` them.

Which means they provide their own definition and implementation.

`Virtual methods` enable you to work with groups of related objects in a uniform way

