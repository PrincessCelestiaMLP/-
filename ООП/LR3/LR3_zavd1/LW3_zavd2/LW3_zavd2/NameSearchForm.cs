using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1_zavd3
{
    public partial class NameSearchForm : Form
    {
        public string NameToSearch { get; private set; } = "";
        public NameSearchForm(List<string> names)
        {
            InitializeComponent();
            comboBox1.Items.AddRange(names.Distinct().ToArray());
            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                NameToSearch = comboBox1.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.BackColor = Color.Green;
        }
    }
}
