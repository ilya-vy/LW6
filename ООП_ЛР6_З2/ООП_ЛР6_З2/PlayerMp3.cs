using System;
namespace ООП_ЛР6_З2
{
    class PlayerMp3 : IRecordable
    {
        public void Record() { Console.WriteLine("Recording"); }
        public void Pause() { Console.WriteLine("Paused"); }
        public void Stop() { Console.WriteLine("Stopped"); }
    }
}
