namespace ConsoleApp15
{
    internal class Program
    {
        const int str = 4;
        const int stl = 3;
        static int[,] path = new int[str, stl] {
            {100,9,9},
            {4,1,1},
            {1,1,1},
            {1,1,1}
        };
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Garden1);
            Thread thread = new Thread(threadStart);
            thread.Start();
            Garden2();

            for (int j = 0; j < str; j++)
            {
                Console.WriteLine();
                for (int i = 0; i < stl; i++)
                {
                    Console.Write($"{path[j, i]} ");
                }
               
            }
        }


        static void Garden1()
        {
            for (int j = 0; j < str; j++)
            {
                for (int i = 0; i < stl; i++)
                {
                    if (path[j, i] >= 0)
                    {
                        int z = path[j, i];
                        path[j, i] = -1;
                        Thread.Sleep(z);
                    }

                }

            }
        }

        static void Garden2()
        {
            for (int j = str - 1; j >= 0; j--)
            {
                for (int i = stl - 1; i >= 0; i--)
                {
                    if (path[j, i] >= 0)
                    {
                        int z = path[j, i];
                        path[j, i] = -2;
                        Thread.Sleep(z);
                    }

                }

            }
        }


    }
}










