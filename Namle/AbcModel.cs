using System;

namespace Namle
{
    public class AbcModel
    {
        public string a;

        public string b;

        public string c;


        public AbcModel(){

            a = b = c = "Not Found!";

        }

        public AbcModel(string a, String b, String c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public string toString()
        {
            return "a = " + a +"\nb = " + b + "\nc = " + c;
        }

    }


}
