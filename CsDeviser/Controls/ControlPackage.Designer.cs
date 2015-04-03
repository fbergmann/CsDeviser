namespace CsDeviser.Controls
{
  partial class ControlPackage
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPackage));
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.txtFullName = new System.Windows.Forms.TextBox();
      this.txtOffset = new System.Windows.Forms.TextBox();
      this.txtStartNumber = new System.Windows.Forms.TextBox();
      this.txtPackage = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lstClasses = new System.Windows.Forms.ListBox();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolCmdDown = new System.Windows.Forms.ToolStripButton();
      this.toolCmdUp = new System.Windows.Forms.ToolStripButton();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.txtVersion = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.chkRequired = new System.Windows.Forms.CheckBox();
      this.txtAddDecls = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.txtAddImpls = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtFullName
      // 
      this.txtFullName.Location = new System.Drawing.Point(234, 3);
      this.txtFullName.Name = "txtFullName";
      this.txtFullName.Size = new System.Drawing.Size(239, 20);
      this.txtFullName.TabIndex = 2;
      this.toolTip1.SetToolTip(this.txtFullName, "The full name of the package as used in the specification and error messages");
      this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
      // 
      // txtOffset
      // 
      this.txtOffset.Location = new System.Drawing.Point(234, 29);
      this.txtOffset.Name = "txtOffset";
      this.txtOffset.Size = new System.Drawing.Size(100, 20);
      this.txtOffset.TabIndex = 4;
      this.txtOffset.Text = "0";
      this.txtOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.toolTip1.SetToolTip(this.txtOffset, "The offset for the validation numbers");
      this.txtOffset.TextChanged += new System.EventHandler(this.txtOffset_TextChanged);
      // 
      // txtStartNumber
      // 
      this.txtStartNumber.Location = new System.Drawing.Point(59, 29);
      this.txtStartNumber.Name = "txtStartNumber";
      this.txtStartNumber.Size = new System.Drawing.Size(100, 20);
      this.txtStartNumber.TabIndex = 3;
      this.txtStartNumber.Text = "0";
      this.txtStartNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.toolTip1.SetToolTip(this.txtStartNumber, "The starting number of the typecode enum. ");
      this.txtStartNumber.TextChanged += new System.EventHandler(this.txtStartNumber_TextChanged);
      // 
      // txtPackage
      // 
      this.txtPackage.Location = new System.Drawing.Point(59, 3);
      this.txtPackage.Name = "txtPackage";
      this.txtPackage.Size = new System.Drawing.Size(100, 20);
      this.txtPackage.TabIndex = 1;
      this.toolTip1.SetToolTip(this.txtPackage, "The name of the package");
      this.txtPackage.TextChanged += new System.EventHandler(this.txtPackage_TextChanged);
      this.txtPackage.Leave += new System.EventHandler(this.txtPackage_Leave);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(168, 6);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(60, 13);
      this.label4.TabIndex = 10;
      this.label4.Text = "Full Name: ";
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.lstClasses);
      this.groupBox1.Controls.Add(this.toolStrip1);
      this.groupBox1.Location = new System.Drawing.Point(6, 81);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(554, 338);
      this.groupBox1.TabIndex = 9;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = " Classes";
      // 
      // lstClasses
      // 
      this.lstClasses.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lstClasses.FormattingEnabled = true;
      this.lstClasses.Location = new System.Drawing.Point(3, 41);
      this.lstClasses.Name = "lstClasses";
      this.lstClasses.Size = new System.Drawing.Size(548, 294);
      this.lstClasses.TabIndex = 1;
      // 
      // toolStrip1
      // 
      this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCmdDown,
            this.toolCmdUp});
      this.toolStrip1.Location = new System.Drawing.Point(3, 16);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
      this.toolStrip1.Size = new System.Drawing.Size(548, 25);
      this.toolStrip1.TabIndex = 0;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolCmdDown
      // 
      this.toolCmdDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolCmdDown.Image = ((System.Drawing.Image)(resources.GetObject("toolCmdDown.Image")));
      this.toolCmdDown.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolCmdDown.Name = "toolCmdDown";
      this.toolCmdDown.Size = new System.Drawing.Size(42, 22);
      this.toolCmdDown.Text = "&Down";
      this.toolCmdDown.Click += new System.EventHandler(this.OnMoveClassDown);
      // 
      // toolCmdUp
      // 
      this.toolCmdUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolCmdUp.Image = ((System.Drawing.Image)(resources.GetObject("toolCmdUp.Image")));
      this.toolCmdUp.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolCmdUp.Name = "toolCmdUp";
      this.toolCmdUp.Size = new System.Drawing.Size(26, 22);
      this.toolCmdUp.Text = "&Up";
      this.toolCmdUp.Click += new System.EventHandler(this.OnMoveClassUp);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(187, 32);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(41, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Offset: ";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 32);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Number: ";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(41, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Name: ";
      // 
      // txtVersion
      // 
      this.txtVersion.Location = new System.Drawing.Point(398, 29);
      this.txtVersion.Name = "txtVersion";
      this.txtVersion.Size = new System.Drawing.Size(75, 20);
      this.txtVersion.TabIndex = 5;
      this.txtVersion.Text = "1";
      this.txtVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.toolTip1.SetToolTip(this.txtVersion, "The version of this package");
      this.txtVersion.TextChanged += new System.EventHandler(this.txtVersion_TextChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(342, 32);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(48, 13);
      this.label5.TabIndex = 12;
      this.label5.Text = "Version: ";
      // 
      // chkRequired
      // 
      this.chkRequired.AutoSize = true;
      this.chkRequired.Location = new System.Drawing.Point(398, 57);
      this.chkRequired.Name = "chkRequired";
      this.chkRequired.Size = new System.Drawing.Size(75, 17);
      this.chkRequired.TabIndex = 8;
      this.chkRequired.Text = "Required?";
      this.toolTip1.SetToolTip(this.chkRequired, "Check if the package is required (i.e.: it changes math)");
      this.chkRequired.UseVisualStyleBackColor = true;
      this.chkRequired.CheckedChanged += new System.EventHandler(this.chkRequired_CheckedChanged);
      // 
      // txtAddDecls
      // 
      this.txtAddDecls.Location = new System.Drawing.Point(59, 55);
      this.txtAddDecls.Name = "txtAddDecls";
      this.txtAddDecls.Size = new System.Drawing.Size(100, 20);
      this.txtAddDecls.TabIndex = 6;
      this.toolTip1.SetToolTip(this.txtAddDecls, "Additional declarations to be included in the Package extension header");
      this.txtAddDecls.TextChanged += new System.EventHandler(this.txtAddDecls_TextChanged);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(-3, 58);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(57, 13);
      this.label6.TabIndex = 14;
      this.label6.Text = "Add Decl: ";
      // 
      // txtAddImpls
      // 
      this.txtAddImpls.Location = new System.Drawing.Point(234, 55);
      this.txtAddImpls.Name = "txtAddImpls";
      this.txtAddImpls.Size = new System.Drawing.Size(100, 20);
      this.txtAddImpls.TabIndex = 7;
      this.toolTip1.SetToolTip(this.txtAddImpls, "Additional implementations to be included in the Package extension source file");
      this.txtAddImpls.TextChanged += new System.EventHandler(this.txtAddImpls_TextChanged);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(172, 58);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(54, 13);
      this.label7.TabIndex = 16;
      this.label7.Text = "Add Impl: ";
      // 
      // ControlPackage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.txtAddImpls);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.txtAddDecls);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.chkRequired);
      this.Controls.Add(this.txtVersion);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtFullName);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.txtOffset);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtStartNumber);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtPackage);
      this.Controls.Add(this.label1);
      this.Name = "ControlPackage";
      this.Size = new System.Drawing.Size(563, 422);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtPackage;
    private System.Windows.Forms.TextBox txtStartNumber;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.TextBox txtOffset;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ListBox lstClasses;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton toolCmdDown;
    private System.Windows.Forms.ToolStripButton toolCmdUp;
    private System.Windows.Forms.TextBox txtFullName;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtVersion;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.CheckBox chkRequired;
    private System.Windows.Forms.TextBox txtAddDecls;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtAddImpls;
    private System.Windows.Forms.Label label7;
  }
}
