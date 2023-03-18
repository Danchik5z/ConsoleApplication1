namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args) //Вы сказали сначала получить одномерный массив, а потом в нём уже искать минимум или максимум
        {
            int[,] arr = { { 4, 21, 3, 4 }, { 5, 6, 7, 8 }, { 9, 3, 3, 30 }, { 13, 14, 3, 33 } };
            int[] arr1 = new int[6];
            int[] arr2 = new int[6];
            int k = 0;
            int l = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (i < j)
                    {
                        arr1[k] = arr[i, j]; //arr1 - массив над главной диагональю
                        k++;
                    }

                    if (i > j)
                    {
                        arr2[l] = arr[i, j]; //arr2 - массив под главной диагональю
                        l++;
                    }
                }
            }
            System.Console.WriteLine("Максимальный элемент над главной диагональю: " + MaxOrMin(arr1, true));
            System.Console.WriteLine("Минимальный элемент под главной диагональю: " + MaxOrMin(arr2, false));
        }

        private static int MaxOrMin(int[] arr, bool maximum)
        {
            if (maximum)
            {
                int max = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }

                return max;
            }
            else
            {
                int min = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }

                return min;
            }
        }

    }
}




















//bool max = true;
            //System.Console.WriteLine("Максимальный элемент над главной диагональю: " + MaxOrMin(arr, 4, max));
            //System.Console.WriteLine("Минимальный элемент над главной диагональю: " + MaxOrMin(arr, 4, !max));
            //System.Console.WriteLine("Максимальный элемент над главной диагональю: " + MaxAboveMainDiagonal(arr, 4));
            //System.Console.WriteLine("Минимальный элемент над главной диагональю: " + MinUnderMainDiagonal(arr, 4));

            /*private static int MaxOrMin(int[,] arr, int sizeArr, bool max)
            {
                int curr;
                if (max)
                {
                    curr = arr[0, 1];
                }
                else
                {
                    curr = arr[1, 0];
                }
    
                for (int i = 0; i < sizeArr; i++)
                {
                    for (int j = 0; j < sizeArr; j++)
                    {
                        if (max)
                        {
                            if (j > i)
                            {
    
                                if (arr[i, j] > curr)
                                {
                                    curr = arr[i, j];
                                }
                            }
                        }
                        else
                        {
                            if (j < i)
                            {
                                if (arr[i, j] < curr)
                                {
                                    curr = arr[i, j];
                                }
                            }
                        }
    
                    }
                }
                return curr;
            }
            */
        
      /*private static int MaxAboveMainDiagonal(int[,] arr, int sizeArr)
        {
            int max = arr[0, 0];
            for (int i = 0; i < sizeArr - 1; i++)
            {
                for (int j = i + 1; j < sizeArr; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }
            return max;
        }
        
        private static int MinUnderMainDiagonal(int[,] arr, int sizeArr)
        {
            int min = arr[sizeArr - 1,sizeArr - 1];
            for (int i = 1; i < sizeArr; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                }
            }
            return min;
        }*/
