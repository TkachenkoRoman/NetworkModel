using System.Drawing;
using System.Windows.Forms;
using NetworkModel.Properties;

namespace NetworkModel
{
    class NodeControl : Button
    {
        public int Id { get; set; }

        public NodeControl()
        {
            Image = Resources.computer_icon;
            ImageAlign = ContentAlignment.MiddleCenter;
            Height = 21;
            Width = 21;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Padding = new Padding(0);
        }
    }
}
