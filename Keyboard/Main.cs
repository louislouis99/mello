using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keyboard.Models;
using System.IO;

namespace Keyboard
{
    public partial class Main : Form
    {
        private List<Sample> _samples;
        private string _path = @"C:\Users\louis\source\repos\Mello\Keyboard\Sounds\mkviolins";

        public Main()
        {
            InitializeComponent();
            _samples = new List<Sample>();


            LoadSamples();
            DisplaySamples();
        }

        private void DisplaySamples()
        {
            var x = 0;
            var y = 50;
            var width = 35;
            var height = 100;
            var space = 2;

            var sampleList = new SampleList();

            sampleList.OrderBy(c => c.Position).ToList().ForEach(p =>
            {
                var sample = _samples
                .Where(c => c.NoteName == p.NoteName && c.NoteType == p.KeyType && c.Octave == p.Octave)
                .First();

                if (sample.NoteType == KeyType.Natural)
                {
                    AddSample(
                        sample, 
                        new Point(x += (width + space), y + 100 + space), 
                        new Size(width, height), 
                        Color.White,
                        Color.Black);
                }
                else
                {
                    AddSample(sample, 
                        new Point(x += (width + space), y), 
                        new Size(width, height), 
                        Color.Black, 
                        Color.White);
                }
            });
        }

        private void AddSample(Sample sample, Point location, Size size, Color backcolor, Color forecolor)
        {
            if (sample != null)
            {
                var key = new Keys(sample.Note, sample.SamplePath, backcolor, forecolor);
                key.Location = location;
                key.Size = size;

                this.Controls.Add(key);
            }
        }

        private void LoadSamples()
        {
            Directory.GetFiles(_path).ToList().ForEach(sound =>
            {
                var instrumentPath = sound.Split(new char[] { '\\' });
                var instrument = instrumentPath[instrumentPath.Length - 2];

                _samples.Add(new Sample
                {
                    SamplePath = sound
                });
            });
        }
    }
}
