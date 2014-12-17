using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace MUN_ChairTools
{
    partial class AboutBox : Form
    {
        public string AssemblyAuthorized = "All User";//默认授权给All User

        public AboutBox()
        {
            InitializeComponent();
            
            this.Text = String.Format("关于 {0}", AssemblyTitle);
            this.labelAuthorization.Text = "本产品授权给:\n\n" + this.AssemblyAuthorized;
            this.linkLabelMyGithubAddress.Text = "https://github.com/WuZhuoran";
            this.linkLabelMyGithubAddress.Click += new EventHandler(linkLabelMyGithubAddress_Click);
            this.linkLabelWriterEmail.Click += new EventHandler(linkLabelWriterEmail_Click);

            this.labelProductName.Text += ProductName;
            this.labelProdectOwner.Text += "吴卓燃 常州大学 软件工程专业2012级";
            this.labelProductVersion.Text += AssemblyVersion;
            this.labelWarning.Text += "本程序软件遵照GPL协议开放源代码";

            
        }

        void linkLabelWriterEmail_Click(object sender, EventArgs e)
        {
            this.linkLabelWriterEmail.Links[0].LinkData = "work.serv.oliver@gmail.com";
            Clipboard.SetDataObject(this.linkLabelWriterEmail.Links[0].LinkData, true);
            MessageBox.Show("已经将邮箱地址复制到剪贴板中！");
        }

        void linkLabelMyGithubAddress_Click(object sender, EventArgs e)
        {
            this.linkLabelMyGithubAddress.Links[0].LinkData = "https://github.com/WuZhuoran";
            System.Diagnostics.Process.Start(this.linkLabelMyGithubAddress.Links[0].LinkData.ToString());
        }

        #region 程序集特性访问器

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCppyRightText_Click(object sender, EventArgs e)
        {
            new FormOpenSourceStatement().Show();
        }

        private void buttonGPLlicense_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gnu.org/licenses/gpl.html");
        }


    }
}
