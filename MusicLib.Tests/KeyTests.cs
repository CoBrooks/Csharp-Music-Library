using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLib.Core;
using NUnit.Framework;

namespace MusicLib.Tests
{
    public class KeyTests
    {
        [Test]
        public void GetKey_CMajor()
        {
            Key cMajor = new Key
            {
                Mode = Scale.Major,
                RootNote = new Note
                {
                    Name = "C",
                    Octave = 4
                }
            };

            cMajor.Notes.ForEach(n =>
            {
                Console.WriteLine(n.DisplayName);
            });

            Assert.AreEqual(cMajor.Notes[6].DisplayName, "B4");
            Assert.AreEqual(cMajor.Notes[7].DisplayName, "C5");
        }

        [Test]
        public void GetKey_EflatMajor()
        {
            Key eFlatMajor = new Key
            {
                Mode = Scale.Major,
                RootNote = new Note
                {
                    Name = "Eflat",
                    Octave = 4
                }
            };

            eFlatMajor.Notes.ForEach(n =>
            {
                Console.WriteLine(n.DisplayName);
            });

            Assert.AreEqual(eFlatMajor.Notes[6].DisplayName, "D5");
            Assert.AreEqual(eFlatMajor.Notes[7].DisplayName, "Eb5");
        }

        [Test]
        public void GetKey_GflatMajor()
        {
            Key gFlatMajor = new Key
            {
                Mode = Scale.Major,
                RootNote = new Note
                {
                    Name = "Gflat",
                    Octave = 3
                }
            };

            gFlatMajor.Notes.ForEach(n =>
            {
                Console.WriteLine(n.DisplayName);
            });

            Assert.AreEqual(gFlatMajor.Notes[6].DisplayName, "F4");
            Assert.AreEqual(gFlatMajor.Notes[7].DisplayName, "Gb4");
        }

        [Test]
        public void GetKey_FSharpMajor()
        {
            Key fSharpMajor = new Key
            {
                Mode = Scale.Major,
                RootNote = new Note
                {
                    Name = "Fsharp",
                    Octave = 3
                }
            };

            fSharpMajor.Notes.ForEach(n =>
            {
                Console.WriteLine(n.DisplayName);
            });

            Assert.AreEqual(fSharpMajor.Notes[6].DisplayName, "E#4");
            Assert.AreEqual(fSharpMajor.Notes[7].DisplayName, "F#4");
        }

        [Test]
        public void GetKey_AMinor()
        {
            Key aMinor = new Key
            {
                Mode = Scale.Minor,
                RootNote = new Note
                {
                    Name = "A",
                    Octave = 3
                }
            };

            aMinor.Notes.ForEach(n =>
            {
                Console.WriteLine(n.DisplayName);
            });


            Assert.AreEqual(aMinor.Notes[6].DisplayName, "G4");
            Assert.AreEqual(aMinor.Notes[7].DisplayName, "A4");
        }

        [Test]
        public void GetKey_CMinor()
        {
            Key cMinor = new Key
            {
                Mode = Scale.Minor,
                RootNote = new Note
                {
                    Name = "C",
                    Octave = 4
                }
            };

            cMinor.Notes.ForEach(n =>
            {
                Console.WriteLine(n.DisplayName);
            });


            Assert.AreEqual(cMinor.Notes[6].DisplayName, "Bb4");
            Assert.AreEqual(cMinor.Notes[7].DisplayName, "C5");
        }

        [Test]
        public void GetKey_DMinor()
        {
            Key dMinor = new Key
            {
                Mode = Scale.Minor,
                RootNote = new Note
                {
                    Name = "D",
                    Octave = 4
                }
            };

            dMinor.Notes.ForEach(n =>
            {
                Console.WriteLine(n.DisplayName);
            });

            Assert.AreEqual(dMinor.Notes[6].DisplayName, "C5");
            Assert.AreEqual(dMinor.Notes[7].DisplayName, "D5");
        }

        [Test]
        public void GetKey_DDorian()
        {
            Key dDorian = new Key
            {
                Mode = Scale.Dorian,
                RootNote = new Note
                {
                    Name = "D",
                    Octave = 4
                }
            };

            dDorian.Notes.ForEach(n =>
            {
                Console.WriteLine(n.DisplayName);
            });

            Assert.AreEqual(dDorian.Notes[6].DisplayName, "C5");
            Assert.AreEqual(dDorian.Notes[7].DisplayName, "D5");
        }

        [Test]
        public void GetKey_AHarmonicMinor()
        {
            Key aHarmonicMinor = new Key
            {
                Mode = Scale.HarmonicMinor,
                RootNote = new Note
                {
                    Name = "A",
                    Octave = 3
                }
            };

            aHarmonicMinor.Notes.ForEach(n =>
            {
                Console.WriteLine(n.DisplayName);
            });


            Assert.AreEqual(aHarmonicMinor.Notes[6].DisplayName, "G#4");
            Assert.AreEqual(aHarmonicMinor.Notes[7].DisplayName, "A4");
        }

        [Test]
        public void GetKey_CHarmonicMinor()
        {
            Key cHarmonicMinor = new Key
            {
                Mode = Scale.HarmonicMinor,
                RootNote = new Note
                {
                    Name = "C",
                    Octave = 4
                }
            };

            cHarmonicMinor.Notes.ForEach(n =>
            {
                Console.WriteLine(n.DisplayName);
            });


            Assert.AreEqual(cHarmonicMinor.Notes[6].DisplayName, "B4");
            Assert.AreEqual(cHarmonicMinor.Notes[7].DisplayName, "C5");
        }

        [Test]
        public void GetKey_GHarmonicMinor()
        {
            Key gHarmonicMinor = new Key
            {
                Mode = Scale.HarmonicMinor,
                RootNote = new Note
                {
                    Name = "G",
                    Octave = 3
                }
            };

            gHarmonicMinor.Notes.ForEach(n =>
            {
                Console.WriteLine(n.DisplayName);
            });


            Assert.AreEqual(gHarmonicMinor.Notes[6].DisplayName, "F#4");
            Assert.AreEqual(gHarmonicMinor.Notes[7].DisplayName, "G4");
        }

    }
}
