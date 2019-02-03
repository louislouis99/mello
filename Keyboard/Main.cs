using Keyboard.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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
            MakeButtons();
        }

        private void ClearDisplay()
        {
            var count = this.groupBoxKeys.Controls.Count - 1;
            for (int i = count; i > 0; i--)
            {
                if (this.groupBoxKeys.Controls[i].GetType() == typeof(Keys))
                {
                    this.groupBoxKeys.Controls.Remove(this.groupBoxKeys.Controls[i]);
                }
            }
        }

        private void DisplaySamples()
        {
            var x = 0;
            var y = 50;
            var width = 38;
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

                    _current = k;
                    _current.Play();

                });

                key.Location = location;
                key.Size = size;
                key.Tag = "key";

                this.groupBoxKeys.Controls.Add(key);
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
        }

        private void MakeButtons()
        {
            var size = new Size(100, 100);
            var location = new Point(0, 0);
            _instruments.ForEach(i =>
            {
                var button = new Button();
                button.Text = i;
                button.Click += LoadSamplesClick;
                button.Top = 500;
                button.Size = size;
                button.Location = location;
                button.BackColor = Color.White;
                button.Tag = "instrument";

                groupBoxInstrument.Controls.Add(button);

                location.X += button.Width;
            });
        }

        private void LoadSamplesClick(object sender, EventArgs e)
        {
            ClearButtonColor();

            Button button = (Button)sender;
            LoadSamples(button.Text);
            ClearDisplay();
            DisplaySamples();
            button.BackColor = Color.LightSteelBlue;
        }

        private void ClearButtonColor()
        {
            foreach (Control control in groupBoxInstrument.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    if (control.Tag.ToString() == "instrument")
                    {                        
                        control.BackColor = Color.White;
                    }
                }
            }
        }

        private void LoadSamples(string instrument)
        {
            _samples.Clear();

            Directory.GetFiles($"{_path}\\{instrument}").ToList().ForEach(sound =>
            {
                _samples.Add(new Sample
                {
                    SamplePath = sound
                });
            });
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            _current.Stop();
        }

        private void Main_MouseClick(object sender, MouseEventArgs e)
        {
            if (_current != null)
            {
                _current.Stop();

            }
        }
    }
}
