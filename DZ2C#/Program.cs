using System.Text;

namespace DZ2C_
{
    internal class Program
    {
        public static void BubbleSortIntArray(int[] array) 
        {
            int tmp;
           for (int i = 0; i < array.Length; i++) 
           {
                for (int j = 0; j < array.Length - 1 - i; j++) 
                {
                    if (array[j] > array[j+1])
                    {
                         tmp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = tmp;
                    }
                }
           }
        }
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        public static void PrintTable<T>(T[,] table) 
        {
            for(int i = 0;i < table.GetLength(0);i++) 
            {
                for (int j=0; j< table.GetLength(1); j++) 
                {
                    Console.Write(table[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            // Дан двумерный массив.Отсортировать данные в нем по возрастанию.

            //732
            //496
            //185

            int[,] myTable =
            {     { 7, 3, 2 },
                  { 4, 9, 6 },
                  { 1, 8, 5 }
            };
            int[] myArray = GetArrayFromTable(myTable); 

            BubbleSortIntArray(myArray);

            int myRowCount = myTable.GetLength(0);

            int myColumnCount = myTable.GetLength(1);

            int[,] sortedTable = GetTableFromArray(myRowCount, myColumnCount, myArray);

            PrintTable(sortedTable);



        }

        private static int[] GetArrayFromTable(int[,] table)
        {
            int[] array = new int[table.Length];
            int k = 0;
            while (k < table.Length)
            {
                for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                    {
                        array[k] = table[i, j];
                        k++;
                    }
                }

            }
            return array;
        }

        private static int[,] GetTableFromArray( int rowCount,int colCount , int[] array)
        {
            int[,] table = new int[rowCount, colCount];
            int k=0;
            while (k < array.Length)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < colCount; j++)
                    {
                        table[i, j] = array[k];
                        k++;
                    }
                }
            }

            return table;
        }

        // Этот метод просто чтобы показать что можно и методом приведения в строку , как
        // было сказанно в конце семинара.

      /*  private static int[] GetIntArrayFromString(string str)
        {
            char [] chars = str.ToCharArray();

            int[] ints = new int[chars.Length];

            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = Convert.ToInt32(chars[i]);
            }
            return ints;
        }*/
    }
}
