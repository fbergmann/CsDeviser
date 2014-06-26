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
      this.SuspendLayout();
      // 
      // txtExtensionPoint
      // 
      this.txtExtensionPoint.Location = new System.Drawing.Point(121, 19);
      this.txtExtensionPoint.Name = "txtExtensionPoint";
      this.txtExtensionPoint.Size = new System.Drawing.Size(143, 20);
      this.txtExtensionPoint.TabIndex = 5;
      this.toolTip1.SetToolTip(this.txtExtensionPoint, "The extension point of this plugin");
      this.txtExtensionPoint.TextChanged += new System.EventHandler(this.txtExtensionPoint_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(32, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(83, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "ExtensionPoint: ";
      // 
      // ControlPlugin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.txtExtensionPoint);
      this.Controls.Add(this.label1);
      this.Name = "ControlPlugin";
      this.Size = new System.Drawing.Size(701, 322);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtExtensionPoint;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ToolTip toolTip1;
  }
}
