using System.IO;

namespace ООП_ЛР6_З1_Form
{
    class TXT : AbstractHandler
    {
        public TXT(string filename, string dir) : base(filename, dir)
        {
            FileName = filename;
            Dir = dir;
        }
        public override string CreateFile()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(Dir);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            using (FileStream filestream = new FileStream($"{Dir}/{FileName}", FileMode.OpenOrCreate))
            {
                return "Файл успешно создан";
            }
        }

        public override string OpenFile()
        {
            FileInfo fileInf = new FileInfo($"{Dir}/{FileName}");
            if (fileInf.Exists)
            {
                using (FileStream filestream = File.OpenRead($"{Dir}/{FileName}"))
                {
                    byte[] array = new byte[filestream.Length];
                    filestream.Read(array, 0, array.Length);
                    string text = System.Text.Encoding.Default.GetString(array);
                    return text;
                }
            }
            else
                return "Файл не существует, сначала создайте файл";
        }

        public override string EditFile(string text)
        {
            FileInfo fileInf = new FileInfo($"{Dir}/{FileName}");
            if (fileInf.Exists)
            {
                using (FileStream filestream = File.Create($"{Dir}/{FileName}"))
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes(text);
                    filestream.Write(array, 0, array.Length);
                    return "Файл успешно записан";
                }
            }
            else
                return "Файл не существует, сначала создайте файл";

        }
    }
}
