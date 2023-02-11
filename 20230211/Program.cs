namespace _20230211
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //float fl = 999.12395000009f;

            //double doub = 999999999.5456488888;

            //decimal dec = 999999999.54564888888888888m;

            //long lg = 9223372036854775807;
            //long lg2 = 9223372036854775807;
            //}

            int[] randomArray = { 5, 82, 34, 49, 85, 62, 74, 58, 78, 98 };
            int[] emptyArray = new int[] { };
            int j = 0;
            for (int i = 0; i < randomArray.Length; i++)
            {
                if (randomArray[i] < 30)
                {
                    emptyArray[j] = randomArray[i];
                    j++;
                }
            }
            for (int i = 0; i < emptyArray.Length; i++)
            {
                Console.WriteLine(emptyArray[i]);
            }



        }
    }
}