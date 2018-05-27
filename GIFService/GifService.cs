using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace GIFService
{
    public class GifService
    {

        private readonly Dictionary<string, List<string>> Gifs = new Dictionary<string, List<string>>
        {
            {
                "pet",
                new List<string>
                {
                    "doc63485431_335220113",
                    "doc63485431_462648649",
                    "doc63485431_328870749"
                } },
            {
                "kb",
                    new List<string>
                    {
                        "doc63485431_438330735",
                        "doc63485431_438330663",

                    }
            }
        };

        public string GetGifByCategory(string category)
        {
            return Gifs.ContainsKey(category) ? Gifs[category][new Random().Next(Gifs[category].Count)] : null;
        }
        public string GetRandomGif()
        {
            var list = Gifs
                .Values
                .SelectMany(x => x)
                .ToList();
            return list[new Random().Next(list.Count)];
        }

    }
}
