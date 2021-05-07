
namespace IMG_trans
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.select_file = new System.Windows.Forms.Button();
            this.source_path_tb = new System.Windows.Forms.TextBox();
            this.selIMG_type_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.img_type_lb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.trans_btn = new System.Windows.Forms.Button();
            this.save_path_tb = new System.Windows.Forms.TextBox();
            this.save_path_btn = new System.Windows.Forms.Button();
            this.status_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // select_file
            // 
            this.select_file.Location = new System.Drawing.Point(240, 10);
            this.select_file.Name = "select_file";
            this.select_file.Size = new System.Drawing.Size(75, 23);
            this.select_file.TabIndex = 0;
            this.select_file.Text = "选择图片";
            this.select_file.UseVisualStyleBackColor = true;
            this.select_file.Click += new System.EventHandler(this.select_file_Click);
            // 
            // source_path_tb
            // 
            this.source_path_tb.Location = new System.Drawing.Point(12, 12);
            this.source_path_tb.Name = "source_path_tb";
            this.source_path_tb.ReadOnly = true;
            this.source_path_tb.Size = new System.Drawing.Size(222, 21);
            this.source_path_tb.TabIndex = 1;
            // 
            // selIMG_type_cb
            // 
            this.selIMG_type_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selIMG_type_cb.FormattingEnabled = true;
            this.selIMG_type_cb.Location = new System.Drawing.Point(170, 41);
            this.selIMG_type_cb.Name = "selIMG_type_cb";
            this.selIMG_type_cb.Size = new System.Drawing.Size(64, 20);
            this.selIMG_type_cb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(134, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "→";
            // 
            // img_type_lb
            // 
            this.img_type_lb.AutoSize = true;
            this.img_type_lb.Location = new System.Drawing.Point(86, 44);
            this.img_type_lb.Name = "img_type_lb";
            this.img_type_lb.Size = new System.Drawing.Size(59, 12);
            this.img_type_lb.TabIndex = 6;
            this.img_type_lb.Text = "File_Type";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "关于";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trans_btn
            // 
            this.trans_btn.Location = new System.Drawing.Point(240, 39);
            this.trans_btn.Name = "trans_btn";
            this.trans_btn.Size = new System.Drawing.Size(75, 23);
            this.trans_btn.TabIndex = 8;
            this.trans_btn.Text = "转换";
            this.trans_btn.UseVisualStyleBackColor = true;
            this.trans_btn.Click += new System.EventHandler(this.trans_btn_Click);
            // 
            // save_path_tb
            // 
            this.save_path_tb.Location = new System.Drawing.Point(12, 78);
            this.save_path_tb.Name = "save_path_tb";
            this.save_path_tb.ReadOnly = true;
            this.save_path_tb.Size = new System.Drawing.Size(222, 21);
            this.save_path_tb.TabIndex = 9;
            // 
            // save_path_btn
            // 
            this.save_path_btn.Location = new System.Drawing.Point(240, 78);
            this.save_path_btn.Name = "save_path_btn";
            this.save_path_btn.Size = new System.Drawing.Size(75, 23);
            this.save_path_btn.TabIndex = 10;
            this.save_path_btn.Text = "保存路径";
            this.save_path_btn.UseVisualStyleBackColor = true;
            this.save_path_btn.Click += new System.EventHandler(this.save_path_btn_Click);
            // 
            // status_lb
            // 
            this.status_lb.AutoSize = true;
            this.status_lb.Location = new System.Drawing.Point(328, 44);
            this.status_lb.Name = "status_lb";
            this.status_lb.Size = new System.Drawing.Size(41, 12);
            this.status_lb.TabIndex = 11;
            this.status_lb.Text = "status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 111);
            this.Controls.Add(this.status_lb);
            this.Controls.Add(this.save_path_btn);
            this.Controls.Add(this.save_path_tb);
            this.Controls.Add(this.trans_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.img_type_lb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selIMG_type_cb);
            this.Controls.Add(this.source_path_tb);
            this.Controls.Add(this.select_file);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 150);
            this.MinimumSize = new System.Drawing.Size(400, 150);
            this.Name = "Form1";
            this.Text = "IMG_TRANS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button select_file;
        private System.Windows.Forms.TextBox source_path_tb;
        private System.Windows.Forms.ComboBox selIMG_type_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label img_type_lb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button trans_btn;
        private System.Windows.Forms.TextBox save_path_tb;
        private System.Windows.Forms.Button save_path_btn;
        private System.Windows.Forms.Label status_lb;
    }
}

