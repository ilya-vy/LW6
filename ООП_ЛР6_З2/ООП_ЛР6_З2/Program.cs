using System;

namespace ООП_ЛР6_З2
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerItem playerItem = new PlayerItem();
            playerItem.FindAudio();
            Console.ReadKey();
        }
    }
    interface IMedia
    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }
}
