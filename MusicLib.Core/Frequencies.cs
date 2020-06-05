using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MusicLib.Core
{
    public static class Frequencies
    {
        public const double C = 32.70320, Bsharp = C;
        public const double Csharp = 34.64783, Dflat = Csharp;
        public const double D = 36.70810;
        public const double Dsharp = 38.89087, Eflat = Dsharp;
        public const double E = 41.20344, Fflat = E;
        public const double F = 43.65353, Esharp = F;
        public const double Fsharp = 46.24930, Gflat = Fsharp;
        public const double G = 48.99943;
        public const double Gsharp = 51.91309, Aflat = Gsharp;
        public const double A = 55.00000;
        public const double Asharp = 58.27047, Bflat = Asharp;
        public const double B = 61.73541, Cflat = B;

        public static double GetFrequency(string noteName)
        {
            try
            {
                noteName = noteName.First().ToString().ToUpper() + noteName.Substring(1).ToLower();

                List<FieldInfo> freqs = typeof(Frequencies).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).ToList();
                var freq = (double) freqs.First(f => f.Name == noteName).GetValue(null);

                return freq;
            }
            catch (Exception e)
            {
                throw new Exception("Note Name not Recognized");
            }
        }
    }
}
