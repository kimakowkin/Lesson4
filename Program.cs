namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string o;
            do
            {
                Console.Clear();
                Console.WriteLine("Выберите операцию: \n1.Fibonacci \n2.Calculate Deposit \n3.Create Array \n4.Create Odd Array \n5.Sort Names \n6.Bubble Sort \n\n0.Завершить работу");

                o = Convert.ToString(Console.ReadLine());

            
                switch (o)
                {
                    case "1":
                        Fibonacci();
                        break;
                    case "2":
                        CalculateDeposit();
                        break;
                    case "3":
                        CreateArray();
                        break;
                    case "4":
                        CreateOddArray();
                        break;
                    case "5":
                        SortNames();
                        break;
                    case "6":
                        BubbleSort();
                        break;
                    case "0":
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Неверный ввод. Выберите другую операцию");
                        Console.ReadLine();
                        break;
                }
            }
            while (o != "0");

            //Fibonacci();
            //CalculateDeposit();
            //CreateArray();
            //CreateOddArray();
            //SortNames();
            //BubbleSort();
        }

        // Выведите на экран первые 11 членов последовательности Фибоначчи
        // 1 1 2 3 5 8 13 21 34 55 89

        static void Fibonacci()
        {
            int start = 0;
            int next = 1;
            for (int i = 1; i <= 6; i++)
            {
                Console.Write(start + " ");
                Console.Write(next + " ");
                start = next + start;
                next = next + start;
            }
            Console.ReadLine();
        }

        // За каждый месяц банк начисляет к сумме вклада 7% от суммы.
        // Напишите программу, в которую пользователь вводит сумму вклада и
        // количество месяцев.А банк вычисляет конечную сумму вклада с учетом
        // начисления процентов за каждый месяц.
        // Для вычисления суммы с учетом процентов используйте цикл for. Пусть
        // сумма вклада будет представлять тип float.

        static void CalculateDeposit()
        {
            Console.WriteLine("Введите сумму вклада: ");
            float sum = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество месяцев: ");
            int months = int.Parse(Console.ReadLine());

            float total = 0;
            for (int i = 1; i <= months; i++)
            {
                total = (total + sum) * 1.07f;
            }

            Console.WriteLine($"Конечная сумма = {total}");
            Console.ReadLine();
        }

        // Создайте массив из n случайных целых чисел и выведите его на экран.
        // Размер массива пусть задается с консоли и размер массива может быть
        // больше 5 и меньше или равно 10.
        // Если n не удовлетворяет условию - выведите сообщение об этом.
        // Если пользователь ввёл не подходящее число, то программа должна
        // просить пользователя повторить ввод.
        // Создайте второй массив только из чётных элементов первого массива,
        // если они там есть, и вывести его на экран.
        static void CreateArray()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите количество элементов массива: ");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x <= 5 || x > 10)
                {
                    Console.WriteLine("Недопустимое количество элементов массива!");
                    Console.ReadLine();
                    continue;
                }

                Random rand = new Random();
                int[] array = new int[x];

                Console.WriteLine("Первичный массив случайных чисел: ");
                for (int i = 0; i < x; i++)
                {
                    array[i] = rand.Next(1, 100);
                    Console.Write(array[i] + " ");
                }
                Console.ReadLine();

                Console.WriteLine("Вторичный массив чётных чисел: ");
                int[] evenArray = array.Where(x => x % 2 == 0).ToArray();
                foreach (int i in evenArray)
                {
                    Console.Write(i + " ");
                }
                Console.ReadLine();
                break;
            }

        }

        // Создайте массив и заполните массив.
        // Выведите массив на экран в строку.
        // Замените каждый элемент с нечётным индексом на ноль.
        // Снова выведите массив на экран на отдельной строке.

        static void CreateOddArray()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите количество элементов массива: ");
                int x = Convert.ToInt32(Console.ReadLine());

                Random rand = new Random();
                int[] array = new int[x];

                Console.WriteLine("Первичный массив случайных чисел: ");
                for (int i = 0; i < x; i++)
                {
                    array[i] = rand.Next(1, 100);
                    Console.Write(array[i] + " ");
                }
                Console.ReadLine();

                Console.WriteLine("Вторичный массив с заменёнными числами: ");
                for (int i = 0; i < x; i++)
                {
                    array[i] = i % 2 == 0 ? array[i] : 0;
                    Console.Write(array[i] + " ");
                }
                Console.ReadLine();
                break;

            }
        }

        // Создайте массив строк.Заполните его произвольными именами людей.
        // Отсортируйте массив.
        // Результат выведите на консоль.

        static void SortNames()
        {
            string[] names = { "James", "John", "Alex", "Danny", "George" };

            Console.WriteLine("Первичный несортированный массив: ");
            foreach (string name in names)
            {
                Console.Write($"{name} ");
            }
            Console.ReadLine();

            Array.Sort(names);

            Console.WriteLine("Вторичный сортированный массив: ");
            foreach (string name in names)
            {
                Console.Write($"{name} ");
            }
            Console.ReadLine();
        }

        // Реализуйте алгоритм сортировки пузырьком

        static void BubbleSort()
        {
            int[] array = { 5, 3, 8, 4, 1 };
            Console.WriteLine("Первичный несортированный массив: ");
            foreach(int i in array)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Вторичный сортированный массив: ");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}