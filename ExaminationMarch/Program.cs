using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationMarch;

namespace ExaminationMarch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExaminationMarch.Functions<int> sortingInt = new ExaminationMarch.Functions<int>();
            ExaminationMarch.Functions<char> sortingChara = new ExaminationMarch.Functions<char>();
            ExaminationMarch.Functions<string> sortingString= new ExaminationMarch.Functions<string>();
            sortingInt.AddTry(1);
            sortingInt.AddTry(2);
            sortingInt.AddTry(3);
            sortingInt.AddTry(4);
            sortingInt.AddTry(5);
            sortingInt.RemoveFirst();
            sortingInt.RemoveValue(5);
            sortingInt.PrintInt();

            sortingString.AddString();
            sortingString.AddString();
            sortingString.AddString();
            sortingString.PrintString();


            //sortingChara.AddChar();


        }

    }
}
