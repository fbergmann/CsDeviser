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
  public partial class ControlPlugin : DeviserControl
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
      txtAddDecls.Text = "";
      txtAddImpls.Text = "";

      lstAllClasses.Items.Clear();
      lstChildClasses.Items.Clear();
      gridAttributes.Rows.Clear();

      splitContainer1.Panel2Collapsed = true;
      chkRequiresAdditionalCode.Checked = false;
      chkElementFromCore.Checked = true;
      grpAdditionalFiles.Visible = false;
      pnlPackage.Visible = !chkElementFromCore.Checked;

      Current = package;

      if (Current == null) return;

      Initializing = true;

      txtExtensionPoint.Text = Current.ExtensionPoint;
      txtAddDecls.Text = Current.AdditionalDeclarations;
      txtAddImpls.Text = Current.AdditionalDefinitions;
      txtTypeCode.Text = Current.TypeCode;
      txtPackage.Text = Current.Package;
      chkElementFromCore.Checked = Util.CoreClasses.Contains(Current.ExtensionPoint);
      pnlPackage.Visible = !chkElementFromCore.Checked;

      if (Current.Attributes.Count > 0)
      {
        chkHasAdditional.Checked = true;
        splitContainer1.Panel2Collapsed = false;
      }
      else
      {
        chkHasAdditional.Checked = false;
      }
      
      if (Current.Document != null)
      foreach (var item in Current.Document.Elements)
      { 
        lstAllClasses.Items.Add(item.Name);
        if (item.HasListOf)
        {
          lstAllClasses.Items.Add(item.GetListOfName());
        }
      }

      foreach (var newAttr in Current.References)
        lstChildClasses.Items.Add(newAttr.Name);

      foreach (var newAttr in Current.Attributes)
        gridAttributes.Rows.Add(newAttr.Name, newAttr.Type, newAttr.Element, newAttr.Required, newAttr.Abstract, newAttr.XMLName);

      Initializing = false;
    }

    private void txtExtensionPoint_TextChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      Current.ExtensionPoint= txtExtensionPoint.Text;
      Current.Dirty = true;
    }

    private void chkHasAdditional_CheckedChanged(object sender, EventArgs e)
    {
      splitContainer1.Panel2Collapsed = !chkHasAdditional.Checked;
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

      lstChildClasses.SelectedIndex = index - 1;
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

      lstChildClasses.SelectedIndex = index + 1;
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
      Current.Dirty = true;
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
      Current.Dirty = true;
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
        case 3:
          attribute.Required = (bool)row.Cells[3].Value;
          break;
        case 2:
          attribute.Element = row.Cells[2].Value as string;
          break;
        case 4:
          attribute.Abstract = (bool)row.Cells[4].Value;
          break;
        case 5:
          attribute.XMLName = row.Cells[5].Value as string;
          break;
      }
      Current.Dirty = true;
    }

    private void cmdAddAttribute_Click(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;

      var newAttr = new DeviserAttribute { Name = "Attribute" + (Current.Attributes.Count + 1).ToString() };
      Current.Attributes.Add(newAttr);

      var row = gridAttributes.Rows.Add(newAttr.Name, newAttr.Type, newAttr.Element, newAttr.Required, newAttr.Abstract, newAttr.XMLName);
      gridAttributes.CurrentCell = gridAttributes[0, row];
      gridAttributes.Focus();
      gridAttributes.BeginEdit(true);
      Current.Dirty = true;
    }

    private void txtExtensionPoint_Leave(object sender, EventArgs e)
    {
      OnRenamedEvent();
    }

    private void cmdDelAttr_Click(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;

      var row = gridAttributes.SelectedRows;
      for (int i = row.Count - 1; i >= 0; i--)
      {
        gridAttributes.Rows.Remove(row[i]);
        var attr = Current.Attributes.FirstOrDefault(a => a.Name == row[i].Cells[0].Value as string);
        if (attr != null)
          Current.Attributes.Remove(attr);
      }
      Current.Dirty = true;
    }

    private void txtAddImpls_TextChanged(object sender, EventArgs e)
    {
      if (Current == null) return;
      Current.AdditionalDefinitions = txtAddImpls.Text;
      Current.Dirty = true;
    }

    private void txtAddDecls_TextChanged(object sender, EventArgs e)
    {
      if (Current == null) return;
      Current.AdditionalDeclarations = txtAddDecls.Text;
      Current.Dirty = true;
    }


    public override void OnCommitChanges()
    {
      gridAttributes.EndEdit();
    }

    private void txtTypeCode_TextChanged(object sender, EventArgs e)
    {
      if (Current == null) return;
      Current.TypeCode = txtTypeCode.Text;
      Current.Dirty = true;
    }

    private void txtPackage_TextChanged(object sender, EventArgs e)
    {
      if (Current == null) return;
      Current.Package = txtPackage.Text;
      Current.Dirty = true;
    }

    private void OnCheckRequiresAdditionalCodeCheckedChanged(object sender, EventArgs e)
    {
      if (Current == null) return;
      grpAdditionalFiles.Visible = chkRequiresAdditionalCode.Checked;
    }

    private void OnBrowseDeclsClick(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      using (var dlg = new OpenFileDialog { Title = "Select Declaration file", Filter = "Header files|*.h;*.hxx;*.h++;*.hpp;*.hh|All files|*.*" })
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

    private void chkElementFromCore_CheckedChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      pnlPackage.Visible = !chkElementFromCore.Checked;
    }

  }
}
