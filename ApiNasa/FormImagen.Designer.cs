
namespace ApiNasa
{
    partial class FormImagen
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxExplanation = new System.Windows.Forms.TextBox();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(256, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(679, 671);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.labelTitle.Font = new System.Drawing.Font("Myanmar Text", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTitle.Location = new System.Drawing.Point(243, 674);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(161, 53);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Loading...";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxExplanation
            // 
            this.textBoxExplanation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.textBoxExplanation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExplanation.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxExplanation.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxExplanation.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxExplanation.Location = new System.Drawing.Point(12, 719);
            this.textBoxExplanation.Multiline = true;
            this.textBoxExplanation.Name = "textBoxExplanation";
            this.textBoxExplanation.ReadOnly = true;
            this.textBoxExplanation.Size = new System.Drawing.Size(1188, 200);
            this.textBoxExplanation.TabIndex = 2;
            this.textBoxExplanation.TabStop = false;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(941, 506);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(94, 29);
            this.buttonDownload.TabIndex = 4;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(941, 541);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "View in HD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(156, 36);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(94, 29);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1212, 931);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.textBoxExplanation);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormImagen";
            this.Text = "Pic of the day";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormImagen_FormClosed);
            this.Load += new System.EventHandler(this.FormImagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxExplanation;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonBack;
    }
}