namespace CsDeviser.Controls
{
  partial class ControlClass
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
      this.txtName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.txtTypeCode = new System.Windows.Forms.TextBox();
      this.txtBaseClass = new System.Windows.Forms.TextBox();
      this.txtElementName = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.chkHasChildren = new System.Windows.Forms.CheckBox();
      this.chkHasListOf = new System.Windows.Forms.CheckBox();
      this.chkAbstract = new System.Windows.Forms.CheckBox();
      this.label2 = new System.Windows.Forms.Label();
      this.chkHasMath = new System.Windows.Forms.CheckBox();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.gridAttributes = new System.Windows.Forms.DataGridView();
      this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colRequired = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.colElement = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colAbstract = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.gridConcrete = new System.Windows.Forms.DataGridView();
      this.colConcreteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colConcreteElement = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel2 = new System.Windows.Forms.Panel();
      this.cmdDelConcrete = new System.Windows.Forms.Button();
      this.cmdRemoveAttr = new System.Windows.Forms.Button();
      this.cmdAddConcrete = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.cmdAddAttribute = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridAttributes)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridConcrete)).BeginInit();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtName
      // 
      this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtName.Location = new System.Drawing.Point(71, 3);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(175, 20);
      this.txtName.TabIndex = 0;
      this.toolTip1.SetToolTip(this.txtName, "The name of this element");
      this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
      this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(24, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(41, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Name: ";
      // 
      // txtTypeCode
      // 
      this.txtTypeCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtTypeCode.Location = new System.Drawing.Point(71, 26);
      this.txtTypeCode.Name = "txtTypeCode";
      this.txtTypeCode.Size = new System.Drawing.Size(175, 20);
      this.txtTypeCode.TabIndex = 1;
      this.toolTip1.SetToolTip(this.txtTypeCode, "The name of this element");
      this.txtTypeCode.TextChanged += new System.EventHandler(this.txtTypeCode_TextChanged);
      // 
      // txtBaseClass
      // 
      this.txtBaseClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtBaseClass.Location = new System.Drawing.Point(88, 3);
      this.txtBaseClass.Name = "txtBaseClass";
      this.txtBaseClass.Size = new System.Drawing.Size(159, 20);
      this.txtBaseClass.TabIndex = 0;
      this.toolTip1.SetToolTip(this.txtBaseClass, "The name of this element");
      this.txtBaseClass.TextChanged += new System.EventHandler(this.txtBaseClass_TextChanged);
      // 
      // txtElementName
      // 
      this.txtElementName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtElementName.Location = new System.Drawing.Point(88, 26);
      this.txtElementName.Name = "txtElementName";
      this.txtElementName.Size = new System.Drawing.Size(159, 20);
      this.txtElementName.TabIndex = 1;
      this.toolTip1.SetToolTip(this.txtElementName, "The name of this element");
      this.txtElementName.TextChanged += new System.EventHandler(this.txtElementName_TextChanged);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(511, 298);
      this.tableLayoutPanel1.TabIndex = 4;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.chkHasChildren);
      this.panel1.Controls.Add(this.txtTypeCode);
      this.panel1.Controls.Add(this.chkHasListOf);
      this.panel1.Controls.Add(this.chkAbstract);
      this.panel1.Controls.Add(this.txtName);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.chkHasMath);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(249, 102);
      this.panel1.TabIndex = 0;
      // 
      // chkHasChildren
      // 
      this.chkHasChildren.AutoSize = true;
      this.chkHasChildren.Location = new System.Drawing.Point(82, 55);
      this.chkHasChildren.Name = "chkHasChildren";
      this.chkHasChildren.Size = new System.Drawing.Size(81, 17);
      this.chkHasChildren.TabIndex = 5;
      this.chkHasChildren.Text = "hasChildren";
      this.chkHasChildren.UseVisualStyleBackColor = true;
      this.chkHasChildren.CheckedChanged += new System.EventHandler(this.chkHasChildren_CheckedChanged);
      // 
      // chkHasListOf
      // 
      this.chkHasListOf.AutoSize = true;
      this.chkHasListOf.Location = new System.Drawing.Point(6, 55);
      this.chkHasListOf.Name = "chkHasListOf";
      this.chkHasListOf.Size = new System.Drawing.Size(70, 17);
      this.chkHasListOf.TabIndex = 4;
      this.chkHasListOf.Text = "hasListOf";
      this.chkHasListOf.UseVisualStyleBackColor = true;
      this.chkHasListOf.CheckedChanged += new System.EventHandler(this.chkHasListOf_CheckedChanged);
      // 
      // chkAbstract
      // 
      this.chkAbstract.AutoSize = true;
      this.chkAbstract.Location = new System.Drawing.Point(82, 76);
      this.chkAbstract.Name = "chkAbstract";
      this.chkAbstract.Size = new System.Drawing.Size(64, 17);
      this.chkAbstract.TabIndex = 7;
      this.chkAbstract.Text = "abstract";
      this.chkAbstract.UseVisualStyleBackColor = true;
      this.chkAbstract.CheckedChanged += new System.EventHandler(this.chkAbstract_CheckedChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 28);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(62, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "TypeCode: ";
      // 
      // chkHasMath
      // 
      this.chkHasMath.AutoSize = true;
      this.chkHasMath.Location = new System.Drawing.Point(6, 76);
      this.chkHasMath.Name = "chkHasMath";
      this.chkHasMath.Size = new System.Drawing.Size(67, 17);
      this.chkHasMath.TabIndex = 6;
      this.chkHasMath.Text = "hasMath";
      this.chkHasMath.UseVisualStyleBackColor = true;
      this.chkHasMath.CheckedChanged += new System.EventHandler(this.chkHasMath_CheckedChanged);
      // 
      // splitContainer1
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.splitContainer1, 2);
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(3, 111);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.gridAttributes);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.gridConcrete);
      this.splitContainer1.Size = new System.Drawing.Size(505, 184);
      this.splitContainer1.SplitterDistance = 132;
      this.splitContainer1.TabIndex = 1;
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
      this.gridAttributes.Size = new System.Drawing.Size(505, 132);
      this.gridAttributes.TabIndex = 0;
      this.gridAttributes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAttributes_CellValueChanged);
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
      // gridConcrete
      // 
      this.gridConcrete.AllowUserToAddRows = false;
      this.gridConcrete.AllowUserToDeleteRows = false;
      this.gridConcrete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridConcrete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colConcreteName,
            this.colConcreteElement});
      this.gridConcrete.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridConcrete.Location = new System.Drawing.Point(0, 0);
      this.gridConcrete.Name = "gridConcrete";
      this.gridConcrete.Size = new System.Drawing.Size(505, 48);
      this.gridConcrete.TabIndex = 0;
      this.gridConcrete.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridConcrete_CellValueChanged);
      // 
      // colConcreteName
      // 
      this.colConcreteName.HeaderText = "Name";
      this.colConcreteName.Name = "colConcreteName";
      // 
      // colConcreteElement
      // 
      this.colConcreteElement.HeaderText = "Element";
      this.colConcreteElement.Name = "colConcreteElement";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.cmdDelConcrete);
      this.panel2.Controls.Add(this.cmdRemoveAttr);
      this.panel2.Controls.Add(this.cmdAddConcrete);
      this.panel2.Controls.Add(this.txtBaseClass);
      this.panel2.Controls.Add(this.label3);
      this.panel2.Controls.Add(this.cmdAddAttribute);
      this.panel2.Controls.Add(this.label4);
      this.panel2.Controls.Add(this.txtElementName);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(258, 3);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(250, 102);
      this.panel2.TabIndex = 2;
      // 
      // cmdDelConcrete
      // 
      this.cmdDelConcrete.Location = new System.Drawing.Point(118, 76);
      this.cmdDelConcrete.Name = "cmdDelConcrete";
      this.cmdDelConcrete.Size = new System.Drawing.Size(106, 23);
      this.cmdDelConcrete.TabIndex = 5;
      this.cmdDelConcrete.Text = "Del Concrete";
      this.cmdDelConcrete.UseVisualStyleBackColor = true;
      this.cmdDelConcrete.Click += new System.EventHandler(this.OnRemoveConcreteClick);
      // 
      // cmdRemoveAttr
      // 
      this.cmdRemoveAttr.Location = new System.Drawing.Point(118, 51);
      this.cmdRemoveAttr.Name = "cmdRemoveAttr";
      this.cmdRemoveAttr.Size = new System.Drawing.Size(106, 23);
      this.cmdRemoveAttr.TabIndex = 3;
      this.cmdRemoveAttr.Text = "Del Attribute";
      this.cmdRemoveAttr.UseVisualStyleBackColor = true;
      this.cmdRemoveAttr.Click += new System.EventHandler(this.OnRemoveAttrClick);
      // 
      // cmdAddConcrete
      // 
      this.cmdAddConcrete.Location = new System.Drawing.Point(6, 76);
      this.cmdAddConcrete.Name = "cmdAddConcrete";
      this.cmdAddConcrete.Size = new System.Drawing.Size(106, 23);
      this.cmdAddConcrete.TabIndex = 4;
      this.cmdAddConcrete.Text = "Add Concrete";
      this.cmdAddConcrete.UseVisualStyleBackColor = true;
      this.cmdAddConcrete.Click += new System.EventHandler(this.cmdAddConcrete_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(20, 6);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(62, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "BaseClass: ";
      // 
      // cmdAddAttribute
      // 
      this.cmdAddAttribute.Location = new System.Drawing.Point(6, 52);
      this.cmdAddAttribute.Name = "cmdAddAttribute";
      this.cmdAddAttribute.Size = new System.Drawing.Size(106, 23);
      this.cmdAddAttribute.TabIndex = 2;
      this.cmdAddAttribute.Text = "Add Attribute";
      this.cmdAddAttribute.UseVisualStyleBackColor = true;
      this.cmdAddAttribute.Click += new System.EventHandler(this.cmdAddAttribute_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(3, 28);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(79, 13);
      this.label4.TabIndex = 11;
      this.label4.Text = "ElementName: ";
      // 
      // ControlClass
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "ControlClass";
      this.Size = new System.Drawing.Size(511, 298);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridAttributes)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridConcrete)).EndInit();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox txtElementName;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.CheckBox chkHasMath;
    private System.Windows.Forms.CheckBox chkHasChildren;
    private System.Windows.Forms.CheckBox chkHasListOf;
    private System.Windows.Forms.TextBox txtBaseClass;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtTypeCode;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.CheckBox chkAbstract;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Button cmdAddConcrete;
    private System.Windows.Forms.Button cmdAddAttribute;
    private System.Windows.Forms.DataGridView gridAttributes;
    private System.Windows.Forms.DataGridView gridConcrete;
    private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    private System.Windows.Forms.DataGridViewTextBoxColumn colType;
    private System.Windows.Forms.DataGridViewCheckBoxColumn colRequired;
    private System.Windows.Forms.DataGridViewTextBoxColumn colElement;
    private System.Windows.Forms.DataGridViewCheckBoxColumn colAbstract;
    private System.Windows.Forms.DataGridViewTextBoxColumn colConcreteName;
    private System.Windows.Forms.DataGridViewTextBoxColumn colConcreteElement;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button cmdDelConcrete;
    private System.Windows.Forms.Button cmdRemoveAttr;

  }
}
