using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Keyboard.Models
{
    public enum KeyType
    {
        Sharp,
        Natural
    }
    public class Sample
    {
        public string SamplePath { get; set; }

        public int Octave => Convert.ToInt32(Note.Substring(Note.Length - 1, 1));
        public string NoteName => Note.Substring(0, 1);
        public KeyType NoteType => Note.Contains("#") ? KeyType.Sharp : KeyType.Natural;
        public string Note => Path.GetFileNameWithoutExtension(SamplePath);

        public string Instrument
        {
            get
            {
                var instrumentPath = SamplePath.Split(new char[] { '\\' });
                var instrument = instrumentPath[instrumentPath.Length - 2];

                return instrument;
            }
        }
    }

    public class KeyPosition
    {
        public string NoteName { get; set; }
        public int Position { get; set; }
        public int Octave { get; set; }
        public KeyType KeyType { get; set; }

        public KeyPosition(string noteName, int octave, KeyType keyType, int position)
        {
            NoteName = noteName;
            Position = position;
            Octave = octave;
            KeyType = keyType;
        }
    }

    public class SampleList : List<KeyPosition>
    {
        public SampleList()
        {
            Add(new KeyPosition("G", 2, KeyType.Natural, 0));
            Add(new KeyPosition("G", 2, KeyType.Sharp, 1));
            Add(new KeyPosition("A", 2, KeyType.Natural, 2));
            Add(new KeyPosition("A", 2, KeyType.Sharp, 3));
            Add(new KeyPosition("B", 2, KeyType.Natural, 4));

            Add(new KeyPosition("C", 3, KeyType.Natural, 6));
            Add(new KeyPosition("C", 3, KeyType.Sharp, 7));
            Add(new KeyPosition("D", 3, KeyType.Natural, 8));
            Add(new KeyPosition("D", 3, KeyType.Sharp, 9));
            Add(new KeyPosition("E", 3, KeyType.Natural, 10));
            Add(new KeyPosition("F", 3, KeyType.Natural, 11));
            Add(new KeyPosition("F", 3, KeyType.Sharp, 12));
            Add(new KeyPosition("G", 3, KeyType.Natural, 13));
            Add(new KeyPosition("G", 3, KeyType.Sharp, 14));
            Add(new KeyPosition("A", 3, KeyType.Natural, 15));
            Add(new KeyPosition("A", 3, KeyType.Sharp, 16));
            Add(new KeyPosition("B", 3, KeyType.Natural, 17));

            Add(new KeyPosition("C", 4, KeyType.Natural, 18));
            Add(new KeyPosition("C", 4, KeyType.Sharp, 19));
            Add(new KeyPosition("D", 4, KeyType.Natural, 20));
            Add(new KeyPosition("D", 4, KeyType.Sharp, 21));
            Add(new KeyPosition("E", 4, KeyType.Natural, 22));
            Add(new KeyPosition("F", 4, KeyType.Natural, 23));
            Add(new KeyPosition("F", 4, KeyType.Sharp, 24));
            Add(new KeyPosition("G", 4, KeyType.Natural, 25));
            Add(new KeyPosition("G", 4, KeyType.Sharp, 26));
            Add(new KeyPosition("A", 4, KeyType.Natural, 27));
            Add(new KeyPosition("A", 4, KeyType.Sharp, 28));
            Add(new KeyPosition("B", 4, KeyType.Natural, 29));

            Add(new KeyPosition("C", 5, KeyType.Natural, 30));
            Add(new KeyPosition("C", 5, KeyType.Sharp, 31));
            Add(new KeyPosition("D", 5, KeyType.Natural, 32));
            Add(new KeyPosition("D", 5, KeyType.Sharp, 33));
            Add(new KeyPosition("E", 5, KeyType.Natural, 34));
        }
    }
}

