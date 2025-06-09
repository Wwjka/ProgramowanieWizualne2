using System;
using System.Windows.Forms;

namespace KalkulatorCenZestawu
{
    public partial class OknoGlowne : Form
    {
        public decimal cenaPodzespolow;
        public decimal cenaAkcesoriow;

        public OknoGlowne()
        {
            InitializeComponent();
        }

        private void przyciskPodzespoly_Click(object sender, EventArgs e)
        {
            OknoPodzespoly okno = new OknoPodzespoly();
            okno.ShowDialog();
            cenaPodzespolow = okno.cenaWybranychPodzespolow;
            AktualizujCene();
        }

        private void przyciskAkcesoria_Click(object sender, EventArgs e)
        {
            OknoAkcesoria okno = new OknoAkcesoria();
            okno.ShowDialog();
            cenaAkcesoriow = okno.cenaWybranychAkcesoriow;
            AktualizujCene();
        }

        private void AktualizujCene()
        {
            decimal suma = cenaPodzespolow + cenaAkcesoriow;
            etykietaCena.Text = suma.ToString("C");
        }
    }
}