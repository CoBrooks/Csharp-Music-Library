using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MusicLib.Core
{
    public static class Scale
    {
        // Major Modes
        public const string Major = "2212221", Ionian = Major;
        public const string Dorian = "2122212";
        public const string Phrygian = "1222122";
        public const string Lydian = "2221221";
        public const string Mixolydian = "2212212";
        public const string Minor = "2122122", Aeolian = Minor, NaturalMinor = Minor;
        public const string Locrian = "1221222";

        // Other Scales
        public const string HarmonicMinor = "2122131";
    }

    public static class ChromaticScale
    {
        public const int C = 0, Bsharp = C;
        public const int Csharp = 1, Dflat = Csharp;
        public const int D = 2;
        public const int Dsharp = 3, Eflat = Dsharp;
        public const int E = 4, Fflat = E;
        public const int F = 5, Esharp = F;
        public const int Fsharp = 6, Gflat = Fsharp;
        public const int G = 7;
        public const int Gsharp = 8, Aflat = Gsharp;
        public const int A = 9;
        public const int Asharp = 10, Bflat = Asharp;
        public const int B = 11, Cflat = B;

        public static int GetNoteIndex(string noteName)
        {
            try
            {
                noteName = noteName.First().ToString().ToUpper() + noteName.Substring(1).ToLower();

                List<FieldInfo> fields = typeof(ChromaticScale).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).ToList();
                var index = (int)fields.First(n => n.Name == noteName).GetValue(null);

                return index;
            }
            catch (Exception e)
            {
                throw new Exception("Note Name not Recognized");
            }
        }

        public static string GetNoteNameFromIndex(int interval)
        {
            interval %= 12;

            try
            {
                List<FieldInfo> fields = typeof(ChromaticScale).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).ToList();
                var name = fields.First(f => (int)f.GetValue(null) == interval).Name;

                return name;
            }
            catch (Exception e)
            {
                throw new Exception($"Interval not Recognized: {interval}");
            }
        }
    }
}
