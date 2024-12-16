
/// <summary>
/// Defines speed, engine, drive(), speedUp()…
/// Bound together in one unit
/// Engine data must be hidden (private)
/// speedUp() can be working on data but still be publicly available
/// </summary>
public class car
{
    // Private part is only useable from within the class itself
    private int id;

    // Important data can be hidden so it can’t be changed (intentionally or by mistake)
    private int temperature;

    // Public part is useable from outside
    public int Id
    {
        get { return id; }
        set
        {
            // We can control how the data changes
            if (id > 0)
                id = Value;
        }
    }
}