
namespace IMG_trans
{
    partial class aboutForm
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
            this.about_lb = new System.Windows.Forms.Label();
            this.about_rtb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // about_lb
            // 
            this.about_lb.AutoSize = true;
            this.about_lb.Location = new System.Drawing.Point(12, 9);
            this.about_lb.Name = "about_lb";
            this.about_lb.Size = new System.Drawing.Size(41, 12);
            this.about_lb.TabIndex = 0;
            this.about_lb.Text = "label1";
            // 
            // about_rtb
            // 
            this.about_rtb.Location = new System.Drawing.Point(12, 6);
            this.about_rtb.Name = "about_rtb";
            this.about_rtb.ReadOnly = true;
            this.about_rtb.Size = new System.Drawing.Size(240, 100);
            this.about_rtb.TabIndex = 1;
            this.about_rtb.Text = "";
            // 
            // aboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 111);
            this.Controls.Add(this.about_rtb);
            this.Controls.Add(this.about_lb);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(280, 150);
            this.MinimumSize = new System.Drawing.Size(280, 150);
            this.Name = "aboutForm";
            this.Text = "aboutForm";
            this.Load += new System.EventHandler(this.aboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label about_lb;
        private System.Windows.Forms.RichTextBox about_rtb;
    }
}