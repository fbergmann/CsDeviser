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
    
    public event EventHandler RenamedEvent;

    public bool Initializing { get; set; }

    protected virtual void OnRenamedEvent()
    {
      var handler = RenamedEvent;
      if (handler != null) handler(this, EventArgs.Empty);
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
      Initializing = true;
      txtOffset.Text = Current.Offset.ToString();
      txtStartNumber.Text = Current.StartNumber.ToString();
      txtPackage.Text = Current.Name;
      Initializing = false;
    }

    private void txtPackage_TextChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      Current.Name = txtPackage.Text;      
    }

    private void txtStartNumber_TextChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      int number;
      if (int.TryParse(txtStartNumber.Text, out number))
        Current.StartNumber = number;
    }

    private void txtOffset_TextChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      int number;
      if (int.TryParse(txtOffset.Text, out number))
        Current.Offset = number;
    }

    private void txtPackage_Leave(object sender, EventArgs e)
    {
      OnRenamedEvent();
    }
  }
}
