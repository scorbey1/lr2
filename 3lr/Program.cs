using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2
{
    internal class Program
    {
        static void Main()
        {
            int[] array1 = { -46, 38, 29, 568, -329, 89, -53 };
            int[] array2 = { 46, 38, 29, 568, 329, 89, 53 };
            //одинаковые массивы
            OneDimensionalArray oneDimensionArray1 = new OneDimensionalArray(array1);
            OneDimensionalArray oneDimensionArray2 = new OneDimensionalArray(array2);
            //только положительные значения
            OneDimensionalArray oneDimensionArrayCopy = new OneDimensionalArray(array1);
            Console.WriteLine("=== Исхоные массивы ===");
            Console.WriteLine("Массив 1: " + oneDimensionArray1.ToString());
            Console.WriteLine("Массив 2: " + oneDimensionArray2.ToString());
            // Индексатор
            Console.WriteLine();
            Console.WriteLine("=== Проверка индексатора ===");
            Console.WriteLine($"Результат данной операции: {oneDimensionArray1[0]} + {oneDimensionArray2[0]} равен {oneDimensionArray1[0] + oneDimensionArray2[0]}");

            // * - умножение массивов (может выкинуть исключение)
            Console.WriteLine();
            Console.WriteLine("=== Проверка умножения массивов ===");
            try
            {
                OneDimensionalArray oneDimensionArray4 = oneDimensionArray1 * oneDimensionArray2;
                Console.WriteLine($"{oneDimensionArray4}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
            }

            // true – истина, если массив не содержит отрицательных элементов
            Console.WriteLine();
            Console.WriteLine("=== Проверка оператора true ===");
            // 1. Выведет false
            if (oneDimensionArray1)
                Console.WriteLine($"Массив {oneDimensionArray1} не имеет отрицательные значения");
            else
                Console.WriteLine($"Массив {oneDimensionArray1} имеет отрицательные значения");
            // 2. Выведет true
            if (oneDimensionArray2)
                Console.WriteLine($"Массив {oneDimensionArray2} не имеет отрицательные значения");
            else
                Console.WriteLine($"Массив {oneDimensionArray2} имеет отрицательные значения");

            // false – истина, если массив содержит отрицательные элементы(хотя бы 1)
            Console.WriteLine();
            Console.WriteLine("=== Проверка оператора false ===");
            // 1. Выведет true
            if (!oneDimensionArray1)
                Console.WriteLine($"Массив {oneDimensionArray1} имеет отрицательные значения");
            else
                Console.WriteLine($"Массив {oneDimensionArray1} не имеет отрицательные значения");
            // 2. Выведет false
            if (!oneDimensionArray2)
                Console.WriteLine($"Массив {oneDimensionArray2} имеет отрицательные значения");
            else
                Console.WriteLine($"Массив {oneDimensionArray2} не имеет отрицательные значения");


            // (int) - операция приведения – возвращает размер массива
            Console.WriteLine();
            Console.WriteLine("=== Проверка операции приведения (int) ===");
            int len1 = (int)oneDimensionArray1;
            Console.WriteLine($"Длина массива: {len1}");

            //== - проверка на равенство
            Console.WriteLine();
            Console.WriteLine("=== Проверка оператора '==' ===");
            // не равные массивы
            if (oneDimensionArray1 == oneDimensionArray2)
                Console.WriteLine($"Массивы {oneDimensionArray1} и {oneDimensionArray2} равны");
            else
                Console.WriteLine($"Массивы {oneDimensionArray1} и {oneDimensionArray2} не равны");
            // равные массивы
            if (oneDimensionArray1 == oneDimensionArrayCopy)
                Console.WriteLine($"Массивы {oneDimensionArray1} и {oneDimensionArrayCopy} равны");
            else
                Console.WriteLine($"Массивы {oneDimensionArray1} и {oneDimensionArrayCopy} не равны");

            //!= - проверка на неравенство
            Console.WriteLine();
            Console.WriteLine("=== Проверка оператора '!=' ===");
            // не равные массивы
            if (oneDimensionArray1 != oneDimensionArray2)
                Console.WriteLine($"Массивы {oneDimensionArray1} и {oneDimensionArray2} не равны");
            else
                Console.WriteLine($"Массивы {oneDimensionArray1} и {oneDimensionArray2} равны");
            // равные массивы
            if (oneDimensionArray1 != oneDimensionArrayCopy)
                Console.WriteLine($"Массивы {oneDimensionArray1} и {oneDimensionArrayCopy} не равны");
            else
                Console.WriteLine($"Массивы {oneDimensionArray1} и {oneDimensionArrayCopy} равны");

            //Лексикографическое сравнение
            // < - сравнение
            Console.WriteLine();
            Console.WriteLine("=== Проверка оператора '<' ===");
            if (oneDimensionArray1 < oneDimensionArray2)
                Console.WriteLine($"Массив {oneDimensionArray1} меньше, чем {oneDimensionArray2}");
            else
                Console.WriteLine($"Массив {oneDimensionArray1} больше или равен {oneDimensionArray2}");

            // > - сравнение
            Console.WriteLine();
            Console.WriteLine("=== Проверка оператора '>' ===");
            if (oneDimensionArray1 > oneDimensionArray2)
                Console.WriteLine($"Массив {oneDimensionArray1} больше, чем {oneDimensionArray2}");
            else
                Console.WriteLine($"Массив {oneDimensionArray1} меньше или равен {oneDimensionArray2}");

            // 1) Проверка на содержание определённого символа в строке
            Console.WriteLine();
            Console.WriteLine("=== Проверка на содержание определённого символа в строке ===");
            string str = "Строка";
            char c = 'т';
            bool res = str.FoundChar(c);
            if (res)
                Console.WriteLine($"Буква '{c}' была найдена в строке \"{str}\"");
            else
                Console.WriteLine($"Буква '{c}' не была найдена в строке \"{str}\"");

            // 2) Удаление отрицательных элементов (новый массив как результат)
            Console.WriteLine();
            Console.WriteLine("=== Проверка удаления отрицательных элементов ===");
            OneDimensionalArray oneDimensionArray1Possitive = oneDimensionArray1.DeleteNegativeNums();
            Console.WriteLine($"{oneDimensionArray1} -> {oneDimensionArray1Possitive}");
        }
    }
}
