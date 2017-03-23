using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class types
    {
        static public void Main(string[] args)
        {
            const string bla = "bla";
            "bla".;

            var c = new Class();
            c.Int = 99;

            var c1 = c;
            c.Int = 100;

            var st = new Struct();
            st.Int = 99;

            var st1 = st;
            st.Int = 100;

            int i = 100;
            string s = "Hello, world";

            Console.WriteLine("Before, i = " + i);
            ChangeInt(i);
            Console.WriteLine("After, i = " + i);

            Console.WriteLine("Before, s = " + s);
            ChangeString(s);
            Console.WriteLine("After, s = " + s);

            Console.Write("\nPress any key to continue>\n");
            Console.ReadLine();


            string q = "Hello, world.    ";
            q.Trim();
            Console.WriteLine(q + " I wasn't trimmed !");

            string w = q.Trim();
            Console.WriteLine(w + " I wasn't trimmed !");
            Console.ReadLine();
        }

        static void ChangeInt(int i)
        {
            i = 99;
        }

        static void ChangeString(string s)
        {
            s = "Hello, I've been changed.";
        }

    }

    class Class
    {
        internal int Int;
    }

    struct Struct
    {
        internal int Int;
    }
}
