using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2
{
    internal class OneDimensionalArray
    {
        private int[] array;
        // конструкторы
        public OneDimensionalArray() 
        { 
            array = new int[0];
        }
        // Пустой массив с заданной длиной
        public OneDimensionalArray(int len)
        {
            array = new int[len];
        }
        public OneDimensionalArray(int[] array)
        {
            this.array = array;
        }
        // Свойства
        public int[] Value
        {
            get => array;
            set => array = value;

        }
        // Индексатор
        public int this[int index]
        {
            get { return array[index]; }
            set {  array[index] = value; }
        } 
        // перегрузка операций
        // * - умножение массивов
        public static OneDimensionalArray operator *(OneDimensionalArray array1, OneDimensionalArray array2)
        {
            if (array1.Value.Length != array2.Value.Length)
                throw new ArgumentException("Массивы должны быть одинаковой длины!");

            //умножение каждого элемента массива на тот же элемент в другом массиве
            int[] newArray = new int[array1.Value.Length];
            int i = 0;
            while(i < array1.Value.Length)
            {
                newArray[i] = array1.Value[i]* array2.Value[i];
                i++;
            }
            OneDimensionalArray array3 = new OneDimensionalArray(newArray);
            return array3;           
        }
        // true – истина, если массив не сдержит отрицательных элементов
        public static bool operator true(OneDimensionalArray array)
        {
            for (int i = 0; i < array.Value.Length; i++)
            {
                if (array.Value[i] < 0) return false;
            }
            return true;
        }
        // false – истина, если массив содержит отрицательные элементы(хотя бы 1)
        public static bool operator false(OneDimensionalArray array)
        {
            for (int i = 0; i < array.Value.Length; i++)
            {
                if (array.Value[i] < 0) return true;
            }
            return false;
        }
        // перегрузка !
        public static bool operator !(OneDimensionalArray array)
        {
            // Логическое отрицание operator true
            for (int i = 0; i < array.Value.Length; i++)
            {
                if (array.Value[i] < 0) return true;
            }
            return false;
        }

        // (int) - операция приведения – возвращает размер массива
        public static implicit operator int(OneDimensionalArray array)
        {
            return array.Value.Length;
        }
        public static explicit operator OneDimensionalArray(int len)
        {
            return new OneDimensionalArray(len);
        }
        //== - проверка на равенство
        public static bool operator ==(OneDimensionalArray array1, OneDimensionalArray array2)
        {
            if (array1.Value == array2.Value && array1.Value != null && array2.Value != null ) return true;
            else return false;
        }
        //!= - проверка на равенство
        public static bool operator !=(OneDimensionalArray array1, OneDimensionalArray array2)
        {
            if (array1.Value == array2.Value) return false;
            else return true;
        }
        //Лексикографическое сравнение
        // < - сравнение
        public static bool operator <(OneDimensionalArray array1, OneDimensionalArray array2)
        {
            int minLenght = Math.Min(array1.Value.Length, array2.Value.Length);
            for (int i = 0; i < minLenght; i++)
            {
                if (array1.Value[i] < array2.Value[i])
                    return true;
                if (array1.Value[i] > array2.Value[i])
                    return false;
            }
            return array1.Value.Length < array2.Value.Length;
        }
        // > - сравнение
        public static bool operator >(OneDimensionalArray array1, OneDimensionalArray array2)
        {
            int minLenght = Math.Min(array1.Value.Length, array2.Value.Length);
            for (int i = 0; i < minLenght; i++)
            {
                if (array1.Value[i] > array2.Value[i])
                    return true;
                if (array1.Value[i] < array2.Value[i])
                    return false;
            }
            return array1.Value.Length > array2.Value.Length;
        }
        public override string ToString()
        {
            string str;
            str = "[" + string.Join(" ", array) + "]";
            return str;
        }
    }
}
