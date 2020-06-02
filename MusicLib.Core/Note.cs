using System;

namespace MusicLib.Core
{
    public class Note
    {
        public string Name { get; set; }
        public int Octave { get; set; }
        public double Duration { get; set; }

        public double Frequency => Frequencies.GetFreq(Name) * Octave;
        public string DisplayName => $"{Name.ToUpper().Replace("SHARP", "#").Replace("FLAT", "b")}{Octave}";
    }
}
