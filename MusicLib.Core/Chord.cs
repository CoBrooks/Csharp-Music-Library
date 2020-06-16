using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLib.Core
{
    public class Chord
    {
        public Note RootNote { get; set; }
        public string Quality { get; set; }
        public List<int> Extensions { get; set; } = new List<int>();
        public List<Note> Notes => GetNotes();

        private List<int> _intervals;

        private List<Note> GetNotes()
        {
            List<Note> notes = new List<Note> {RootNote};

            _intervals = Quality.Split(' ').Select(i => Convert.ToInt32(i)).ToList();
            _intervals.AddRange(Extensions);

            notes.AddRange(_intervals.Skip(1).Select(i => RootNote.GetInterval(i)));

            return notes;
        }
    }
}
