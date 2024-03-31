/*using System;

class Program
{
    //Дан массив и число. Найдите три числа в массиве сумма которых равна искомому числу.
    //Подсказка: если взять первое число в массиве, можно ли найти в оставшейся его части два числа равных по сумме первому.
    static void Main(string[] args)
    {

        int[] arr = { 1, 4, 6, 3, 9, 2, 1, 3, 4, 6, 45, 2, 75, 74, 232, 64, 6 };
        int target = 5;

        HW_seminar_4(arr, target);

    }
    static void HW_seminar_4(int[] arr, int target)
    {
        int n = arr.Length;
        Array.Sort(arr);

        for (int i = 0; i < n - 2; i++)
        {
            int left = i + 1;
            int right = n - 1;

            while (left < right)
            {
                int currentSum = arr[i] + arr[left] + arr[right];

                if (currentSum == target)
                {
                    Console.WriteLine("Три числа сумма которых равна " + target + " найдены: " + arr[i] + ", " + arr[left] + ", " + arr[right]);
                    return;
                }
                else if (currentSum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        Console.WriteLine("Такие три числа не найдены.");
    }

}
*/