//Создать класс House: id, Номер квартиры, Площадь,
//Этаж, Количество комнат, Улица, Тип здания, Срок
//эксплуатации. Свойства и конструкторы должны
//обеспечивать проверку корректности. Добавить метод
//расчета возраста задания (необходимость в кап.
//ремонте).
//Создать массив объектов. Вывести:
//a) список квартир, имеющих заданное число комнат;
//b) список квартир, имеющих заданное число комнат и
//расположенных на этаже, который находится в заданном
//промежутке;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab03
{
    class Program
    {
        class House
        {
            readonly uint id;
            private ushort flatNumber;
            private ushort FlatNumber
            {
                get { return flatNumber; }
                set
                {
                    if (value < 0 || value > 1000) Console.WriteLine("Объект номер " + Amount + ": Неверно задан номер квартиры");
                    else flatNumber = value;
                }
            }
            private float flatSquare;
            private float FlatSquare
            {
                get { return flatSquare; }
                set
                {
                    if (value < 0 || value > 300) Console.WriteLine("Объект номер " + Amount + ": Неверно задана площадь квартиры");
                    else flatSquare = value;
                }
            }
            private ushort floor;
            private ushort Floor
            {
                get { return floor; }
                set
                {
                    if (value < 0 || value > 16) Console.WriteLine("Объект номер " + Amount + ": Неверно задан этаж");
                    else floor = value;
                }
            }
            private const string Address = "г. Минск, ул. Свердлова ";

            private byte type;
            private byte Type
            {
                get { return type; }
                set
                {
                    if (value < 0 || value > 8) Console.WriteLine("Объект номер " + Amount + ": Неверно задан тип");
                    else type = value;
                }
            }
            private ushort age;

            public ushort Age
            {
                get { return age; }
                private set { age = value; }
            }

            private static ushort Amount;

            static House()
            {
                Amount++;
            }

            public House(ushort FlatNumber, float FlatSquare, ushort Floor, byte Type, ushort Age)
            {
                this.FlatNumber = FlatNumber;
                this.FlatSquare = FlatSquare;
                this.Floor = Floor;
                this.Type = Type;
                this.Age = Age;
                this.id = (uint)(this.GetHashCode());
            }

            public House(ushort FlatNumber, float FlatSquare)
            {
                this.FlatNumber = FlatNumber;
                this.FlatSquare = FlatSquare;
                this.id = (uint)(this.GetHashCode());
            }

            public House()
            {
                this.id = (uint)(this.GetHashCode());
            }

            private House(ushort FlatNumber)
            {
                this.FlatNumber = FlatNumber;
                this.Floor = (ushort)(FlatNumber / 10);
            }

            public bool CapRepair(ref int age)
            {
                if (age > 10) return true;
                else return false;
            }

        }

        static void Main(string[] args)
        {
            House house1 = new House();
            House house2 = new House(15,100);
            House house3 = new House(5,35,3,22,9);
        }
    }
}
