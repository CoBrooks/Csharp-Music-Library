using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLib.Core
{
    public static class Interval
    {
        public const int PerfectUnison = 0;
        public const int MinorSecond = 1, Semitone = MinorSecond;
        public const int MajorSecond = 2, WholeTone = MajorSecond;
        public const int MinorThird = 3, AugmentedSecond = MinorThird;
        public const int MajorThird = 4;
        public const int PerfectFourth = 5;
        public const int Tritone = 6;
        public const int PerfectFifth = 7;
        public const int MinorSixth = 8, AugmentedFifth = MinorSixth;
        public const int MajorSixth = 9, DiminishedSeventh = MajorSixth;
        public const int MinorSeventh = 10;
        public const int MajorSeventh = 11;
        public const int PerfectOctave = 12;
        public const int FlatNinth = 13;
        public const int Ninth = 14;
        public const int SharpNinth = 15;
        public const int FlatEleventh = 16;
        public const int Eleventh = 17;
        public const int SharpEleventh = 18;
        public const int FlatThirteenth = 20;
        public const int Thirteenth = 21;
        public const int SharpThirteenth = 22;
    }
}
