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
      this.label1 = new System.Windows.Forms.Label();
      this.txtPackage = new System.Windows.Forms.TextBox();
      this.txtStartNumber = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.txtOffset = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lstClasses = new System.Windows.Forms.ListBox();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolCmdDown = new System.Windows.Forms.ToolStripButton();
      this.toolCmdUp = new System.Windows.Forms.ToolStripButton();
      this.groupBox1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
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
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 32);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Number: ";
      // 
      // txtOffset
      // 
      this.txtOffset.Location = new System.Drawing.Point(59, 55);
      this.txtOffset.Name = "txtOffset";
      this.txtOffset.Size = new System.Drawing.Size(100, 20);
      this.txtOffset.TabIndex = 5;
      this.txtOffset.Text = "0";
      this.txtOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.toolTip1.SetToolTip(this.txtOffset, "The offset for the validation numbers");
      this.txtOffset.TextChanged += new System.EventHandler(this.txtOffset_TextChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 58);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(41, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Offset: ";
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
      // ControlPackage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
  }
}
