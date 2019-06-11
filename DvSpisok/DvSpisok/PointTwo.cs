using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvSpisok
{
    class PointTwo
    {
        public static int count;
        public string data;      //информационное поле
        public PointTwo next;   //адресное поле
        public PointTwo pred;  //адресное поле
        public static int Count { get; set; }
        //конструктор без параметров
        public PointTwo()
        {
            data = "";
            next = null;
            pred = null;
        }
        //конструктор с параметром
        public PointTwo(string d)
        {
            data = d;
            next = null;
            pred = null;
        }
        //выводит список
        public override string ToString()
        {
            return data + "\n\n";
        }
    }
}
