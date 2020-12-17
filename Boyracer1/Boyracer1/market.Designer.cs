namespace Boyracer1
{
    partial class market
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
            this.back = new System.Windows.Forms.Button();
            this.fejléc = new System.Windows.Forms.Label();
            this.pricemax = new System.Windows.Forms.Label();
            this.lang = new System.Windows.Forms.Label();
            this.kép = new System.Windows.Forms.PictureBox();
            this.Golf2 = new System.Windows.Forms.Label();
            this.Audi80 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kép)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.back.Location = new System.Drawing.Point(13, 555);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(164, 35);
            this.back.TabIndex = 0;
            this.back.Text = "Vissza a garázsba";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // fejléc
            // 
            this.fejléc.AutoSize = true;
            this.fejléc.Font = new System.Drawing.Font("Unispace", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fejléc.ForeColor = System.Drawing.Color.Red;
            this.fejléc.Location = new System.Drawing.Point(545, 9);
            this.fejléc.Name = "fejléc";
            this.fejléc.Size = new System.Drawing.Size(273, 44);
            this.fejléc.TabIndex = 1;
            this.fejléc.Text = "Osztrija.at";
            // 
            // pricemax
            // 
            this.pricemax.AutoSize = true;
            this.pricemax.Location = new System.Drawing.Point(1138, 39);
            this.pricemax.Name = "pricemax";
            this.pricemax.Size = new System.Drawing.Size(133, 13);
            this.pricemax.TabIndex = 2;
            this.pricemax.Text = "Sort by: price max 1700 € ˇ";
            // 
            // lang
            // 
            this.lang.AutoSize = true;
            this.lang.Location = new System.Drawing.Point(24, 38);
            this.lang.Name = "lang";
            this.lang.Size = new System.Drawing.Size(41, 13);
            this.lang.TabIndex = 3;
            this.lang.Text = "English";
            // 
            // kép
            // 
            this.kép.BackColor = System.Drawing.Color.Transparent;
            this.kép.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kép.Location = new System.Drawing.Point(957, 75);
            this.kép.Name = "kép";
            this.kép.Size = new System.Drawing.Size(355, 217);
            this.kép.TabIndex = 4;
            this.kép.TabStop = false;
            // 
            // Golf2
            // 
            this.Golf2.AutoSize = true;
            this.Golf2.Location = new System.Drawing.Point(184, 99);
            this.Golf2.Name = "Golf2";
            this.Golf2.Size = new System.Drawing.Size(35, 13);
            this.Golf2.TabIndex = 5;
            this.Golf2.Text = "label1";
            this.Golf2.Click += new System.EventHandler(this.Golf2_Click);
            // 
            // Audi80
            // 
            this.Audi80.AutoSize = true;
            this.Audi80.Location = new System.Drawing.Point(184, 125);
            this.Audi80.Name = "Audi80";
            this.Audi80.Size = new System.Drawing.Size(35, 13);
            this.Audi80.TabIndex = 6;
            this.Audi80.Text = "label1";
            this.Audi80.Click += new System.EventHandler(this.Audi80_Click);
            // 
            // market
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Boyracer1.Properties.Resources.osztrija_at;
            this.ClientSize = new System.Drawing.Size(1324, 602);
            this.Controls.Add(this.Audi80);
            this.Controls.Add(this.Golf2);
            this.Controls.Add(this.kép);
            this.Controls.Add(this.lang);
            this.Controls.Add(this.pricemax);
            this.Controls.Add(this.fejléc);
            this.Controls.Add(this.back);
            this.Name = "market";
            this.Text = "http//:osztrija.at";
            this.Load += new System.EventHandler(this.market_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kép)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label fejléc;
        private System.Windows.Forms.Label pricemax;
        private System.Windows.Forms.Label lang;
        private System.Windows.Forms.PictureBox kép;
        private System.Windows.Forms.Label Golf2;
        private System.Windows.Forms.Label Audi80;
    }
}