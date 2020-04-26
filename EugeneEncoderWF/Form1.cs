using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EugeneEncoder.BL;

namespace EugeneEncoderWF
{
    public partial class EugeneEncoder : Form
    {
        public EugeneEncoder()
        {
            InitializeComponent();
        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            if (EncodingsList.SelectedItem == null)
            {
                MessageBox.Show("Select Encoding");
            }
            else
            {
                var EncodingController = new EncodingController(EncodingsList.SelectedItem.ToString());
                OutputTextBox.Text = EncodingController.Encode(InputTextBox.Text.ToLower());
            }
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            if (EncodingsList.SelectedItem == null)
            {
                MessageBox.Show("Select Encoding");
            }
            else
            {
                var EncodingController = new EncodingController(EncodingsList.SelectedItem.ToString());
                OutputTextBox.Text = EncodingController.Decode(InputTextBox.Text.ToLower());
            }
        }
    }
}
