namespace CsDeviser.Controls
{
  partial class ControlVersion
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlVersion));
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.txtCoreVersion = new System.Windows.Forms.TextBox();
      this.txtCoreLevel = new System.Windows.Forms.TextBox();
      this.txtPkgVersion = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lstClasses = new System.Windows.Forms.ListBox();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolCmdDown = new System.Windows.Forms.ToolStripButton();
      this.toolCmdUp = new System.Windows.Forms.ToolStripButton();
      this.label2 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtCoreVersion
      // 
      this.txtCoreVersion.Location = new System.Drawing.Point(252, 10);
      this.txtCoreVersion.Name = "txtCoreVersion";
      this.txtCoreVersion.Size = new System.Drawing.Size(100, 20);
      this.txtCoreVersion.TabIndex = 4;
      this.txtCoreVersion.Text = "0";
      this.txtCoreVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.toolTip1.SetToolTip(this.txtCoreVersion, "The Version of the Core");
      this.txtCoreVersion.TextChanged += new System.EventHandler(this.OnVersionChanged);
      // 
      // txtCoreLevel
      // 
      this.txtCoreLevel.Location = new System.Drawing.Point(67, 10);
      this.txtCoreLevel.Name = "txtCoreLevel";
      this.txtCoreLevel.Size = new System.Drawing.Size(100, 20);
      this.txtCoreLevel.TabIndex = 3;
      this.txtCoreLevel.Text = "0";
      this.txtCoreLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.toolTip1.SetToolTip(this.txtCoreLevel, "The Level of the Core");
      this.txtCoreLevel.TextChanged += new System.EventHandler(this.OnLevelChanged);
      // 
      // txtPkgVersion
      // 
      this.txtPkgVersion.Location = new System.Drawing.Point(434, 10);
      this.txtPkgVersion.Name = "txtPkgVersion";
      this.txtPkgVersion.Size = new System.Drawing.Size(75, 20);
      this.txtPkgVersion.TabIndex = 5;
      this.txtPkgVersion.Text = "1";
      this.txtPkgVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.toolTip1.SetToolTip(this.txtPkgVersion, "Version of the Package");
      this.txtPkgVersion.TextChanged += new System.EventHandler(this.OnPkgVersionChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(173, 13);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(73, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Core Version: ";
      this.toolTip1.SetToolTip(this.label3, "Version of the Core");
      
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.lstClasses);
      this.groupBox1.Controls.Add(this.toolStrip1);
      this.groupBox1.Location = new System.Drawing.Point(6, 36);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(554, 383);
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
      this.lstClasses.Size = new System.Drawing.Size(548, 339);
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
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 13);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(64, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Core Level: ";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(358, 13);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(70, 13);
      this.label5.TabIndex = 12;
      this.label5.Text = "Pkg Version: ";
      // 
      // ControlVersion
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.txtPkgVersion);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.txtCoreVersion);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtCoreLevel);
      this.Controls.Add(this.label2);
      this.Name = "ControlVersion";
      this.Size = new System.Drawing.Size(563, 422);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtCoreLevel;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.TextBox txtCoreVersion;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ListBox lstClasses;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton toolCmdDown;
    private System.Windows.Forms.ToolStripButton toolCmdUp;
    private System.Windows.Forms.TextBox txtPkgVersion;
    private System.Windows.Forms.Label label5;
  }
}
