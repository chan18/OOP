
/// <summary>
/// 
///    1. Think about the essential concepts, not the background details
///    2. Create layer of abstraction
///    3. Expose simple handles to interact without knowing about the details
///    4. Focus on what it does, not how it does it.
///    
///    Benefits of Applying Abstraction
///    Reduce complexity, only simple interfaces
///    Hide and secure important functionality
///    Better for maintenance
///    Updates don't break existing interface mostly
///    
/// </summary>

// class declaration and naming
// access modifiers define access to memebers, public, private
public class Employee
{
    // constructors are used for initialization.
    public Employee()
    {
        //Initialization code goes here
    }

    // fields containing data.
    private string firstName;
    private int age;

    // properties control access to data.
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    // methods define functionality
    public void PerformWork()
    {
        //method implementation goes here
    }
}


// instatntiating an object
// new operator
Employee employee = new Employee();

// working with an object.
// invoking methods, properties..
employee.PerformWork();
employee.PerformWork(10);
employee.FirstName = "Gill";