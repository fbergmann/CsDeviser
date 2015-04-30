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
  public partial class ControlMappings : DeviserControl
  {
    public DeviserVersion Current { get; set; }

    public void InitializeFrom(DeviserVersion package)
    {
      Current = package;

      gridMappings.Rows.Clear();

      if (Current == null) return;

      if (package.Document != null)
      package.Document.InitializeMappings();

      Initializing = true;

      foreach(var item in package.Mappings)
      {
        gridMappings.Rows.Add(item.Name, item.Package);
      }

      Initializing = false;
    }

    public ControlMappings()
    {
      InitializeComponent();
    }

    private void OnCellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      if (Current == null || Initializing) return;


      var row = gridMappings.Rows[e.RowIndex];
      var attribute = Current.Mappings[e.RowIndex];

      switch (e.ColumnIndex)
      {
        case 1:
          attribute.Package = row.Cells[1].Value as string;
          Current.Dirty = true;
          break;
      }
    }


    public override void OnCommitChanges()
    {
      gridMappings.EndEdit();
    }    
  }
}
