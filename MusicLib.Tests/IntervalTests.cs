using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLib.Core;
using NUnit.Framework;

namespace MusicLib.Tests
{
    public class IntervalTests
    {
        [Test]
        public void GetDistanceBetweenNotes_C4Fsharp4()
        {
            Note a = new Note
            {
                Name = "C",
                Octave = 4
            };

            Note b = new Note
            {
                Name = "Fsharp",
                Octave = 4
            };

            Assert.AreEqual(a.DistanceBetween(b), 6);
        }

        [Test]
        public void GetDistanceBetweenNotes_C4C5()
        {
            Note a = new Note
            {
                Name = "C",
                Octave = 4
            };

            Note b = new Note
            {
                Name = "C",
                Octave = 5
            };

            Assert.AreEqual(a.DistanceBetween(b), 12);
        }

        [Test]
        public void GetNoteFromInterval_C_Tritone()
        {
            Note a = new Note
            {
                Name = "C",
                Octave = 4
            };

            Assert.AreEqual(a.GetInterval(Interval.Tritone).DisplayName, "F#4");
        }
        
        [Test]
        public void GetNoteFromInterval_C_MinorSeventh()
        {
            Note a = new Note
            {
                Name = "C",
                Octave = 4
            };

            Assert.AreEqual(a.GetInterval(Interval.MinorSeventh).DisplayName, "Bb4");
        }

        [Test]
        public void GetNoteFromInterval_Csharp_MajorThird()
        {
            Note a = new Note
            {
                Name = "Csharp",
                Octave = 4
            };

            Assert.AreEqual(a.GetInterval(Interval.MajorThird).DisplayName, "E#4");
        }

        [Test]
        public void GetNoteFromInterval_Bb_MajorSeventh()
        {
            Note a = new Note
            {
                Name = "Bflat",
                Octave = 3
            };

            Assert.AreEqual(a.GetInterval(Interval.MajorSeventh).DisplayName, "A4");
        }

        [Test]
        public void GetNoteFromInterval_G_MajorSeventh()
        {
            Note a = new Note
            {
                Name = "G",
                Octave = 3
            };

            Assert.AreEqual(a.GetInterval(Interval.MajorSeventh).DisplayName, "F#4");
        }

        [Test]
        public void GetNoteFromInterval_G_MajorNinth()
        {
            Note a = new Note
            {
                Name = "G",
                Octave = 3
            };

            Assert.AreEqual(a.GetInterval(Interval.Ninth).DisplayName, "A4");
        }

        [Test]
        public void GetNoteFromInterval_Bb_SharpEleven()
        {
            Note a = new Note
            {
                Name = "Bflat",
                Octave = 3
            };

            Assert.AreEqual(a.GetInterval(Interval.SharpEleventh).DisplayName, "E5");
        }

    }
}
