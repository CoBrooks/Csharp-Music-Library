using System;
using System.Collections.Generic;
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
            note.Name = ChromaticScale.GetNoteNameFromIndex(ChromaticScale.NormalizeInterval(rootIndex + interval));

            string noteNames = "CDEFGAB";

            note.Octave = Octave;
            note.Octave += (noteNames.IndexOf(note.Name[0]) <= noteNames.IndexOf(Name[0]) && interval != 0) ? 1 : 0;
            note.Octave += interval > 11 ? 1 : 0;

            int newIndex = ChromaticScale.GetNoteIndex(note.Name);
            int sharpOrFlat = Math.Clamp(interval - this.DistanceBetween(note), -1, 1);

            note.Name = ChromaticScale.GetNoteNameFromIndex(newIndex + sharpOrFlat, sharpOrFlat);

            int rootNoteChromaticIndex = ChromaticScale.GetNoteIndex(Name[0].ToString());
            int noteIndex = ChromaticScale.GetNoteIndex(note.Name[0].ToString());

            Note a = new Note
            {
                Name = ChromaticScale.GetNoteNameFromIndex(rootNoteChromaticIndex),
                Octave = Octave
            };
            Note b = new Note
            {
                Name = ChromaticScale.GetNoteNameFromIndex(noteIndex),
                Octave = note.Octave
            };

            int intervalDist = a.DistanceBetween(b);
            int noteDist = this.DistanceBetween(note);

            if (ChromaticScale.NormalizeInterval(intervalDist) != ChromaticScale.NormalizeInterval(noteDist))
            {
                note = note.EnharmonicEquivalent();
            }

            return note;
        }

        public Note EnharmonicEquivalent()
        {
            int chromaticIndex = ChromaticScale.GetNoteIndex(Name);
            List<string> equivalents = ChromaticScale.GetNoteNamesFromIndex(chromaticIndex);

            string name = (equivalents.Count > 1) ? equivalents.First(e => e[0].ToString() != Name[0].ToString()) : equivalents.First();

            int octave = Octave;

            // I'm not sure where in the chromatic scale B# and Cb fall.
            // This makes B# the first note of the chromatic scale and Cb the last.
            if (name == "Bsharp")
            {
                octave--;
            }
            else if (name == "Cflat")
            {
                octave++;
            }

            Note n = new Note
            {
                Name = name,
                Octave = octave
            };

            return n;
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
