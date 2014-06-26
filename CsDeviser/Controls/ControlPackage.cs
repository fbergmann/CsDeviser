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
  public partial class ControlPackage : UserControl
  {
    public ControlPackage()
    {
      InitializeComponent();
    }

    public DeviserPackage Current { get; set; }

    public void InitializeFrom(DeviserPackage package)
    {
      Current = null;

      txtOffset.Text = "0";
      txtStartNumber.Text = "0";
      txtPackage.Text = "";

      Current = package;

      if (Current == null) return;

      txtOffset.Text = Current.Offset.ToString();
      txtStartNumber.Text = Current.StartNumber.ToString();
      txtPackage.Text = Current.Name;

    }

    private void txtPackage_TextChanged(object sender, EventArgs e)
    {
      if (Current == null) return;
      Current.Name = txtPackage.Text;

    }

    private void txtStartNumber_TextChanged(object sender, EventArgs e)
    {
      if (Current == null) return;
      int number;
      if (int.TryParse(txtStartNumber.Text, out number))
        Current.StartNumber = number;
    }

    private void txtOffset_TextChanged(object sender, EventArgs e)
    {
      if (Current == null) return;
      int number;
      if (int.TryParse(txtOffset.Text, out number))
        Current.Offset = number;
    }
  }
}
