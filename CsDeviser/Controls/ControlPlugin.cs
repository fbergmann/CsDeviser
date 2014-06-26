using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibDeviser;

namespace CsDeviser.Controls
{
  public partial class ControlPlugin : UserControl
  {
    public ControlPlugin()
    {
      InitializeComponent();
    }
    public DeviserPlugin Current { get; set; }

    public void InitializeFrom(DeviserPlugin package)
    {
      Current = null;

      txtExtensionPoint.Text = "";

      Current = package;

      if (Current == null) return;

      txtExtensionPoint.Text = Current.ExtensionPoint;

    }

    private void txtExtensionPoint_TextChanged(object sender, EventArgs e)
    {
      if (Current == null) return;
      Current.ExtensionPoint= txtExtensionPoint.Text;

    }
  }
}
