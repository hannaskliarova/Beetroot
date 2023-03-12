namespace Homework5_Lesson7_
{
    internal class Program
    {

       enum SortAlgorithmType
        {
            Selection = 1,
            Bubble,
            Insertion
        }

        //пока не понимаю, как применить
        enum OrderBy
        {
            Ascending, 
            Descending,
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the length of the array:\t");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] theArray = new int[arrayLength];
            
            for (int i = 0; i < theArray.Length; i++) 
            { 
                Console.Write("Enter the value of the array element {i}:\n");
                theArray[i] = int.Parse(Console.ReadLine());
            }
            
            
            Console.WriteLine("Enter the type of algorithm (Selection (1), Bubble(2), Insertion(3)): ");
            int typeOfAlgorithm = int.Parse(Console.ReadLine());



            //при ссылке на enum требует bool

            if (typeOfAlgorithm == 1)

            { 
                theArray = SelectionSort(theArray); 
            }

            else if (typeOfAlgorithm == 2)
            {
                theArray = BubbleSort(theArray);
            }
            else if (typeOfAlgorithm == 3)
            {
                theArray = InsertionSort(theArray);
            }

            foreach (int i in theArray)
            { Console.WriteLine(i); }

            theArray = InsertionSort(theArray);

            foreach (int i in theArray)
            { Console.WriteLine(i); }

            
        }
        static int[] BubbleSort(int[] theArray)
        {
            for (int i = 0; i < theArray.Length; i++)
            {
                for (int j = 0; j < theArray.Length - 1 - i; j++)
                {
                    if (theArray[j] > theArray[j + 1])
                    {
                        int temp = theArray[j];
                        theArray[j] = theArray[j + 1];
                        theArray[j + 1] = temp;
                    }
                }
            }
            return theArray;
        }
        static int[] InsertionSort(int[] theArray)
        {
            for (int i = 0; i < theArray.Length; i++)
            {
                int index = i;
                int currentNumber = theArray[i];
                while (index > 0 && currentNumber < theArray[index - 1])
                {
                    theArray[index] = theArray[index - 1];
                    index--;
                }
                theArray[index] = currentNumber;
            }
            return theArray;
        }
        static int[] SelectionSort(int[] theArray)
        {
            for (int i = 0; i < theArray.Length; i++)
            {
                int currentMinIndex = i;
                for (int j = i; j < theArray.Length; j++)
                {
                    if (theArray[j] < theArray[currentMinIndex])
                    {
                        currentMinIndex = j;
                    }

                }
                int temp = theArray[i];
                theArray[i] = theArray[currentMinIndex];
                theArray[currentMinIndex] = temp;
            }
            return theArray;
        }
    }
}