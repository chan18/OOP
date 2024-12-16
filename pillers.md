

Encapsulation

Inheritance

Polymorphism

Abstraction


--

Extra 


coupling

composition

cohesion

abstractions

instantiation

Orthogonality



---
# Define a class

```mermaid
classDiagram
    class Animal
    Vehicle <|-- Car
```

# class labels
```mermaid
classDiagram
    class Animal["Animal with a label"]
    class Car["Car with *! symbols"]
    Animal --> Car
```

```mermaid
classDiagram
    class `Animal Class!`
    class `Car Class`
    `Animal Class!` --> `Car Class`
```

# Defining Members of a class

```mermaid
classDiagram
    class BankAccount
    BankAccount : +String owner
    BankAccount : +BigDecimal balance
    BankAccount : +deposit(amount)
    BankAccount : +withdrawal(amount)
```

**Code Example**

we can use code syntax.

```mermaid
classDiagram
    class BankAccount { 
        +String owner
        +BigDecimal balance
        +deposit(amount)
        +withdrawal(amount)
    }
```


--- 

**Return Type**

added bool and int return type to methods

```mermaid
classDiagram
class BankAccount{
    +String owner
    +BigDecimal balance
    +deposit(amount) bool
    +withdrawal(amount) int
}
```

**Generic Types**

```mermaid
classDiagram
class Square~Shape~{
    int id
    List~int~ position
    setPoints(List~int~ points)
    getPoints() List~int~
}
Square : -List~string~ messages
Square : +setMessages(List~string~ messages)
Square : +getMessages() List~string~
Square : +getDistanceMatrix() List~List~int~~
```

# Defining Relationship

[classA][Arrow][ClassB]

Type	Description
<|--	Inheritance

*--	Composition

o--	Aggregation

-->	Association

--	Link (Solid)

..>	Dependency

..|>	Realization

..	Link (Dashed)


```mermaid
classDiagram
classA <|-- classB
classC *-- classD
classE o-- classF
classG <-- classH
classI -- classJ
classK <.. classL
classM <|.. classN
classO .. classP
```

**with lables**

```mermaid
classDiagram
classA --|> classB : Inheritance
classC --* classD : Composition
classE --o classF : Aggregation
classG --> classH : Association
classI -- classJ : Link(Solid)
classK ..> classL : Dependency
classM ..|> classN : Realization
classO .. classP : Link(Dashed)
```

*label on relationship**

```mermaid
classDiagram
classA <|-- classB : implements
classC *-- classD : composition
classE o-- classF : aggregation
```

# Two way relations

```mermaid
classDiagram
    Animal <|--|> Zebra

```

[Relation Type][Link][Relation Type]

Type	Description
<|	Inheritance

\*	Composition

o	Aggregation

>	Association

<	Association

|>	Realization

Type	Description

--	Solid

..	Dashed


**Lollipop Interfaces**

bar ()-- foo

foo --() bar



```mermaid
classDiagram
  bar ()-- foo
```

```mermaid
classDiagram
  class Class01 {
    int amount
    draw()
  }
  Class01 --() bar
  Class02 --() bar

  foo ()-- Class01
```

# Define Namespace

```mermaid
classDiagram
namespace BaseShapes {
    class Triangle
    class Rectangle {
      double width
      double height
    }
}
```

# Cardinality / Multiplicity on relations

[classA] "cardinality1" [Arrow] "cardinality2" [ClassB]:LabelText

Multiplicity notations are placed near the end of an association.

The different cardinality options are :

1 Only 1

0..1 Zero or One

1..* One or more

* Many

n n (where n>1)

0..n zero to n (where n>1)

1..n one to n (where n>1)



```mermaid
classDiagram
    Customer "1" --> "*" Ticket
    Student "1" --> "1..*" Course
    Galaxy --> "many" Star : Contains
```

# Annotations on classes

<<Interface>> To represent an Interface class

<<Abstract>> To represent an abstract class

<<Service>> To represent a service class

<<Enumeration>> To represent an enum

```mermaid
classDiagram
    class Shape
        <<interface>> Shape
            Shape : noOfVertices
            Shape : draw()
```

```mermaid
classDiagram
class Shape{
    <<interface>>
    noOfVertices
    draw()
}
class Color{
    <<enumeration>>
    RED
    BLUE
    GREEN
    WHITE
    BLACK
}
```


# Comments


```mermaid
classDiagram
%% This whole line is a comment classDiagram class Shape <<interface>>
class Shape{
    <<interface>>
    noOfVertices
    draw()
}
```

# Setting the direction of the diagram

```mermaid
classDiagram
  direction RL
  class Student {
    -idCard : IdCard
  }
  class IdCard{
    -id : int
    -name : string
  }
  class Bike{
    -id : int
    -name : string
  }
  Student "1" --o "1" IdCard : carries
  Student "1" --o "1" Bike : rides
```


# Interaction

something i might not use but it got it i don't know why i have this.

action className "reference" "tooltip"

click className call callback() "tooltip"

click className href "url" "tooltip"


```mermaid

```

# Notes

```mermaid
classDiagram
    note "This is a general note"
    note for MyClass "This is a note for a class"
    class MyClass{
    }
```

**url link**
```mermaid
classDiagram
class Shape
link Shape "https://www.github.com" "This is a tooltip for a link"
class Shape2
click Shape2 href "https://www.github.com" "This is a tooltip for a link"
```

**callback**
```mermaid
classDiagram
class Shape
callback Shape "callbackFunction" "This is a tooltip for a callback"
class Shape2
click Shape2 call callbackFunction() "This is a tooltip for a callback"
```
the script below is linked.

```js
<script>
  const callbackFunction = function () {
    alert('A callback was triggered');
  };
</script>
```

```mermaid
classDiagram
    class Class01
    class Class02
    callback Class01 "callbackFunction" "Callback tooltip"
    link Class02 "https://www.github.com" "This is a link"
    class Class03
    class Class04
    click Class03 call callbackFunction() "Callback tooltip"
    click Class04 href "https://www.github.com" "This is a link"
```


```html
<body>
  <pre class="mermaid">
    classDiagram
    Animal <|-- Duck
    Animal <|-- Fish
    Animal <|-- Zebra
    Animal : +int age
    Animal : +String gender
    Animal: +isMammal()
    Animal: +mate()
    class Duck{
      +String beakColor
      +swim()
      +quack()
      }
    class Fish{
      -int sizeInFeet
      -canEat()
      }
    class Zebra{
      +bool is_wild
      +run()
      }

      callback Duck callback "Tooltip"
      link Zebra "https://www.github.com" "This is a link"
  </pre>

  <script>
    const callback = function () {
      alert('A callback was triggered');
    };
    const config = {
      startOnLoad: true,
      securityLevel: 'loose',
    };
    mermaid.initialize(config);
  </script>
</body>
```

# styling

styling a node

```mermaid
classDiagram
  class Animal
  class Mineral
  style Animal fill:#f9f,stroke:#333,stroke-width:4px
  style Mineral fill:#bbf,stroke:#f66,stroke-width:2px,color:#fff,stroke-dasharray: 5 5
```


```mermaid
classDiagram
    class Animal:::someclass
    classDef someclass fill:#f96
```

```mermaid
classDiagram
    class Animal:::someclass {
        -int sizeInFeet
        -canEat()
    }
    classDef someclass fill:#f96

```

