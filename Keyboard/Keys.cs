using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Keyboard
{
    public partial class Keys : UserControl
    {
        private string _note;
        private string _path;
        private SoundPlayer _soundPlayer;
        private Action<Keys> _func;
        private Action<Keys> _duration;
        public bool Playing { get; set; }
        public int Counter { get; private set; }

        public Keys(string note, string path, Color backcolor, Color forecolor, Action<Keys> func, Action<Keys> duration)
        {
            InitializeComponent();

            _note = note;
            _path = path;
            _soundPlayer = new SoundPlayer(_path);
            _func = func;
            _duration = duration;

            Init();
            this.buttonKey.Size = this.Size;
            this.buttonKey.Text = string.Empty;
            this.KeyColor = backcolor;
            DefaultColor = backcolor;
            timerDuration.Stop();
        }

        public Color DefaultColor;

        public Color KeyColor
        {
            get
            {
                return this.buttonKey.BackColor;
            }
            set
            {
                this.buttonKey.BackColor = value;
            }
        }

        private void Init()
        {
            try
            {
                _soundPlayer.LoadAsync();
            }
            catch
            {

            }
        }

        private void buttonKey_Click(object sender, EventArgs e)
        {
            _func(this);
        }

        public void Play()
        {
            Counter = 0;
            _soundPlayer.Play();
            timerDuration.Start();
        }

        public void Stop()
        {
            _soundPlayer.Stop();
            timerDuration.Stop();

        }

        private void timerDuration_Tick(object sender, EventArgs e)
        {
            Counter += timerDuration.Interval;
            _duration(this);
        }
    }
}
