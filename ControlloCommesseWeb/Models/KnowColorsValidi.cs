using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlloCommesseWeb
{
    public enum KnownColorSelezionati
    {
        //
        // Summary:
        //     A system-defined color.
        AliceBlue = 28,
        //
        // Summary:
        //     A system-defined color.
        AntiqueWhite = 29,
        //
        // Summary:
        //     A system-defined color.
        Aqua = 30,
        //
        // Summary:
        //     A system-defined color.
        Aquamarine = 31,
        //
        // Summary:
        //     A system-defined color.
        Azure = 32,
        //
        // Summary:
        //     A system-defined color.
        Beige = 33,
        //
        // Summary:
        //     A system-defined color.
        Bisque = 34,
        //
        // Summary:
        //     A system-defined color.
        Black = 35,
        //
        // Summary:
        //     A system-defined color.
        BlanchedAlmond = 36,
        //
        // Summary:
        //     A system-defined color.
        Blue = 37,
        //
        // Summary:
        //     A system-defined color.
        BlueViolet = 38,
        //
        // Summary:
        //     A system-defined color.
        Brown = 39,
        //
        // Summary:
        //     A system-defined color.
        BurlyWood = 40,
        //
        // Summary:
        //     A system-defined color.
        CadetBlue = 41,
        //
        // Summary:
        //     A system-defined color.
        Chartreuse = 42,
        //
        // Summary:
        //     A system-defined color.
        Chocolate = 43,
        //
        // Summary:
        //     A system-defined color.
        Coral = 44,
        //
        // Summary:
        //     A system-defined color.
        CornflowerBlue = 45,
        //
        // Summary:
        //     A system-defined color.
        Cornsilk = 46,
        //
        // Summary:
        //     A system-defined color.
        Crimson = 47,
        //
        // Summary:
        //     A system-defined color.
        Cyan = 48,
        //
        // Summary:
        //     A system-defined color.
        DarkBlue = 49,
        //
        // Summary:
        //     A system-defined color.
        DarkCyan = 50,
        //
        // Summary:
        //     A system-defined color.
        DarkGoldenrod = 51,
        //
        // Summary:
        //     A system-defined color.
        DarkGray = 52,
        //
        // Summary:
        //     A system-defined color.
        DarkGreen = 53,
        //
        // Summary:
        //     A system-defined color.
        DarkKhaki = 54,
        //
        // Summary:
        //     A system-defined color.
        DarkMagenta = 55,
        //
        // Summary:
        //     A system-defined color.
        DarkOliveGreen = 56,
        //
        // Summary:
        //     A system-defined color.
        DarkOrange = 57,
        //
        // Summary:
        //     A system-defined color.
        DarkOrchid = 58,
        //
        // Summary:
        //     A system-defined color.
        DarkRed = 59,
        //
        // Summary:
        //     A system-defined color.
        DarkSalmon = 60,
        //
        // Summary:
        //     A system-defined color.
        DarkSeaGreen = 61,
        //
        // Summary:
        //     A system-defined color.
        DarkSlateBlue = 62,
        //
        // Summary:
        //     A system-defined color.
        DarkSlateGray = 63,
        //
        // Summary:
        //     A system-defined color.
        DarkTurquoise = 64,
        //
        // Summary:
        //     A system-defined color.
        DarkViolet = 65,
        //
        // Summary:
        //     A system-defined color.
        DeepPink = 66,
        //
        // Summary:
        //     A system-defined color.
        DeepSkyBlue = 67,
        //
        // Summary:
        //     A system-defined color.
        DimGray = 68,
        //
        // Summary:
        //     A system-defined color.
        DodgerBlue = 69,
        //
        // Summary:
        //     A system-defined color.
        Firebrick = 70,
        //
        // Summary:
        //     A system-defined color.
        FloralWhite = 71,
        //
        // Summary:
        //     A system-defined color.
        ForestGreen = 72,
        //
        // Summary:
        //     A system-defined color.
        Fuchsia = 73,
        //
        // Summary:
        //     A system-defined color.
        Gainsboro = 74,
        //
        // Summary:
        //     A system-defined color.
        GhostWhite = 75,
        //
        // Summary:
        //     A system-defined color.
        Gold = 76,
        //
        // Summary:
        //     A system-defined color.
        Goldenrod = 77,
        //
        // Summary:
        //     A system-defined color.
        Gray = 78,
        //
        // Summary:
        //     A system-defined color.
        Green = 79,
        //
        // Summary:
        //     A system-defined color.
        GreenYellow = 80,
        //
        // Summary:
        //     A system-defined color.
        Honeydew = 81,
        //
        // Summary:
        //     A system-defined color.
        HotPink = 82,
        //
        // Summary:
        //     A system-defined color.
        IndianRed = 83,
        //
        // Summary:
        //     A system-defined color.
        Indigo = 84,
        //
        // Summary:
        //     A system-defined color.
        Ivory = 85,
        //
        // Summary:
        //     A system-defined color.
        Khaki = 86,
        //
        // Summary:
        //     A system-defined color.
        Lavender = 87,
        //
        // Summary:
        //     A system-defined color.
        LavenderBlush = 88,
        //
        // Summary:
        //     A system-defined color.
        LawnGreen = 89,
        //
        // Summary:
        //     A system-defined color.
        LemonChiffon = 90,
        //
        // Summary:
        //     A system-defined color.
        LightBlue = 91,
        //
        // Summary:
        //     A system-defined color.
        LightCoral = 92,
        //
        // Summary:
        //     A system-defined color.
        LightCyan = 93,
        //
        // Summary:
        //     A system-defined color.
        LightGoldenrodYellow = 94,
        //
        // Summary:
        //     A system-defined color.
        LightGray = 95,
        //
        // Summary:
        //     A system-defined color.
        LightGreen = 96,
        //
        // Summary:
        //     A system-defined color.
        LightPink = 97,
        //
        // Summary:
        //     A system-defined color.
        LightSalmon = 98,
        //
        // Summary:
        //     A system-defined color.
        LightSeaGreen = 99,
        //
        // Summary:
        //     A system-defined color.
        LightSkyBlue = 100,
        //
        // Summary:
        //     A system-defined color.
        LightSlateGray = 101,
        //
        // Summary:
        //     A system-defined color.
        LightSteelBlue = 102,
        //
        // Summary:
        //     A system-defined color.
        LightYellow = 103,
        //
        // Summary:
        //     A system-defined color.
        Lime = 104,
        //
        // Summary:
        //     A system-defined color.
        LimeGreen = 105,
        //
        // Summary:
        //     A system-defined color.
        Linen = 106,
        //
        // Summary:
        //     A system-defined color.
        Magenta = 107,
        //
        // Summary:
        //     A system-defined color.
        Maroon = 108,
        //
        // Summary:
        //     A system-defined color.
        MediumAquamarine = 109,
        //
        // Summary:
        //     A system-defined color.
        MediumBlue = 110,
        //
        // Summary:
        //     A system-defined color.
        MediumOrchid = 111,
        //
        // Summary:
        //     A system-defined color.
        MediumPurple = 112,
        //
        // Summary:
        //     A system-defined color.
        MediumSeaGreen = 113,
        //
        // Summary:
        //     A system-defined color.
        MediumSlateBlue = 114,
        //
        // Summary:
        //     A system-defined color.
        MediumSpringGreen = 115,
        //
        // Summary:
        //     A system-defined color.
        MediumTurquoise = 116,
        //
        // Summary:
        //     A system-defined color.
        MediumVioletRed = 117,
        //
        // Summary:
        //     A system-defined color.
        MidnightBlue = 118,
        //
        // Summary:
        //     A system-defined color.
        MintCream = 119,
        //
        // Summary:
        //     A system-defined color.
        MistyRose = 120,
        //
        // Summary:
        //     A system-defined color.
        Moccasin = 121,
        //
        // Summary:
        //     A system-defined color.
        NavajoWhite = 122,
        //
        // Summary:
        //     A system-defined color.
        Navy = 123,
        //
        // Summary:
        //     A system-defined color.
        OldLace = 124,
        //
        // Summary:
        //     A system-defined color.
        Olive = 125,
        //
        // Summary:
        //     A system-defined color.
        OliveDrab = 126,
        //
        // Summary:
        //     A system-defined color.
        Orange = 127,
        //
        // Summary:
        //     A system-defined color.
        OrangeRed = 128,
        //
        // Summary:
        //     A system-defined color.
        Orchid = 129,
        //
        // Summary:
        //     A system-defined color.
        PaleGoldenrod = 130,
        //
        // Summary:
        //     A system-defined color.
        PaleGreen = 131,
        //
        // Summary:
        //     A system-defined color.
        PaleTurquoise = 132,
        //
        // Summary:
        //     A system-defined color.
        PaleVioletRed = 133,
        //
        // Summary:
        //     A system-defined color.
        PapayaWhip = 134,
        //
        // Summary:
        //     A system-defined color.
        PeachPuff = 135,
        //
        // Summary:
        //     A system-defined color.
        Peru = 136,
        //
        // Summary:
        //     A system-defined color.
        Pink = 137,
        //
        // Summary:
        //     A system-defined color.
        Plum = 138,
        //
        // Summary:
        //     A system-defined color.
        PowderBlue = 139,
        //
        // Summary:
        //     A system-defined color.
        Purple = 140,
        //
        // Summary:
        //     A system-defined color.
        Red = 141,
        //
        // Summary:
        //     A system-defined color.
        RosyBrown = 142,
        //
        // Summary:
        //     A system-defined color.
        RoyalBlue = 143,
        //
        // Summary:
        //     A system-defined color.
        SaddleBrown = 144,
        //
        // Summary:
        //     A system-defined color.
        Salmon = 145,
        //
        // Summary:
        //     A system-defined color.
        SandyBrown = 146,
        //
        // Summary:
        //     A system-defined color.
        SeaGreen = 147,
        //
        // Summary:
        //     A system-defined color.
        SeaShell = 148,
        //
        // Summary:
        //     A system-defined color.
        Sienna = 149,
        //
        // Summary:
        //     A system-defined color.
        Silver = 150,
        //
        // Summary:
        //     A system-defined color.
        SkyBlue = 151,
        //
        // Summary:
        //     A system-defined color.
        SlateBlue = 152,
        //
        // Summary:
        //     A system-defined color.
        SlateGray = 153,
        //
        // Summary:
        //     A system-defined color.
        Snow = 154,
        //
        // Summary:
        //     A system-defined color.
        SpringGreen = 155,
        //
        // Summary:
        //     A system-defined color.
        SteelBlue = 156,
        //
        // Summary:
        //     A system-defined color.
        Tan = 157,
        //
        // Summary:
        //     A system-defined color.
        Teal = 158,
        //
        // Summary:
        //     A system-defined color.
        Thistle = 159,
        //
        // Summary:
        //     A system-defined color.
        Tomato = 160,
        //
        // Summary:
        //     A system-defined color.
        Turquoise = 161,
        //
        // Summary:
        //     A system-defined color.
        Violet = 162,
        //
        // Summary:
        //     A system-defined color.
        Wheat = 163,
        //
        // Summary:
        //     A system-defined color.
        White = 164,
        //
        // Summary:
        //     A system-defined color.
        WhiteSmoke = 165,
        //
        // Summary:
        //     A system-defined color.
        Yellow = 166,
        //
        // Summary:
        //     A system-defined color.
        YellowGreen = 167
    }
}