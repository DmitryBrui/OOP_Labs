using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Класс - множество Set.Дополнительно перегрузить
//следующие операции: 
//      ++ -добавление случайного элемента к множесту, +
//      + - объединение множеств; +
//      <= - сравнение множеств; +
//      неявный int() - мощность множества; +
//      % - доступ к элементу в заданной позиции.

namespace OOP_Lab04
{
    public class Set<T>
    {
        public List<T> _list;
        Set()
        {
            _list = new List<T>();
        }
        public Set(params T[] args): this()
        {
            _list.AddRange(args);
        }
        public Set(IEnumerable<T> mas)
            : this()
        {
            _list.AddRange(mas);
        }

        public void Add(T elem)
        {
            _list.Add(elem);
        }
        public void Delete(T elem)
        {
            _list.Remove(elem);
        }
        public Set<T> Intersect(Set<T> Source)
        {
            return new Set<T>(_list.Intersect(Source._list));
        }
        public Set<T> Union(Set<T> Source)
        {
            return new Set<T>(_list.Union(Source._list));
        }
        public Set<T> Except(Set<T> Source)
        {
            return new Set<T>(_list.Except(Source._list));
        }
        public override string ToString()
        {
            return string.Join(",", _list);
        }

        public static Set<T> operator ++(Set<T> set1)
        {
            T rnd = (T)Convert.ChangeType(set1.GetHashCode(), typeof(T));
            set1.Add(rnd);
            return set1;
        }

        public static Set<T> operator +(Set<T> set1, Set<T> set2)
        {
            return set1.Union(set2);
        }

        public static bool operator <=(Set<T> set1, Set<T> set2)
        {
            if (set1._list.Count <= set2._list.Count) return true;
            else return false;
        }

        public static bool operator >=(Set<T> set1, Set<T> set2)
        {
            if (set1._list.Count >= set2._list.Count) return true;
            else return false;
        }

        public static implicit operator int(Set<T> set1)
        {
            return set1._list.Count;
        }

        public static List<T> operator %(Set<T> set1, int index)
        {
            return new List<T>((IEnumerable<T>)set1._list[index]);
        }
        class Date
        {
            private static DateTime now;
            public Date()
            {
                now = DateTime.Now;
            }
        }

        class Owner
        {
           private Set<T> parent;
            private int id;
           private static string name = "Karelin Dmitry";
           private static string label = "BSTU";

           public Owner(Set<T> parent)
            {
                this.parent = parent;
                this.id = this.parent.GetHashCode();
            }
        }
    }

   public static class StatisticOperations
    {
        public static Set<T> Sum<T>(Set<T> set1, Set<T> set2)
        {
            return (set1 + set2);
        }

        public static int Amount<T>(Set<T> set1)
        {
            return ((int)set1);
        }

        public static int MaxMin<T>(Set<T> set1)
        {
            return (int)Convert.ChangeType(set1._list.Max(), typeof(int)) - (int)Convert.ChangeType(set1._list.Min(), typeof(int));
        }

        public static string Encryption(string str)
        {
            StringBuilder s = new StringBuilder(str);
            for (int i=0; i<s.Length; i++) s[i]=(char)(s[i]+i);
            return s.ToString();
        }

        public static bool isSorted<T>(Set<T> set1)
        {
           if (set1._list.SequenceEqual(set1._list.OrderBy(x => x))) return true;
           else return false;
        }
    }
}
