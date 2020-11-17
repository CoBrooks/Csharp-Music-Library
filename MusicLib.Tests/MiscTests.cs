using System;
using NUnit.Framework;
using MusicLib.Core;

namespace MusicLib.Tests
{
    public class MiscTests
    {
        public Note TestNote;

        [SetUp]
        public void Setup()
        {
            TestNote = new Note
            {
                Name = "fSHARP",
                Octave = 4
            };
        }

        [Test]
        public void GetFrequencyOfNote()
        {
            Assert.AreEqual(TestNote.Frequency, Frequencies.Fsharp * 4);
        }

        [Test]
        public void GetFrequencyOfNote_BadNoteName()
        {
            Note n = new Note
            {
                Name = "not a note",
                Octave = 4
            };

            var ex = Assert.Throws<Exception>(() =>
            {
                var a = n.Frequency;
            });

            Assert.AreEqual(ex.Message, "Note Name not Recognized");
        }

        [Test]
        public void GetDisplayName()
        {
            Assert.AreEqual(TestNote.DisplayName, "F#4");
        }

        [Test]
        public void AreEnharmonicallyEqual_Fsharp_Gflat()
        {
            Note a = new Note
            {
                Name = "Fsharp"
            };

            Note b = new Note
            {
                Name = "Gflat"
            };

            Assert.AreEqual(Note.AreEnharmonicallyEqual(a, b), true);
        }
    }
}