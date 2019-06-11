using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvSpisok
{
    class Rand
    {
        static Random rnd = new Random();
        public static string Words()
        {
            string x = ":)";
            int r = rnd.Next(1, 11);
            switch (r)
            {
                case 1:
                    x = "Привет!";
                    return x;
                case 2:
                    x = "Где?";
                    return x;
                case 3:
                    x = "Куда?";
                    return x;
                case 4:
                    x = "Когда?";
                    return x;
                case 5:
                    x = "О";
                    return x;
                case 6:
                    x = "Чайка";
                    return x;
                case 7:
                    x = "Дom";
                    return x;
                case 8:
                    x = "* (.___. ) ";
                    return x;
                case 9:
                    x = "Пока!";
                    return x;
                case 10:
                    x = "Здравствуйте!";
                    return x;
            }
            return x;
        }
    }
}
