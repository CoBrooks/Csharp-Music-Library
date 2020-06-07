using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLib.Core
{
    public class Key
    {
        public Note RootNote { get; set; }
        public string Mode { get; set; }

        public List<Note> Notes => _getNotes();


        private List<Note> _getNotes()
        {
            var notes = new List<Note> {RootNote};

            string noteNames = "CDEFGAB";

            int currentLetterIndex = noteNames.IndexOf(RootNote.Name[0]) + 1;

            foreach (var i in Mode)
            {
                Note next = new Note
                {
                    Name = noteNames[currentLetterIndex % noteNames.Length].ToString(),
                    Octave = (currentLetterIndex % noteNames.Length <= noteNames.IndexOf(RootNote.Name[0]))
                        ? RootNote.Octave + 1
                        : RootNote.Octave
                };

                var distFromPrev = notes.Last().DistanceBetween(next);

                if (distFromPrev < i - '0') // subtract by '0' to get the int of a char ('1' - '0' = 1, but '1' - 0 != 1)
                {
                    next.Name += "sharp";
                }
                else if (distFromPrev > i - '0')
                {
                    next.Name += "flat";
                }

                currentLetterIndex++;

                notes.Add(next);
            }

            return notes;
        }
    }
}