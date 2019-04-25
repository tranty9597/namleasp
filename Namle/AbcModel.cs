using System;

namespace Namle
{
    public class AbcModel
    {
        public string a;

        public string b;

        public string c;

 

        public AbcModel(string a, String b, String c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public String toString()
        {
            return a +"/n" + b + "/n" + c;
        }

    }


}
