namespace KalkulatorCenZestawu
{
    partial class OknoPodzespoly
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
            this.checkBoxProcesor = new System.Windows.Forms.CheckBox();
            this.checkBoxKartaGraficzna = new System.Windows.Forms.CheckBox();
            this.checkBoxRAM = new System.Windows.Forms.CheckBox();
            this.przyciskZatwierdz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.checkBoxProcesor.Location = new System.Drawing.Point(12, 12);
            this.checkBoxProcesor.Text = "Procesor (1200 zł)";
            this.checkBoxKartaGraficzna.Location = new System.Drawing.Point(12, 39);
            this.checkBoxKartaGraficzna.Text = "Karta graficzna (2500 zł)";
            this.checkBoxRAM.Location = new System.Drawing.Point(12, 66);
            this.checkBoxRAM.Text = "RAM (400 zł)";
            this.przyciskZatwierdz.Location = new System.Drawing.Point(12, 100);
            this.przyciskZatwierdz.Size = new System.Drawing.Size(100, 30);
            this.przyciskZatwierdz.Text = "Zatwierdź";
            this.przyciskZatwierdz.Click += new System.EventHandler(this.przyciskZatwierdz_Click);
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.przyciskZatwierdz);
            this.Controls.Add(this.checkBoxRAM);
            this.Controls.Add(this.checkBoxKartaGraficzna);
            this.Controls.Add(this.checkBoxProcesor);
            this.Text = "Podzespoły";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.CheckBox checkBoxProcesor;
        private System.Windows.Forms.CheckBox checkBoxKartaGraficzna;
        private System.Windows.Forms.CheckBox checkBoxRAM;
        private System.Windows.Forms.Button przyciskZatwierdz;
    }
}