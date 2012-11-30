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
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(109, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 43);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btUsername
            // 
            this.btUsername.Location = new System.Drawing.Point(12, 86);
            this.btUsername.Name = "btUsername";
            this.btUsername.Size = new System.Drawing.Size(88, 28);
            this.btUsername.TabIndex = 1;
            this.btUsername.Text = "Get skin";
            this.btUsername.UseVisualStyleBackColor = true;
            this.btUsername.Click += new System.EventHandler(this.btUsername_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(12, 31);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(188, 20);
            this.tbUsername.TabIndex = 2;
            // 
            // dlSkin
            // 
            this.dlSkin.Location = new System.Drawing.Point(12, 120);
            this.dlSkin.Name = "dlSkin";
            this.dlSkin.Size = new System.Drawing.Size(88, 28);
            this.dlSkin.TabIndex = 3;
            this.dlSkin.Text = "Download skin";
            this.dlSkin.UseVisualStyleBackColor = true;
            this.dlSkin.Click += new System.EventHandler(this.dlSkin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username is case sensitive";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 57);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(188, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(206, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 126);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Made by Vebjørn Hallås 2012";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 168);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dlSkin);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.btUsername);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "SkinViewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button dlSkin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;

    }
}

