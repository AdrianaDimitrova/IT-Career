
public class Program
{
    public static void Main()
    {
        Person person = new Person("John");
        Person person2 = new Person("John",34);

        person.Introduce();
        person2.Introduce();

    }
}

