using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2
{
    internal static class ExtensionMethods
    {
        // 1) Проверка на содержание определённого символа в строке
        public static bool FoundChar(this string str, char c)
        {
            if (str == null) return false;
            for(int i = 0; i < str.Length; i++)
            {
                if(str[i] == c) return true;
            }
            return false;
        }
        // 2) Удаление отрицательных элементов (новый массив как результат)
        public static OneDimensionalArray DeleteNegativeNums(this OneDimensionalArray array)
        {
            if (array.Value == null) return null;
            int newLenght = 0;
            for(int i = 0; i < array.Value.Length; i++)
            {
                if (array[i] >= 0) newLenght++;
            }
            OneDimensionalArray newArray = new OneDimensionalArray(newLenght);
            int j = 0;
            for (int i = 0; i < array.Value.Length; i++)
            {
                if (array[i] < 0) continue;
                else
                {
                    newArray[j] = array[i];
                    j++;
                }
            }
            return newArray;
        }
    }
}
