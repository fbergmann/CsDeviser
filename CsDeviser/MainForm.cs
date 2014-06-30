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
      NewDocument();
    }

    public void LoadFile(string fileName)
    {
      Model = DeviserPackage.FromFile(fileName);
      FileName = fileName;
      Current = Model;
      UpdateUI();
      tree.ExpandAll();
    }

    private void OnOpenClick(object sender, EventArgs e)
    {
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
      if (string.IsNullOrWhiteSpace(FileName) || FileName == "untitled.xml")
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
        }  
      }

      Model.WriteTo(fileName);
      FileName = fileName;
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
      UpdateFromCurrent();
    }

    private void OnAddEnumClick(object sender, EventArgs e)
    {
      var element = new DeviserEnum { Name = "Enum" + (Model.Enums.Count + 1).ToString(), Document = Model };
      Model.Enums.Add(element);
      tree.Nodes[NODE_ENUMS].Nodes.Add(element.Name);
      Current = element;
      UpdateFromCurrent();

    }


    private void OnAddPluginClick(object sender, EventArgs e)
    {
      var element = new DeviserPlugin { ExtensionPoint = "Extension" + (Model.Plugins.Count + 1).ToString(), Document = Model };
      Model.Plugins.Add(element);
      tree.Nodes[NODE_PLUGINS].Nodes.Add(element.ExtensionPoint);
      Current = element;
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

  }
}
