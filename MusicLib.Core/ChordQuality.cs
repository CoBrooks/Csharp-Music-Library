namespace MusicLib.Core
{
    public static class ChordQuality
    {
        public const string Major = "0 4 7", MajorTriad = Major;
        public const string Minor = "0 3 7", MinorTriad = Minor;
        public const string DiminishedTriad = "0 3 6";
        public const string Augmented = "0 4 8", AugmentedTriad = Augmented;
        public const string Sus2 = "0 2 7";
        public const string Sus4 = "0 5 7", Suspended = Sus4;

        public const string MajorSeven = "0 4 7 11";
        public const string MinorSeven = "0 3 7 10";
        public const string Diminished = "0 3 6 9", DiminishedSeventh = Diminished;
        public const string Dominant = "0 4 7 10", DominantSeventh = Dominant;
        public const string HalfDiminished = "0 3 6 10";
    }
}