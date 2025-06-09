using System;
using System.Windows.Forms;

namespace KalkulatorCenZestawu
{
    public partial class OknoPodzespoly : Form
    {
        public decimal cenaWybranychPodzespolow;

        public OknoPodzespoly()
        {
            InitializeComponent();
        }

        private void przyciskZatwierdz_Click(object sender, EventArgs e)
        {
            cenaWybranychPodzespolow = 0;
            if (checkBoxProcesor.Checked) cenaWybranychPodzespolow += 1200;
            if (checkBoxKartaGraficzna.Checked) cenaWybranychPodzespolow += 2500;
            if (checkBoxRAM.Checked) cenaWybranychPodzespolow += 400;
            this.Close();
        }
    }
}