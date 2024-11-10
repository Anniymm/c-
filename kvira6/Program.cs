using System;

class Program
{
    static void Main()
    {
        Martkutxedi rectangle = new Martkutxedi(5.0, 10.0);

        double perimeter = Martkutxedi.GetPerimeter();

        Console.WriteLine("Perimetri: " + perimeter);
    }
}

////////////////////////////////////////////////
/// aq chavsvam komentarad Klasi_2stvis rogorc iqneba 
/// using System;

//class Program
//{
//    static void Main()
//    {
//        // Initialize a 2D array of integers
//        int[,] inputArray = {
//            { 1, 2, 3 },
//            { 4, 5, 6 },
//            { 7, 8, 9 }
//        };

//        Klasi_2 klasi2 = new Klasi_2(inputArray);
//        int oddCount = Klasi_2.GetOddCount();

//        Console.WriteLine("kenti elementebi: " + oddCount);
//    }
//}





