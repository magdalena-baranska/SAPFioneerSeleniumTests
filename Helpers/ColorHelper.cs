using System;
using System.Collections.Generic;
using System.Linq;
namespace SAPFioneerSeleniumTests.Helpers
{
    public static class ColorHelper
    {
        public static string ConvertRgbToHex(string rgb)
        {
            var components = rgb.Replace("rgba(", "")
                                 .Replace("rgb(", "")
                                 .Replace(")", "")
                                 .Split(',');

            int r = int.Parse(components[0].Trim());
            int g = int.Parse(components[1].Trim());
            int b = int.Parse(components[2].Trim());

            return $"#{r:X2}{g:X2}{b:X2}";
        }
    }
}
