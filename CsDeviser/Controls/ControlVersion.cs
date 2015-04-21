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
  public partial class ControlVersion : DeviserControl
  {
    public ControlVersion()
    {
      InitializeComponent();
    }
       
    public DeviserVersion Current { get; set; }

    public void InitializeFrom(DeviserVersion version)
    {
      Current = null;

      txtCoreVersion.Text = "0";
      txtCoreLevel.Text = "0";
      txtPkgVersion.Text = "0";

      lstClasses.Items.Clear();

      Current = version;

      if (Current == null) return;
      Initializing = true;
      txtCoreVersion.Text = Current.Version.ToString();
      txtCoreLevel.Text = Current.Level.ToString();
      txtPkgVersion.Text = Current.PackageVersion.ToString();

      foreach(var item in version.Elements)
        lstClasses.Items.Add(item.Name);
      
      Initializing = false;
    }

    private void OnLevelChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      int number;
      if (int.TryParse(txtCoreLevel.Text, out number))
        Current.Level = number;
      OnRenamedEvent();
    }

    private void OnVersionChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      int number;
      if (int.TryParse(txtCoreVersion.Text, out number))
        Current.Version = number;
      OnRenamedEvent();
    }

    private void OnMoveClassDown(object sender, EventArgs e)
    {
      var index = lstClasses.SelectedIndex;
      if (index < 0 || index + 1 > lstClasses.Items.Count || Current == null || Current.Elements.Count <= index + 1) return;
      if (Current == null || Initializing) return;
      var elem = Current.Elements[index];
      Current.Elements.RemoveAt(index);
      Current.Elements.Insert(index + 1, elem);

      lstClasses.Items.RemoveAt(index);
      lstClasses.Items.Insert(index + 1, elem.Name);

      lstClasses.SelectedIndex = index + 1;
    }

    private void OnMoveClassUp(object sender, EventArgs e)
    {
      var index = lstClasses.SelectedIndex;
      if (index < 1 || Current == null || Current.Elements.Count <= index) return;
      if (Current == null || Initializing) return;
      var elem = Current.Elements[index];
      Current.Elements.RemoveAt(index);
      Current.Elements.Insert(index - 1, elem);

      lstClasses.Items.RemoveAt(index);
      lstClasses.Items.Insert(index - 1, elem.Name);

      lstClasses.SelectedIndex = index - 1;

    }

    private void OnPkgVersionChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      int number;
      if (int.TryParse(txtPkgVersion.Text, out number))
        Current.PackageVersion = number;

      OnRenamedEvent();

    }

  }
}
