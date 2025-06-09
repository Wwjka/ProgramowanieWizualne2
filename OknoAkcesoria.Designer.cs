namespace KalkulatorCenZestawu
{
    partial class OknoAkcesoria
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
            this.checkBoxMysz = new System.Windows.Forms.CheckBox();
            this.checkBoxKlawiatura = new System.Windows.Forms.CheckBox();
            this.checkBoxSluchawki = new System.Windows.Forms.CheckBox();
            this.przyciskZatwierdz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.checkBoxMysz.Location = new System.Drawing.Point(12, 12);
            this.checkBoxMysz.Text = "Mysz (100 zł)";
            this.checkBoxKlawiatura.Location = new System.Drawing.Point(12, 39);
            this.checkBoxKlawiatura.Text = "Klawiatura (150 zł)";
            this.checkBoxSluchawki.Location = new System.Drawing.Point(12, 66);
            this.checkBoxSluchawki.Text = "Słuchawki (300 zł)";
            this.przyciskZatwierdz.Location = new System.Drawing.Point(12, 100);
            this.przyciskZatwierdz.Size = new System.Drawing.Size(100, 30);
            this.przyciskZatwierdz.Text = "Zatwierdź";
            this.przyciskZatwierdz.Click += new System.EventHandler(this.przyciskZatwierdz_Click);
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.przyciskZatwierdz);
            this.Controls.Add(this.checkBoxSluchawki);
            this.Controls.Add(this.checkBoxKlawiatura);
            this.Controls.Add(this.checkBoxMysz);
            this.Text = "Akcesoria";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.CheckBox checkBoxMysz;
        private System.Windows.Forms.CheckBox checkBoxKlawiatura;
        private System.Windows.Forms.CheckBox checkBoxSluchawki;
        private System.Windows.Forms.Button przyciskZatwierdz;
    }
}