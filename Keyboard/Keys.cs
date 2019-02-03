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

        public Keys(string note, string path, Color backcolor, Color forecolor)
        {
            InitializeComponent();

            _note = note;
            _path = path;
            _soundPlayer = new SoundPlayer(_path);

            Init();
            this.buttonKey.Size = this.Size;
            this.buttonKey.Text = _note;
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
            _soundPlayer.Play();                        
        }
    }
}
