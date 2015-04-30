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
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.txtFullName = new System.Windows.Forms.TextBox();
      this.txtOffset = new System.Windows.Forms.TextBox();
      this.txtStartNumber = new System.Windows.Forms.TextBox();
      this.txtPackage = new System.Windows.Forms.TextBox();
      this.chkRequired = new System.Windows.Forms.CheckBox();
      this.txtAddDecls = new System.Windows.Forms.TextBox();
      this.txtAddImpls = new System.Windows.Forms.TextBox();
      this.chkRequiresAdditionalCode = new System.Windows.Forms.CheckBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.grpAdditionalFiles = new System.Windows.Forms.GroupBox();
      this.cmdBrowseImpls = new System.Windows.Forms.Button();
      this.cmdBrowseDecls = new System.Windows.Forms.Button();
      this.grpAdditionalFiles.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtFullName
      // 
      this.txtFullName.Location = new System.Drawing.Point(117, 54);
      this.txtFullName.Name = "txtFullName";
      this.txtFullName.Size = new System.Drawing.Size(239, 20);
      this.txtFullName.TabIndex = 2;
      this.toolTip1.SetToolTip(this.txtFullName, "The full name of the package as used in the specification and error messages");
      this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
      // 
      // txtOffset
      // 
      this.txtOffset.Location = new System.Drawing.Point(117, 290);
      this.txtOffset.Name = "txtOffset";
      this.txtOffset.Size = new System.Drawing.Size(100, 20);
      this.txtOffset.TabIndex = 6;
      this.txtOffset.Text = "0";
      this.txtOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.toolTip1.SetToolTip(this.txtOffset, "The offset for the validation numbers");
      this.txtOffset.TextChanged += new System.EventHandler(this.txtOffset_TextChanged);
      // 
      // txtStartNumber
      // 
      this.txtStartNumber.Location = new System.Drawing.Point(117, 176);
      this.txtStartNumber.Name = "txtStartNumber";
      this.txtStartNumber.Size = new System.Drawing.Size(100, 20);
      this.txtStartNumber.TabIndex = 5;
      this.txtStartNumber.Text = "0";
      this.txtStartNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.toolTip1.SetToolTip(this.txtStartNumber, "The starting number of the typecode enum. ");
      this.txtStartNumber.TextChanged += new System.EventHandler(this.txtStartNumber_TextChanged);
      // 
      // txtPackage
      // 
      this.txtPackage.Location = new System.Drawing.Point(117, 28);
      this.txtPackage.Name = "txtPackage";
      this.txtPackage.Size = new System.Drawing.Size(239, 20);
      this.txtPackage.TabIndex = 1;
      this.toolTip1.SetToolTip(this.txtPackage, "The name of the package");
      this.txtPackage.TextChanged += new System.EventHandler(this.txtPackage_TextChanged);
      this.txtPackage.Leave += new System.EventHandler(this.txtPackage_Leave);
      // 
      // chkRequired
      // 
      this.chkRequired.AutoSize = true;
      this.chkRequired.Location = new System.Drawing.Point(117, 83);
      this.chkRequired.Name = "chkRequired";
      this.chkRequired.Size = new System.Drawing.Size(64, 17);
      this.chkRequired.TabIndex = 3;
      this.chkRequired.Text = "required";
      this.toolTip1.SetToolTip(this.chkRequired, "Check if the package is required (i.e.: it changes math)");
      this.chkRequired.UseVisualStyleBackColor = true;
      this.chkRequired.CheckedChanged += new System.EventHandler(this.chkRequired_CheckedChanged);
      // 
      // txtAddDecls
      // 
      this.txtAddDecls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtAddDecls.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.txtAddDecls.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
      this.txtAddDecls.Location = new System.Drawing.Point(102, 19);
      this.txtAddDecls.Name = "txtAddDecls";
      this.txtAddDecls.Size = new System.Drawing.Size(374, 20);
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
      this.txtAddImpls.Size = new System.Drawing.Size(374, 20);
      this.txtAddImpls.TabIndex = 2;
      this.toolTip1.SetToolTip(this.txtAddImpls, "Additional implementations to be included in the Package extension source file");
      this.txtAddImpls.TextChanged += new System.EventHandler(this.txtAddImpls_TextChanged);
      // 
      // chkRequiresAdditionalCode
      // 
      this.chkRequiresAdditionalCode.AutoSize = true;
      this.chkRequiresAdditionalCode.Location = new System.Drawing.Point(198, 83);
      this.chkRequiresAdditionalCode.Name = "chkRequiresAdditionalCode";
      this.chkRequiresAdditionalCode.Size = new System.Drawing.Size(138, 17);
      this.chkRequiresAdditionalCode.TabIndex = 4;
      this.chkRequiresAdditionalCode.Text = "requires additional code";
      this.toolTip1.SetToolTip(this.chkRequiresAdditionalCode, "Check if the package is required (i.e.: it changes math)");
      this.chkRequiresAdditionalCode.UseVisualStyleBackColor = true;
      this.chkRequiresAdditionalCode.CheckedChanged += new System.EventHandler(this.OnCheckRequiresAdditionalCodeCheckedChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(51, 57);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(60, 13);
      this.label4.TabIndex = 10;
      this.label4.Text = "Full Name: ";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(70, 293);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(41, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Offset: ";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(61, 179);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Number: ";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(70, 31);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(41, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Name: ";
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
      // label5
      // 
      this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label5.Location = new System.Drawing.Point(51, 129);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(500, 44);
      this.label5.TabIndex = 17;
      this.label5.Text = "A package must define the starting point for the enumeration of SBMLTypeCode_t \r\n" +
    "values used to distinguish SBase derived objects. This should be an integer grea" +
    "ter \r\nthan 100 ending in 00. ";
      // 
      // label8
      // 
      this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label8.Location = new System.Drawing.Point(51, 243);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(500, 44);
      this.label8.TabIndex = 18;
      this.label8.Text = "A package must define the additional offset added to all validation rule numbers " +
    "\r\nto allow these to be uniquely stored. This should be a two digit integer follo" +
    "wed by 000000. ";
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
      this.grpAdditionalFiles.Location = new System.Drawing.Point(15, 348);
      this.grpAdditionalFiles.Name = "grpAdditionalFiles";
      this.grpAdditionalFiles.Size = new System.Drawing.Size(536, 78);
      this.grpAdditionalFiles.TabIndex = 19;
      this.grpAdditionalFiles.TabStop = false;
      this.grpAdditionalFiles.Text = " Additional code files: ";
      // 
      // cmdBrowseImpls
      // 
      this.cmdBrowseImpls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdBrowseImpls.Location = new System.Drawing.Point(482, 43);
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
      this.cmdBrowseDecls.Location = new System.Drawing.Point(482, 17);
      this.cmdBrowseDecls.Name = "cmdBrowseDecls";
      this.cmdBrowseDecls.Size = new System.Drawing.Size(48, 23);
      this.cmdBrowseDecls.TabIndex = 17;
      this.cmdBrowseDecls.Text = "...";
      this.cmdBrowseDecls.UseVisualStyleBackColor = true;
      this.cmdBrowseDecls.Click += new System.EventHandler(this.OnBrowseDeclsClick);
      // 
      // ControlPackage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.chkRequiresAdditionalCode);
      this.Controls.Add(this.grpAdditionalFiles);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.chkRequired);
      this.Controls.Add(this.txtFullName);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtOffset);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtStartNumber);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtPackage);
      this.Controls.Add(this.label1);
      this.Name = "ControlPackage";
      this.Size = new System.Drawing.Size(563, 451);
      this.grpAdditionalFiles.ResumeLayout(false);
      this.grpAdditionalFiles.PerformLayout();
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
    private System.Windows.Forms.TextBox txtFullName;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.CheckBox chkRequired;
    private System.Windows.Forms.TextBox txtAddDecls;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtAddImpls;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.GroupBox grpAdditionalFiles;
    private System.Windows.Forms.CheckBox chkRequiresAdditionalCode;
    private System.Windows.Forms.Button cmdBrowseImpls;
    private System.Windows.Forms.Button cmdBrowseDecls;
  }
}
