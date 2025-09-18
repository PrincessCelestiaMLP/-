
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace LR1_Zavd3

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeBox.ValidatingType = typeof(DateTime);
        }
    }
}
