using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMG_trans
{
    public partial class Form1 : Form
    {
        public String pro_curr_path;
        public Form1()
        {
            InitializeComponent();
            initFileType();

            // 获取当前程序所在的路径
            pro_curr_path = System.Environment.CurrentDirectory + "\\";
            img_type_lb.Text = "";
            save_path_tb.Text = pro_curr_path;
            trans_status(0);
        }


        // 初始化下拉框信息
        public void initFileType() 
        {
            selIMG_type_cb.Items.Clear();
            String[] IMGtype = new string[4];
            IMGtype[0] = ".jpg";
            IMGtype[1] = ".png";
            IMGtype[2] = ".tiff";
            IMGtype[3] = ".bmp";
            selIMG_type_cb.Items.AddRange(IMGtype);
        }

        
        public String file_path;  // 文件路径
        public String file_name;  // 文件名
        public String save_path;  // 保存路径
        // 选择图片文件
        private void select_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();        
            // 可选择的文件格式
            file.Filter = "图片格式|*.jpg;*.png*;*.tiff*;*.bmp*";
            file.ShowDialog();
            // 获取文件路径
            file_path = file.FileName;
            file_name = System.IO.Path.GetFileNameWithoutExtension(file_path);
            source_path_tb.Text = file_path;
            // 获取文件类型
            img_type_lb.Text = System.IO.Path.GetExtension(file_path);
            trans_status(1);
        }
        // 保存路径
        private void save_path_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog savepath = new FolderBrowserDialog();
            if (savepath.ShowDialog() == DialogResult.OK) 
            {
                save_path = savepath.SelectedPath;
                save_path_tb.Text = save_path;
            }
        }


        // 关于对话框
        private void button1_Click(object sender, EventArgs e)
        {
            aboutForm aboutForm = new aboutForm();
            aboutForm.ShowDialog();
        }


        // 图片转换主方法
        public void ImgTransFun(String filePath, String savePath, String fileType)
        {
            switch (fileType)
            {
                case ".jpg":
                    Image.FromFile(filePath).Save(savePath + file_name + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;
                case ".png":
                    Image.FromFile(filePath).Save(savePath + file_name + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    break;
                case ".tiff":
                    Image.FromFile(filePath).Save(savePath + file_name + ".tiff", System.Drawing.Imaging.ImageFormat.Tiff);
                    break;
                case ".bmp":
                    Image.FromFile(filePath).Save(savePath + file_name + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                    break;
            }
        }


        // 转换按钮
        private void trans_btn_Click(object sender, EventArgs e)
        {
            if (file_path == null || selIMG_type_cb.SelectedItem == null)
            {
                MessageBox.Show("请选择文件以及目标类型！");
            }
            else if (file_path != null && selIMG_type_cb.SelectedItem != null)
            {
                try
                {
                    trans_status(2);
                    ImgTransFun(file_path, save_path_tb.Text, selIMG_type_cb.Text);
                    trans_status(3);
                }
                catch
                {
                    MessageBox.Show("路径有误请重新选择！");                    
                }                
            }
        }

        // 转换状态显示设置
        public void trans_status(int status) 
        {
            switch (status) 
            {
                case 0:
                    status_lb.Text = "未选择";
                    status_lb.ForeColor = Color.Red;
                    break;
                case 1:
                    status_lb.Text = "未转换";
                    status_lb.ForeColor = Color.Orange;
                    break;
                case 2:
                    status_lb.Text = "转换中";
                    status_lb.ForeColor = Color.LightGreen;
                    break;
                case 3:
                    status_lb.Text = "已转换";
                    status_lb.ForeColor = Color.Green;
                    break;
            }                            
        }
        
    }
}
