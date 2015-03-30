using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsDeviser.Forms;
using CsDeviser.Controls;
using LibDeviser;

namespace CsDeviser
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();

      controlClass1.RenamedEvent += (o, e) => UpdateUI();
      controlPackage1.RenamedEvent += (o, e) => UpdateUI();
      controlPlugin1.RenamedEvent += (o, e) => UpdateUI();
      controlEnum1.RenamedEvent += (o, e) => UpdateUI();

      NewDocument();
    }

    const string NODE_PACKAGE = "nodePackage";
    const string NODE_ENUMS = "nodeEnums";
    const string NODE_CLASSES = "nodeClasses";
    const string NODE_PLUGINS = "nodePlugins";

    public DeviserPackage Model { get; set; }

    public DeviserBase Current { get; set; }

    public DeviserControl CurrentControl
    {
      get
      {
        if (controlPackage1.Visible) return controlPackage1;
        if (controlClass1.Visible) return controlClass1;
        if (controlPlugin1.Visible) return controlPlugin1;
        if (controlEnum1.Visible) return controlEnum1;

        return null;
      }
    }

    void CommitControls()
    {
      var current = CurrentControl;
      if (current == null) return;
      current.OnCommitChanges();
    }


    public string FileName { get; set; }

    private void UpdateTitle()
    {
      if (string.IsNullOrWhiteSpace(FileName))
        FileName = "untitled.xml";

      Text = "Deviser [ " + Path.GetFileName(FileName) + " ]";
    }
    public void UpdateUI()
    {

      tree.Nodes[NODE_CLASSES].Nodes.Clear();

      if (Model != null)
      {
        foreach (var item in Model.Elements)
        {
          tree.Nodes[NODE_CLASSES].Nodes.Add(item.Name);
        }
      }

      tree.Nodes[NODE_PLUGINS].Nodes.Clear();
      if (Model != null)
      {
        foreach (var item in Model.Plugins)
        {
          tree.Nodes[NODE_PLUGINS].Nodes.Add(item.ExtensionPoint);
        }
      }

      tree.Nodes[NODE_ENUMS].Nodes.Clear();
      if (Model != null)
      {
        foreach (var item in Model.Enums)
        {
          tree.Nodes[NODE_ENUMS].Nodes.Add(item.Name);
        }
      }


      UpdateTitle();

      if (Current == null)
        Current = Model;

      UpdateFromCurrent();

    }

    private void UpdateFromCurrent()
    {
      if (Current == null)
      {
        controlPackage1.Visible = false;
        controlClass1.Visible = false;
        controlPlugin1.Visible = false;
        controlEnum1.Visible = false;
        return;
      }

      if (Current is DeviserPackage)
      {
        controlClass1.Visible = false;
        controlPlugin1.Visible = false;
        controlPackage1.Visible = true;
        controlEnum1.Visible = false;
        controlPackage1.InitializeFrom(Current as DeviserPackage);
        return;
      }

      if (Current is DeviserPlugin)
      {
        controlClass1.Visible = false;
        controlPlugin1.Visible = true;
        controlPackage1.Visible = false;
        controlEnum1.Visible = false;
        controlPlugin1.InitializeFrom(Current as DeviserPlugin);
        return;
      }

      if (Current is DeviserClass)
      {
        controlClass1.Visible = true;
        controlPlugin1.Visible = false;
        controlPackage1.Visible = false;
        controlEnum1.Visible = false;
        controlClass1.InitializeFrom(Current as DeviserClass);
        return;
      }

      if (Current is DeviserEnum)
      {
        controlClass1.Visible = false;
        controlPlugin1.Visible = false;
        controlPackage1.Visible = false;
        controlEnum1.Visible = true;
        controlEnum1.InitializeFrom(Current as DeviserEnum);
      }


    }


    private void OnItemSelect(object sender, TreeViewEventArgs e)
    {
      if (e.Node.Level == 0)        
        Current = Model;

      if (e.Node.Level == 1 && e.Node.Parent.Name == NODE_CLASSES)
      {
        Current = Model.GetElement(e.Node.Text);
      }
      if (e.Node.Level == 1 && e.Node.Parent.Name == NODE_PLUGINS)
      {
        Current = Model.GetPlugin(e.Node.Text);
      }

      if (e.Node.Level == 1 && e.Node.Parent.Name == NODE_ENUMS)
      {
        Current = Model.GetEnum(e.Node.Text);
      }

      UpdateFromCurrent();

    }

    private void NewDocument()
    {
      Model = new DeviserPackage { Name = "Package1"};
      FileName = "untitled.xml";
      Current = Model;
      UpdateUI();
    }

    private void OnNewClick(object sender, EventArgs e)
    {
      if (SaveModelIfDirtyOrCancel())
        return;

      NewDocument();
    }

    public void LoadFile(string fileName)
    {      

      Model = DeviserPackage.FromFile(fileName);
      FileName = fileName;
      Current = Model;
      Model.Dirty = false;
      UpdateUI();
      tree.ExpandAll();
    }

    private void OnOpenClick(object sender, EventArgs e)
    {
      if (SaveModelIfDirtyOrCancel())
        return;

      using (var dialog = new OpenFileDialog
      {
        AutoUpgradeEnabled = true,
        Filter = "Xml files|*.xml|All files|*.*",
        Title = "Open Deviser Package"
      })
      {
        if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        {
          LoadFile(dialog.FileName);
        }
      }
      
    }

    private void SaveAs(string fileName = "")
    {
      if (string.IsNullOrWhiteSpace(fileName) || fileName == "untitled.xml")
      {
        using (var dialog = new SaveFileDialog
        {
          AutoUpgradeEnabled = true,
          Filter = "Xml files|*.xml|All files|*.*",
          Title = "Save Deviser Package"
        })
        {
          if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
          {
            fileName = dialog.FileName;
          }
          else
            return;
        }  
      }


      CommitControls();
      Model.WriteTo(fileName);
      FileName = fileName;
      Model.Dirty = false;

      UpdateTitle();
    }

    private void OnSaveClick(object sender, EventArgs e)
    {
      SaveAs(FileName);
    }

    private void OnSaveAsClick(object sender, EventArgs e)
    {
      SaveAs();
    }

    private void OnExitClick(object sender, EventArgs e)
    {
      Close();
    }

    private void OnAboutClick(object sender, EventArgs e)
    {
      using (var dialog = new AboutBox())
      {
        dialog.ShowDialog();
      }
    }

    private void OnAddClassClick(object sender, EventArgs e)
    {
      var element = new DeviserClass { Name = "Class" + (Model.Elements.Count + 1).ToString(), Document = Model };
      Model.Elements.Add(element);
      tree.Nodes[NODE_CLASSES].Nodes.Add(element.Name);
      Current = element;
      Model.Dirty = true;
      UpdateFromCurrent();
    }

    private void OnAddEnumClick(object sender, EventArgs e)
    {
      var element = new DeviserEnum { Name = "Enum" + (Model.Enums.Count + 1).ToString(), Document = Model };
      Model.Enums.Add(element);
      tree.Nodes[NODE_ENUMS].Nodes.Add(element.Name);
      Current = element;
      Model.Dirty = true;
      UpdateFromCurrent();

    }


    private void OnAddPluginClick(object sender, EventArgs e)
    {
      var element = new DeviserPlugin { ExtensionPoint = "Extension" + (Model.Plugins.Count + 1).ToString(), Document = Model };
      Model.Plugins.Add(element);
      tree.Nodes[NODE_PLUGINS].Nodes.Add(element.ExtensionPoint);
      Current = element;
      Model.Dirty = true;
      UpdateFromCurrent();
    }

    private void OnDeleteClick(object sender, EventArgs e)
    {
      if (tree.SelectedNode == null) return;
      if (tree.SelectedNode.Level == 0) return;

      if (tree.SelectedNode.Parent.Name == NODE_CLASSES)
      {
        Model.Elements.Remove(Model.GetElement(tree.SelectedNode.Text));
        Current = Model.Elements.LastOrDefault();
        if (Current == null)
          Current = Model;
      }

      if (tree.SelectedNode.Parent.Name == NODE_PLUGINS)
      {
        Model.Plugins.Remove(Model.GetPlugin(tree.SelectedNode.Text));
        Current = Model.Plugins.LastOrDefault();
        if (Current == null)
          Current = Model;
      }

      Model.Dirty = true;
      UpdateUI();
    }

    private void cmdRefresh_Click(object sender, EventArgs e)
    {
      UpdateUI();
    }

    private void OnValidateDescriptionClick(object sender, EventArgs e)
    {
      var log = Model.AnalyzeDescription(false);

      if (log.Count == 0)
      {
        MessageBox.Show(
          "Could not find inconsistencies.",
          "Could not find inconsistencies.",
          MessageBoxButtons.OK,
          MessageBoxIcon.Information
          );
      }
      else
      {
        var builder = new StringBuilder();
        builder.AppendLine("Found the following inconsistencies: ");
        builder.AppendLine();
        foreach (var item in log)
          builder.AppendLine(item.Message);
        builder.AppendLine();
        builder.AppendLine("Would you like to correct them?");

        if (MessageBox.Show(
          builder.ToString(),
          "Found inconsistencies.",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Warning
          ) == System.Windows.Forms.DialogResult.Yes)
        {
          Model.AnalyzeDescription(true);
        }
      }

    }

    private void OnFixErrorsClick(object sender, EventArgs e)
    {
      var log = Model.AnalyzeDescription(true);
      if (log.Count > 0)
      {
        var builder = new StringBuilder();
        builder.AppendLine("Corrected the following inconsistencies: ");
        builder.AppendLine();
        foreach (var item in log)
          builder.AppendLine(item.Message);
        builder.AppendLine();

        MessageBox.Show(builder.ToString(),
          "Correctd inconsistencies.",
          MessageBoxButtons.OK,
          MessageBoxIcon.Information
          );
        

      }
    }

    #region Drag / Drop

    private void MainForm_DragDrop(object sender, DragEventArgs e)
    {
      try
      {
        var sFilenames = (string[])e.Data.GetData(DataFormats.FileDrop);
        var oInfo = new FileInfo(sFilenames[0]);
        if (oInfo.Extension.ToLower() == ".xml")
        {
          LoadFile(sFilenames[0]);
        }
      }
      catch (Exception)
      {
      }
    }

    private void MainForm_DragEnter(object sender, DragEventArgs e)
    {
      if (e.Data.GetDataPresent(DataFormats.FileDrop))
      {
        var sFilenames = (string[])e.Data.GetData(DataFormats.FileDrop);
        var oInfo = new FileInfo(sFilenames[0]);
        if (oInfo.Extension.ToLower() == ".xml")
        {
          e.Effect = DragDropEffects.Copy;
          return;
        }
      }
      e.Effect = DragDropEffects.None;
    }

    #endregion

    /// <summary>
    /// This function asks a user whether the model should be saved
    /// </summary>
    /// <returns>true, if model is dirty and the user pressed cancel, false otherwise</returns>
    private bool SaveModelIfDirtyOrCancel()
    {
      if (Model == null || !Model.Dirty) return false;

      DialogResult result =
        MessageBox.Show(this,
          "There are unsaved changes in the model. Would you like to save them?",
          "Save changes?",
          MessageBoxButtons.YesNoCancel,
          MessageBoxIcon.Question,
          MessageBoxDefaultButton.Button3);

      if (result == DialogResult.Cancel)
      {
        return true;
      }

      if (result == DialogResult.Yes)
      {
        OnSaveClick(this, EventArgs.Empty);
      }

      return false;
    }
    private void OnFormClosing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = SaveModelIfDirtyOrCancel();
    }

    private void OnEditPreferences(object sender, EventArgs e)
    {
      using (var dlg = new FormPreferences())
      {
        dlg.LoadSettings(DeviserSettings.Instance);
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          dlg.WriteToSettings(DeviserSettings.Instance);
          DeviserSettings.Instance.Save();
          toolGenerate.Enabled = DeviserSettings.Instance.CanGenerate;
        }
      }
    }

    private void OnLoad(object sender, EventArgs e)
    {
      DeviserSettings.Instance = DeviserSettings.GetDefault(Size);
      toolGenerate.Enabled = DeviserSettings.Instance.CanGenerate;
    }

    private void OnGenerateClick(object sender, EventArgs e)
    {
      if (!DeviserSettings.Instance.CanGenerate)
        return;

      using (var dlg = new FormGenerate { Package = FileName, PackageName = Model.Name})
        dlg.ShowDialog(this);

    }

    private void cmdViewUML_Click(object sender, EventArgs e)
    {
      using (var dlg = new FormYuml {})
      {
        dlg.InitializeFrom(Model);
        dlg.ShowDialog(this);
      }
    }

  }
}
