namespace KalkulatorCenZestawu
{
    partial class OknoGlowne
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.przyciskPodzespoly = new System.Windows.Forms.Button();
            this.przyciskAkcesoria = new System.Windows.Forms.Button();
            this.etykietaCena = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.przyciskPodzespoly.Location = new System.Drawing.Point(12, 12);
            this.przyciskPodzespoly.Size = new System.Drawing.Size(150, 30);
            this.przyciskPodzespoly.Text = "Wybierz podzespoły";
            this.przyciskPodzespoly.Click += new System.EventHandler(this.przyciskPodzespoly_Click);
            this.przyciskAkcesoria.Location = new System.Drawing.Point(12, 48);
            this.przyciskAkcesoria.Size = new System.Drawing.Size(150, 30);
            this.przyciskAkcesoria.Text = "Wybierz akcesoria";
            this.przyciskAkcesoria.Click += new System.EventHandler(this.przyciskAkcesoria_Click);
            this.etykietaCena.AutoSize = true;
            this.etykietaCena.Location = new System.Drawing.Point(12, 90);
            this.etykietaCena.Text = "0 zł";
            this.ClientSize = new System.Drawing.Size(200, 130);
            this.Controls.Add(this.etykietaCena);
            this.Controls.Add(this.przyciskAkcesoria);
            this.Controls.Add(this.przyciskPodzespoly);
            this.Text = "Kalkulator cen";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button przyciskPodzespoly;
        private System.Windows.Forms.Button przyciskAkcesoria;
        private System.Windows.Forms.Label etykietaCena;
    }
}