namespace CsDeviser.Controls
{
  partial class ControlPlugin
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.txtAddDecls = new System.Windows.Forms.TextBox();
      this.txtAddImpls = new System.Windows.Forms.TextBox();
      this.chkElementFromCore = new System.Windows.Forms.CheckBox();
      this.chkRequiresAdditionalCode = new System.Windows.Forms.CheckBox();
      this.txtExtensionPoint = new System.Windows.Forms.TextBox();
      this.txtTypeCode = new System.Windows.Forms.TextBox();
      this.txtPackage = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.grpAdditionalFiles = new System.Windows.Forms.GroupBox();
      this.cmdBrowseImpls = new System.Windows.Forms.Button();
      this.cmdBrowseDecls = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.chkHasAdditional = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lstAllClasses = new System.Windows.Forms.ListBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.lstChildClasses = new System.Windows.Forms.ListBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.cmdUp = new System.Windows.Forms.Button();
      this.cmdDown = new System.Windows.Forms.Button();
      this.cmdRemove = new System.Windows.Forms.Button();
      this.cmdAdd = new System.Windows.Forms.Button();
      this.groupAttr = new System.Windows.Forms.GroupBox();
      this.toolStripAttributes = new System.Windows.Forms.ToolStripContainer();
      this.gridAttributes = new System.Windows.Forms.DataGridView();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.addAttrib = new System.Windows.Forms.ToolStripButton();
      this.removeAttr = new System.Windows.Forms.ToolStripButton();
      this.pnlPackage = new System.Windows.Forms.Panel();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colElement = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colRequired = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.colAbstract = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.colXMLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tableLayoutPanel1.SuspendLayout();
      this.grpAdditionalFiles.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.panel2.SuspendLayout();
      this.groupAttr.SuspendLayout();
      this.toolStripAttributes.ContentPanel.SuspendLayout();
      this.toolStripAttributes.LeftToolStripPanel.SuspendLayout();
      this.toolStripAttributes.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridAttributes)).BeginInit();
      this.toolStrip1.SuspendLayout();
      this.pnlPackage.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtAddDecls
      // 
      this.txtAddDecls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtAddDecls.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.txtAddDecls.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
      this.txtAddDecls.Location = new System.Drawing.Point(102, 19);
      this.txtAddDecls.Name = "txtAddDecls";
      this.txtAddDecls.Size = new System.Drawing.Size(535, 20);
      this.txtAddDecls.TabIndex = 1;
      this.toolTip1.SetToolTip(this.txtAddDecls, "Additional declarations to be included in the Package extension header");
      this.txtAddDecls.TextChanged += new System.EventHandler(this.txtAddDecls_TextChanged);
      // 
      // txtAddImpls
      // 
      this.txtAddImpls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtAddImpls.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.txtAddImpls.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
      this.txtAddImpls.Location = new System.Drawing.Point(102, 45);
      this.txtAddImpls.Name = "txtAddImpls";
      this.txtAddImpls.Size = new System.Drawing.Size(535, 20);
      this.txtAddImpls.TabIndex = 2;
      this.toolTip1.SetToolTip(this.txtAddImpls, "Additional implementations to be included in the Package extension source file");
      this.txtAddImpls.TextChanged += new System.EventHandler(this.txtAddImpls_TextChanged);
      // 
      // chkElementFromCore
      // 
      this.chkElementFromCore.AutoSize = true;
      this.chkElementFromCore.Checked = true;
      this.chkElementFromCore.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkElementFromCore.Location = new System.Drawing.Point(92, 29);
      this.chkElementFromCore.Name = "chkElementFromCore";
      this.chkElementFromCore.Size = new System.Drawing.Size(110, 17);
      this.chkElementFromCore.TabIndex = 1;
      this.chkElementFromCore.Text = "element from core";
      this.toolTip1.SetToolTip(this.chkElementFromCore, "Check if the package is required (i.e.: it changes math)");
      this.chkElementFromCore.UseVisualStyleBackColor = true;
      this.chkElementFromCore.CheckedChanged += new System.EventHandler(this.chkElementFromCore_CheckedChanged);
      // 
      // chkRequiresAdditionalCode
      // 
      this.chkRequiresAdditionalCode.AutoSize = true;
      this.chkRequiresAdditionalCode.Location = new System.Drawing.Point(301, 29);
      this.chkRequiresAdditionalCode.Name = "chkRequiresAdditionalCode";
      this.chkRequiresAdditionalCode.Size = new System.Drawing.Size(138, 17);
      this.chkRequiresAdditionalCode.TabIndex = 6;
      this.chkRequiresAdditionalCode.Text = "requires additional code";
      this.toolTip1.SetToolTip(this.chkRequiresAdditionalCode, "does this class require the user to provide additional code");
      this.chkRequiresAdditionalCode.UseVisualStyleBackColor = true;
      this.chkRequiresAdditionalCode.CheckedChanged += new System.EventHandler(this.OnCheckRequiresAdditionalCodeCheckedChanged);
      // 
      // txtExtensionPoint
      // 
      this.txtExtensionPoint.Location = new System.Drawing.Point(92, 3);
      this.txtExtensionPoint.Name = "txtExtensionPoint";
      this.txtExtensionPoint.Size = new System.Drawing.Size(173, 20);
      this.txtExtensionPoint.TabIndex = 0;
      this.toolTip1.SetToolTip(this.txtExtensionPoint, "The extension point of this plugin");
      this.txtExtensionPoint.TextChanged += new System.EventHandler(this.txtExtensionPoint_TextChanged);
      this.txtExtensionPoint.Leave += new System.EventHandler(this.txtExtensionPoint_Leave);
      // 
      // txtTypeCode
      // 
      this.txtTypeCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtTypeCode.Location = new System.Drawing.Point(334, 6);
      this.txtTypeCode.Name = "txtTypeCode";
      this.txtTypeCode.Size = new System.Drawing.Size(357, 20);
      this.txtTypeCode.TabIndex = 12;
      this.toolTip1.SetToolTip(this.txtTypeCode, "the SBMLTypeCode_t enumeration for this extension point");
      this.txtTypeCode.TextChanged += new System.EventHandler(this.txtTypeCode_TextChanged);
      // 
      // txtPackage
      // 
      this.txtPackage.Location = new System.Drawing.Point(92, 6);
      this.txtPackage.Name = "txtPackage";
      this.txtPackage.Size = new System.Drawing.Size(173, 20);
      this.txtPackage.TabIndex = 10;
      this.toolTip1.SetToolTip(this.txtPackage, " the name of the sbml package that the extension point comes from");
      this.txtPackage.TextChanged += new System.EventHandler(this.txtPackage_TextChanged);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.grpAdditionalFiles, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.pnlPackage, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.Size = new System.Drawing.Size(703, 432);
      this.tableLayoutPanel1.TabIndex = 6;
      // 
      // grpAdditionalFiles
      // 
      this.grpAdditionalFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grpAdditionalFiles.Controls.Add(this.cmdBrowseImpls);
      this.grpAdditionalFiles.Controls.Add(this.cmdBrowseDecls);
      this.grpAdditionalFiles.Controls.Add(this.txtAddDecls);
      this.grpAdditionalFiles.Controls.Add(this.label6);
      this.grpAdditionalFiles.Controls.Add(this.txtAddImpls);
      this.grpAdditionalFiles.Controls.Add(this.label7);
      this.grpAdditionalFiles.Location = new System.Drawing.Point(3, 351);
      this.grpAdditionalFiles.Name = "grpAdditionalFiles";
      this.grpAdditionalFiles.Size = new System.Drawing.Size(697, 78);
      this.grpAdditionalFiles.TabIndex = 20;
      this.grpAdditionalFiles.TabStop = false;
      this.grpAdditionalFiles.Text = " Additional code files: ";
      // 
      // cmdBrowseImpls
      // 
      this.cmdBrowseImpls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdBrowseImpls.Location = new System.Drawing.Point(643, 43);
      this.cmdBrowseImpls.Name = "cmdBrowseImpls";
      this.cmdBrowseImpls.Size = new System.Drawing.Size(48, 23);
      this.cmdBrowseImpls.TabIndex = 18;
      this.cmdBrowseImpls.Text = "...";
      this.cmdBrowseImpls.UseVisualStyleBackColor = true;
      this.cmdBrowseImpls.Click += new System.EventHandler(this.OnBrowseImplsClick);
      // 
      // cmdBrowseDecls
      // 
      this.cmdBrowseDecls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdBrowseDecls.Location = new System.Drawing.Point(643, 17);
      this.cmdBrowseDecls.Name = "cmdBrowseDecls";
      this.cmdBrowseDecls.Size = new System.Drawing.Size(48, 23);
      this.cmdBrowseDecls.TabIndex = 17;
      this.cmdBrowseDecls.Text = "...";
      this.cmdBrowseDecls.UseVisualStyleBackColor = true;
      this.cmdBrowseDecls.Click += new System.EventHandler(this.OnBrowseDeclsClick);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(29, 22);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(67, 13);
      this.label6.TabIndex = 14;
      this.label6.Text = "Declaration: ";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(12, 48);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(84, 13);
      this.label7.TabIndex = 16;
      this.label7.Text = "Implementation: ";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.chkElementFromCore);
      this.panel1.Controls.Add(this.chkRequiresAdditionalCode);
      this.panel1.Controls.Add(this.chkHasAdditional);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.txtExtensionPoint);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(697, 50);
      this.panel1.TabIndex = 0;
      // 
      // chkHasAdditional
      // 
      this.chkHasAdditional.AutoSize = true;
      this.chkHasAdditional.Location = new System.Drawing.Point(208, 29);
      this.chkHasAdditional.Name = "chkHasAdditional";
      this.chkHasAdditional.Size = new System.Drawing.Size(87, 17);
      this.chkHasAdditional.TabIndex = 2;
      this.chkHasAdditional.Text = "hasAttributes";
      this.chkHasAdditional.UseVisualStyleBackColor = true;
      this.chkHasAdditional.CheckedChanged += new System.EventHandler(this.chkHasAdditional_CheckedChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(83, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "ExtensionPoint: ";
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(3, 94);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.groupAttr);
      this.splitContainer1.Size = new System.Drawing.Size(697, 251);
      this.splitContainer1.SplitterDistance = 184;
      this.splitContainer1.TabIndex = 3;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 3;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.groupBox2, 2, 0);
      this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(697, 184);
      this.tableLayoutPanel2.TabIndex = 0;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.lstAllClasses);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(3, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(299, 178);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = " Define Classes: ";
      // 
      // lstAllClasses
      // 
      this.lstAllClasses.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lstAllClasses.FormattingEnabled = true;
      this.lstAllClasses.Location = new System.Drawing.Point(3, 16);
      this.lstAllClasses.Name = "lstAllClasses";
      this.lstAllClasses.Size = new System.Drawing.Size(293, 159);
      this.lstAllClasses.TabIndex = 0;
      this.lstAllClasses.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnAllClassesMouseDoubleClick);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.lstChildClasses);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox2.Location = new System.Drawing.Point(395, 3);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(299, 178);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = " Child Classes: ";
      // 
      // lstChildClasses
      // 
      this.lstChildClasses.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lstChildClasses.FormattingEnabled = true;
      this.lstChildClasses.Location = new System.Drawing.Point(3, 16);
      this.lstChildClasses.Name = "lstChildClasses";
      this.lstChildClasses.Size = new System.Drawing.Size(293, 159);
      this.lstChildClasses.TabIndex = 0;
      this.lstChildClasses.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnChildClassesMouseDoubleClick);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.cmdUp);
      this.panel2.Controls.Add(this.cmdDown);
      this.panel2.Controls.Add(this.cmdRemove);
      this.panel2.Controls.Add(this.cmdAdd);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(308, 3);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(81, 178);
      this.panel2.TabIndex = 2;
      // 
      // cmdUp
      // 
      this.cmdUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdUp.Location = new System.Drawing.Point(3, 123);
      this.cmdUp.Name = "cmdUp";
      this.cmdUp.Size = new System.Drawing.Size(75, 23);
      this.cmdUp.TabIndex = 2;
      this.cmdUp.Text = "Up";
      this.cmdUp.UseVisualStyleBackColor = true;
      this.cmdUp.Click += new System.EventHandler(this.OnUpClick);
      // 
      // cmdDown
      // 
      this.cmdDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdDown.Location = new System.Drawing.Point(3, 152);
      this.cmdDown.Name = "cmdDown";
      this.cmdDown.Size = new System.Drawing.Size(75, 23);
      this.cmdDown.TabIndex = 3;
      this.cmdDown.Text = "Down";
      this.cmdDown.UseVisualStyleBackColor = true;
      this.cmdDown.Click += new System.EventHandler(this.OnDownClick);
      // 
      // cmdRemove
      // 
      this.cmdRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdRemove.Location = new System.Drawing.Point(3, 45);
      this.cmdRemove.Name = "cmdRemove";
      this.cmdRemove.Size = new System.Drawing.Size(75, 23);
      this.cmdRemove.TabIndex = 1;
      this.cmdRemove.Text = " << ";
      this.cmdRemove.UseVisualStyleBackColor = true;
      this.cmdRemove.Click += new System.EventHandler(this.OnRemoveClick);
      // 
      // cmdAdd
      // 
      this.cmdAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdAdd.Location = new System.Drawing.Point(3, 16);
      this.cmdAdd.Name = "cmdAdd";
      this.cmdAdd.Size = new System.Drawing.Size(75, 23);
      this.cmdAdd.TabIndex = 0;
      this.cmdAdd.Text = " >> ";
      this.cmdAdd.UseVisualStyleBackColor = true;
      this.cmdAdd.Click += new System.EventHandler(this.OnAddClick);
      // 
      // groupAttr
      // 
      this.groupAttr.Controls.Add(this.toolStripAttributes);
      this.groupAttr.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupAttr.Location = new System.Drawing.Point(0, 0);
      this.groupAttr.Name = "groupAttr";
      this.groupAttr.Size = new System.Drawing.Size(697, 63);
      this.groupAttr.TabIndex = 4;
      this.groupAttr.TabStop = false;
      this.groupAttr.Text = "Class attributes and child elements: ";
      // 
      // toolStripAttributes
      // 
      this.toolStripAttributes.BottomToolStripPanelVisible = false;
      // 
      // toolStripAttributes.ContentPanel
      // 
      this.toolStripAttributes.ContentPanel.Controls.Add(this.gridAttributes);
      this.toolStripAttributes.ContentPanel.Size = new System.Drawing.Size(641, 44);
      this.toolStripAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // toolStripAttributes.LeftToolStripPanel
      // 
      this.toolStripAttributes.LeftToolStripPanel.Controls.Add(this.toolStrip1);
      this.toolStripAttributes.Location = new System.Drawing.Point(3, 16);
      this.toolStripAttributes.Name = "toolStripAttributes";
      this.toolStripAttributes.RightToolStripPanelVisible = false;
      this.toolStripAttributes.Size = new System.Drawing.Size(691, 44);
      this.toolStripAttributes.TabIndex = 1;
      this.toolStripAttributes.Text = "toolStripContainer1";
      this.toolStripAttributes.TopToolStripPanelVisible = false;
      // 
      // gridAttributes
      // 
      this.gridAttributes.AllowUserToAddRows = false;
      this.gridAttributes.AllowUserToDeleteRows = false;
      this.gridAttributes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.gridAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridAttributes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colType,
            this.colElement,
            this.colRequired,
            this.colAbstract,
            this.colXMLName});
      this.gridAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridAttributes.Location = new System.Drawing.Point(0, 0);
      this.gridAttributes.Name = "gridAttributes";
      this.gridAttributes.Size = new System.Drawing.Size(641, 44);
      this.gridAttributes.TabIndex = 14;
      this.gridAttributes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
      // 
      // toolStrip1
      // 
      this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
      this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAttrib,
            this.removeAttr});
      this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
      this.toolStrip1.Size = new System.Drawing.Size(50, 44);
      this.toolStrip1.Stretch = true;
      this.toolStrip1.TabIndex = 15;
      this.toolStrip1.Text = "toolStrip1";
      this.toolStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
      // 
      // addAttrib
      // 
      this.addAttrib.Image = global::CsDeviser.Properties.Resources.list_add;
      this.addAttrib.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.addAttrib.Name = "addAttrib";
      this.addAttrib.Size = new System.Drawing.Size(49, 20);
      this.addAttrib.Text = "&Add";
      this.addAttrib.ToolTipText = "Adds an Attribute to this Class";
      this.addAttrib.Click += new System.EventHandler(this.cmdAddAttribute_Click);
      // 
      // removeAttr
      // 
      this.removeAttr.Image = global::CsDeviser.Properties.Resources.list_remove;
      this.removeAttr.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.removeAttr.Name = "removeAttr";
      this.removeAttr.Size = new System.Drawing.Size(44, 20);
      this.removeAttr.Text = "&Del";
      this.removeAttr.ToolTipText = "Removes the selected Attribute from the class";
      this.removeAttr.Click += new System.EventHandler(this.cmdDelAttr_Click);
      // 
      // pnlPackage
      // 
      this.pnlPackage.AutoSize = true;
      this.pnlPackage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.pnlPackage.Controls.Add(this.label5);
      this.pnlPackage.Controls.Add(this.label4);
      this.pnlPackage.Controls.Add(this.txtTypeCode);
      this.pnlPackage.Controls.Add(this.txtPackage);
      this.pnlPackage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlPackage.Location = new System.Drawing.Point(3, 59);
      this.pnlPackage.Name = "pnlPackage";
      this.pnlPackage.Size = new System.Drawing.Size(697, 29);
      this.pnlPackage.TabIndex = 2;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(270, 9);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(58, 13);
      this.label5.TabIndex = 13;
      this.label5.Text = "Typecode:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(33, 9);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(53, 13);
      this.label4.TabIndex = 11;
      this.label4.Text = "Package:";
      // 
      // colName
      // 
      this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colName.HeaderText = "Name";
      this.colName.Name = "colName";
      // 
      // colType
      // 
      this.colType.HeaderText = "Type";
      this.colType.Name = "colType";
      // 
      // colElement
      // 
      this.colElement.HeaderText = "Element";
      this.colElement.Name = "colElement";
      // 
      // colRequired
      // 
      this.colRequired.HeaderText = "Required";
      this.colRequired.Name = "colRequired";
      // 
      // colAbstract
      // 
      this.colAbstract.HeaderText = "isBaseClass";
      this.colAbstract.Name = "colAbstract";
      // 
      // colXMLName
      // 
      this.colXMLName.HeaderText = "XML name";
      this.colXMLName.Name = "colXMLName";
      // 
      // ControlPlugin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.MinimumSize = new System.Drawing.Size(463, 261);
      this.Name = "ControlPlugin";
      this.Size = new System.Drawing.Size(703, 432);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.grpAdditionalFiles.ResumeLayout(false);
      this.grpAdditionalFiles.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.groupAttr.ResumeLayout(false);
      this.toolStripAttributes.ContentPanel.ResumeLayout(false);
      this.toolStripAttributes.LeftToolStripPanel.ResumeLayout(false);
      this.toolStripAttributes.LeftToolStripPanel.PerformLayout();
      this.toolStripAttributes.ResumeLayout(false);
      this.toolStripAttributes.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridAttributes)).EndInit();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.pnlPackage.ResumeLayout(false);
      this.pnlPackage.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox txtExtensionPoint;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.CheckBox chkHasAdditional;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ListBox lstAllClasses;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.ListBox lstChildClasses;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button cmdUp;
    private System.Windows.Forms.Button cmdDown;
    private System.Windows.Forms.Button cmdRemove;
    private System.Windows.Forms.Button cmdAdd;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtTypeCode;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtPackage;
    private System.Windows.Forms.Panel pnlPackage;
    private System.Windows.Forms.GroupBox grpAdditionalFiles;
    private System.Windows.Forms.Button cmdBrowseImpls;
    private System.Windows.Forms.Button cmdBrowseDecls;
    private System.Windows.Forms.TextBox txtAddDecls;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtAddImpls;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.CheckBox chkElementFromCore;
    private System.Windows.Forms.CheckBox chkRequiresAdditionalCode;
    private System.Windows.Forms.GroupBox groupAttr;
    private System.Windows.Forms.ToolStripContainer toolStripAttributes;
    private System.Windows.Forms.DataGridView gridAttributes;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton addAttrib;
    private System.Windows.Forms.ToolStripButton removeAttr;
    private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    private System.Windows.Forms.DataGridViewTextBoxColumn colType;
    private System.Windows.Forms.DataGridViewTextBoxColumn colElement;
    private System.Windows.Forms.DataGridViewCheckBoxColumn colRequired;
    private System.Windows.Forms.DataGridViewCheckBoxColumn colAbstract;
    private System.Windows.Forms.DataGridViewTextBoxColumn colXMLName;
  }
}
