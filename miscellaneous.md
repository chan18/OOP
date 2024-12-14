https://opendsa.cs.vt.edu/ODSA/Books/Everything/html/IntroOO.html

# Encapsulation:

Encapsulation refers to the creation of self-contained modules (classes) that bind processing functions to its data members.

The data within each class is kept private. 
 
Each class defines rules for what is publicly visible and what modifications are allowed.

# Bad code
```c#
/** A class with no encapsulation */
class BadBoyShipping {
  public int weight;
  public String address;

  /* remaining code ommitted ... */
}

class ExploitShipping {
  public static void main (String[] args) {
    BadBoyShipping bad = new BadBoyShipping();
    bad.weight = -3;  // Nothing prevents me from doing this
  }
}
```

# Bad code1
```c#
/** A class with encapsulation */
class Shipping {
  private int weight;

  public int getWeight () {
    return weight;
  }

  public void setWeight (int value) {
    weight = value;
  }

}

class ExploitShipping {
  public static void main (String[] args) {
    Shipping s = new Shipping();
    s.setWeight(-3);   // Still not the behavior we are looking for
  }
}
```

# Good code
```c#

/** A class with encapsulation */
class Shipping {

  // minimum shipping weight in oz.
  private static readonly int MIN_WEIGHT = 1;
  private int weight;

  public int getWeight () {
    return weight;
  }

  public void setWeight (int value) {
    weight = Math.max(MIN_WEIGHT, value);
  }

}

class ExploitShipping {
  public static void main (String[] args) {
    Shipping s = new Shipping();
    s.setWeight(-3);   // weight is set to MIN_WEIGHT
  }
}
```

---

# Inheritance:
Classes may be created in hierarchies, and inheritance lets the structure and methods in one class pass down the class hierarchy. 

By inheriting code, complex behaviors emerge through the reuse of code in a parent class. 

If a step is added at the bottom of a hierarchy, only the processing and data associated with that unique step must be added. 

Everything else above that step may be inherited.

Reuse is considered a major advantage of object orientation.

```java
class Test {
  public static void main (String[] args) {
    Test test1 = new Test();
    Test test2 = new Test();

    if (!test1.equals(test2)) {
      System.out.println("'test1' does not equal 'test2'.");
    }
    if (test1 instanceof Object) {
      System.out.println("'test1' is an Object.");
    }
  }
}
```


```java
try( InputStream inputstream = new FileInputStream("file.txt") ) {

  int data = inputstream.read();
  while(data != -1) {
    System.out.print((char) data);
    data = inputstream.read();
  }
} catch (Exception e) { }
```

---

# Polymorphism: Greek word that means “many-shaped” 

Object oriented programming lets programmers create procedures for objects whose exact type is not known until runtime.

 For example, 
 A screen cursor may change its shape from an arrow to a line depending on the program mode. The routine to move the cursor on screen in response to mouse movement can be written for “cursor”, and polymorphism lets the right version for the given shape be called.

Forms: 

 ## Run-time polymorphism

 Base classes may define and implement abstract, or virtual methods, and derived classes can override them, which means they provide their own definition and implementation

 At run-time, when client code calls the method, the type is resolved and invokes that override of the virtual method.

 Thus in your source code you can call a method on a base class, and cause a derived class’s version of the method to be executed.

 At run time, objects of a derived class may be treated as objects of a base class in places such as method parameters and collections or arrays. When this occurs, the object’s declared type is no longer identical to its run-time type.

 Note that a derived class may be treated as any type in its inheritance hierarchy. Also, it is perfectly valid for an overloaded method to be overridden.


 ## Compile-time polymorphism

 Compile-time polymorphism is simply method overloading. 

 

 Overloaded methods have the same method name but different number of arguments or different types of arguments or both.


```java
public class Complex {
  private final double real;  // real number
  private final double imag;  // imaginary number's coefficient

  public Complex(double real, double imag) {
    this.real = real;
    this.imag = imag;
  }

  public static void main(String[] args)
  {
    Complex a = new Complex(1, 0);
    Complex b = new Complex(1, 0);

    if (a.equals(b)) {
      System.out.println ("'a' equals 'b'.");
    } else {
      System.out.println ("'a' and 'b' are not equal.");
    }
    System.out.println("'a' is " + a.toString());
    System.out.println("'b' is " + b.toString());
  }
}
```


```java
public class Complex {
  private final double real;  // real number
  private final double imag;  // imaginary number's coefficient

  public Complex(double real, double imag) {
    this.real = real;
    this.imag = imag;
  }

  @Override 
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (!(o instanceof Complex)) {
      return false;
    }
    Complex c = (Complex) o;

    return Double.compare(real, c.real) == 0 &&
           Double.compare(imag, c.imag) == 0;
  }

  @Override public String toString() {
    String sign = imag < 0 ? " - " : " + ";
    return "(" + real + sign + Math.abs(imag) + "i)";
  }

  public static void main(String[] args)
  {
    Complex a = Complex(1, 0);
    Complex b = Complex(1, 0);

    if (a.equals(b)) {
      System.out.println ("'a' equals 'b'.");
    } else {
      System.out.println ("'a' and 'b' are not equal.");
    }
    System.out.println ("'a' = " + a);
    System.out.println ("'b' = " + b);
  }
}
```

### Compile-time Polymorphism - code

with out compile time polymorphism - disadvantage 
In C, the abs() function returns the absolute value of an integer. The only valid parameter you can pass is an int—any other type will fail to compile. How is this problem solved in C? With different method names: labs() is used to return the absolute value of a long and fabs() returns the absolute value of a float. The burden is on the users of these functions

programmers to remember which function is needed. Additionally, there is no easy way to be flexible about the generic concept of taking the absolute value of a number. The burden is on the programmer of the various *abs() functions to ensure the correct function is used with the appropriate type

```java
public class DataStructureGroup {

  public static String group (List<?> l) {
    return "List";
  }

  public static String group (Queue<?> l) {
    return "Queue";
  }

  public static String group (Collection<?> l) {
    return "Unknown group";
  }

  public static void main(String[] args)
  {
    Collection <?>[] cols = {
      new ArrayList<Integer>(),
      new PriorityQueue<String>(),
      new TreeSet<Long>()
    };

    for (Collection<?> c : cols) {
      System.out.println (group(c));
    }
  }
}
```


---
# Abstraction:

An abstraction denotes the essential characteristics of an object that distinguish it from all other kinds of objects and thus provide crisply defined conceptual boundaries, relative to the perspective of the viewer. 

Abstraction denotes a model, a view, or some other focused representation for an actual item. 

It’s the development of a software object to represent an object we can find in the real world. 

Encapsulation hides the details of that implementation.


A better way to manage the complexity of large programs is to keep the data in a program and the operations allowed on that data in a cohesive logical unit.

The idea that individual units within a program each have a specific role or responsibility is called `cohesion` and is difficult to achieve in procedural programs.


For very large programs, which might contain hundreds or even thousands of entities, lack of cohesion can introduce errors, make programs more difficult to understand and maintain, and complicate the development of very large programs.


