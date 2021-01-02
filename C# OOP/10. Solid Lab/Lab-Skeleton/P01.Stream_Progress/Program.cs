using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            Music music = new Music("Pesho", "Album", 50, 100);
            StreamProgressInfo streamProgressInfo = new StreamProgressInfo(music);
            Console.WriteLine(streamProgressInfo.CalculateCurrentPercent());
            File file = new File("MyFile", 100, 50);
            streamProgressInfo = new StreamProgressInfo(file);
            Console.WriteLine(streamProgressInfo.CalculateCurrentPercent());
        }
    }
}
