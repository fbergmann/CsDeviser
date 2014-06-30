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
  public partial class ControlEnum : DeviserControl
  {
    public ControlEnum()
    {
      InitializeComponent();
    }


    public DeviserEnum Current { get; set; }

    public void InitializeFrom(DeviserEnum package)
    {
      Current = null;

      txtName.Text = "";


      gridAttributes.Rows.Clear();

      Current = package;

      if (Current == null) return;
      Initializing = true;
      txtName.Text = Current.Name;

      foreach (var newAttr in Current.Values)
        gridAttributes.Rows.Add(newAttr.Name, newAttr.Value);

      Initializing = false;
    }


    private void txtName_TextChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      Current.Name = txtName.Text;      

    }

    private void cmdAddAttribute_Click(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;

      var newAttr = new DeviserEnumValue { Name = "EnumValue" + (Current.Values.Count + 1).ToString() };
      Current.Values.Add(newAttr);

      var row = gridAttributes.Rows.Add(newAttr.Name, newAttr.Value);
      gridAttributes.CurrentCell = gridAttributes[0, row];
      gridAttributes.Focus();
      gridAttributes.BeginEdit(true);

    }

    private void cmdRemoveAttr_Click(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      var row = gridAttributes.SelectedRows;
      for (int i = row.Count - 1; i >= 0; i--)
      {
        gridAttributes.Rows.Remove(row[i]);
        var attr = Current.Values.FirstOrDefault(a => a.Name == row[i].Cells[0].Value as string);
        if (attr != null)
          Current.Values.Remove(attr);
      }

    }

    private void OnGridValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      if (Current == null || Initializing) return;


      var row = gridAttributes.Rows[e.RowIndex];
      var attribute = Current.Values[e.RowIndex];

      switch (e.ColumnIndex)
      {
        case 0:
          attribute.Name = row.Cells[0].Value as string;
          break;
        case 1:
          attribute.Value = row.Cells[1].Value as string;
          break;
      }

    }

    private void txtName_Leave(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      OnRenamedEvent();
    }



  }
}
