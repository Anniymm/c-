using System;

public class Klasi_2
{
    // 2 ganzomilebiani asivi
    public static int[,] array;

    // konstruqtori inicializaciistvis
    public Klasi_2(int[,] inputArray)
    {
        array = inputArray;
    }

    // daaitvalos kenti elementebi
    private int CountOddNumbers()
    {
        int count = 0;
        foreach (int element in array)
        {
            if (element % 2 != 0) // sheamowmos tu aris kenti
            {
                count++;
            }
        }
        return count;
    }

    // shedegis gamosatanad
    public static int GetOddCount()
    {
        Klasi_2 instance = new Klasi_2(array);
        return instance.CountOddNumbers(); 
    }
}
