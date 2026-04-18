


public class Person
{
    private const double MinSalary = 460;

    private int firstName;
    private int lastName;
    private int age;
    private double salary;

    public Person(string firstName, string lastName, int age, double salary = MinSalary)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Salary = salary;
    }

    public string FirstName
    {
        get
        {
            return FirstName;
        }

        private set
        {
            if (value.Length<3)
            {
                throw new ArgumentException("First name cannot be less than 3 symbols.");
            }
            FirstName = value;
        }
    }
    public string LastName
    {
        get { return LastName; }

        private set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Last name cannot be less than 3 symbols.");
            }
            LastName = value;
        }
    }
    public int Age
    {
        get { return age; }

        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer.");
            }
            age = value;
        }
    }
    public double Salary
    {
        get { return salary; }

        private set
        {
            if (value < MinSalary)
            {
                throw new ArgumentException($"Salary cannot be less than {MinSalary}€.");
            }
            salary = value;
        }
    }

    override public string ToString()
    {
        return $"{FirstName} {LastName} receives {Salary:F2}€.";
    }




}

