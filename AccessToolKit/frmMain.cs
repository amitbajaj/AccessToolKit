using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessToolKit
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            BuildMenuItems();
            
        }
        private void BuildMenuItems()
        {
            for (int i = 0; i < menuStripMain.Items.Count; i++) menuStripMain.Items.RemoveAt(0);
            ToolStripMenuItem[] items = new ToolStripMenuItem[1];
            ToolStripItem o;
            items[0] = new ToolStripMenuItem("&File");
            items[0].Name = "FileMenu";
            o = items[0].DropDownItems.Add("Open");
            o.Tag = "OpenDB";
            o.Name = "OpenDB";
            o.Click += new EventHandler(MenuItemClickHandler);
            o = items[0].DropDownItems.Add("Create");
            o.Tag="CreateDB";
            o.Name = "CreateDB";
            o.Click += new EventHandler(MenuItemClickHandler);
            items[0].Click += new EventHandler(MenuItemClickHandler);
            menuStripMain.Items.AddRange(items);
        }

        private void MenuItemClickHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            if (clickedItem.Tag != null)
            {
                MessageBox.Show(clickedItem.Tag.ToString());

            }

        }
    }
}
