using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piano
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"c:\Windows\Media\chimes.wav"))
            {
                soundPlayer.Play();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
