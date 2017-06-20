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
            this.lbOverview = new System.Windows.Forms.CheckedListBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnNieuwePartij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOverview
            // 
            this.lbOverview.FormattingEnabled = true;
            this.lbOverview.Location = new System.Drawing.Point(12, 7);
            this.lbOverview.Name = "lbOverview";
            this.lbOverview.Size = new System.Drawing.Size(564, 480);
            this.lbOverview.TabIndex = 0;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(664, 63);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "TEST";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnNieuwePartij
            // 
            this.btnNieuwePartij.Location = new System.Drawing.Point(664, 110);
            this.btnNieuwePartij.Name = "btnNieuwePartij";
            this.btnNieuwePartij.Size = new System.Drawing.Size(125, 39);
            this.btnNieuwePartij.TabIndex = 2;
            this.btnNieuwePartij.Text = "Nieuwe Partij";
            this.btnNieuwePartij.UseVisualStyleBackColor = true;
            this.btnNieuwePartij.Click += new System.EventHandler(this.btnNieuwePartij_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 511);
            this.Controls.Add(this.btnNieuwePartij);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lbOverview);
            this.Name = "MainForm";
            this.Text = "LPA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lbOverview;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnNieuwePartij;
    }
}

