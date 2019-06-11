using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_methods;

namespace DvSpisok
{
    class Program
    {
        public static PointTwo beg;
        public static int zadacha, size;
        public static int HowCreate;

        static PointTwo MakeListTwo()
        {
            beg = MakePointTwo(1);//создает первый элемент
            for (int i = 1; i < size; i++)
                beg = AddToTwo(beg, (i + 1));//добавляет  остальные элементы в начало
            return beg;
        }
        static PointTwo AddToTwo(PointTwo beg, int numb)//добавление остальных элементов в начало
        {
            PointTwo x = MakePointTwo(numb);
            PointTwo pointTwo = new PointTwo(x.data);

            if (beg == null)
                return pointTwo;
            PointTwo temp = beg;
            while (temp.pred != null) temp = temp.pred;
            pointTwo.next = beg;
            beg.pred = pointTwo;
            beg = pointTwo;
            return beg;
        }

        static PointTwo MakePointTwo(int i)
        {
            Console.Clear();
            string x = "";
            if (HowCreate == 1)
            {
                Color.Print("\n Допускается ввод букв и знаков препинаний (!.?,;:)\n", ConsoleColor.Yellow);
                Color.Print("\n Введено " + i + " из " + size + " элементов: ", ConsoleColor.Green);
                x = Number.Symbols();
                return new PointTwo(x);
            }
            else
                x = Rand.Words();
            Color.Print("\n Добавлено!", ConsoleColor.Cyan);
            return new PointTwo(x);
        }

        static void ShowListTwo()
        {
            Console.WriteLine("");
            if (beg == null)
            {
                Color.Print("Список пуст!\n", ConsoleColor.Red);
                return;
            }
            PointTwo temp = beg;
            Color.Print("Исходный список:\n", ConsoleColor.Yellow);
            while (temp != null)
            {
                Console.Write(temp);
                temp = temp.next;//переход к следующему элементу
            }
        }

        public static PointTwo Delete()
        {
            if (beg == null)//список пустой
            {
                Color.Print(" Список пуст!\n ", ConsoleColor.Red);
                return null;
            }
            ShowListTwo();
            Color.Print(" Номер удаляемого элемента: ", ConsoleColor.Green);
            int number = Number.Check(1, int.MaxValue);
            if (number == 1) //удаление в начале списка
            {
                beg = beg.next;
                if (beg != null)
                    beg.pred = null;
                return beg;
            }
            PointTwo p = beg;
            for (int i = 1; i < number && p != null; i++) p = p.next;
            if (p == null)//если элемент не найден
            {
                Color.Print("Ошибка! Размер списка меньше, чем номер.\n", ConsoleColor.Red);
                return beg;
            }
            //исключаем элемент из списка
            p.pred.next = p.next;
            if (p.next != null)
                p.next.pred = p.pred;
            Color.Print("\n Удалено!", ConsoleColor.Cyan);
            return beg;
        }
        public static void Create()
        {
            Color.Print("\nВведите количество элементов: ", ConsoleColor.Yellow);
            size = Number.Check(1, int.MaxValue);
            Color.Print("\nВыберите способ заполнения: \n\n ", ConsoleColor.Yellow);
            Color.Print("1) Ручной ввод \n 2) Случайный \n Номер:  ");
            HowCreate = Number.Check(1, 2);
            beg = MakeListTwo();
        }

        public static void Finde()
        {
            if (beg == null)//список пустой
            {
                Color.Print(" Список пуст!\n ", ConsoleColor.Red);
                return;
            }
            Color.Print(" Номер искомого элемента: ", ConsoleColor.Green);
            int number = Number.Check(1, int.MaxValue) - 1;
            PointTwo temp = beg;
            for (int i = 0; i < number && temp != null; i++) temp = temp.next;//перебор элементов до нужного номера
            if (temp == null)
            {
                Color.Print("Элемент не найден.\n", ConsoleColor.Red);
                return;
            }
            Color.Print("\n Элемент: " + temp, ConsoleColor.Green);
        }
        static void Main()
        {
            Color.Print("\tВыберите пункт: \n", ConsoleColor.Yellow);
            Color.Print(" 1) Создать список \n 2) Печать списка \n 3) Удалить элемент по номеру \n 4) Найти элемент по номеру \n 5) Выход \n Номер: ");
            zadacha = Number.Check(1, 5);
            switch (zadacha)
            {
                case 1: Create(); Text.GoBackMenu(); Main(); break;
                case 2: ShowListTwo(); Text.GoBackMenu(); Main(); break;
                case 3: beg = Delete(); Text.GoBackMenu(); Main(); break;
                case 4: Finde(); Text.GoBackMenu(); Main(); break;
                case 5: break;
            }
        }
    }
}
