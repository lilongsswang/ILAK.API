using System;
using System.Windows.Forms;
using System.Reflection;

namespace ILAK.API
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        #region 窗口加载时
        /// <summary>
        /// 窗口加载时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            #region 初始化TabPage内容
            foreach (TabPage page in tabShow.TabPages)
            {
                if (page.Tag != null)
                {
                    Assembly asb = Assembly.GetExecutingAssembly();//得到当前的程序集
                    object c = asb.CreateInstance("ILAK.API." + page.Tag.ToString(), true);
                    if (c != null)
                    {
                        Form f = (Form)c;
                        f.Dock = DockStyle.Fill;
                        f.TopLevel = false;
                        f.FormBorderStyle = FormBorderStyle.None;
                        f.Show();
                        page.Controls.Add(f);
                    }
                }
            }
            #endregion
        }
        #endregion
    }
}