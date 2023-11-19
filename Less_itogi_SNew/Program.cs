namespace Less_itogi_SNew
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task1
            // создаем массив исключений
            // задание 1.2
            // в массив добавляю исключения на свой вкус + пользовательское исключенние 

            Console.WriteLine("===========================================================================================================");
            Console.WriteLine("ЗАДАНИЕ 1");
            Console.WriteLine();

            Exception[] exceptions = new Exception[5];
            exceptions[0] = new OverflowException("Арифметическое, приведение или операция преобразования приводят к переполнению");     // Арифметическое, приведение или операция преобразования приводят к переполнению.
            exceptions[1] = new DivideByZeroException("Знаменатель в операции деления или целого числа Decimal равен нулю"); // Знаменатель в операции деления или целого числа Decimal равен нулю.
            exceptions[2] = new ArgumentException("Непустой аргумент, передаваемый в метод, является недопустимым");     // Непустой аргумент, передаваемый в метод, является недопустимым.
            exceptions[3] = new TimeoutException("Срок действия интервала времени, выделенного для операции, истек");      // Срок действия интервала времени, выделенного для операции, истек.
            exceptions[4] = new PersonException("Фамилия не может быть меньше двух знаков!");       // Пользовательское исключение

            // готовим конструкцию try - catch
            // задание 1.2
            // немного не понял задание
            // я бы сделал через несколько блоков cath
            // но тут стоит слово итерация
            // по этому я буду делать через foreach

            // запускаем цикл
            foreach (Exception ex in exceptions)
            {
                try
                {
                    throw ex;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.GetType());
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }

                // finally { } - этот блок к данной задаче не подойдет
            }

            Console.WriteLine();
            Console.WriteLine("ЗАДАНИЕ 1 ОКОНЧАНИЕ");
            Console.WriteLine("===========================================================================================================");
            #endregion


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===========================================================================================================");
            Console.WriteLine("ЗАДАНИЕ 2");
            Console.WriteLine();

            string flagTest;
            int parametrSort;
            Console.WriteLine("Вы хотите начать тестировать задание 2?");
            Console.Write("Введите ДА: ");
            flagTest = Console.ReadLine();

            try
            {
                if (flagTest == "ДА")
                {
                    Console.WriteLine("Введите способ сортировки!");
                    Console.Write("1 - по возрастанию / 2 - по убыванию: ");
                    parametrSort = Convert.ToInt32(Console.ReadLine());

                    // создаем объект 
                    ExamParam examParam = new ExamParam();

                    // подписываем этого человека на событие
                    examParam.EventParamSort += ExamParam_EventParamSort;

                    // вызываем метод, который вызывает событие
                    examParam.CallEvent(parametrSort);
                }
                else
                {
                    Console.WriteLine("Вы не ввели ДА! Программа будет закрыта");
                }
            }
            catch
            {
                Console.WriteLine("Вы ввели странное значение! Программа будет закрыта!");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ЗАДАНИЕ 2 ОКОНЧАНИЕ");
            Console.WriteLine("===========================================================================================================");   
            Console.WriteLine();
        }

        private static void ExamParam_EventParamSort(int numParam)
        {
            try
            {
                int valSecondName;

                Console.Write("Ввведите длину массива для проверки: ");
                valSecondName = Convert.ToInt32(Console.ReadLine());

                // создаем массив с нужным количеством элементов
                string[] ArraySecondName = new string[valSecondName];

                Console.WriteLine("Заполните пожалуйста массив фамилий!");
                // запускаем цикл для заполнения массива
                for (int i = 0; i < ArraySecondName.Length; i++)
                {
                    Console.Write("Введите {0}-й элемент массива: ", i+1);
                    ArraySecondName[i] = Console.ReadLine();

                    if (ArraySecondName[i].Length < 2)
                    {
                        throw new PersonException("Фамилия не может быть меньше двух знаков!");
                    }
                }

                
                // буду сортировать массив один раз по возрастанию
                // а выводить даннные буду в зависимости от параметра 1 и 2

                Array.Sort(ArraySecondName);

                if (numParam == 1)
                {
                    Console.WriteLine("Массив по возрастанию:");
                    foreach (string s in ArraySecondName)
                    {
                        Console.WriteLine(s);
                    }
                }
                else
                {
                    Console.WriteLine("Массив по убыванию: ");
                    for (int i = ArraySecondName.Length; i > 0; i--)
                    {
                        Console.WriteLine(ArraySecondName[i-1]);
                    } 
                }

            }
            catch (PersonException e)
            {
                Console.WriteLine();
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.Message);
                Console.WriteLine("Программа будет закрыта!");
            }

            catch
            {
                Console.WriteLine("Другая ошибка! Пррограмма будет закрыта!"); 
            }
        }
    }
}