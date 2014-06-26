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

    public event EventHandler RenamedEvent;

    public bool Initializing { get; set; }

    protected virtual void OnRenamedEvent()
    {
      var handler = RenamedEvent;
      if (handler != null) handler(this, EventArgs.Empty);
    }


    public DeviserPlugin Current { get; set; }

    public void InitializeFrom(DeviserPlugin package)
    {
      Current = null;

      txtExtensionPoint.Text = "";

      lstAllClasses.Items.Clear();
      lstChildClasses.Items.Clear();
      gridAttributes.Rows.Clear();

      splitContainer1.Panel2Collapsed = true;
      cmdAddAttribute.Visible = false;

      Current = package;

      if (Current == null) return;

      Initializing = true;

      txtExtensionPoint.Text = Current.ExtensionPoint;

      if (Current.Attributes.Count > 0)
      {
        chkHasAdditional.Checked = true;
        splitContainer1.Panel2Collapsed = false;
        cmdAddAttribute.Visible = true;
      }
      else
      {
        chkHasAdditional.Checked = false;
      }
      
      if (Current.Document != null)
      foreach (var item in Current.Document.Elements)
        lstAllClasses.Items.Add(item.Name);

      foreach (var newAttr in Current.References)
        lstChildClasses.Items.Add(newAttr.Name);

      foreach (var newAttr in Current.Attributes)
        gridAttributes.Rows.Add(newAttr.Name, newAttr.Type, newAttr.Required, newAttr.Element, newAttr.Abstract);

      Initializing = false;
    }

    private void txtExtensionPoint_TextChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      Current.ExtensionPoint= txtExtensionPoint.Text;      

    }

    private void chkHasAdditional_CheckedChanged(object sender, EventArgs e)
    {
      splitContainer1.Panel2Collapsed = !chkHasAdditional.Checked;
      cmdAddAttribute.Visible = chkHasAdditional.Checked;
    }

    private void OnAddClick(object sender, EventArgs e)
    {
      AddReferences();
    }

    private void OnRemoveClick(object sender, EventArgs e)
    {
      RemoveReferences();
    }

    private void OnUpClick(object sender, EventArgs e)
    {
      var index = lstChildClasses.SelectedIndex;
      if (index < 1 || Current == null || Current.References.Count <= index) return;
      if (Current == null || Initializing) return;
      var elem = Current.References[index];
      Current.References.RemoveAt(index);
      Current.References.Insert(index-1,elem);

      lstChildClasses.Items.RemoveAt(index);
      lstChildClasses.Items.Insert(index - 1, elem.Name);
      
    }

    private void OnDownClick(object sender, EventArgs e)
    {
      var index = lstChildClasses.SelectedIndex;
      if (index < 0 || index + 1 > lstChildClasses.Items.Count || Current == null || Current.References.Count <= index+1) return;
      if (Current == null || Initializing) return;
      var elem = Current.References[index];
      Current.References.RemoveAt(index);
      Current.References.Insert(index+1, elem);

      lstChildClasses.Items.RemoveAt(index);
      lstChildClasses.Items.Insert(index + 1, elem.Name);
      
    }

    private void OnChildClassesMouseDoubleClick(object sender, MouseEventArgs e)
    {
      RemoveReferences();
    }

    private void RemoveReferences()
    {
      if (Current == null || Initializing) return;
      var selected = lstChildClasses.SelectedItem;
      if (selected == null) return;

        lstChildClasses.Items.Remove(selected);
        var reference = Current.References.FirstOrDefault(r => r.Name == (string)selected);
        if (reference != null)
        Current.References.Remove(reference);

    }


    private void AddReferences()
    {
      if (Current == null || Initializing) return;
      var selected = lstAllClasses.SelectedItems;
      if (selected == null) return;

      foreach (var item in selected)
      {
        if (lstChildClasses.Items.Contains(item)) continue;

        lstChildClasses.Items.Add(item);
        Current.References.Add(new DeviserReferenceAttribute { Name = (string)item, Document = Current.Document });
      }
    }
    private void OnAllClassesMouseDoubleClick(object sender, MouseEventArgs e)
    {
      AddReferences();
    }

    private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      if (Current == null || Initializing) return;

      var row = gridAttributes.Rows[e.RowIndex];
      var attribute = Current.Attributes[e.RowIndex];

      switch (e.ColumnIndex)
      {
        case 0:
          attribute.Name = row.Cells[0].Value as string;
          break;
        case 1:
          attribute.Type = row.Cells[1].Value as string;
          break;
        case 2:
          attribute.Required = (bool)row.Cells[2].Value;
          break;
        case 3:
          attribute.Element = row.Cells[3].Value as string;
          break;
        case 4:
          attribute.Abstract = (bool)row.Cells[4].Value;
          break;
      }
    }

    private void cmdAddAttribute_Click(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;

      var newAttr = new DeviserAttribute { Name = "Attribute" + (Current.Attributes.Count + 1).ToString() };
      Current.Attributes.Add(newAttr);

      gridAttributes.Rows.Add(newAttr.Name, newAttr.Type, newAttr.Required, newAttr.Element, newAttr.Abstract);

    }

    private void txtExtensionPoint_Leave(object sender, EventArgs e)
    {
      OnRenamedEvent();
    }
  }
}
