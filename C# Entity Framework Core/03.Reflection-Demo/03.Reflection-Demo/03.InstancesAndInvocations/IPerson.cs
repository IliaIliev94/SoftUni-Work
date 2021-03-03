namespace InstancesAndInvocations
{
    public interface IPerson
    {
        int Age { get; }

        string Name { get; }

        string Eat(string food);
    }
}
