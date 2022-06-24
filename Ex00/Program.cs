// See https://aka.ms/new-console-template for more information
namespace Ex00 // Note: actual namespace depends on the project name.
{
    public static class Program
    {
        static int[] array = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };

        static int targetSum = 10;
        static void Main(string[] args)
        {
            Console.WriteLine(Should_return_minus1_eleven_when_sumTarget_is_equals_ten().ToString());
        }

        static int[] twoNumberSum(int[] tableau, int target)
        {
            List<int> Output = new List<int>();
            int result;
            for (int i = 0; i < tableau.Length; i++)
            {
                for (int j = 0; j < tableau.Length ; j++)
                {
                    if (i != j)
                    {
                        result = tableau[i] + tableau[j];
                        if (result == targetSum)
                        {
                            Output.Add(tableau[i]);
                            Output.Add(tableau[j]);
                            return Output.ToArray();
                        }
                    }
                }
            }
            return Output.ToArray();
        }
    public static bool Should_return_minus1_eleven_when_sumTarget_is_equals_ten()
    {
        int target = 10;
        int[] tab = { 11, -1 };
        int[] init = { 3, 5, -4, 8, 11, 1, -1, 6 };
            var exemple = twoNumberSum(init, target);
        if (twoNumberSum(init, target).Equals(tab))
        {
            return true;
        }
        return false;
    }
}
}


