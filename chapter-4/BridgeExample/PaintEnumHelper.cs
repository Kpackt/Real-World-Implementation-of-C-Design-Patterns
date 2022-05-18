using BumbleBikesLibrary;

namespace BridgeExample;

public static class PaintEnumHelper
{
    public static BicyclePaintColors ConvertColorToBicyclePaintColors(string colorName)
    {
        return colorName.ToUpper() switch
        {
            "BLUE" => BicyclePaintColors.Blue,
            "RED" => BicyclePaintColors.Red,
            "WHITE" => BicyclePaintColors.White,
            "BLACK" => BicyclePaintColors.Black,
            _ => throw new IndexOutOfRangeException()
        };
    }
    
    
}