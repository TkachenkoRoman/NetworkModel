using System;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Windows.Forms;

namespace NetworkModel
{
    static class Global
    {
        public static int NodeId { get; set; }
        public static bool IsMouseOverControl(this Control control)
        {
            if (control == null) throw new ArgumentNullException("control");
            Contract.EndContractBlock();

            Point pt = control.PointToClient(Control.MousePosition);
            return (pt.X >= 0 && pt.Y >= 0 && pt.X <= control.Width && pt.Y <= control.Height);
        }
    }
}
