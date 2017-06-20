namespace LPA
{
    partial class CreatePartijForm
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
            this.txtLijstTrekker = new System.Windows.Forms.TextBox();
            this.btnCreatePartij = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(144, 40);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(200, 22);
            this.txtNaam.TabIndex = 0;
            // 
            // txtLijstTrekker
            // 
            this.txtLijstTrekker.Location = new System.Drawing.Point(144, 92);
            this.txtLijstTrekker.Name = "txtLijstTrekker";
            this.txtLijstTrekker.Size = new System.Drawing.Size(200, 22);
            this.txtLijstTrekker.TabIndex = 1;
            // 
            // btnCreatePartij
            // 
            this.btnCreatePartij.Location = new System.Drawing.Point(381, 111);
            this.btnCreatePartij.Name = "btnCreatePartij";
            this.btnCreatePartij.Size = new System.Drawing.Size(110, 40);
            this.btnCreatePartij.TabIndex = 2;
            this.btnCreatePartij.Text = "Nieuwe Partij";
            this.btnCreatePartij.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naam partij:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naam lijsttrekker:";
            // 
            // CreatePartijForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 163);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreatePartij);
            this.Controls.Add(this.txtLijstTrekker);
            this.Controls.Add(this.txtNaam);
            this.Name = "CreatePartijForm";
            this.Text = "CreatePartijForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtLijstTrekker;
        private System.Windows.Forms.Button btnCreatePartij;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}