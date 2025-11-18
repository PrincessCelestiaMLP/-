using LR1_Zavd3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;


namespace LW4_zavd2
{
    public partial class AttractionViewForm : Form
    {
        private List<Attraction> attractions;
        private int currentIndex = 0;
        public AttractionViewForm(List<Attraction> attractions, int Index)
        {
            this.attractions = attractions;
            currentIndex = Index;
            InitializeComponent();
            ShowAttractionInfo();

        }

        private void AttractionViewForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonNextClick_Click(object sender, EventArgs e)
        {
        }
        private void ShowAttractionInfo()
        {
            var attraction = attractions[currentIndex];


            labelName.Text = attraction.NameAttraction;
            labelInfo.Text = attraction.GetInfo(); // <-- з інтерфейсу
            pictureBox.Image = attraction.GetImage(); // <-- з інтерфейсу
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AttractionViewForm.ActiveForm.Close();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
