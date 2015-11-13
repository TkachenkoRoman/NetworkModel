using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetworkModel.Properties;

namespace NetworkModel
{
    public partial class MainForm : Form
    {
        private bool newNodeDragging;
        private ContextMenu rightClickNodeMenu;

        public MainForm()
        {
            InitializeComponent();
            InitializeNodeRightClickMenu();
        }

        private void InitializeNodeRightClickMenu()
        {
            rightClickNodeMenu = new ContextMenu();
            MenuItem menuItem1 = new MenuItem("Create chanel from here");
            rightClickNodeMenu.MenuItems.Add(menuItem1);
        }

        private bool CanDropNewNode()
        {
            return !buttonNewNode.IsMouseOverControl();
        }

        private void buttonNewNode_MouseDown(object sender, MouseEventArgs e)
        {
            newNodeDragging = true;
        }

        private void buttonNewNode_MouseUp(object sender, MouseEventArgs e)
        {
            newNodeDragging = false;
            if (CanDropNewNode())
                CreateNewNode(e.Location);
        }

        private void CreateNewNode(Point location)
        {
            NodeControl newNode = new NodeControl();
            int xPoint = location.X - panelNetworkModel.Location.X;
            int yPoint = location.Y - panelNetworkModel.Location.Y;
            newNode.Location = new Point(xPoint, yPoint);
            newNode.Id = Global.NodeId++;
            panelNetworkModel.Controls.Add(newNode);

            newNode.MouseUp += newNode_MouseUp;
        }

        void newNode_MouseUp(object sender, MouseEventArgs e)
        {
            if (((NodeControl) sender).IsMouseOverControl())
            {
                if (e.Button == MouseButtons.Right)
                {
                    ((NodeControl) sender).ContextMenu = rightClickNodeMenu;
                    //MessageBox.Show("right clicked node " + ((NodeControl)sender).Id);
                }
            }          
        }


        private void buttonNewNode_MouseMove(object sender, MouseEventArgs e)
        {
            if (newNodeDragging)
            {
                if (CanDropNewNode())
                {
                    Bitmap bmp = new Bitmap(Resources.computer_icon);
                    //abmp.MakeTransparent(Color.White);
                    Cursor cur = new Cursor(bmp.GetHicon());
                    Cursor.Current = cur;
                }
                else
                {
                    Cursor.Current = Cursors.No;
                }
            }
        }
    }
}
