namespace StudentSystem
{
    public class StartUp
    {
        public static void Main()
        {
            var studentSystem = new StudentData();
            var inputOutputProvider = new ConsoleInputOutputProvider();
            var engine = new Engine(studentSystem, inputOutputProvider);
            engine.Process();
        }
    }
}
