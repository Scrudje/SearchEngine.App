using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine
{
    public static class KeyLoad
    {
        public static void Save(string key)
        {
            using (StreamWriter sw = new StreamWriter("key.txt"))
            {
                sw.Write(key);
            }


        }
        public static string Load()
        {
            string key = String.Empty;
            using (StreamReader sr = new StreamReader("key.txt"))
            {

                key = sr.ReadLine();

            }
            return key;
        }



    }
}
