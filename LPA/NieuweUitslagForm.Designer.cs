namespace LPA
{
    partial class NieuweUitslagForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNieuwUitslag = new System.Windows.Forms.Button();
            this.dtUitslagDatum = new System.Windows.Forms.DateTimePicker();
            this.txtUitslagNaam = new System.Windows.Forms.TextBox();
            this.cbPartij = new System.Windows.Forms.ComboBox();
            this.nStemmen = new System.Windows.Forms.NumericUpDown();
            this.btnInvoerStem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nStemmen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNieuwUitslag
            // 
            this.btnNieuwUitslag.Location = new System.Drawing.Point(417, 68);
            this.btnNieuwUitslag.Name = "btnNieuwUitslag";
            this.btnNieuwUitslag.Size = new System.Drawing.Size(211, 63);
            this.btnNieuwUitslag.TabIndex = 1;
            this.btnNieuwUitslag.Text = "Nieuwe uitslag";
            this.btnNieuwUitslag.UseVisualStyleBackColor = true;
            this.btnNieuwUitslag.Click += new System.EventHandler(this.btnNieuwUitslag_Click);
            // 
            // dtUitslagDatum
            // 
            this.dtUitslagDatum.Location = new System.Drawing.Point(417, 12);
            this.dtUitslagDatum.Name = "dtUitslagDatum";
            this.dtUitslagDatum.Size = new System.Drawing.Size(200, 22);
            this.dtUitslagDatum.TabIndex = 2;
            // 
            // txtUitslagNaam
            // 
            this.txtUitslagNaam.Location = new System.Drawing.Point(417, 40);
            this.txtUitslagNaam.Name = "txtUitslagNaam";
            this.txtUitslagNaam.Size = new System.Drawing.Size(200, 22);
            this.txtUitslagNaam.TabIndex = 3;
            // 
            // cbPartij
            // 
            this.cbPartij.FormattingEnabled = true;
            this.cbPartij.Location = new System.Drawing.Point(25, 12);
            this.cbPartij.Name = "cbPartij";
            this.cbPartij.Size = new System.Drawing.Size(257, 24);
            this.cbPartij.TabIndex = 4;
            // 
            // nStemmen
            // 
            this.nStemmen.Location = new System.Drawing.Point(25, 42);
            this.nStemmen.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nStemmen.Name = "nStemmen";
            this.nStemmen.Size = new System.Drawing.Size(257, 22);
            this.nStemmen.TabIndex = 5;
            // 
            // btnInvoerStem
            // 
            this.btnInvoerStem.Location = new System.Drawing.Point(25, 70);
            this.btnInvoerStem.Name = "btnInvoerStem";
            this.btnInvoerStem.Size = new System.Drawing.Size(211, 63);
            this.btnInvoerStem.TabIndex = 6;
            this.btnInvoerStem.Text = "Stemmen invoeren";
            this.btnInvoerStem.UseVisualStyleBackColor = true;
            this.btnInvoerStem.Click += new System.EventHandler(this.btnInvoerStem_Click);
            // 
            // NieuweUitslagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 238);
            this.Controls.Add(this.btnInvoerStem);
            this.Controls.Add(this.nStemmen);
            this.Controls.Add(this.cbPartij);
            this.Controls.Add(this.txtUitslagNaam);
            this.Controls.Add(this.dtUitslagDatum);
            this.Controls.Add(this.btnNieuwUitslag);
            this.Name = "NieuweUitslagForm";
            this.Text = "NieuweUitslagForm";
            ((System.ComponentModel.ISupportInitialize)(this.nStemmen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNieuwUitslag;
        private System.Windows.Forms.DateTimePicker dtUitslagDatum;
        private System.Windows.Forms.TextBox txtUitslagNaam;
        private System.Windows.Forms.ComboBox cbPartij;
        private System.Windows.Forms.NumericUpDown nStemmen;
        private System.Windows.Forms.Button btnInvoerStem;
    }
}