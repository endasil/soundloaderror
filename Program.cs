using ATL;
using System.IO;

namespace TestAudio;

internal class Program
{
    static void Main(string[] args)
    {
        using FileStream fs = new FileStream("effect.flac", FileMode.Open, FileAccess.Read,
            FileShare.Read);

        fs.Position = 0;
        Track audioInfo = new(fs, "audio/flac");


        Console.WriteLine("Audio length filestream: " + audioInfo.Duration);

        Track audioInfo2 = new("effect.flac");
        Console.WriteLine("Audio length direct path: " + audioInfo2.Duration);
    }
}
