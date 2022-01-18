using System;

namespace Chess_board
{
    class Program
    {
        static void Main()
        {
            var count = 0;
            Console.WriteLine("Введите размерность шахматной доски");

            try
            {
                var size = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                for (var i = 0; i <= size; i++)
                {
                    while (count <= size)
                    {
                        if (size % 2 == 0)
                        {
                            Console.Write("#");
                            count++;

                            if (count == size)
                            {
                                i++;
                                if (i == size) break;
                                Console.WriteLine();
                                Console.Write("#");
                                count = 1;
                            }

                            Console.Write(".");
                            count++;

                            if (count == size)
                            {
                                i++;
                                if (i == size) break;
                                Console.WriteLine();
                                Console.Write(".");
                                count = 1;
                            }
                        }
                        else
                        {
                            Console.Write("#");
                            count++;

                            if (count == size)
                            {
                                i++;
                                if (i == size) break;
                                Console.WriteLine();
                                Console.Write(".");
                                Console.Write("#");
                                count = 2;
                            }

                            Console.Write(".");
                            count++;

                            if (count == size)
                            {
                                i++;
                                if (i == size) break;
                                Console.WriteLine();
                                Console.Write("#");
                                Console.Write(".");
                                count = 2;
                            }
                        }
                    }
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}
