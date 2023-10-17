namespace tek_çift_oyunu
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSayi = new System.Windows.Forms.Label();
            this.btnUret = new System.Windows.Forms.Button();
            this.btnCift = new System.Windows.Forms.Button();
            this.btnTek = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(48, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "sayı:";
            // 
            // lblSayi
            // 
            this.lblSayi.AutoSize = true;
            this.lblSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSayi.Location = new System.Drawing.Point(107, 59);
            this.lblSayi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(19, 20);
            this.lblSayi.TabIndex = 1;
            this.lblSayi.Text = "0";
            // 
            // btnUret
            // 
            this.btnUret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUret.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUret.Location = new System.Drawing.Point(166, 43);
            this.btnUret.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(107, 53);
            this.btnUret.TabIndex = 2;
            this.btnUret.Text = "sayı üret";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // btnCift
            // 
            this.btnCift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCift.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCift.Location = new System.Drawing.Point(166, 129);
            this.btnCift.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCift.Name = "btnCift";
            this.btnCift.Size = new System.Drawing.Size(107, 63);
            this.btnCift.TabIndex = 3;
            this.btnCift.Text = "çift sayı";
            this.btnCift.UseVisualStyleBackColor = true;
            this.btnCift.Click += new System.EventHandler(this.btnCift_Click);
            // 
            // btnTek
            // 
            this.btnTek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTek.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTek.Location = new System.Drawing.Point(15, 129);
            this.btnTek.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTek.Name = "btnTek";
            this.btnTek.Size = new System.Drawing.Size(111, 63);
            this.btnTek.TabIndex = 4;
            this.btnTek.Text = "tek sayı";
            this.btnTek.UseVisualStyleBackColor = true;
            this.btnTek.Click += new System.EventHandler(this.btnTek_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(36, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "puan:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPuan.Location = new System.Drawing.Point(120, 238);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(15, 16);
            this.lblPuan.TabIndex = 7;
            this.lblPuan.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 412);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTek);
            this.Controls.Add(this.btnCift);
            this.Controls.Add(this.btnUret);
            this.Controls.Add(this.lblSayi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSayi;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.Button btnCift;
        private System.Windows.Forms.Button btnTek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPuan;
    }
}

