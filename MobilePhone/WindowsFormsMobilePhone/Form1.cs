using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMobilePhone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbiPhoneHeadset.Checked = true;
        }



        private void butApply_Click(object sender, EventArgs e)
        {

            if (rbiPhoneHeadset.Checked)
            {
                textBox1.Text += "iPhoneHeadset playback selected" + Environment.NewLine + "Set playback to Mobile..." + Environment.NewLine + "Play sound in Mobile:" + Environment.NewLine + "iPhoneHeadset sound" + Environment.NewLine + Environment.NewLine;
                return;
            }

            else if (rbSansungHeadset.Checked)
            {
                textBox1.Text += "SunsungHeadset playback selected" + Environment.NewLine + "Set playback to Mobile..." + Environment.NewLine + "Play sound in Mobile:" + Environment.NewLine + "SamsungHeadset sound" + Environment.NewLine + Environment.NewLine;
                return;
            }
            else if (rbUnofficialHeadset.Checked)
            {
                textBox1.Text += "UnofficialPhoneHeadset playback selected" + Environment.NewLine + "Set playback to Mobile..." + Environment.NewLine + "Play sound in Mobile:" + Environment.NewLine + "UnofficialPhoneHeadset sound" + Environment.NewLine + Environment.NewLine;
                return;
            }
            else if (rbPhoneSpeaker.Checked)
            {
                textBox1.Text += "PhoneSpeaker playback selected" + Environment.NewLine + "Set playback to Mobile..." + Environment.NewLine + "Play sound in Mobile:" + Environment.NewLine + "PhoneSpeaker sound" + Environment.NewLine + Environment.NewLine;
                return;
            }

        }
    }
}
