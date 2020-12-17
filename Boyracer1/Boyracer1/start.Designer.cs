namespace Boyracer1
{
    partial class Startscreen
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
            this.button1 = new System.Windows.Forms.Button();
            this.cím = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(385, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cím
            // 
            this.cím.AutoSize = true;
            this.cím.BackColor = System.Drawing.Color.Transparent;
            this.cím.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cím.ForeColor = System.Drawing.Color.White;
            this.cím.Location = new System.Drawing.Point(322, 87);
            this.cím.Name = "cím";
            this.cím.Size = new System.Drawing.Size(346, 85);
            this.cím.TabIndex = 1;
            this.cím.Text = "Boyrécer 1";
            // 
            // Startscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Boyracer1.Properties.Resources.Start_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 921);
            this.Controls.Add(this.cím);
            this.Controls.Add(this.button1);
            this.Name = "Startscreen";
            this.Text = "Boyracer 1";
            this.Load += new System.EventHandler(this.Startscreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label cím;
    }
}

