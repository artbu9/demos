using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoWin
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblHello.Text = Info.getInfo(); //DemoDLL.HelloDll.GetDll();
        }

        private void lblAlert_Click(object sender, EventArgs e)
        {
            MessageBox.Show("呵呵", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
