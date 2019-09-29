using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageFormatting
{
    public partial class Form1 : Form
    {
        private int _ticks;
        public FormatDelegate Formatter;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem as dynamic == "Start with DateTime")
            {
                Formatter = MessageFormatter.FormatWithTime;
            }
            if (comboBox1.SelectedItem as dynamic == "End with DateTime")
            {
                Formatter = MessageFormatter.FormatWithTimeEnd;
            }
            if (comboBox1.SelectedItem as dynamic == "Uppercase")
            {
                Formatter = MessageFormatter.FormatWithUpperCase;
            }

            if (comboBox1.SelectedItem as dynamic == "Lowercase")
            {
                Formatter = MessageFormatter.FormatWithLowerCase;
            }
            if (comboBox1.SelectedItem as dynamic == "Custom")
            {
                Formatter = MessageFormatter.FormatCustom;
            }

            if ((comboBox1.SelectedItem as dynamic != "None") && (comboBox1.SelectedItem as dynamic != null))
            {
                _ticks++;
                var message = "Message #" + _ticks.ToString() + " received!";
                OnSMSReseived(message);
            }

        }

        private void OnSMSReseived(string message)
        {
            if (InvokeRequired)
            {
               Invoke(new SMSProvider.SMSRecievedDelegate(OnSMSReseived), message);
                return;
            }

            string formattedMessage = Formatter($"{message}");
            MessageRichTextBox.AppendText(formattedMessage);
        }

    }
}
