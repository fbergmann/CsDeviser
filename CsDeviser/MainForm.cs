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
      controlVersion1.RenamedEvent += (o, e) => 
      {
        Current = Model.CurrentVersion;
        UpdateUI();
        SelectPath(Current.ToString());
      }; 

      NewDocument();
    }

    const string NODE_PACKAGE = "nodePackage";
    const string NODE_VERSIONS = "nodeVersions";
    const string NODE_MAPPINGS = "nodeMappings";
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
        if (controlMappings1.Visible) return controlMappings1;
        if (controlVersion1.Visible) return controlVersion1;

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

      Text = string.Format("Deviser Edit [ {0} ]", Path.GetFileName(FileName));
    }

    bool initializing = false;

    public void UpdateUI()
    {
      initializing = true;
      var path = tree.SelectedNode == null ? null : tree.SelectedNode.FullPath;

      var versionsNode = tree;
      for (int i = versionsNode.Nodes.Count - 1; i >= 1; --i)
        versionsNode.Nodes.RemoveAt(i);

      if (Model != null)
        foreach (var version in Model.Versions)
        {
          var currentVersion = versionsNode.Nodes.Add(version.ToString());
          currentVersion.Name = version.ToString();
          currentVersion.Tag = version;

          var classNode = new TreeNode { Name =  NODE_CLASSES, Text = "Classes"};
          var pluginNode = new TreeNode { Name = NODE_PLUGINS, Text = "Plugins" };
          var enumNode = new TreeNode { Name = NODE_ENUMS, Text = "Enums" };
          var mappingsNode = new TreeNode { Name = NODE_MAPPINGS, Text = "Mappings" };

          currentVersion.Nodes.Add(mappingsNode);
          currentVersion.Nodes.Add(classNode);
          currentVersion.Nodes.Add(pluginNode);
          currentVersion.Nodes.Add(enumNode);

          foreach (var item in version.Elements)
          {
            classNode.Nodes.Add(item.Name);
          }

          foreach (var item in version.Plugins)
          {
            pluginNode.Nodes.Add(item.ExtensionPoint);
          }

          foreach (var item in version.Enums)
          {
            enumNode.Nodes.Add(item.Name);
          }

        }

      SelectPath(path);

      UpdateTitle();

      if (Current == null)
        Current = Model;

      UpdateFromCurrent();

      initializing = false;
    }


    public void SelectPath(string path)
    {
      if (string.IsNullOrWhiteSpace(path))
        return;

      var path_list = path.Split('\\').ToList();
      foreach (TreeNode node in tree.Nodes)
        if (path_list.Count > 0 && node.Text == path_list[0])
          ExpandNodes(node, path_list);

    }

    private void ExpandNodes(TreeNode node, List<string> path)
    {
      path.RemoveAt(0);

      node.Expand();
      tree.SelectedNode = node;

      foreach (TreeNode mynode in node.Nodes)
      {
        if (path.Count == 0)
          return;
        if (mynode.Text == path[0])
          ExpandNodes(mynode, path); //recursive call
      }


    }


    private void UpdateFromCurrent()
    {
      if (Current == null)
      {
        controlPackage1.Visible = false;
        controlClass1.Visible = false;
        controlPlugin1.Visible = false;
        controlEnum1.Visible = false;
        controlMappings1.Visible = false;
        controlVersion1.Visible = false;
        return;
      }

      if (Current is DeviserPackage)
      {
        controlClass1.Visible = false;
        controlPlugin1.Visible = false;
        controlPackage1.Visible = true;
        controlEnum1.Visible = false;
        controlMappings1.Visible = false;
        controlVersion1.Visible = false;
        controlPackage1.InitializeFrom(Current as DeviserPackage);
        return;
      }

      if (Current is DeviserPlugin)
      {
        controlClass1.Visible = false;
        controlPlugin1.Visible = true;
        controlPackage1.Visible = false;
        controlEnum1.Visible = false;
        controlMappings1.Visible = false;
        controlVersion1.Visible = false;
        controlPlugin1.InitializeFrom(Current as DeviserPlugin);
        return;
      }

      if (Current is DeviserClass)
      {
        controlClass1.Visible = true;
        controlPlugin1.Visible = false;
        controlPackage1.Visible = false;
        controlEnum1.Visible = false;
        controlMappings1.Visible = false;
        controlVersion1.Visible = false;
        controlClass1.InitializeFrom(Current as DeviserClass);
        return;
      }

      if (Current is DeviserEnum)
      {
        controlClass1.Visible = false;
        controlPlugin1.Visible = false;
        controlPackage1.Visible = false;
        controlEnum1.Visible = true;
        controlMappings1.Visible = false;
        controlVersion1.Visible = false;
        controlEnum1.InitializeFrom(Current as DeviserEnum);
      }

      if (Current is DeviserMapping)
      {
        controlClass1.Visible = false;
        controlPlugin1.Visible = false;
        controlPackage1.Visible = false;
        controlEnum1.Visible = false;
        controlMappings1.Visible = true;
        controlVersion1.Visible = false;
        controlMappings1.InitializeFrom(Model.CurrentVersion);
      }

      if (Current is DeviserVersion)
      {
        controlClass1.Visible = false;
        controlPlugin1.Visible = false;
        controlPackage1.Visible = false;
        controlEnum1.Visible = false;
        controlMappings1.Visible = false;
        controlVersion1.Visible = true;
        controlVersion1.InitializeFrom(Current as DeviserVersion);
      }

    }


    private void OnItemSelect(object sender, TreeViewEventArgs e)
    {
      if (initializing) return;

      if (e.Node.Level == 0 && !e.Node.Name.StartsWith("Version") )
        Current = Model;

      if (e.Node.Level == 1 && e.Node.Name == NODE_MAPPINGS)
      {
        Current = new DeviserMapping();
        Model.CurrentVersion = e.Node.Parent.Tag as DeviserVersion;
      }

      if (e.Node.Text.StartsWith("Version"))
      {
        Current = e.Node.Tag as DeviserVersion;
        Model.CurrentVersion = Current as DeviserVersion;
      }

      if (e.Node.Level == 2 && e.Node.Parent.Name == NODE_CLASSES)
      {
        Current = Model.GetElement(e.Node.Text, e.Node.Parent.Parent.Tag);
      }
      
      if (e.Node.Level == 2 && e.Node.Parent.Name == NODE_PLUGINS)
      {
        Current = Model.GetPlugin(e.Node.Text, e.Node.Parent.Parent.Tag);
      }

      if (e.Node.Level == 2 && e.Node.Parent.Name == NODE_ENUMS)
      {
        Current = Model.GetEnum(e.Node.Text, e.Node.Parent.Parent.Tag);
      }

      UpdateFromCurrent();

    }

    private void NewDocument()
    {
      Model = new DeviserPackage { Name = "Package1" };
      var version = new DeviserVersion { PackageVersion = 1 };
      Model.Versions.Add(version);
      Model.CurrentVersion = version;
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
        if (dialog.ShowDialog() == DialogResult.OK)
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
          if (dialog.ShowDialog() == DialogResult.OK)
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

    private TreeNode FindNode(DeviserVersion currentVersion)
    {

      for (int i = 1;i < tree.Nodes.Count; ++i)
      {
        var current = tree.Nodes[i];
        if (current.Tag == currentVersion)
          return current;
      }
      return null;
    }
    private void OnAddClassClick(object sender, EventArgs e)
    {
      var node = FindNode(Model.CurrentVersion);
      if (node == null) return;
      var element = new DeviserClass { Name = "Class" + (Model.Elements.Count + 1).ToString(), Document = Model };
      Model.CurrentVersion.Elements.Add(element);
      Model.CurrentVersion.SetParent(Model);
      var newNode = node.Nodes[NODE_CLASSES].Nodes.Add(element.Name);
      tree.SelectedNode = newNode;
      Current = element;
      Model.Dirty = true;
      UpdateFromCurrent();
    }

    private void OnAddEnumClick(object sender, EventArgs e)
    {
      var node = FindNode(Model.CurrentVersion);
      if (node == null) return;

      var element = new DeviserEnum { Name = "Enum" + (Model.Enums.Count + 1).ToString(), Document = Model };
      Model.CurrentVersion.Enums.Add(element);
      Model.CurrentVersion.SetParent(Model);
      var newNode = node.Nodes[NODE_ENUMS].Nodes.Add(element.Name);
      tree.SelectedNode = newNode;
      Current = element;
      Model.Dirty = true;
      UpdateFromCurrent();

    }


    private void OnAddPluginClick(object sender, EventArgs e)
    {
      var node = FindNode(Model.CurrentVersion);
      if (node == null) return;

      var element = new DeviserPlugin { ExtensionPoint = "Extension" + (Model.Plugins.Count + 1).ToString(), Document = Model };
      Model.CurrentVersion.Plugins.Add(element);
      Model.CurrentVersion.SetParent(Model);
      var newNode = node.Nodes[NODE_PLUGINS].Nodes.Add(element.ExtensionPoint);
      tree.SelectedNode = newNode;
      Current = element;
      Model.Dirty = true;
      UpdateFromCurrent();
    }

    private void OnDeleteClick(object sender, EventArgs e)
    {
      if (tree.SelectedNode == null) return;
      if (tree.SelectedNode.Level == 0 && !tree.SelectedNode.Text.StartsWith("Version")) return;

      if (tree.SelectedNode.Level == 0)
      {
        var version = tree.SelectedNode.Tag as DeviserVersion;
        if (version == null) return;
        Model.Versions.Remove(version);
        tree.SelectedNode = tree.SelectedNode.NextNode;

      }
      else if (tree.SelectedNode.Level == 2)
      {
        var version = tree.SelectedNode.Parent.Parent.Tag as DeviserVersion;
        if (version == null) return;

        if (tree.SelectedNode.Parent.Name == NODE_CLASSES)
        {
          version.Elements.Remove(Model.GetElement(tree.SelectedNode.Text, version));
          Current = version.Elements.LastOrDefault();
          if (Current == null)
          {
            Current = version;
            tree.SelectedNode = tree.SelectedNode.Parent;
          }
          else
            tree.SelectedNode = tree.SelectedNode.NextNode;
        }

        if (tree.SelectedNode.Parent.Name == NODE_PLUGINS)
        {
          version.Plugins.Remove(Model.GetPlugin(tree.SelectedNode.Text, version));
          Current = version.Plugins.LastOrDefault();
          if (Current == null)
          {
            Current = version;
            tree.SelectedNode = tree.SelectedNode.Parent;
          }
          else
            tree.SelectedNode = tree.SelectedNode.NextNode;
        }


        if (tree.SelectedNode.Parent.Name == NODE_ENUMS)
        {
          version.Enums.Remove(Model.GetEnum(tree.SelectedNode.Text, version));
          Current = version.Enums.LastOrDefault();
          if (Current == null)
          {
            Current = version;
            tree.SelectedNode = tree.SelectedNode.Parent;
          }
          else
          {
            tree.SelectedNode = tree.SelectedNode.NextNode;
          }
        }
      }
      Model.Dirty = true;
      UpdateUI();
    }

    private void OnRefreshClick(object sender, EventArgs e)
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
          ) == DialogResult.Yes)
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
          "Corrected inconsistencies.",
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
      if (Model == null || !Model.HasModification) return false;

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
        if (dlg.ShowDialog(this) == DialogResult.OK)
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

      if (SaveModelIfDirtyOrCancel()) return;

      using (var dlg = new FormGenerate { Package = FileName, PackageName = Model.Name, ThePackage = Model})
        dlg.ShowDialog(this);

    }

    private void OnViewUmlClick(object sender, EventArgs e)
    {

      using (var dlg = new FormYuml {})
      {
        dlg.InitializeFrom(Model);
        dlg.ShowDialog(this);
      }
    }

    private void OnAddVersionClick(object sender, EventArgs e)
    {
      var version = new DeviserVersion {PackageVersion = Model.Versions.Count + 1};
      Model.Versions.Add(version);
      Current = version;
      UpdateUI();
    }

    private void OnDuplicateClick(object sender, EventArgs e)
    {
      var selected = tree.SelectedNode;
      if (selected == null) return;
      if (selected.Level  == 0 && selected.Name.StartsWith("Version"))
      {
        var version = new DeviserVersion(selected.Tag as DeviserVersion);
        Model.Versions.Add(version);
        Current = version;
        UpdateUI();
        Model.Dirty = true;
      }
      else if (selected.Level == 2 && selected.Parent.Name == NODE_CLASSES)
      {
        var version = selected.Parent.Parent.Tag as DeviserVersion;
        if (version != null)
        {
          var oldItem = version.GetElement(selected.Text);
          var newItem = oldItem.Clone() as DeviserClass;
          if (newItem != null)
          {
            newItem.Name = newItem.Name + "_copy";
            version.Elements.Add(newItem);
            Current = newItem;
            Model.Dirty = true;
          }
        }
        UpdateUI();
      }
      else if (selected.Level == 2 && selected.Parent.Name == NODE_ENUMS)
      {
        var version = selected.Parent.Parent.Tag as DeviserVersion;
        if (version != null)
        {
          var oldItem = version.GetEnum(selected.Text);
          var newItem = oldItem.Clone() as DeviserEnum;
          if (newItem != null)
          {
            newItem.Name = newItem.Name + "_copy";
            version.Enums.Add(newItem);
            Current = newItem;
            Model.Dirty = true;
          }
        }
        UpdateUI();
      }
      else if (selected.Level == 2 && selected.Parent.Name == NODE_PLUGINS)
      {
        var version = selected.Parent.Parent.Tag as DeviserVersion;
        if (version != null)
        {
          var oldItem = version.GetPlugin(selected.Text);
          var newItem = oldItem.Clone() as DeviserPlugin;
          if (newItem != null)
          {
            newItem.ExtensionPoint = newItem.ExtensionPoint + "_copy";
            version.Plugins.Add(newItem);
            Current = newItem;
            Model.Dirty = true;
          }
        }
        UpdateUI();
      }



    }

  }
}
