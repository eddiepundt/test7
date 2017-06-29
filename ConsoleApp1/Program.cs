using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mga_SQL_Utils;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            clsSQL objSQL = new clsSQL();
            String strTest;

            strTest = "";

            strTest = objSQL.Get_SQL_Connection_String("", "websource");



            Console.WriteLine("a");
            Console.ReadKey();

            Console.WriteLine("Git is good");
            Console.ReadKey();
            Console.WriteLine("Git is real good");

            // test

            
            // another comment
            // test2
        }
    }
}
