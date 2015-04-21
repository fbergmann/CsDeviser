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
  public partial class ControlPackage : DeviserControl
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
      txtFullName.Text = "";
      txtVersion.Text = "0";
      txtAddDecls.Text = "";
      txtAddImpls.Text = "";
      chkRequired.Checked = false;

      Current = package;

      if (Current == null) return;
      Initializing = true;
      txtOffset.Text = Current.Offset.ToString();
      txtStartNumber.Text = Current.StartNumber.ToString();
      txtPackage.Text = Current.Name;
      txtFullName.Text = Current.FullName;
      txtVersion.Text = Current.Version.ToString();
      chkRequired.Checked = Current.Required;
      txtAddDecls.Text = Current.AdditionalDeclarations;
      txtAddImpls.Text = Current.AdditionalDefinitions;

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

    private void txtFullName_TextChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      Current.FullName = txtFullName.Text;   
    }

    private void chkRequired_CheckedChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      Current.Required = chkRequired.Checked;   
    }

    private void txtVersion_TextChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      int number;
      if (int.TryParse(txtVersion.Text, out number))
        Current.Version = number;
    }

    private void txtAddDecls_TextChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      Current.AdditionalDeclarations = txtAddDecls.Text;   

    }

    private void txtAddImpls_TextChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      Current.AdditionalDefinitions = txtAddImpls.Text;   

    }

  }
}
