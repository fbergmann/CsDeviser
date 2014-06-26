﻿using System;
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
  public partial class ControlClass : UserControl
  {
    public ControlClass()
    {
      InitializeComponent();
    }


    public bool Initializing { get; set; }

    public event EventHandler RenamedEvent;

    protected virtual void OnRenamedEvent()
    {
      var handler = RenamedEvent;
      if (handler != null) handler(this, EventArgs.Empty);
    }

    public DeviserClass Current { get; set; }

    public void InitializeFrom(DeviserClass package)
    {
      Current = null;

      txtName.Text = "";
      txtBaseClass.Text = "";
      txtElementName.Text = "";
      txtTypeCode.Text = "";

      gridConcrete.Rows.Clear();
      gridAttributes.Rows.Clear();

      splitContainer1.Panel2Collapsed = true;
      cmdAddConcrete.Visible = false;
      cmdDelConcrete.Visible = false;

      Current = package;

      if (Current == null) return;
      Initializing = true;
      txtName.Text = Current.Name;
      txtBaseClass.Text = Current.BaseClass;
      txtElementName.Text = Current.ElementName;
      txtTypeCode.Text = Current.TypeCode;

      chkAbstract.Checked = Current.Abstract;
      splitContainer1.Panel2Collapsed = !Current.Abstract;
      cmdAddConcrete.Visible = Current.Abstract;
      cmdDelConcrete.Visible = Current.Abstract;
      chkHasChildren.Checked = Current.HasChildren;
      chkHasListOf.Checked = Current.HasListOf;
      chkHasMath.Checked = Current.HasMath;


      foreach( var newAttr in Current.Attributes)
      gridAttributes.Rows.Add(newAttr.Name, newAttr.Type, newAttr.Required, newAttr.Element, newAttr.Abstract);

      foreach (var newAttr in Current.Concretes)
      gridAttributes.Rows.Add(newAttr.Name, newAttr.Element);

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
      Current.Abstract = chkAbstract.Checked;
      splitContainer1.Panel2Collapsed = !Current.Abstract;
      cmdAddConcrete.Visible = Current.Abstract;
      cmdDelConcrete.Visible = Current.Abstract;

    }

    private void cmdAddAttribute_Click(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;

      var newAttr = new DeviserAttribute { Name = "Attribute" + (Current.Attributes.Count + 1).ToString() };
      Current.Attributes.Add(newAttr);

      var row = gridAttributes.Rows.Add(newAttr.Name, newAttr.Type, newAttr.Required, newAttr.Element, newAttr.Abstract);
      gridAttributes.Rows[row].Selected = true;
      gridAttributes.Focus();

    }

    private void cmdAddConcrete_Click(object sender, EventArgs e)
    {
      if (Current == null || Initializing) return;
      var newAttr = new DeviserConcrete { Name = "Concrete" + (Current.Attributes.Count + 1).ToString() };
      Current.Concretes.Add(newAttr);

      var row = gridConcrete.Rows.Add(newAttr.Name, newAttr.Element);
      gridConcrete.Rows[row].Selected = true;
      gridConcrete.Focus();
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

    private void gridConcrete_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
      if (Current == null || Initializing) return;
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

  }
}
