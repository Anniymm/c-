using System;
// 6_1 nomeri 2
public class Martkutxedi
{
    // ganvsazghvot cvladbi
    public static double side1;
    public static double side2;
    private double perimeter;

    // konstruqtori cvladebis inicializaciistvis
    public Martkutxedi(double side1Value, double side2Value)
    {
        side1 = side1Value;
        side2 = side2Value;
        // gamovidzavot privatuli methodi perimetris gamotvlistvis
        CalculatePerimeter();
    }

    // metodis aghwera
    private void CalculatePerimeter()
    {
        perimeter = 2 * (side1 + side2);
    }

    // Statikuri metodi shedegis dasabrundeblad
    public static double GetPerimeter()
    {
        Martkutxedi instance = new Martkutxedi(side1, side2);
        return instance.perimeter;
    }
}
