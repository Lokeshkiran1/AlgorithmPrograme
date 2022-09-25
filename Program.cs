namespace AlgorithmPrograme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Algorithm programes:");
            int option1;

            do
            {
                Console.WriteLine("choose choice:\n1.InsertionSort\n2.BubbleSort of numbers" +
                    "\n3.AnagramOrNot\n4.PrimeNumber Or Not" +
                    "\n5.Palindrome or not\n6.PrimePalindrome" +
                    "\n7.Permutation");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        string[] names = { "John Doe", "Doe John", "Another Name", "Name Another" };
                        InsertionSort.InsertSortString(names);
                        foreach (var item in names)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 2:
                        BubbleSort.BubbleSortIntegers();
                        break;
                    case 3:
                        Anagram.AnagramOrNot();
                        break;
                    case 4:
                        PrimeNumber.PrimeNumberOrNot();
                        break;
                    case 5:
                        PalindromeOrNot.Palindrome();
                        break;
                    case 6:
                        PrimePalindrome.PrimePalindromeCheck();
                        break;
                    case 7:
                        string str = "ABC";
                        int n = str.Length;
                        Permutation.permute(str, 0, n - 1);
                        break;

                    default:
                        Console.WriteLine("entered wrong choice");
                        break;

                }
                Console.WriteLine();
                Console.WriteLine("Do you want to continue press 1 else press 0 to exit");
                option1 = Convert.ToInt32(Console.ReadLine());
                if (option1 > 1)
                {
                    Console.WriteLine("wrong option and program will stop");
                    break;
                }
 
            }
            while (option1 != 0);
        }
    }
    
}