namespace BarbutOOP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lSayi1 = new System.Windows.Forms.Label();
            this.bZarAt = new System.Windows.Forms.Button();
            this.lSayi2 = new System.Windows.Forms.Label();
            this.lbSonuc = new System.Windows.Forms.ListBox();
            this.pbSayi1 = new System.Windows.Forms.PictureBox();
            this.pbSayi2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSayi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSayi2)).BeginInit();
            this.SuspendLayout();
            // 
            // lSayi1
            // 
            this.lSayi1.AutoSize = true;
            this.lSayi1.Location = new System.Drawing.Point(12, 9);
            this.lSayi1.Name = "lSayi1";
            this.lSayi1.Size = new System.Drawing.Size(37, 15);
            this.lSayi1.TabIndex = 0;
            this.lSayi1.Text = "lSayi1";
            this.lSayi1.Visible = false;
            this.lSayi1.Click += new System.EventHandler(this.lSayi1_Click);
            // 
            // bZarAt
            // 
            this.bZarAt.Location = new System.Drawing.Point(216, 115);
            this.bZarAt.Name = "bZarAt";
            this.bZarAt.Size = new System.Drawing.Size(206, 63);
            this.bZarAt.TabIndex = 1;
            this.bZarAt.Text = "Zar At";
            this.bZarAt.UseVisualStyleBackColor = true;
            this.bZarAt.Click += new System.EventHandler(this.bZarAt_Click);
            // 
            // lSayi2
            // 
            this.lSayi2.AutoSize = true;
            this.lSayi2.Location = new System.Drawing.Point(137, 9);
            this.lSayi2.Name = "lSayi2";
            this.lSayi2.Size = new System.Drawing.Size(37, 15);
            this.lSayi2.TabIndex = 2;
            this.lSayi2.Text = "lSayi2";
            this.lSayi2.Visible = false;
            // 
            // lbSonuc
            // 
            this.lbSonuc.FormattingEnabled = true;
            this.lbSonuc.ItemHeight = 15;
            this.lbSonuc.Location = new System.Drawing.Point(216, 184);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(206, 319);
            this.lbSonuc.TabIndex = 3;
            // 
            // pbSayi1
            // 
            this.pbSayi1.Location = new System.Drawing.Point(216, 9);
            this.pbSayi1.Name = "pbSayi1";
            this.pbSayi1.Size = new System.Drawing.Size(100, 100);
            this.pbSayi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSayi1.TabIndex = 4;
            this.pbSayi1.TabStop = false;
            // 
            // pbSayi2
            // 
            this.pbSayi2.Location = new System.Drawing.Point(322, 9);
            this.pbSayi2.Name = "pbSayi2";
            this.pbSayi2.Size = new System.Drawing.Size(100, 100);
            this.pbSayi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSayi2.TabIndex = 5;
            this.pbSayi2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbSayi2);
            this.Controls.Add(this.pbSayi1);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.lSayi2);
            this.Controls.Add(this.bZarAt);
            this.Controls.Add(this.lSayi1);
            this.Name = "Form1";
            this.Text = "Barbut";
            ((System.ComponentModel.ISupportInitialize)(this.pbSayi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSayi2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lSayi1;
        private Button bZarAt;
        private Label lSayi2;
        private ListBox lbSonuc;
        private PictureBox pbSayi1;
        private PictureBox pbSayi2;
    }
}