namespace LPA
{
    partial class MainForm
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
            this.btnTest = new System.Windows.Forms.Button();
            this.btnNieuwePartij = new System.Windows.Forms.Button();
            this.dgMainView = new System.Windows.Forms.DataGridView();
            this.btnWijzigPartij = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LijstTrekker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zetels = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNieuwUitslag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMainView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(640, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "TEST";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnNieuwePartij
            // 
            this.btnNieuwePartij.Location = new System.Drawing.Point(640, 92);
            this.btnNieuwePartij.Name = "btnNieuwePartij";
            this.btnNieuwePartij.Size = new System.Drawing.Size(166, 57);
            this.btnNieuwePartij.TabIndex = 2;
            this.btnNieuwePartij.Text = "Nieuwe Partij";
            this.btnNieuwePartij.UseVisualStyleBackColor = true;
            this.btnNieuwePartij.Click += new System.EventHandler(this.btnNieuwePartij_Click);
            // 
            // dgMainView
            // 
            this.dgMainView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMainView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naam,
            this.LijstTrekker,
            this.Zetels});
            this.dgMainView.Location = new System.Drawing.Point(12, 12);
            this.dgMainView.Name = "dgMainView";
            this.dgMainView.RowTemplate.Height = 24;
            this.dgMainView.Size = new System.Drawing.Size(602, 487);
            this.dgMainView.TabIndex = 3;
            // 
            // btnWijzigPartij
            // 
            this.btnWijzigPartij.Location = new System.Drawing.Point(640, 155);
            this.btnWijzigPartij.Name = "btnWijzigPartij";
            this.btnWijzigPartij.Size = new System.Drawing.Size(166, 61);
            this.btnWijzigPartij.TabIndex = 4;
            this.btnWijzigPartij.Text = "Wijzig geselecteerde partij";
            this.btnWijzigPartij.UseVisualStyleBackColor = true;
            this.btnWijzigPartij.Click += new System.EventHandler(this.btnWijzigPartij_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Visible = false;
            // 
            // Naam
            // 
            this.Naam.HeaderText = "Naam";
            this.Naam.Name = "Naam";
            // 
            // LijstTrekker
            // 
            this.LijstTrekker.HeaderText = "Lijst trekker";
            this.LijstTrekker.MinimumWidth = 250;
            this.LijstTrekker.Name = "LijstTrekker";
            this.LijstTrekker.ReadOnly = true;
            this.LijstTrekker.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LijstTrekker.Width = 250;
            // 
            // Zetels
            // 
            this.Zetels.HeaderText = "Zetels";
            this.Zetels.Name = "Zetels";
            this.Zetels.ReadOnly = true;
            this.Zetels.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnNieuwUitslag
            // 
            this.btnNieuwUitslag.Location = new System.Drawing.Point(640, 222);
            this.btnNieuwUitslag.Name = "btnNieuwUitslag";
            this.btnNieuwUitslag.Size = new System.Drawing.Size(166, 57);
            this.btnNieuwUitslag.TabIndex = 5;
            this.btnNieuwUitslag.Text = "Nieuwe Uitslag";
            this.btnNieuwUitslag.UseVisualStyleBackColor = true;
            this.btnNieuwUitslag.Click += new System.EventHandler(this.btnNieuwUitslag_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 511);
            this.Controls.Add(this.btnNieuwUitslag);
            this.Controls.Add(this.btnWijzigPartij);
            this.Controls.Add(this.dgMainView);
            this.Controls.Add(this.btnNieuwePartij);
            this.Controls.Add(this.btnTest);
            this.Name = "MainForm";
            this.Text = "LPA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMainView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnNieuwePartij;
        private System.Windows.Forms.DataGridView dgMainView;
        private System.Windows.Forms.Button btnWijzigPartij;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn LijstTrekker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zetels;
        private System.Windows.Forms.Button btnNieuwUitslag;
    }
}

