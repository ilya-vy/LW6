using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_ЛР6_З1_Form
{
    abstract class AbstractHandler
    {
        public string FileName;
        public string Dir;

        public AbstractHandler(string filename, string dir)
        {
            FileName = filename;
            Dir = dir;
        }
        public abstract string OpenFile();
        public abstract string CreateFile();
        public abstract string EditFile(string text);
    }
}
