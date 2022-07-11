using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersWithThisDigitInside
{
    internal class Program
    {
        /* You have to search all numbers from inclusive 1 to inclusive a given number x, that have the given digit d in it.
 The value of d will always be 0 - 9.
 The value of x will always be greater than 0.

 You have to return as an array

 the count of these numbers,
 their sum
 and their product.

 For example:
 x = 11
 d = 1
 ->
 Numbers: 1, 10, 11
 Return: [3, 22, 110]

         If there are no numbers, which include the digit, return [0,0,0].

 Have fun coding it and please don't forget to vote and rank this kata! :-)

 I have created other katas.Have a look if you like coding and challenges.*/
        /* Вы должны искать все числа от 1 включительно до заданного числа x включительно, в котором есть заданная цифра d.
 Значение d всегда будет от 0 до 9.
 Значение x всегда будет больше 0.

 Вы должны вернуть как массив

 количество этих чисел,
 их сумма
 и их продукт.

 Например:
 х = 11
 д = 1
 ->
 Числа: 1, 10, 11
 Возврат: [3, 22, 110]

          Если нет чисел, включающих цифру, вернуть [0,0,0].

 Получайте удовольствие от его кодирования и, пожалуйста, не забудьте проголосовать и оценить этот ката! :-)

 Я создал и другие ката. Посмотрите, если вам нравится программирование и вызовы.*/
        static void Main(string[] args)
        {
            NumbersWithDigitInside(11, 1);
            Console.WriteLine(NumbersWithDigitInside(11,1));
            Console.ReadLine();
        }

        
            public static long[] NumbersWithDigitInside(long x, long d)
            {
                long count = 0;
                long sum = 0;
                long product = 1;

                for (long i = 1; i <= x; i++)
                {
                    if (i.ToString().Contains(d.ToString()))
                    {
                        count += 1;
                        sum += i;
                        product *= i;
                    }
                }
                if (count == 0)
                {
                    product = 0;
                }
                return new long[] { count, sum, product };
            }

        public static long[] NumbersWithDigitInside1(long x, long d)
        {
            var numbers = new List<long>();
            for (long i = 1; i <= x; i++)
            {
                if (i.ToString().Contains(d.ToString()))
                {
                    numbers.Add(i);
                }
            }
            if (numbers.Count == 0)
            {
                return new long[] { 0, 0, 0 };
            }
            return new long[] { numbers.Count, numbers.Sum(), numbers.Aggregate((a, b) => a * b) };
        }
    }
    }

