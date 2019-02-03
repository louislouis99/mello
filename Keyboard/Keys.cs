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
        public bool Playing { get; set; }

        public Keys(string note, string path, Color backcolor, Color forecolor, Action<Keys> func)
        {
            InitializeComponent();

            _note = note;
            _path = path;
            _soundPlayer = new SoundPlayer(_path);
            _func = func;

            Init();
            this.buttonKey.Size = this.Size;
            this.buttonKey.Text = string.Empty;
            this.buttonKey.BackColor = backcolor;
            this.buttonKey.ForeColor = forecolor;
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
            _soundPlayer.Play();
        }

        public void Stop()
        {
            _soundPlayer.Stop();
        }
    }
}
