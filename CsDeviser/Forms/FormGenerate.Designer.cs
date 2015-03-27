namespace CsDeviser.Forms
{
  partial class FormGenerate
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.txtOutDir = new System.Windows.Forms.TextBox();
      this.cmdBrowseDir = new System.Windows.Forms.Button();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.txtResult = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtPackageName = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtPackageFile = new System.Windows.Forms.TextBox();
      this.cmdGeneratePackage = new System.Windows.Forms.Button();
      this.cmdGenerateTex = new System.Windows.Forms.Button();
      this.cmdOpenOutDir = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.cmdClose = new System.Windows.Forms.Button();
      this.cmdCompileTex = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(32, 20);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(61, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Output Dir: ";
      // 
      // txtOutDir
      // 
      this.txtOutDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtOutDir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.txtOutDir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
      this.txtOutDir.Location = new System.Drawing.Point(99, 17);
      this.txtOutDir.Name = "txtOutDir";
      this.txtOutDir.Size = new System.Drawing.Size(434, 20);
      this.txtOutDir.TabIndex = 1;
      // 
      // cmdBrowseDir
      // 
      this.cmdBrowseDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdBrowseDir.Location = new System.Drawing.Point(539, 15);
      this.cmdBrowseDir.Name = "cmdBrowseDir";
      this.cmdBrowseDir.Size = new System.Drawing.Size(75, 23);
      this.cmdBrowseDir.TabIndex = 2;
      this.cmdBrowseDir.Text = "...";
      this.cmdBrowseDir.UseVisualStyleBackColor = true;
      this.cmdBrowseDir.Click += new System.EventHandler(this.cmdBrowseDir_Click);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 441);
      this.tableLayoutPanel1.TabIndex = 3;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.cmdCompileTex);
      this.panel1.Controls.Add(this.txtResult);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.txtPackageName);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.txtPackageFile);
      this.panel1.Controls.Add(this.cmdGeneratePackage);
      this.panel1.Controls.Add(this.cmdGenerateTex);
      this.panel1.Controls.Add(this.cmdOpenOutDir);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.cmdBrowseDir);
      this.panel1.Controls.Add(this.txtOutDir);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(618, 400);
      this.panel1.TabIndex = 0;
      // 
      // txtResult
      // 
      this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtResult.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtResult.Location = new System.Drawing.Point(3, 140);
      this.txtResult.Multiline = true;
      this.txtResult.Name = "txtResult";
      this.txtResult.ReadOnly = true;
      this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtResult.Size = new System.Drawing.Size(612, 257);
      this.txtResult.TabIndex = 10;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 72);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(87, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "Package Name: ";
      // 
      // txtPackageName
      // 
      this.txtPackageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPackageName.Location = new System.Drawing.Point(99, 69);
      this.txtPackageName.Name = "txtPackageName";
      this.txtPackageName.Size = new System.Drawing.Size(434, 20);
      this.txtPackageName.TabIndex = 9;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(18, 46);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(75, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Package File: ";
      // 
      // txtPackageFile
      // 
      this.txtPackageFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPackageFile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.txtPackageFile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
      this.txtPackageFile.Location = new System.Drawing.Point(99, 43);
      this.txtPackageFile.Name = "txtPackageFile";
      this.txtPackageFile.Size = new System.Drawing.Size(434, 20);
      this.txtPackageFile.TabIndex = 7;
      // 
      // cmdGeneratePackage
      // 
      this.cmdGeneratePackage.Location = new System.Drawing.Point(385, 111);
      this.cmdGeneratePackage.Name = "cmdGeneratePackage";
      this.cmdGeneratePackage.Size = new System.Drawing.Size(137, 23);
      this.cmdGeneratePackage.TabIndex = 5;
      this.cmdGeneratePackage.Text = "Generate Package";
      this.cmdGeneratePackage.UseVisualStyleBackColor = true;
      this.cmdGeneratePackage.Click += new System.EventHandler(this.cmdGeneratePackage_Click);
      // 
      // cmdGenerateTex
      // 
      this.cmdGenerateTex.Location = new System.Drawing.Point(242, 111);
      this.cmdGenerateTex.Name = "cmdGenerateTex";
      this.cmdGenerateTex.Size = new System.Drawing.Size(137, 23);
      this.cmdGenerateTex.TabIndex = 4;
      this.cmdGenerateTex.Text = "Generate Latex";
      this.cmdGenerateTex.UseVisualStyleBackColor = true;
      this.cmdGenerateTex.Click += new System.EventHandler(this.cmdGenerateTex_Click);
      // 
      // cmdOpenOutDir
      // 
      this.cmdOpenOutDir.Location = new System.Drawing.Point(99, 111);
      this.cmdOpenOutDir.Name = "cmdOpenOutDir";
      this.cmdOpenOutDir.Size = new System.Drawing.Size(137, 23);
      this.cmdOpenOutDir.TabIndex = 3;
      this.cmdOpenOutDir.Text = "Open OutDir";
      this.cmdOpenOutDir.UseVisualStyleBackColor = true;
      this.cmdOpenOutDir.Click += new System.EventHandler(this.cmdOpenOutDir_Click);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.cmdClose);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(3, 409);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(618, 29);
      this.panel2.TabIndex = 1;
      // 
      // cmdClose
      // 
      this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.cmdClose.Location = new System.Drawing.Point(539, 3);
      this.cmdClose.Name = "cmdClose";
      this.cmdClose.Size = new System.Drawing.Size(75, 23);
      this.cmdClose.TabIndex = 0;
      this.cmdClose.Text = "&Close";
      this.cmdClose.UseVisualStyleBackColor = true;
      // 
      // cmdCompileTex
      // 
      this.cmdCompileTex.Location = new System.Drawing.Point(528, 111);
      this.cmdCompileTex.Name = "cmdCompileTex";
      this.cmdCompileTex.Size = new System.Drawing.Size(75, 23);
      this.cmdCompileTex.TabIndex = 11;
      this.cmdCompileTex.Text = "Compile TeX";
      this.cmdCompileTex.UseVisualStyleBackColor = true;
      this.cmdCompileTex.Click += new System.EventHandler(this.cmdCompileTex_Click);
      // 
      // FormGenerate
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.cmdClose;
      this.ClientSize = new System.Drawing.Size(624, 441);
      this.Controls.Add(this.tableLayoutPanel1);
      this.MinimumSize = new System.Drawing.Size(640, 480);
      this.Name = "FormGenerate";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Generate ... ";
      this.Load += new System.EventHandler(this.FormGenerate_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtOutDir;
    private System.Windows.Forms.Button cmdBrowseDir;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button cmdGeneratePackage;
    private System.Windows.Forms.Button cmdGenerateTex;
    private System.Windows.Forms.Button cmdOpenOutDir;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button cmdClose;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtPackageName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtPackageFile;
    private System.Windows.Forms.TextBox txtResult;
    private System.Windows.Forms.Button cmdCompileTex;
  }
}