using System;
using System.Windows.Forms;

namespace KalkulatorCenZestawu
{
    public partial class OknoAkcesoria : Form
    {
        public decimal cenaWybranychAkcesoriow;

        public OknoAkcesoria()
        {
            InitializeComponent();
        }

        private void przyciskZatwierdz_Click(object sender, EventArgs e)
        {
            cenaWybranychAkcesoriow = 0;
            if (checkBoxMysz.Checked) cenaWybranychAkcesoriow += 100;
            if (checkBoxKlawiatura.Checked) cenaWybranychAkcesoriow += 150;
            if (checkBoxSluchawki.Checked) cenaWybranychAkcesoriow += 300;
            this.Close();
        }
    }
}