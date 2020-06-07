using System;
using System.Linq;

namespace MusicLib.Core
{
    public class Note
    {
        public string Name
        {
            get => _name;
            set => _name = value.First().ToString().ToUpper() + value.Substring(1).ToLower();
        }
        private string _name;

        public int Octave { get; set; }
        public double Duration { get; set; }

        public double Frequency => Frequencies.GetFrequency(Name) * Octave;
        public string DisplayName => $"{Name.ToUpper().Replace("SHARP", "#").Replace("FLAT", "b")}{Octave}";

        public Note GetInterval(int interval)
        {
            Note note = new Note();
            
            int rootIndex = ChromaticScale.GetNoteIndex(Name);

            note.Name = ChromaticScale.GetNoteNameFromIndex(rootIndex + interval);
            note.Octave = Octave + (interval / 12);

            return note;
        }

        public static bool AreEnharmonicallyEqual(Note a, Note b)
        {
            return ChromaticScale.GetNoteIndex(a.Name) == ChromaticScale.GetNoteIndex(b.Name);
        }
    }

    public static class NoteHelpers
    {
        public static int DistanceBetween(this Note a, Note b)
        {
            var indexOfA = ChromaticScale.GetNoteIndex(a.Name);
            var indexOfB = ChromaticScale.GetNoteIndex(b.Name);

            return Math.Abs((indexOfA - indexOfB) + (a.Octave - b.Octave) * 12);
        }
    }
}
