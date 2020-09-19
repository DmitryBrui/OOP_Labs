using System;
using System.Linq;
using System.Text;
using System.Threading;

namespace MyProgram
{
    class Variables
    {   static void Main(string[] args)

        {
            bool boolVar = true;
            Console.WriteLine(boolVar);
            byte bVar = 255;
            Console.WriteLine(bVar);
            sbyte sbVar = -127;
            Console.WriteLine(sbVar);
            char cVar = 'a';
            Console.WriteLine(cVar);
            decimal decVar = 12.3M;
            Console.WriteLine(decVar);
            double dblVar = 12.3333333333333;
            Console.WriteLine(dblVar);
            float fVar = 3.14F;
            Console.WriteLine(fVar);
            int iVar = -10;
            Console.WriteLine(iVar);
            uint uiVar = 10;
            Console.WriteLine(uiVar);
            long lVar = -10000000000;
            Console.WriteLine(lVar);
            ulong ulVar = 10000000000000000;
            Console.WriteLine(ulVar);
            short sVar = -14;
            Console.WriteLine(sVar);
            ushort usVar = 14;
            Console.WriteLine(usVar);

            //Неявные
            fVar = +cVar;
            lVar = sVar+1;
            decVar = bVar;
            sVar =sbVar;
            usVar = bVar;


            //Явные
            decVar = (decimal)dblVar;
            bVar = (byte)(iVar + uiVar);
            sbVar = (sbyte)(cVar - 1);
            fVar = (float)(decVar / 10);
            dblVar = Convert.ToDouble(decVar - sbVar);

            //Упаковка
            
            object box = iVar;

            //Распаковка

            int unboxedVar = (int)box;

            //Неявный тип
            dynamic value;
            value = (iVar > 5) ? (value ="True") : (value = 0);

            //Nullable

            uint CustomersAmount = 10;
            bool? IsEnough = (CustomersAmount <10)?(IsEnough=null):(IsEnough=true);

            //var

            var a = 10;
            //a = Convert.ToDouble(10); var не является типом сам по себе, тип будет выведен из значения компилятором.

            //Строки
            string Name = "Дмитрий ";
            string Surname = "Карелин ";
            string Patronymic = "Владиславович";
            Console.WriteLine("Сравнение строк");
            Console.WriteLine(string.Compare(Name, Surname));
            string fullName = Surname + Name + Patronymic;
            Console.WriteLine(fullName);
            Console.WriteLine(string.Copy(Surname));
            Console.WriteLine(fullName.Substring(8, 7));
            string[] parts = fullName.Split(' ');
            foreach (string part in parts)
                Console.WriteLine(part);
            Console.WriteLine(fullName.Insert(0, "Моё имя - "));
            Console.WriteLine(fullName.Remove(0, 8));

            //Интерполяция

            long number = 375295567745;
            Console.WriteLine($"{number:+###(##)###-##-##}");

            //Пустая и null строки

            string nullStr=null;
            string emptyStr="";

            Console.WriteLine("Нулевая строка - ",string.IsNullOrEmpty(nullStr));
            Console.WriteLine("Пустая строка - ", string.IsNullOrEmpty(emptyStr));

            emptyStr= emptyStr + fullName;
            Console.WriteLine(emptyStr);

            //StringBuilder

            StringBuilder sbStr = new StringBuilder("За Беларусь", 20);
            sbStr.Remove(0,2);
            sbStr.Insert(0, "Жыве");
            sbStr.Append("!");
            Console.WriteLine(sbStr);

            //Массивы

            int[,] Matrix = new int [3,3]{ { 1, 2, 3 },{ 2, 2, 2 },{ 3, 3, 3 } };
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                Console.Write(Matrix[i, j]+" ");
                Console.WriteLine();
            }

            string[] StrArr = { "Саске", "Вернись", "В Коноху" };
            foreach (string word in StrArr) Console.Write(word + " ");
            Console.WriteLine(StrArr.Length);
            StrArr[0] = fullName;
            foreach (string word in StrArr) Console.Write(word + " ");
            Console.WriteLine();

            double[][] dblArr=new double[3][];
            dblArr[0] = new double[2];
            dblArr[1] = new double[3];
            dblArr[2] = new double[4];


            Console.WriteLine("Введите массив");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < i+2; j++)
                    dblArr[i][j] = double.Parse(Console.ReadLine());
            }

            foreach (double[] Arr in dblArr)
            {
                foreach (double numb in Arr) Console.Write(numb+" ");
                Console.WriteLine();
            }

            var arrHolder = new object[0];
            var strHolder = "";

            ValueTuple <int, string, char, string, ulong> MyTuple = (32, "Посылки", 'R', "г.Минск", 320032);
            Console.WriteLine(MyTuple);
            Console.WriteLine(MyTuple.Item1);
            Console.WriteLine(MyTuple.Item3);
            Console.WriteLine(MyTuple.Item5);

            //var (amo,nam,typ,addr,ind) = CreateCortage(MyTuple);

            int Amount = MyTuple.Item1;
            string productName = MyTuple.Item2;
            char productType = MyTuple.Item3;

            //local func

            int Sum = locSum(2, 5);

            int locSum(int m, int n)
            {
                return m - n;
            }

            //cheked uncheked

            int locFunc1()
            {
                checked
                {
                    int maxValue = 2147483647;
                }
                return 0;
            }

            int locFunc2()
            {
                unchecked
                {
                    int maxValue = 2147483647;
                }
                return 0;
            }
        }
    }
}