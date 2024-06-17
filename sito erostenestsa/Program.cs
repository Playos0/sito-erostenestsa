using static System.Math;
public class Sito
{
    public static void Main(string[] args)
    {
        int n = 100;
        int[] tab = new int[n + 1];
        wyp(tab, n);


        for (int i = 2; i < n; i++)
        {
            for (int j = i * 2; j < n; j += i)
            {
                tab[j] = 0;
            }
        }
        Console.WriteLine();
        for (int i = 2; i < n; i++)
        {
            if (tab[i] != 0)
            {
                Console.WriteLine(tab[i] + " ");
            }
        }
        Console.ReadKey();
    }
    static void wyp(int[] tab, int n)
    {
        for (int i = 2; i < n; i++)
        {
            tab[i] = i;
        }


    }
}
//public static void Main(string[] args)
//{
//    int[] tab = new int[101];
//    wyp(tab);
//    for (int i = 2; i < tab.Length - 1; i++)
//    {
//        if (tab[i] != 0)
//        {
//            int j = i + i;
//            while (j <= tab.Length)
//            {
//                tab[j] = 0;
//                j += i;
//            }
//        }
//    }
//    System.Console.WriteLine($"Liczby pierwsze w zakresie od 2 do {tab.Length - 1}");
//    for (int i = 2; i < tab.Length -1; i++)
//    {

//        if (tab[i] != 0)
//        {
//            System.Console.Write($"{tab[i]} ");
//        }
//    }
//}
//public static void wyp(int[] tab)
//{
//    for (int i = 2; i < tab.Length; i++)
//    {
//        tab[i] = i; 
//    }

//}