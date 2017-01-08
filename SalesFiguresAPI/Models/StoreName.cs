using System.Collections.Generic;
using System.ComponentModel;

namespace SalesFiguresAPI.Models
{
    public static class StoreNames
    {
        public static readonly Dictionary<string, string> StoreName1 = new Dictionary<string, string>
        {
            { "0001", "Knightsbridge" },
            { "0003", "Birmingham" },
            { "0004", "Leeds" },
            { "0007", "Dublin" },
            { "0009", "Bristol" }
        };
    }

    public enum StoreName
    {
        Knightsbridge = 1,
        Leeds,
        Dublin,
        Bristol,
        Edinburgh,
        Birmingham,
        Manchester
    }
}