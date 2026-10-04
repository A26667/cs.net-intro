public class Person
{
    // defined attributes: "fields" to assign object values
    private string name;
    private int age;

    // encapsulation with properties: allow definition of accessors get/set
    
    public string Name
    {
        get => name;
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0) // validate non-negative age
            {
                age = value;
            }
        }
    }
}
