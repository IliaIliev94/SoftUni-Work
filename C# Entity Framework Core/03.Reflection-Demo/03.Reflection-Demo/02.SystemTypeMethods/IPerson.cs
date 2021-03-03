namespace SystemTypeMethods
{
    public interface IPerson
    {
        int Age { get; }

        string Name { get; }

        string WhoAmI();
    }
}
