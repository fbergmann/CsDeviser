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
  public partial class ControlClass : DeviserControl
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
      txtBaseClass.Text = "";
      txtElementName.Text = "";
      txtTypeCode.Text = "";

      txtListOfName.Text = "";
      txtListOfClassName.Text = "";
      txtAddDecls.Text = "";
      txtAddImpls.Text = "";

      txtMinNoChildren.Text = "";
      txtMaxNoChildren.Text = "";

      chkRequiresAdditionalCode.Checked = false;
      grpAdditionalFiles.Visible = false;

      gridConcrete.Rows.Clear();
      gridAttributes.Rows.Clear();
      gridLoAttributes.Rows.Clear();

      splitContainer1.Panel2Collapsed = true;
      splitContainer2.Panel2Collapsed = true;


      Current = package;

      if (Current == null) return;
      Initializing = true;
      txtName.Text = Current.Name;
      txtBaseClass.Text = Current.BaseClass;
      txtElementName.Text = Current.ElementName;
      txtTypeCode.Text = Current.TypeCode;
      txtListOfName.Text = Current.ListOfName;
      txtListOfClassName.Text = Current.ListOfClassName;
      txtAddDecls.Text = Current.AdditionalDeclarations;
      txtAddImpls.Text = Current.AdditionalDefinitions;
      chkRequiresAdditionalCode.Checked = Current.HasAdditionalCode;
      grpAdditionalFiles.Visible = Current.HasAdditionalCode;
      txtMinNoChildren.Text = Current.MinNumberChildren.ToString();
      txtMaxNoChildren.Text = Current.MaxNumberChildren.ToString();


      chkIsBaseClass.Checked = Current.IsBaseClass;
      splitContainer1.Panel2Collapsed = !Current.IsBaseClass;
      chkHasChildren.Checked = Current.HasChildren;
      chkHasListOf.Checked = Current.HasListOf;
      pnlLoClassName.Visible = Current.HasListOf;
      pnlLoName.Visible = Current.HasListOf;
      splitContainer2.Panel2Collapsed = !Current.HasListOf;

      chkChildrenOverwriteElementName.Checked = Current.ChildrenOverwriteElementName;
      chkHasMath.Checked = Current.HasMath;

      foreach( var newAttr in Current.Attributes)
        gridAttributes.Rows.Add(newAttr.Name, newAttr.Type, newAttr.Element, newAttr.Required, newAttr.Abstract, newAttr.XMLName);

      foreach (var newAttr in Current.ListOfAttributes)
        gridLoAttributes.Rows.Add(newAttr.Name, newAttr.Type, newAttr.Element, newAttr.Required, newAttr.Abstract, newAttr.XMLName);

      foreach (var newAttr in Current.Concretes)
        gridConcrete.Rows.Add(newAttr.Name, newAttr.Element, newAttr.MinNumChildren == 0 ? "" : newAttr.MinNumChildren.ToString(), newAttr.MaxNumChildren == 0 ? "": newAttr.MaxNumChildren.ToString());

      Initializing = false;
    }

    private void txtName_TextChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      Current.Name= txtName.Text;

    }

    private void txtBaseClass_TextChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      Current.BaseClass = txtBaseClass.Text;

    }


    private void txtListOfClassName_TextChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      Current.ListOfClassName = txtListOfClassName.Text;

    }


    private void txtTypeCode_TextChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      Current.TypeCode = txtTypeCode.Text;

    }

    private void txtElementName_TextChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      Current.ElementName= txtElementName.Text;

    }

    private void chkHasListOf_CheckedChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      Current.HasListOf = chkHasListOf.Checked;
      splitContainer2.Panel2Collapsed = !Current.HasListOf;
      pnlLoClassName.Visible = Current.HasListOf;
      pnlLoName.Visible = Current.HasListOf;

    }

    private void chkHasChildren_CheckedChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      Current.HasChildren= chkHasChildren.Checked;

    }

    private void chkHasMath_CheckedChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      Current.HasMath = chkHasMath.Checked;

    }

    private void chkAbstract_CheckedChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      Current.IsBaseClass = chkIsBaseClass.Checked;
      splitContainer1.Panel2Collapsed = !Current.IsBaseClass;

    }

    private void OnAddAttributeClick(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;

      var newAttr = new DeviserAttribute { Name = "Attribute" + (Current.Attributes.Count + 1).ToString() };
      Current.Attributes.Add(newAttr);

      var row = gridAttributes.Rows.Add(newAttr.Name, newAttr.Type, newAttr.Element, newAttr.Required, newAttr.Abstract, newAttr.XMLName);
      gridAttributes.CurrentCell = gridAttributes[0, row];
      gridAttributes.Focus();
      gridAttributes.BeginEdit(true);

    }

    private void OnAddConcreteClick(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      var newAttr = new DeviserConcrete { Name = "Concrete" + (Current.Concretes.Count + 1).ToString() };
      Current.Concretes.Add(newAttr);

      var row = gridConcrete.Rows.Add(newAttr.Name, newAttr.Element, newAttr.MinNumChildren == 0 ? "" : newAttr.MinNumChildren.ToString(), newAttr.MaxNumChildren == 0 ? "": newAttr.MaxNumChildren.ToString());
      gridConcrete.CurrentCell = gridConcrete[0, row];
      gridConcrete.Focus();
      gridConcrete.BeginEdit(true);

    }

    private void gridAttributes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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

    }

    private void gridConcrete_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      if (Current == null || Initializing) return;

      var row = gridConcrete.Rows[e.RowIndex];
      var attribute = Current.Concretes[e.RowIndex];

      switch (e.ColumnIndex)
      {
        case 0:
          attribute.Name = row.Cells[0].Value as string;
          break;
        case 1:
          attribute.Element = row.Cells[1].Value as string;
          break;
        case 2:
        {
          string strVal = row.Cells[2].Value as string;
          attribute.MinNumChildren = strVal.ToInt();
          break;
        }
        case 3:
        {
          string strVal = row.Cells[3].Value as string;
          attribute.MaxNumChildren = strVal.ToInt();
          break;
        }
      }
    }

    private void txtName_Leave(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      OnRenamedEvent();
    }

    private void OnRemoveAttrClick(object sender, EventArgs e)
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
    }

    private void OnRemoveConcreteClick(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      var row = gridConcrete.SelectedRows;
      for (int i = row.Count - 1; i >= 0; i--)
      {
        gridConcrete.Rows.Remove(row[i]);
        var attr = Current.Concretes.FirstOrDefault(a => a.Name == row[i].Cells[0].Value as string);
        if (attr != null)
          Current.Concretes.Remove(attr);
      }      
    }

    private void chkChildrenOverwriteElementName_CheckedChanged(object sender, EventArgs e)
    {
      if (Current == null) return;
      Current.ChildrenOverwriteElementName = chkChildrenOverwriteElementName.Checked;
    }

    private void txtListOfName_TextChanged(object sender, EventArgs e)
    {
      if (Current == null) return;
      Current.ListOfName = txtListOfName.Text;
    }

    private void txtAddDecl_TextChanged(object sender, EventArgs e)
    {
      if (Current == null) return;
      Current.AdditionalDeclarations = txtAddDecls.Text;
    }

    private void txtAddImpl_TextChanged(object sender, EventArgs e)
    {
      if (Current == null) return;
      Current.AdditionalDefinitions = txtAddImpls.Text;
    }

    public override void OnCommitChanges()
    {
      gridAttributes.EndEdit();
      gridLoAttributes.EndEdit();
      gridConcrete.EndEdit();
    }

    private void gridLoAttributes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      if (Current == null || Initializing) return;

      var row = gridLoAttributes.Rows[e.RowIndex];
      var attribute = Current.ListOfAttributes[e.RowIndex];

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
    }

    private void OnAddLoAttributeClick(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;

      var newAttr = new DeviserListOfAttribute { Name = "ListOfAttribute" + (Current.ListOfAttributes.Count + 1).ToString() };
      Current.ListOfAttributes.Add(newAttr);

      var row = gridLoAttributes.Rows.Add(newAttr.Name, newAttr.Type, newAttr.Element, newAttr.Required, newAttr.Abstract, newAttr.XMLName);
      gridLoAttributes.CurrentCell = gridLoAttributes[0, row];
      gridLoAttributes.Focus();
      gridLoAttributes.BeginEdit(true);
    }

    private void OnRemoveLoAttributeClick(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      var row = gridLoAttributes.SelectedRows;
      for (int i = row.Count - 1; i >= 0; i--)
      {
        gridLoAttributes.Rows.Remove(row[i]);
        var attr = Current.ListOfAttributes.FirstOrDefault(a => a.Name == row[i].Cells[0].Value as string);
        if (attr != null)
          Current.ListOfAttributes.Remove(attr);
      }
    }

    private void OnCheckRequiresAdditionalCodeCheckedChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
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
        }
      }
    }

    private void txtMaxNoChildren_TextChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      int val;
      if (int.TryParse(txtMaxNoChildren.Text, out val))
        Current.MaxNumberChildren = val;
    }

    private void txtMinNoChildren_TextChanged(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      int val;
      if (int.TryParse(txtMinNoChildren.Text, out val))
        Current.MinNumberChildren = val;
    }
  }
}
