using ATL;
using System.IO;

namespace TestAudio;

internal class Program
{
    static void Main(string[] args)
    {
        using FileStream fs = new FileStream("effect.flac", FileMode.Open, FileAccess.Read,
            FileShare.Read);
        Track audioInfo = new(fs, "audio/flac");


        Console.WriteLine("Audio length: " + audioInfo.Duration);
    }
}
