using System;
using System.Collections.Generic;
using System.IO;

namespace ООП_ЛР6_З2
{
    class PlayerItem
    {
        public void FindAudio()
        {
            int i = 0;
            int fileposition;
            string action;
            List<String> mp3 = new List<string>();
            foreach (var file in (Directory.EnumerateFiles(@"C:\Music", "*.mp3")))
            {
                FileInfo name = new FileInfo(file);
                mp3.Add(name.Name);
                Console.WriteLine(mp3[i]);
                i++;
            }

            List<String> mkv = new List<string>();
            foreach (string file in (Directory.EnumerateFiles(@"C:\Music", "*.mkv")))
            {
                FileInfo name = new FileInfo(file);
                mkv.Add(name.Name);
                Console.WriteLine(mkv[i]);
                i++;
            }

            List<String> wav = new List<string>();
            foreach (string file in (Directory.EnumerateFiles(@"C:\Music", "*.wav")))
            {
                FileInfo name = new FileInfo(file);
                wav.Add(name.Name);
                Console.WriteLine(wav[i]);
                i++;
            }

            Console.WriteLine("Choose file format(mp3,mkv,wav): ");
            string fileExtention = Console.ReadLine();
            if (fileExtention == "mp3")
            {
                PlayerMp3 playerMp3 = new PlayerMp3();

                Console.WriteLine("Choose file(by pos number): ");
                fileposition = int.Parse(Console.ReadLine());
                fileposition -= 1;
                Console.WriteLine("The file {0} was chosen", mp3[fileposition]);

                Console.WriteLine("Choose your action(record,pause,stop): ");
                action = Console.ReadLine();
                if (action == "record")
                    playerMp3.Record();
                if (action == "pause")
                    playerMp3.Pause();
                if (action == "stop")
                    playerMp3.Stop();
            }

            if (fileExtention == "mkv")
            {
                PlayerMkv playerMkv = new PlayerMkv();

                Console.WriteLine("Choose file(by pos number): ");
                fileposition = int.Parse(Console.ReadLine());
                fileposition -= 1;
                Console.WriteLine("The file {0} was chosen", mkv[fileposition]);

                Console.WriteLine("Choose your action(play,pause,stop): ");
                action = Console.ReadLine();
                if (action == "play")
                    playerMkv.Play();
                if (action == "pause")
                    playerMkv.Pause();
                if (action == "stop")
                    playerMkv.Stop();
            }

            if (fileExtention == "wav")
            {
                PlayerWav playerWav = new PlayerWav();

                Console.WriteLine("Choose file(by pos number): ");
                fileposition = int.Parse(Console.ReadLine());
                fileposition -= 1;
                Console.WriteLine("The file {0} was chosen", wav[fileposition]);

                Console.WriteLine("Choose your action(play,pause,stop): ");
                action = Console.ReadLine();
                if (action == "play")
                    playerWav.Play();
                if (action == "pause")
                    playerWav.Pause();
                if (action == "stop")
                    playerWav.Stop();
            }
        }
    }
}
