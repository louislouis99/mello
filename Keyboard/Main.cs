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
        private string _path = @"C:\Users\louis\source\repos\Mello\Keyboard\Sounds\";
        private Keys _current;
        private List<string> _instruments;

        public Main()
        {
            InitializeComponent();
            _samples = new List<Sample>();
            _instruments = new List<string>();
            GetInstruments(_path);
        }

        private void ClearDisplay()
        {
            var count = Controls.Count-1;
            for (int i = count; i > 0; i--)
            {
                if (Controls[i].GetType() == typeof(Keys))
                {
                    Controls.Remove(Controls[i]);
                }
            }
        }

        private void DisplaySamples()
        {
            var x = 0;
            var y = 50;
            var width = 35;
            var height = 100;
            var space = 2;

            // list of keys in the right order
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
                        new Point(x += (width + space), y + 80 + space),
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
                var key = new Keys(sample.Note, sample.SamplePath, backcolor, forecolor, k =>
                {
                    if (_current != null)
                    {
                        _current.Stop();
                    }

                    if (_current == k)
                    {
                        _current.Stop();
                        _current = null;
                    }
                    else
                    {
                        _current = k;
                        _current.Play();
                    }
                });

                key.Location = location;
                key.Size = size;

                this.Controls.Add(key);
            }
        }

        private void GetInstruments(string path)
        {
            Directory.GetDirectories(_path).ToList().ForEach(i =>
            {
                var instrumentPath = i.Split(new char[] { '\\' });
                var instrument = instrumentPath[instrumentPath.Length - 1];
                _instruments.Add(instrument);

            });

            Instruments.DataSource = _instruments;

        }

        private void LoadSamples(string instrument)
        {
            _samples.Clear();

            Directory.GetFiles($"{_path}//{instrument}").ToList().ForEach(sound =>
            {
                _samples.Add(new Sample
                {
                    SamplePath = sound
                });
            });
        }

        private void Instruments_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSamples(Instruments.SelectedItem.ToString());
            ClearDisplay();
            DisplaySamples();
        }
    }
}
