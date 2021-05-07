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
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();
        }

        private void aboutForm_Load(object sender, EventArgs e)
        {
            String company = "YukiTechStudio";
            String version = "Version: v0.2";
            String author = "author: Yuki";
            String info = "这是一个免费的简易图片转换工具！并且会持续维护！";
            String tips = "v0.1 暂时只支持单个文件, 文件保存在此程序所在位置。\n" +
                          "v0.2 支持选择保存路径, 增加状态提示。";
            about_rtb.Text = company + "\n" +
                            version + "\n" +
                            author + "\n" +
                            info + "\n" +
                            tips;
        }
    }
}
