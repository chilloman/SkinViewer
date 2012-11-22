namespace SkinViewer
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btUsername = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.dlSkin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(72, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 43);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btUsername
            // 
            this.btUsername.Location = new System.Drawing.Point(63, 38);
            this.btUsername.Name = "btUsername";
            this.btUsername.Size = new System.Drawing.Size(88, 28);
            this.btUsername.TabIndex = 1;
            this.btUsername.Text = "Get skin";
            this.btUsername.UseVisualStyleBackColor = true;
            this.btUsername.Click += new System.EventHandler(this.btUsername_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(12, 12);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(188, 20);
            this.tbUsername.TabIndex = 2;
            // 
            // dlSkin
            // 
            this.dlSkin.Location = new System.Drawing.Point(63, 121);
            this.dlSkin.Name = "dlSkin";
            this.dlSkin.Size = new System.Drawing.Size(88, 28);
            this.dlSkin.TabIndex = 3;
            this.dlSkin.Text = "Download skin";
            this.dlSkin.UseVisualStyleBackColor = true;
            this.dlSkin.Click += new System.EventHandler(this.dlSkin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 162);
            this.Controls.Add(this.dlSkin);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.btUsername);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "SkinViewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button dlSkin;

    }
}

