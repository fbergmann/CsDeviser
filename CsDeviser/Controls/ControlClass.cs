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
  public partial class ControlClass : UserControl
  {
    public ControlClass()
    {
      InitializeComponent();
    }

    public DeviserClass Current { get; set; }

    public void InitializeFrom(DeviserClass package)
    {
      Current = null;

      txtName.Text = "";

      Current = package;

      if (Current == null) return;

      txtName.Text = Current.Name;

    }

    private void txtName_TextChanged(object sender, EventArgs e)
    {
      if (Current == null) return;
      Current.Name= txtName.Text;

    }

  }
}
