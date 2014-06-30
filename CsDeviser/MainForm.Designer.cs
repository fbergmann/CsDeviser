namespace CsDeviser
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Package");
      System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Classes");
      System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Plugins");
      System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Enums");
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.tree = new System.Windows.Forms.TreeView();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.addClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.addPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.controlEnum1 = new CsDeviser.Controls.ControlEnum();
      this.controlPlugin1 = new CsDeviser.Controls.ControlPlugin();
      this.controlClass1 = new CsDeviser.Controls.ControlClass();
      this.controlPackage1 = new CsDeviser.Controls.ControlPackage();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.cmdRefresh = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
      this.cmdAddClass = new System.Windows.Forms.ToolStripButton();
      this.cmdAddPlugin = new System.Windows.Forms.ToolStripButton();
      this.cmdAddEnum = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
      this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.addClassToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.addPluginToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.addEnumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
      this.toolStripContainer1.ContentPanel.SuspendLayout();
      this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
      this.toolStripContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.contextMenuStrip1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStripContainer1
      // 
      // 
      // toolStripContainer1.BottomToolStripPanel
      // 
      this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
      // 
      // toolStripContainer1.ContentPanel
      // 
      this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
      this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(784, 490);
      this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
      this.toolStripContainer1.Name = "toolStripContainer1";
      this.toolStripContainer1.Size = new System.Drawing.Size(784, 561);
      this.toolStripContainer1.TabIndex = 0;
      this.toolStripContainer1.Text = "toolStripContainer1";
      // 
      // toolStripContainer1.TopToolStripPanel
      // 
      this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
      this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
      this.statusStrip1.Location = new System.Drawing.Point(0, 0);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(784, 22);
      this.statusStrip1.TabIndex = 0;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.tree);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.controlEnum1);
      this.splitContainer1.Panel2.Controls.Add(this.controlPlugin1);
      this.splitContainer1.Panel2.Controls.Add(this.controlClass1);
      this.splitContainer1.Panel2.Controls.Add(this.controlPackage1);
      this.splitContainer1.Size = new System.Drawing.Size(784, 490);
      this.splitContainer1.SplitterDistance = 197;
      this.splitContainer1.TabIndex = 0;
      // 
      // tree
      // 
      this.tree.ContextMenuStrip = this.contextMenuStrip1;
      this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tree.Location = new System.Drawing.Point(0, 0);
      this.tree.Name = "tree";
      treeNode5.Name = "nodePackage";
      treeNode5.Text = "Package";
      treeNode6.Name = "nodeClasses";
      treeNode6.Text = "Classes";
      treeNode6.ToolTipText = "All Classes Defined by this Package";
      treeNode7.Name = "nodePlugins";
      treeNode7.Text = "Plugins";
      treeNode7.ToolTipText = "All Plugins of this package";
      treeNode8.Name = "nodeEnums";
      treeNode8.Text = "Enums";
      this.tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
      this.tree.Size = new System.Drawing.Size(197, 490);
      this.tree.TabIndex = 0;
      this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OnItemSelect);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClassToolStripMenuItem,
            this.addPluginToolStripMenuItem,
            this.toolStripMenuItem2,
            this.deleteToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(134, 76);
      // 
      // addClassToolStripMenuItem
      // 
      this.addClassToolStripMenuItem.Name = "addClassToolStripMenuItem";
      this.addClassToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
      this.addClassToolStripMenuItem.Text = "Add Class";
      this.addClassToolStripMenuItem.Click += new System.EventHandler(this.OnAddClassClick);
      // 
      // addPluginToolStripMenuItem
      // 
      this.addPluginToolStripMenuItem.Name = "addPluginToolStripMenuItem";
      this.addPluginToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
      this.addPluginToolStripMenuItem.Text = "Add Plugin";
      this.addPluginToolStripMenuItem.Click += new System.EventHandler(this.OnAddPluginClick);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(130, 6);
      // 
      // deleteToolStripMenuItem
      // 
      this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
      this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
      this.deleteToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
      this.deleteToolStripMenuItem.Text = "Delete";
      this.deleteToolStripMenuItem.Click += new System.EventHandler(this.OnDeleteClick);
      // 
      // controlEnum1
      // 
      this.controlEnum1.Current = null;
      this.controlEnum1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.controlEnum1.Initializing = false;
      this.controlEnum1.Location = new System.Drawing.Point(0, 0);
      this.controlEnum1.Name = "controlEnum1";
      this.controlEnum1.Size = new System.Drawing.Size(583, 490);
      this.controlEnum1.TabIndex = 3;
      this.controlEnum1.Visible = false;
      // 
      // controlPlugin1
      // 
      this.controlPlugin1.Current = null;
      this.controlPlugin1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.controlPlugin1.Initializing = false;
      this.controlPlugin1.Location = new System.Drawing.Point(0, 0);
      this.controlPlugin1.MinimumSize = new System.Drawing.Size(377, 207);
      this.controlPlugin1.Name = "controlPlugin1";
      this.controlPlugin1.Size = new System.Drawing.Size(583, 490);
      this.controlPlugin1.TabIndex = 2;
      this.controlPlugin1.Visible = false;
      // 
      // controlClass1
      // 
      this.controlClass1.Current = null;
      this.controlClass1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.controlClass1.Initializing = false;
      this.controlClass1.Location = new System.Drawing.Point(0, 0);
      this.controlClass1.Name = "controlClass1";
      this.controlClass1.Size = new System.Drawing.Size(583, 490);
      this.controlClass1.TabIndex = 1;
      this.controlClass1.Visible = false;
      // 
      // controlPackage1
      // 
      this.controlPackage1.Current = null;
      this.controlPackage1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.controlPackage1.Initializing = false;
      this.controlPackage1.Location = new System.Drawing.Point(0, 0);
      this.controlPackage1.Name = "controlPackage1";
      this.controlPackage1.Size = new System.Drawing.Size(583, 490);
      this.controlPackage1.TabIndex = 0;
      this.controlPackage1.Visible = false;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(784, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      this.fileToolStripMenuItem.Click += new System.EventHandler(this.OnNewClick);
      // 
      // newToolStripMenuItem
      // 
      this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
      this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
      this.newToolStripMenuItem.Text = "&New";
      this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewClick);
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
      this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
      this.openToolStripMenuItem.Text = "&Open";
      this.openToolStripMenuItem.Click += new System.EventHandler(this.OnOpenClick);
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
      this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
      this.saveToolStripMenuItem.Text = "&Save";
      this.saveToolStripMenuItem.Click += new System.EventHandler(this.OnSaveClick);
      // 
      // saveAsToolStripMenuItem
      // 
      this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
      this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
      this.saveAsToolStripMenuItem.Text = "Save &As";
      this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.OnSaveAsClick);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitClick);
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClassToolStripMenuItem1,
            this.addPluginToolStripMenuItem1,
            this.addEnumToolStripMenuItem});
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
      this.editToolStripMenuItem.Text = "&Edit";
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "&Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
      this.aboutToolStripMenuItem.Text = "&About...";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutClick);
      // 
      // toolStrip1
      // 
      this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator2,
            this.cmdRefresh,
            this.toolStripSeparator6,
            this.cmdAddClass,
            this.cmdAddPlugin,
            this.cmdAddEnum,
            this.toolStripSeparator7,
            this.helpToolStripButton});
      this.toolStrip1.Location = new System.Drawing.Point(3, 24);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(372, 25);
      this.toolStrip1.TabIndex = 1;
      // 
      // newToolStripButton
      // 
      this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
      this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.newToolStripButton.Name = "newToolStripButton";
      this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.newToolStripButton.Text = "&New";
      this.newToolStripButton.Click += new System.EventHandler(this.OnNewClick);
      // 
      // openToolStripButton
      // 
      this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
      this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.openToolStripButton.Name = "openToolStripButton";
      this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.openToolStripButton.Text = "&Open";
      this.openToolStripButton.Click += new System.EventHandler(this.OnOpenClick);
      // 
      // saveToolStripButton
      // 
      this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
      this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.saveToolStripButton.Name = "saveToolStripButton";
      this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.saveToolStripButton.Text = "&Save";
      this.saveToolStripButton.Click += new System.EventHandler(this.OnSaveClick);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // cmdRefresh
      // 
      this.cmdRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.cmdRefresh.Image = ((System.Drawing.Image)(resources.GetObject("cmdRefresh.Image")));
      this.cmdRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.cmdRefresh.Name = "cmdRefresh";
      this.cmdRefresh.Size = new System.Drawing.Size(50, 22);
      this.cmdRefresh.Text = "Refresh";
      this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
      // 
      // toolStripSeparator6
      // 
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
      // 
      // cmdAddClass
      // 
      this.cmdAddClass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.cmdAddClass.Image = ((System.Drawing.Image)(resources.GetObject("cmdAddClass.Image")));
      this.cmdAddClass.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.cmdAddClass.Name = "cmdAddClass";
      this.cmdAddClass.Size = new System.Drawing.Size(63, 22);
      this.cmdAddClass.Text = "Add Class";
      this.cmdAddClass.Click += new System.EventHandler(this.OnAddClassClick);
      // 
      // cmdAddPlugin
      // 
      this.cmdAddPlugin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.cmdAddPlugin.Image = ((System.Drawing.Image)(resources.GetObject("cmdAddPlugin.Image")));
      this.cmdAddPlugin.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.cmdAddPlugin.Name = "cmdAddPlugin";
      this.cmdAddPlugin.Size = new System.Drawing.Size(70, 22);
      this.cmdAddPlugin.Text = "Add Plugin";
      this.cmdAddPlugin.Click += new System.EventHandler(this.OnAddPluginClick);
      // 
      // cmdAddEnum
      // 
      this.cmdAddEnum.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.cmdAddEnum.Image = ((System.Drawing.Image)(resources.GetObject("cmdAddEnum.Image")));
      this.cmdAddEnum.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.cmdAddEnum.Name = "cmdAddEnum";
      this.cmdAddEnum.Size = new System.Drawing.Size(67, 22);
      this.cmdAddEnum.Text = "Add Enum";
      this.cmdAddEnum.Click += new System.EventHandler(this.OnAddEnumClick);
      // 
      // toolStripSeparator7
      // 
      this.toolStripSeparator7.Name = "toolStripSeparator7";
      this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
      // 
      // helpToolStripButton
      // 
      this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
      this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.helpToolStripButton.Name = "helpToolStripButton";
      this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.helpToolStripButton.Text = "He&lp";
      this.helpToolStripButton.Click += new System.EventHandler(this.OnAboutClick);
      // 
      // addClassToolStripMenuItem1
      // 
      this.addClassToolStripMenuItem1.Name = "addClassToolStripMenuItem1";
      this.addClassToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
      this.addClassToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
      this.addClassToolStripMenuItem1.Text = "Add Class";
      this.addClassToolStripMenuItem1.Click += new System.EventHandler(this.OnAddClassClick);
      // 
      // addPluginToolStripMenuItem1
      // 
      this.addPluginToolStripMenuItem1.Name = "addPluginToolStripMenuItem1";
      this.addPluginToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
      this.addPluginToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
      this.addPluginToolStripMenuItem1.Text = "Add Plugin";
      this.addPluginToolStripMenuItem1.Click += new System.EventHandler(this.OnAddPluginClick);
      // 
      // addEnumToolStripMenuItem
      // 
      this.addEnumToolStripMenuItem.Name = "addEnumToolStripMenuItem";
      this.addEnumToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D3)));
      this.addEnumToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
      this.addEnumToolStripMenuItem.Text = "Add Enum";
      this.addEnumToolStripMenuItem.Click += new System.EventHandler(this.OnAddEnumClick);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 561);
      this.Controls.Add(this.toolStripContainer1);
      this.MainMenuStrip = this.menuStrip1;
      this.MinimumSize = new System.Drawing.Size(640, 480);
      this.Name = "MainForm";
      this.Text = "Deviser";
      this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
      this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
      this.toolStripContainer1.ContentPanel.ResumeLayout(false);
      this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
      this.toolStripContainer1.TopToolStripPanel.PerformLayout();
      this.toolStripContainer1.ResumeLayout(false);
      this.toolStripContainer1.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.contextMenuStrip1.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton newToolStripButton;
    private System.Windows.Forms.ToolStripButton openToolStripButton;
    private System.Windows.Forms.ToolStripButton saveToolStripButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    private System.Windows.Forms.ToolStripButton helpToolStripButton;
    private System.Windows.Forms.TreeView tree;
    private System.Windows.Forms.ToolStripButton cmdAddClass;
    private System.Windows.Forms.ToolStripButton cmdAddPlugin;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem addClassToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addPluginToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    private Controls.ControlPackage controlPackage1;
    private Controls.ControlPlugin controlPlugin1;
    private Controls.ControlClass controlClass1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton cmdRefresh;
    private System.Windows.Forms.ToolStripButton cmdAddEnum;
    private Controls.ControlEnum controlEnum1;
    private System.Windows.Forms.ToolStripMenuItem addClassToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem addPluginToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem addEnumToolStripMenuItem;
  }
}

