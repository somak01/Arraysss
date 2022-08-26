namespace Kukac
{
    class Program
    {
        public static void Main(string[] args)
        {

            int[] arr = new int[15];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr[i] = i;
            }

            Insert(ref arr, 10, 11, 12);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


        }


        static int BinarySearch(int[] arr, int target)
        {

            int upper = arr.Length - 1;
            int lower = 0;
            int mid = (lower + upper) / 2;

            while (arr[mid] != target)
            {
                if (arr[upper] == target)
                {
                    return upper;
                }
                if (arr[lower] == target)
                {
                    return lower;
                }
                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] < target)
                {
                    lower = mid;
                }
                else
                {
                    upper = mid;
                }
                mid = (lower + upper) / 2;

            }
            return mid;
        }
        static void Insert(ref int[] arr, int size, int pos, int val)
        {
            if (size == arr.Length)
            {
                throw new Exception("You've reached the maximum capacity of the array , you cannot insert more elements");
            }
            else
            {
                for (int i = size - 1; i >= pos - 1; i--)
                {
                    int temp = arr[i];
                    arr[i] = arr[i - 1];
                    arr[i + 1] = temp;
                }
                arr[pos - 1] = val;
            }
        }
        static void Delete(ref int[] arr, int size, int pos)
        {

        }
    }

   
}