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
      this.panel1 = new System.Windows.Forms.Panel();
      this.cmdRemoveAttr = new System.Windows.Forms.Button();
      this.cmdAddAttribute = new System.Windows.Forms.Button();
      this.txtName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.gridAttributes = new System.Windows.Forms.DataGridView();
      this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridAttributes)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.gridAttributes, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(319, 311);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.cmdRemoveAttr);
      this.panel1.Controls.Add(this.cmdAddAttribute);
      this.panel1.Controls.Add(this.txtName);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(313, 55);
      this.panel1.TabIndex = 0;
      // 
      // cmdRemoveAttr
      // 
      this.cmdRemoveAttr.Location = new System.Drawing.Point(120, 28);
      this.cmdRemoveAttr.Name = "cmdRemoveAttr";
      this.cmdRemoveAttr.Size = new System.Drawing.Size(106, 23);
      this.cmdRemoveAttr.TabIndex = 6;
      this.cmdRemoveAttr.Text = "&Del Value";
      this.cmdRemoveAttr.UseVisualStyleBackColor = true;
      this.cmdRemoveAttr.Click += new System.EventHandler(this.cmdRemoveAttr_Click);
      // 
      // cmdAddAttribute
      // 
      this.cmdAddAttribute.Location = new System.Drawing.Point(8, 29);
      this.cmdAddAttribute.Name = "cmdAddAttribute";
      this.cmdAddAttribute.Size = new System.Drawing.Size(106, 23);
      this.cmdAddAttribute.TabIndex = 5;
      this.cmdAddAttribute.Text = "&Add Value";
      this.cmdAddAttribute.UseVisualStyleBackColor = true;
      this.cmdAddAttribute.Click += new System.EventHandler(this.cmdAddAttribute_Click);
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
      // gridAttributes
      // 
      this.gridAttributes.AllowUserToAddRows = false;
      this.gridAttributes.AllowUserToDeleteRows = false;
      this.gridAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridAttributes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colValue});
      this.gridAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridAttributes.Location = new System.Drawing.Point(3, 64);
      this.gridAttributes.Name = "gridAttributes";
      this.gridAttributes.Size = new System.Drawing.Size(313, 244);
      this.gridAttributes.TabIndex = 1;
      this.gridAttributes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnGridValueChanged);
      // 
      // colName
      // 
      this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colName.HeaderText = "Name";
      this.colName.Name = "colName";
      // 
      // colValue
      // 
      this.colValue.HeaderText = "Value";
      this.colValue.Name = "colValue";
      // 
      // ControlEnum
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "ControlEnum";
      this.Size = new System.Drawing.Size(319, 311);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridAttributes)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.DataGridView gridAttributes;
    private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button cmdRemoveAttr;
    private System.Windows.Forms.Button cmdAddAttribute;
  }
}
