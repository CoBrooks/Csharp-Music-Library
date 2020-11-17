using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLib.Core;
using NUnit.Framework;

namespace MusicLib.Tests
{
    public class ChordTests
    {
        [Test]
        public void GetChord_C()
        {
            Chord c = new Chord
            {
                RootNote = new Note
                {
                    Name = "C",
                    Octave = 4
                },
                Quality = ChordQuality.Major
            };

            c.Notes.ForEach(n =>
            {
                Console.WriteLine(n.DisplayName);
            });


            Assert.AreEqual(c.Notes[1].DisplayName, "E4");
            Assert.AreEqual(c.Notes[2].DisplayName, "G4");
        }

        [Test]
        public void GetChord_Csus4() 
        {
            Chord c = new Chord
            {
                RootNote = new Note
                {
                    Name = "C",
                    Octave = 4
                },
                Quality = ChordQuality.Sus4
            };

            c.Notes.ForEach(n =>
            {
                Console.WriteLine(n.DisplayName);
            });


            Assert.AreEqual(c.Notes[1].DisplayName, "F4");
            Assert.AreEqual(c.Notes[2].DisplayName, "G4");
        }

        [Test]
        public void GetChord_G7()
        {
            Chord g7 = new Chord
            {
                RootNote = new Note
                {
                    Name = "G",
                    Octave = 3
                },
                Quality = ChordQuality.Dominant
            };

            g7.Notes.ForEach(n =>
            {
                Console.WriteLine(n.DisplayName);
            });


            Assert.AreEqual(g7.Notes[2].DisplayName, "D4");
            Assert.AreEqual(g7.Notes[3].DisplayName, "F4");
        }

        [Test]
        public void GetChord_BbDim7()
        {
            Chord BbDim7 = new Chord
            {
                RootNote = new Note
                {
                    Name = "Bflat",
                    Octave = 3
                },
                Quality = ChordQuality.DiminishedSeventh
            };

            BbDim7.Notes.ForEach(n =>
            {
                Console.WriteLine(n.DisplayName);
            });

            Assert.AreEqual(BbDim7.Notes[1].DisplayName, "Db4");
            Assert.AreEqual(BbDim7.Notes[2].DisplayName, "Fb4");
            Assert.AreEqual(BbDim7.Notes[3].DisplayName, "G4");
        }

        [Test]
        public void GetChord_CsharpMaj7()
        {
            Chord cSharpMaj7 = new Chord
            {
                RootNote = new Note
                {
                    Name = "Csharp",
                    Octave = 4
                },
                Quality = ChordQuality.MajorSeven
            };

            cSharpMaj7.Notes.ForEach(n =>
            {
                Console.WriteLine(n.DisplayName);
            });

            Assert.AreEqual(cSharpMaj7.Notes[1].DisplayName, "E#4");
            Assert.AreEqual(cSharpMaj7.Notes[2].DisplayName, "G#4");
            Assert.AreEqual(cSharpMaj7.Notes[3].DisplayName, "B#4");
        }

        [Test]
        public void GetChord_C7add9()
        {
            Chord c7add9 = new Chord
            {
                RootNote = new Note
                {
                    Name = "C",
                    Octave = 4
                },
                Quality = ChordQuality.Dominant,
                Extensions =
                {
                    Interval.Ninth
                }
            };

            c7add9.Notes.ForEach(n =>
            {
                Console.WriteLine(n.DisplayName);
            });

            Assert.AreEqual(c7add9.Notes[1].DisplayName, "E4");
            Assert.AreEqual(c7add9.Notes[2].DisplayName, "G4");
            Assert.AreEqual(c7add9.Notes[3].DisplayName, "Bb4");
            Assert.AreEqual(c7add9.Notes[4].DisplayName, "D5");
        }

        [Test]
        public void GetChord_Gmaj7addSharp11()
        {
            Chord gMaj7addSharp11 = new Chord
            {
                RootNote = new Note
                {
                    Name = "G",
                    Octave = 3
                },
                Quality = ChordQuality.MajorSeven,
                Extensions =
                {
                    Interval.SharpEleventh
                }
            };

            gMaj7addSharp11.Notes.ForEach(n =>
            {
                Console.WriteLine(n.DisplayName);
            });

            Assert.AreEqual(gMaj7addSharp11.Notes[1].DisplayName, "B3");
            Assert.AreEqual(gMaj7addSharp11.Notes[2].DisplayName, "D4");
            Assert.AreEqual(gMaj7addSharp11.Notes[3].DisplayName, "F#4");
            Assert.AreEqual(gMaj7addSharp11.Notes[4].DisplayName, "C#5");
        }

        [Test]
        public void GetChord_FsharpMin7addFlat13()
        {
            Chord FsharpAlt = new Chord
            {
                RootNote = new Note
                {
                    Name = "Fsharp",
                    Octave = 3
                },
                Quality = ChordQuality.MinorSeven,
                Extensions =
                {
                    Interval.FlatThirteenth
                }
            };

            FsharpAlt.Notes.ForEach(n =>
            {
                Console.WriteLine(n.DisplayName);
            });

            Assert.AreEqual(FsharpAlt.Notes[1].DisplayName, "A3");
            Assert.AreEqual(FsharpAlt.Notes[2].DisplayName, "C#4");
            Assert.AreEqual(FsharpAlt.Notes[3].DisplayName, "E4");
            Assert.AreEqual(FsharpAlt.Notes[4].DisplayName, "D5");
        }
    }
}
