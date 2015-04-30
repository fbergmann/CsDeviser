namespace CsDeviser.Controls
{
  partial class ControlEnum
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.toolStripAttributes = new System.Windows.Forms.ToolStripContainer();
      this.gridAttributes = new System.Windows.Forms.DataGridView();
      this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.addAttrib = new System.Windows.Forms.ToolStripButton();
      this.removeAttr = new System.Windows.Forms.ToolStripButton();
      this.panel1 = new System.Windows.Forms.Panel();
      this.txtName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.tableLayoutPanel1.SuspendLayout();
      this.toolStripAttributes.ContentPanel.SuspendLayout();
      this.toolStripAttributes.LeftToolStripPanel.SuspendLayout();
      this.toolStripAttributes.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridAttributes)).BeginInit();
      this.toolStrip1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.toolStripAttributes, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(319, 311);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // toolStripAttributes
      // 
      this.toolStripAttributes.BottomToolStripPanelVisible = false;
      // 
      // toolStripAttributes.ContentPanel
      // 
      this.toolStripAttributes.ContentPanel.Controls.Add(this.gridAttributes);
      this.toolStripAttributes.ContentPanel.Size = new System.Drawing.Size(277, 270);
      this.toolStripAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // toolStripAttributes.LeftToolStripPanel
      // 
      this.toolStripAttributes.LeftToolStripPanel.Controls.Add(this.toolStrip1);
      this.toolStripAttributes.Location = new System.Drawing.Point(3, 38);
      this.toolStripAttributes.Name = "toolStripAttributes";
      this.toolStripAttributes.RightToolStripPanelVisible = false;
      this.toolStripAttributes.Size = new System.Drawing.Size(313, 270);
      this.toolStripAttributes.TabIndex = 2;
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
            this.colType});
      this.gridAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridAttributes.Location = new System.Drawing.Point(0, 0);
      this.gridAttributes.Name = "gridAttributes";
      this.gridAttributes.Size = new System.Drawing.Size(277, 270);
      this.gridAttributes.TabIndex = 14;
      this.gridAttributes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnGridValueChanged);
      // 
      // colName
      // 
      this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colName.HeaderText = "Name";
      this.colName.Name = "colName";
      // 
      // colType
      // 
      this.colType.HeaderText = "Value (string)";
      this.colType.Name = "colType";
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
      this.toolStrip1.Size = new System.Drawing.Size(36, 270);
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
      this.addAttrib.Size = new System.Drawing.Size(34, 33);
      this.addAttrib.Text = "&Add";
      this.addAttrib.ToolTipText = "Adds an Attribute to this Class";
      this.addAttrib.Click += new System.EventHandler(this.cmdAddAttribute_Click);
      // 
      // removeAttr
      // 
      this.removeAttr.Image = global::CsDeviser.Properties.Resources.list_remove;
      this.removeAttr.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.removeAttr.Name = "removeAttr";
      this.removeAttr.Size = new System.Drawing.Size(34, 28);
      this.removeAttr.Text = "&Del";
      this.removeAttr.ToolTipText = "Removes the selected Attribute from the class";
      this.removeAttr.Click += new System.EventHandler(this.cmdRemoveAttr_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.txtName);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(313, 29);
      this.panel1.TabIndex = 0;
      // 
      // txtName
      // 
      this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtName.Location = new System.Drawing.Point(52, 3);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(258, 20);
      this.txtName.TabIndex = 3;
      this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
      this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(5, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(41, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Name: ";
      // 
      // ControlEnum
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "ControlEnum";
      this.Size = new System.Drawing.Size(319, 311);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.toolStripAttributes.ContentPanel.ResumeLayout(false);
      this.toolStripAttributes.LeftToolStripPanel.ResumeLayout(false);
      this.toolStripAttributes.LeftToolStripPanel.PerformLayout();
      this.toolStripAttributes.ResumeLayout(false);
      this.toolStripAttributes.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridAttributes)).EndInit();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ToolStripContainer toolStripAttributes;
    private System.Windows.Forms.DataGridView gridAttributes;
    private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    private System.Windows.Forms.DataGridViewTextBoxColumn colType;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton addAttrib;
    private System.Windows.Forms.ToolStripButton removeAttr;
  }
}
