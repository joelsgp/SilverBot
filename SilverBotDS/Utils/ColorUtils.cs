using DSharpPlus.Entities;
using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SilverBotDS.Utils
{
    public class ColorUtils
    {
        public static ColorUtils CreateInstance()
        {
            return new ColorUtils();
        }

        private static DiscordColor[] Internal { get; } = {
            DiscordColor.Red,
            DiscordColor.Green,
            DiscordColor.Blue,
            //miku colors
            new DiscordColor(149, 207, 208),
            new DiscordColor(208, 236, 244),
            //popular colors
            new DiscordColor(127,255,212),
            new DiscordColor(138,43,226),
            new DiscordColor(255,69,0),
            new DiscordColor(0,128,0),
            //monika
            new DiscordColor(206, 138, 128),
        };

        private static DiscordColor[] cache;

        /// <summary>
        /// Gets an array of <see cref="DiscordColor"/>s
        /// </summary>
        /// <param name="ignorecache">Should it reload the colors.json</param>
        /// <param name="useinternal">Should it ignore colors.json alltogether</param>
        /// <returns>an array of <see cref="DiscordColor"/>s</returns>
        public static async Task<DiscordColor[]> GetAsync(bool ignorecache = false, bool useinternal = false)
        {
            if (useinternal)
            {
                return Internal;
            }
            if (ignorecache || cache == null)
            {
                if (File.Exists("colors.json"))
                {
                    using StreamReader reader = new("colors.json");
                    var colors = JsonSerializer.Deserialize<SdColor[]>(json: await reader.ReadToEndAsync());
                    cache = (colors ?? Array.Empty<SdColor>()).Select(sdcolor => sdcolor.ToDiscordColor()).ToArray();
                    return cache;
                }
                else
                {
                    var options = new JsonSerializerOptions
                    {
                        WriteIndented = true
                    };
                    await using StreamWriter writer = new("colors.json");
                    await writer.WriteAsync(JsonSerializer.Serialize(Internal.Select(SdColor.FromDiscordColor).ToArray(), options));
                    return Internal;
                }
            }
            else
            {
                return cache;
            }
        }

        public class SdColor
        {
            public DiscordColor ToDiscordColor()
            {
                return new DiscordColor(R, G, B);
            }

            public static SdColor FromDiscordColor(DiscordColor color)
            {
                return new SdColor { R = color.R, G = color.G, B = color.B };
            }

            public byte R { get; init; }
            public byte G { get; init; }
            public byte B { get; init; }
        }

        /// <summary>
        /// Reloads the config
        /// </summary>
        /// <returns>Nothing</returns>
        public static async Task ReloadConfig()
        {
            await GetAsync(true, useinternal: !Program.GetConfig().ColorConfig);
        }

        /// <summary>
        /// Gets a single (random) <see cref="DiscordColor"/> with no parameters
        /// </summary>
        /// <returns>a single (random) <see cref="DiscordColor"/></returns>
        public static async Task<DiscordColor> GetSingleAsync() => await GetSingleAsyncInternal(useinternal: !Program.GetConfig().ColorConfig);

        /// <summary>
        /// Gets a single (random) <see cref="DiscordColor"/>
        /// </summary>
        /// <param name="ignorecache">Should it reload the colors.json</param>
        /// <param name="useinternal">Should it ignore colors.json altogether</param>
        /// <returns>a single (random) <see cref="DiscordColor"/></returns>
        internal static async Task<DiscordColor> GetSingleAsyncInternal(bool ignorecache = false, bool useinternal = false)
        {
            using RandomGenerator rg = new();
            var arr = await GetAsync(ignorecache, useinternal);
            return arr[rg.Next(0, arr.Length)];
        }
    }
}