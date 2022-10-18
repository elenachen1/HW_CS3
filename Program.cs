Console.WriteLine("Введите номер задачи от 1 до 5 включительно ");
Console.WriteLine("Если вы хотите завершить выполнение программы, то отправте значение 0 ");

int caseNumber = int.Parse(Console.ReadLine());

while ( caseNumber != 0 ){
   switch(caseNumber)
    {
        case 1:
        /*
        Задача 1
        Напишите программу, которая принимает на вход 
        пятизначное число и проверяет, является ли оно палиндромом.
        14212 -> нет
        12821 -> да
        23432 -> да
        */

        Console.Write("Введите пятизначное число:");
        var polinom = Console.ReadLine();

        if (polinom.Length == 5)
        {
            if (polinom.Reverse().SequenceEqual(polinom))
            {
                Console.Write("Полином!");
            }

            else
            {
                Console.Write("Не полином!");
            }
        }

        else
        {
            Console.Write($"Ошибка! Число имеет {polinom.Length} знаков.");
        }
            
        break;

        case 2:
        /*
        Задача 21
        Напишите программу, которая принимает на вход координаты 
        двух точек и находит расстояние между ними в 3D пространстве.
        A (3,6,8); B (2,1,-7), -> 15.84
        A (7,-5, 0); B (1,-1,9) -> 11.53
        */
        Console. Write ("Введите координату х первой точки: ");
        double x1=int.Parse(Console.ReadLine());
        Console. Write ("Введите координату у первой точки: ");
        double y1=int.Parse(Console.ReadLine());
        Console. Write ("Введите координату z первой точки: ");
        double z1=int.Parse(Console.ReadLine());
        
        Console. Write ("Введите координату х второй точки: ");
        double x2=int.Parse(Console.ReadLine());
        Console. Write ("Введите координату у второй точки: ");
        double y2=int.Parse(Console.ReadLine());
        Console. Write ("Введите координату z второй точки: ");
        double z2=int.Parse(Console.ReadLine());

        double distanse = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));

        Console. WriteLine($"Расстояние от точки ({x1},{y1},{z1}) до точки ({x1},{y1},{z1}) равно {Math.Round(distanse,2)}");

            
            break;

        case 3:
        /* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
        3 -> 1, 8, 27
        5 -> 1, 8, 27, 64, 125
        */

        Console. WriteLine ("Введите число: ");
        int n =int.Parse(Console.ReadLine());

        for (int i = 1; i <= n ; i=i+1){
        
          Console.Write($"{Math.Pow(i,3)} ");
        
        }
        Console.WriteLine("");
            break;
        case 4:
        /*Создать программу, которая из массива удаляется элемент с позиции, которую введет пользователь.
        */

        int[] mass  = { 5, 4, 7, 2, 9 };
        Console.WriteLine($" Дан масив{String.Join(", ", mass)}, введите номер элемента, который необходимо удалить.Размер масива {mass.Length} ");
        int index = int.Parse(Console.ReadLine());

 
        for (int i = index; i < mass.Length - 1; i++)    {
            mass[i] = mass[i + 1];
        }
        Array.Resize(ref mass, mass.Length - 1);
 
        Console.WriteLine(String.Join(", ", mass));

        break;

        case 5:
        /*Создание массива из двух массивов. В итоговом массиве должны быть элементы первого и второго массива.
        [1,2,3] [4,5,6] -> [1,2,3,4,5,6]
        */

        int[] a = {1, 2, 3};
        int[] b = {4, 5, 6};
        int[] c = a.Union(b).ToArray();
        Console.WriteLine(String.Join(", ", c));

            break;
        default:
            Console.WriteLine("Неверный ввод числа.");
            break;

    }
    Console.WriteLine("Введите номер задачи от 1 до 4 включительно ");
    Console.WriteLine("Если вы хотите завершить выполнение программы, то отправте значение 0 ");
    caseNumber = int.Parse(Console.ReadLine()); 
}





