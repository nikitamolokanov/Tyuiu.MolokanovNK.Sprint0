using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MolokanovNK.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MolokanovNK.Sprint0.Task2.V0
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса DataServise и метода GetMassage
            //из библиотеки Tyuiu.MolokanovNK.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataServise.GetMessage("Никита"));
            Console.ReadKey();
        }
    }
}
