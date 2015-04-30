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
      txtAddDecls.Text = "";
      txtAddImpls.Text = "";
      chkRequired.Checked = false;
      chkRequiresAdditionalCode.Checked = false;
      grpAdditionalFiles.Visible = false;

      Current = package;

      if (Current == null) return;
      Initializing = true;
      txtOffset.Text = Current.Offset.ToString();
      txtStartNumber.Text = Current.StartNumber.ToString();
      txtPackage.Text = Current.Name;
      txtFullName.Text = Current.FullName;
      chkRequired.Checked = Current.Required;
      txtAddDecls.Text = Current.AdditionalDeclarations;
      txtAddImpls.Text = Current.AdditionalDefinitions;

      chkRequiresAdditionalCode.Checked = Current.HasAdditionalCode;
      grpAdditionalFiles.Visible = Current.HasAdditionalCode;

      Initializing = false;
    }

    private void txtPackage_TextChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      Current.Name = txtPackage.Text;
      Current.Dirty = true;
    }

    private void txtStartNumber_TextChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      int number;
      if (int.TryParse(txtStartNumber.Text, out number))
      {
        Current.StartNumber = number;
        Current.Dirty = true;
      }
    }

    private void txtOffset_TextChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      int number;
      if (int.TryParse(txtOffset.Text, out number))
      {
        Current.Offset = number;
        Current.Dirty = true;
      }
    }

    private void txtPackage_Leave(object sender, EventArgs e)
    {
      OnRenamedEvent();
    }

    private void txtFullName_TextChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      Current.FullName = txtFullName.Text;
      Current.Dirty = true;
    }

    private void chkRequired_CheckedChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      Current.Required = chkRequired.Checked;
      Current.Dirty = true;
    }

    private void txtAddDecls_TextChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      Current.AdditionalDeclarations = txtAddDecls.Text;
      Current.Dirty = true;
    }

    private void txtAddImpls_TextChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      Current.AdditionalDefinitions = txtAddImpls.Text;
      Current.Dirty = true;
    }

    private void OnCheckRequiresAdditionalCodeCheckedChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      grpAdditionalFiles.Visible = chkRequiresAdditionalCode.Checked;
    }

    private void OnBrowseDeclsClick(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      using (var dlg = new OpenFileDialog { Title = "Select Declaration file", Filter = "Header files|*.h;*.hxx;*.h++;*.hpp;*.hh|All files|*.*"} )
      {
        if (dlg.ShowDialog() == DialogResult.OK)
        { 
          txtAddDecls.Text = dlg.FileName.Replace("\\", "/");
          Current.AdditionalDeclarations = dlg.FileName.Replace("\\", "/");
          Current.Dirty = true;
        }
      }
    }

    private void OnBrowseImplsClick(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      using (var dlg = new OpenFileDialog { Title = "Select Implementation file", Filter = "Implementation files|*.c;*.cpp;*.c++;*.cxx;*.cc|All files|*.*" })
      {
        if (dlg.ShowDialog() == DialogResult.OK)
        {
          txtAddImpls.Text = dlg.FileName.Replace("\\", "/");
          Current.AdditionalDefinitions = dlg.FileName.Replace("\\", "/");
          Current.Dirty = true;
        }
      }

    }

  }
}
