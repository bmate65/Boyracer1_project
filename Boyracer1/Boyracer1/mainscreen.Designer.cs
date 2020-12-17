namespace Boyracer1
{
    partial class mainscreen
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
            this.market = new System.Windows.Forms.Button();
            this.upgrade = new System.Windows.Forms.Button();
            this.racse = new System.Windows.Forms.Button();
            this.Autóm = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Autóm)).BeginInit();
            this.SuspendLayout();
            // 
            // market
            // 
            this.market.Font = new System.Drawing.Font("Unispace", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.market.ForeColor = System.Drawing.Color.Red;
            this.market.Location = new System.Drawing.Point(12, 600);
            this.market.Name = "market";
            this.market.Size = new System.Drawing.Size(137, 31);
            this.market.TabIndex = 0;
            this.market.Text = "Osztrija.AT";
            this.market.UseVisualStyleBackColor = true;
            this.market.Click += new System.EventHandler(this.market_Click);
            // 
            // upgrade
            // 
            this.upgrade.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.upgrade.Location = new System.Drawing.Point(959, 600);
            this.upgrade.Name = "upgrade";
            this.upgrade.Size = new System.Drawing.Size(102, 31);
            this.upgrade.TabIndex = 1;
            this.upgrade.Text = "Upgrades";
            this.upgrade.UseVisualStyleBackColor = true;
            // 
            // racse
            // 
            this.racse.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.racse.ForeColor = System.Drawing.Color.Lime;
            this.racse.Location = new System.Drawing.Point(478, 581);
            this.racse.Name = "racse";
            this.racse.Size = new System.Drawing.Size(207, 50);
            this.racse.TabIndex = 2;
            this.racse.Text = "RACSE";
            this.racse.UseVisualStyleBackColor = true;
            // 
            // Autóm
            // 
            this.Autóm.BackColor = System.Drawing.Color.Transparent;
            this.Autóm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Autóm.Location = new System.Drawing.Point(370, 152);
            this.Autóm.Name = "Autóm";
            this.Autóm.Size = new System.Drawing.Size(439, 237);
            this.Autóm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Autóm.TabIndex = 3;
            this.Autóm.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "0000000";
            // 
            // mainscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Boyracer1.Properties.Resources.garazs;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1073, 643);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Autóm);
            this.Controls.Add(this.racse);
            this.Controls.Add(this.upgrade);
            this.Controls.Add(this.market);
            this.Name = "mainscreen";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Autóm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button market;
        private System.Windows.Forms.Button upgrade;
        private System.Windows.Forms.Button racse;
        private System.Windows.Forms.PictureBox Autóm;
        private System.Windows.Forms.Label label1;
    }
}