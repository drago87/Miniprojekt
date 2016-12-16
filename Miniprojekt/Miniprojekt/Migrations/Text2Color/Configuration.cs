namespace Miniprojekt.Migrations.Text2Color
{
    using Models.Text2Color;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Miniprojekt.DataAccess.Text2ColorContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Text2Color";
        }

        protected override void Seed(Miniprojekt.DataAccess.Text2ColorContext context)
        {
            // Update-Database -ConfigurationTypeName Miniprojekt.Migrations.Text2Color.Configuration
            context.Colors.AddOrUpdate(
                p => p.Name,
                  //new Color { Name = "aliceblue", HexValue = "#f0f8ff" },
                  //new Color { Name = "antiquewhite", HexValue = "#faebd7" },
                  //new Color { Name = "aqua", HexValue = "#00ffff" },
                  //new Color { Name = "aquamarine", HexValue = "#7fffd4" },
                  //new Color { Name = "azure", HexValue = "#f0ffff" },
                  //new Color { Name = "beige", HexValue = "#f5f5dc" },
                  //new Color { Name = "bisque", HexValue = "#ffe4c4" },
                  //new Color { Name = "black", HexValue = "#000000" },
                  //new Color { Name = "blanchedalmond", HexValue = "#ffebcd" },
                  //new Color { Name = "blue", HexValue = "#0000ff" },
                  //new Color { Name = "blueviolet", HexValue = "#8a2be2" },
                  //new Color { Name = "brown", HexValue = "#a52a2a" },
                  //new Color { Name = "burlywood", HexValue = "#deb887" },
                  //new Color { Name = "cadetblue", HexValue = "#5f9ea0" },
                  //new Color { Name = "chartreuse", HexValue = "#7fff00" },
                  //new Color { Name = "chocolate", HexValue = "#d2691e" },
                  //new Color { Name = "coral", HexValue = "#ff7f50" },
                  //new Color { Name = "cornflowerblue", HexValue = "#6495ed" },
                  //new Color { Name = "cornsilk", HexValue = "#fff8dc" },
                  //new Color { Name = "crimson", HexValue = "#dc143c" },
                  //new Color { Name = "cyan", HexValue = "#00ffff" },
                  //new Color { Name = "darkblue", HexValue = "#00008b" },
                  //new Color { Name = "darkcyan", HexValue = "#008b8b" },
                  //new Color { Name = "darkgoldenrod", HexValue = "#b8860b" },
                  //new Color { Name = "darkgray", HexValue = "#a9a9a9" },
                  //new Color { Name = "darkgreen", HexValue = "#006400" },
                  //new Color { Name = "darkgrey", HexValue = "#a9a9a9" },
                  //new Color { Name = "darkkhaki", HexValue = "#bdb76b" },
                  //new Color { Name = "darkmagenta", HexValue = "#8b008b" },
                  //new Color { Name = "darkolivegreen", HexValue = "#556b2f" },
                  //new Color { Name = "darkorange", HexValue = "#ff8c00" },
                  //new Color { Name = "darkorchid", HexValue = "#9932cc" },
                  //new Color { Name = "darkred", HexValue = "#8b0000" },
                  //new Color { Name = "darksalmon", HexValue = "#e9967a" },
                  //new Color { Name = "darkseagreen", HexValue = "#8fbc8f" },
                  //new Color { Name = "darkslateblue", HexValue = "#483d8b" },
                  //new Color { Name = "darkslategray", HexValue = "#2f4f4f" },
                  //new Color { Name = "darkslategrey", HexValue = "#2f4f4f" },
                  //new Color { Name = "darkturquoise", HexValue = "#00ced1" },
                  //new Color { Name = "darkviolet", HexValue = "#9400d3" },
                  //new Color { Name = "deeppink", HexValue = "#ff1493" },
                  //new Color { Name = "deepskyblue", HexValue = "#00bfff" },
                  //new Color { Name = "dimgray", HexValue = "#696969" },
                  //new Color { Name = "dimgrey", HexValue = "#696969" },
                  //new Color { Name = "dodgerblue", HexValue = "#1e90ff" },
                  //new Color { Name = "firebrick", HexValue = "#b22222" },
                  //new Color { Name = "floralwhite", HexValue = "#fffaf0" },
                  //new Color { Name = "forestgreen", HexValue = "#228b22" },
                  //new Color { Name = "fuchsia", HexValue = "#ff00ff" },
                  //new Color { Name = "gainsboro", HexValue = "#dcdcdc" },
                  //new Color { Name = "ghostwhite", HexValue = "#f8f8ff" },
                  //new Color { Name = "gold", HexValue = "#ffd700" },
                  //new Color { Name = "goldenrod", HexValue = "#daa520" },
                  //new Color { Name = "gray", HexValue = "#808080" },
                  //new Color { Name = "green", HexValue = "#008000" },
                  //new Color { Name = "greenyellow", HexValue = "#adff2f" },
                  //new Color { Name = "honeydew", HexValue = "#f0fff0" },
                  //new Color { Name = "hotpink", HexValue = "#ff69b4" },
                  //new Color { Name = "indianred", HexValue = "#cd5c5c" },
                  //new Color { Name = "indigo", HexValue = "#4b0082" },
                  //new Color { Name = "ivory", HexValue = "#fffff0" },
                  //new Color { Name = "khaki", HexValue = "#f0e68c" },
                  //new Color { Name = "lavender", HexValue = "#e6e6fa" },
                  //new Color { Name = "lavenderblush", HexValue = "#fff0f5" },
                  //new Color { Name = "lawngreen", HexValue = "#7cfc00" },
                  //new Color { Name = "lemonchiffon", HexValue = "#fffacd" },
                  //new Color { Name = "lightblue", HexValue = "#add8e6" },
                  //new Color { Name = "lightcoral", HexValue = "#f08080" },
                  //new Color { Name = "lightcyan", HexValue = "#e0ffff" },
                  //new Color { Name = "lightgoldenrodyellow", HexValue = "#fafad2" },
                  //new Color { Name = "lightgray", HexValue = "#d3d3d3" },
                  //new Color { Name = "lightgreen", HexValue = "#90ee90" },
                  //new Color { Name = "lightpink", HexValue = "#ffb6c1" },
                  //new Color { Name = "lightsalmon", HexValue = "#ffa07a" },
                  //new Color { Name = "lightseagreen", HexValue = "#20b2aa" },
                  //new Color { Name = "lightskyblue", HexValue = "#87cefa" },
                  //new Color { Name = "lightslategray", HexValue = "#778899" },
                  //new Color { Name = "lightslategrey", HexValue = "#778899" },
                  //new Color { Name = "lightsteelblue", HexValue = "#b0c4de" },
                  //new Color { Name = "lightyellow", HexValue = "#ffffe0" },
                  //new Color { Name = "lime", HexValue = "#00ff00" },
                  //new Color { Name = "limegreen", HexValue = "#32cd32" },
                  //new Color { Name = "linen", HexValue = "#faf0e6" },
                  //new Color { Name = "magenta", HexValue = "#ff00ff" },
                  //new Color { Name = "maroon", HexValue = "#800000" },
                  new Color { Name = "mediumaquamarine", HexValue = "#66cdaa" },
                  new Color { Name = "mediumblue", HexValue = "#0000cd" },
                  new Color { Name = "mediumorchid", HexValue = "#ba55d3" },
                  new Color { Name = "mediumpurple", HexValue = "#9370db" },
                  new Color { Name = "mediumseagreen", HexValue = "#3cb371" },
                  new Color { Name = "mediumslateblue", HexValue = "#7b68ee" },
                  new Color { Name = "mediumspringgreen", HexValue = "#00fa9a" },
                  new Color { Name = "mediumturquoise", HexValue = "#48d1cc" },
                  new Color { Name = "mediumvioletred", HexValue = "#c71585" },
                  new Color { Name = "midnightblue", HexValue = "#191970" },
                  new Color { Name = "mintcream", HexValue = "#f5fffa" },
                  new Color { Name = "mistyrose", HexValue = "#ffe4e1" },
                  new Color { Name = "moccasin", HexValue = "#ffe4b5" },
                  new Color { Name = "navajowhite", HexValue = "#ffdead" },
                  new Color { Name = "navy", HexValue = "#000080" },
                  new Color { Name = "oldlace", HexValue = "#fdf5e6" },
                  new Color { Name = "olive", HexValue = "#808000" },
                  new Color { Name = "olivedrab", HexValue = "#6b8e23" },
                  new Color { Name = "orange", HexValue = "#ffa500" },
                  new Color { Name = "orangered", HexValue = "#ff4500" },
                  new Color { Name = "orchid", HexValue = "#da70d6" },
                  new Color { Name = "palegoldenrod", HexValue = "#eee8aa" },
                  new Color { Name = "palegreen", HexValue = "#98fb98" },
                  new Color { Name = "paleturquoise", HexValue = "#afeeee" },
                  new Color { Name = "palevioletred", HexValue = "#db7093" },
                  new Color { Name = "papayawhip", HexValue = "#ffefd5" },
                  new Color { Name = "peachpuff", HexValue = "#ffdab9" },
                  new Color { Name = "peru", HexValue = "#cd853f" },
                  new Color { Name = "pink", HexValue = "#ffc0cb" },
                  new Color { Name = "plum", HexValue = "#dda0dd" },
                  new Color { Name = "powderblue", HexValue = "#b0e0e6" },
                  new Color { Name = "purple", HexValue = "#800080" },
                  new Color { Name = "rebeccapurple", HexValue = "#663399" },
                  new Color { Name = "red", HexValue = "#ff0000" },
                  new Color { Name = "rosybrown", HexValue = "#bc8f8f" },
                  new Color { Name = "royalblue", HexValue = "#4169e1" },
                  new Color { Name = "saddlebrown", HexValue = "#8b4513" },
                  new Color { Name = "salmon", HexValue = "#fa8072" },
                  new Color { Name = "sandybrown", HexValue = "#f4a460" },
                  new Color { Name = "seagreen", HexValue = "#2e8b57" },
                  new Color { Name = "seashell", HexValue = "#fff5ee" },
                  new Color { Name = "sienna", HexValue = "#a0522d" },
                  new Color { Name = "silver", HexValue = "#c0c0c0" },
                  new Color { Name = "skyblue", HexValue = "#87ceeb" },
                  new Color { Name = "slateblue", HexValue = "#6a5acd" },
                  new Color { Name = "slategray", HexValue = "#708090" },
                  new Color { Name = "slategrey", HexValue = "#708090" },
                  new Color { Name = "snow", HexValue = "#fffafa" },
                  new Color { Name = "springgreen", HexValue = "#00ff7f" },
                  new Color { Name = "steelblue", HexValue = "#4682b4" },
                  new Color { Name = "tan", HexValue = "#d2b48c" },
                  new Color { Name = "teal", HexValue = "#008080" },
                  new Color { Name = "thistle", HexValue = "#d8bfd8" },
                  new Color { Name = "tomato", HexValue = "#ff6347" },
                  new Color { Name = "turquoise", HexValue = "#40e0d0" },
                  new Color { Name = "violet", HexValue = "#ee82ee" },
                  new Color { Name = "wheat", HexValue = "#f5deb3" },
                  new Color { Name = "white", HexValue = "#ffffff" },
                  new Color { Name = "whitesmoke", HexValue = "#f5f5f5" },
                  new Color { Name = "yellow", HexValue = "#ffff00" },
                  new Color { Name = "yellowgreen", HexValue = "#9acd32" }
            );
        }
    }
}
