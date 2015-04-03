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
      this.txtExtensionPoint = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.txtAddDecls = new System.Windows.Forms.TextBox();
      this.txtAddImpls = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.cmdDelAttr = new System.Windows.Forms.Button();
      this.cmdAddAttribute = new System.Windows.Forms.Button();
      this.chkHasAdditional = new System.Windows.Forms.CheckBox();
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
      this.gridAttributes = new System.Windows.Forms.DataGridView();
      this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colRequired = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.colElement = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colAbstract = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.label4 = new System.Windows.Forms.Label();
      this.txtPackage = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtTypeCode = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridAttributes)).BeginInit();
      this.SuspendLayout();
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
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(83, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "ExtensionPoint: ";
      // 
      // txtAddDecls
      // 
      this.txtAddDecls.Location = new System.Drawing.Point(92, 29);
      this.txtAddDecls.Name = "txtAddDecls";
      this.txtAddDecls.Size = new System.Drawing.Size(173, 20);
      this.txtAddDecls.TabIndex = 6;
      this.toolTip1.SetToolTip(this.txtAddDecls, "The extension point of this plugin");
      this.txtAddDecls.TextChanged += new System.EventHandler(this.txtAddDecls_TextChanged);
      // 
      // txtAddImpls
      // 
      this.txtAddImpls.Location = new System.Drawing.Point(334, 29);
      this.txtAddImpls.Name = "txtAddImpls";
      this.txtAddImpls.Size = new System.Drawing.Size(173, 20);
      this.txtAddImpls.TabIndex = 8;
      this.toolTip1.SetToolTip(this.txtAddImpls, "The extension point of this plugin");
      this.txtAddImpls.TextChanged += new System.EventHandler(this.txtAddImpls_TextChanged);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(519, 267);
      this.tableLayoutPanel1.TabIndex = 6;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.txtTypeCode);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.txtPackage);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.txtAddImpls);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.txtAddDecls);
      this.panel1.Controls.Add(this.cmdDelAttr);
      this.panel1.Controls.Add(this.cmdAddAttribute);
      this.panel1.Controls.Add(this.chkHasAdditional);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.txtExtensionPoint);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(513, 76);
      this.panel1.TabIndex = 0;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(272, 32);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(56, 13);
      this.label3.TabIndex = 9;
      this.label3.Text = "Add Impls:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(27, 32);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(59, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Add Decls:";
      // 
      // cmdDelAttr
      // 
      this.cmdDelAttr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdDelAttr.Location = new System.Drawing.Point(270, 3);
      this.cmdDelAttr.Name = "cmdDelAttr";
      this.cmdDelAttr.Size = new System.Drawing.Size(68, 23);
      this.cmdDelAttr.TabIndex = 5;
      this.cmdDelAttr.Text = "&Del Attr";
      this.cmdDelAttr.UseVisualStyleBackColor = true;
      this.cmdDelAttr.Click += new System.EventHandler(this.cmdDelAttr_Click);
      // 
      // cmdAddAttribute
      // 
      this.cmdAddAttribute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdAddAttribute.Location = new System.Drawing.Point(344, 3);
      this.cmdAddAttribute.Name = "cmdAddAttribute";
      this.cmdAddAttribute.Size = new System.Drawing.Size(68, 23);
      this.cmdAddAttribute.TabIndex = 1;
      this.cmdAddAttribute.Text = "Add &Attr";
      this.cmdAddAttribute.UseVisualStyleBackColor = true;
      this.cmdAddAttribute.Click += new System.EventHandler(this.cmdAddAttribute_Click);
      // 
      // chkHasAdditional
      // 
      this.chkHasAdditional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.chkHasAdditional.AutoSize = true;
      this.chkHasAdditional.Location = new System.Drawing.Point(418, 6);
      this.chkHasAdditional.Name = "chkHasAdditional";
      this.chkHasAdditional.Size = new System.Drawing.Size(92, 17);
      this.chkHasAdditional.TabIndex = 2;
      this.chkHasAdditional.Text = "Has Attributes";
      this.chkHasAdditional.UseVisualStyleBackColor = true;
      this.chkHasAdditional.CheckedChanged += new System.EventHandler(this.chkHasAdditional_CheckedChanged);
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(3, 85);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.gridAttributes);
      this.splitContainer1.Size = new System.Drawing.Size(513, 179);
      this.splitContainer1.SplitterDistance = 144;
      this.splitContainer1.TabIndex = 1;
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
      this.tableLayoutPanel2.Size = new System.Drawing.Size(513, 144);
      this.tableLayoutPanel2.TabIndex = 0;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.lstAllClasses);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(3, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(207, 138);
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
      this.lstAllClasses.Size = new System.Drawing.Size(201, 119);
      this.lstAllClasses.TabIndex = 0;
      this.lstAllClasses.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnAllClassesMouseDoubleClick);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.lstChildClasses);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox2.Location = new System.Drawing.Point(303, 3);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(207, 138);
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
      this.lstChildClasses.Size = new System.Drawing.Size(201, 119);
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
      this.panel2.Location = new System.Drawing.Point(216, 3);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(81, 138);
      this.panel2.TabIndex = 2;
      // 
      // cmdUp
      // 
      this.cmdUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdUp.Location = new System.Drawing.Point(3, 83);
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
      this.cmdDown.Location = new System.Drawing.Point(3, 112);
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
      // gridAttributes
      // 
      this.gridAttributes.AllowUserToAddRows = false;
      this.gridAttributes.AllowUserToDeleteRows = false;
      this.gridAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridAttributes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colType,
            this.colRequired,
            this.colElement,
            this.colAbstract});
      this.gridAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridAttributes.Location = new System.Drawing.Point(0, 0);
      this.gridAttributes.Name = "gridAttributes";
      this.gridAttributes.Size = new System.Drawing.Size(513, 31);
      this.gridAttributes.TabIndex = 0;
      this.gridAttributes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
      // 
      // colName
      // 
      this.colName.HeaderText = "Name";
      this.colName.Name = "colName";
      // 
      // colType
      // 
      this.colType.HeaderText = "Type";
      this.colType.Name = "colType";
      // 
      // colRequired
      // 
      this.colRequired.HeaderText = "Required";
      this.colRequired.Name = "colRequired";
      // 
      // colElement
      // 
      this.colElement.HeaderText = "Element";
      this.colElement.Name = "colElement";
      // 
      // colAbstract
      // 
      this.colAbstract.HeaderText = "Abstract";
      this.colAbstract.Name = "colAbstract";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(33, 56);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(53, 13);
      this.label4.TabIndex = 11;
      this.label4.Text = "Package:";
      // 
      // txtPackage
      // 
      this.txtPackage.Location = new System.Drawing.Point(92, 53);
      this.txtPackage.Name = "txtPackage";
      this.txtPackage.Size = new System.Drawing.Size(173, 20);
      this.txtPackage.TabIndex = 10;
      this.toolTip1.SetToolTip(this.txtPackage, "In case the extension point is not from \'core\', please state the package name");
      this.txtPackage.TextChanged += new System.EventHandler(this.txtPackage_TextChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(270, 56);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(58, 13);
      this.label5.TabIndex = 13;
      this.label5.Text = "Typecode:";
      // 
      // txtTypeCode
      // 
      this.txtTypeCode.Location = new System.Drawing.Point(334, 53);
      this.txtTypeCode.Name = "txtTypeCode";
      this.txtTypeCode.Size = new System.Drawing.Size(173, 20);
      this.txtTypeCode.TabIndex = 12;
      this.toolTip1.SetToolTip(this.txtTypeCode, "In case the extension point is not from \'core\', please state the package name");
      this.txtTypeCode.TextChanged += new System.EventHandler(this.txtTypeCode_TextChanged);
      // 
      // ControlPlugin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.MinimumSize = new System.Drawing.Size(463, 261);
      this.Name = "ControlPlugin";
      this.Size = new System.Drawing.Size(519, 267);
      this.tableLayoutPanel1.ResumeLayout(false);
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
      ((System.ComponentModel.ISupportInitialize)(this.gridAttributes)).EndInit();
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
    private System.Windows.Forms.DataGridView gridAttributes;
    private System.Windows.Forms.Button cmdAddAttribute;
    private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    private System.Windows.Forms.DataGridViewTextBoxColumn colType;
    private System.Windows.Forms.DataGridViewCheckBoxColumn colRequired;
    private System.Windows.Forms.DataGridViewTextBoxColumn colElement;
    private System.Windows.Forms.DataGridViewCheckBoxColumn colAbstract;
    private System.Windows.Forms.Button cmdDelAttr;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtAddImpls;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtAddDecls;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtTypeCode;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtPackage;
  }
}
