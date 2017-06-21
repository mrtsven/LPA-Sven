namespace LPA
{
    partial class PartijWijzigenForm
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
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtLijsttrekker = new System.Windows.Forms.TextBox();
            this.btnWijzig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(82, 54);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(198, 22);
            this.txtNaam.TabIndex = 0;
            // 
            // txtLijsttrekker
            // 
            this.txtLijsttrekker.Location = new System.Drawing.Point(82, 106);
            this.txtLijsttrekker.Name = "txtLijsttrekker";
            this.txtLijsttrekker.Size = new System.Drawing.Size(198, 22);
            this.txtLijsttrekker.TabIndex = 1;
            // 
            // btnWijzig
            // 
            this.btnWijzig.Location = new System.Drawing.Point(350, 172);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(112, 47);
            this.btnWijzig.TabIndex = 2;
            this.btnWijzig.Text = "Wijzig partij";
            this.btnWijzig.UseVisualStyleBackColor = true;
            this.btnWijzig.Click += new System.EventHandler(this.btnWijzig_Click);
            // 
            // PartijWijzigenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 228);
            this.Controls.Add(this.btnWijzig);
            this.Controls.Add(this.txtLijsttrekker);
            this.Controls.Add(this.txtNaam);
            this.Name = "PartijWijzigenForm";
            this.Text = "PartijWijzigenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtLijsttrekker;
        private System.Windows.Forms.Button btnWijzig;
    }
}