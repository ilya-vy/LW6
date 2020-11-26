using System;
using System.Collections.Generic;
using System.Text;

namespace ООП_ЛР6_З2
{
    class PlayerWav : IMedia
    {
        public void Play() { Console.WriteLine("Playing"); }
        public void Pause() { Console.WriteLine("Paused"); }
        public void Stop() { Console.WriteLine("Stopped"); }
    }
}
