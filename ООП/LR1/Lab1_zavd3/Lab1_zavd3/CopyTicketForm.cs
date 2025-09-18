using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_zavd3
{

    public partial class CopyTicketForm : Form
    {
        public int SelectedIndex { get; private set; } = -1;

        public CopyTicketForm(int maxIndex)
        {
            InitializeComponent();

            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = maxIndex;

            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            SelectedIndex = (int)numericUpDown1.Value - 1; // Зсув на індекс списку
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.BackColor = Color.Green;
        }
    }
}
