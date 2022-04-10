using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Tech.Tasks
{
    internal class WriteStart
    {
        private int _linesNumer = 0;
        public int linesNumer
        {
            get
            {
                return _linesNumer;
            }
            set{
                _linesNumer = value * 10000;
            }
        }

        public void writeToFile(string fname)
        {
            string[] str = new string[linesNumer];
            for (int i = 0; i < linesNumer; i++)
            {
                str[i] = "**********";
            }

            File.WriteAllLines(fname, str);
        }

        string FileName;

        public void writeToFile()
        {
            int a = 0;
            writeToFile(FileName);
        }

        public void writeToFileAsTask(string fname)
        {
            int b = 0;


            Task.Run(() => {
                writeToFile(fname);
                b = 98;  //anonymus function has the all range to parent function;
            });
        }

        public void Run10()
        {

        }
    }
}
