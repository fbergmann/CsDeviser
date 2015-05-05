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
      this.components = new System.ComponentModel.Container();
      this.label1 = new System.Windows.Forms.Label();
      this.txtOutDir = new System.Windows.Forms.TextBox();
      this.cmdBrowseDir = new System.Windows.Forms.Button();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabLatex = new System.Windows.Forms.TabPage();
      this.cmdGenerateTex = new System.Windows.Forms.Button();
      this.cmdCompileTex = new System.Windows.Forms.Button();
      this.tabCompile = new System.Windows.Forms.TabPage();
      this.cmdCompileDependencies = new System.Windows.Forms.Button();
      this.cmdCompilePackage = new System.Windows.Forms.Button();
      this.cmdRemovePackageFromSource = new System.Windows.Forms.Button();
      this.cmdTest = new System.Windows.Forms.Button();
      this.cmdAddPackageToSource = new System.Windows.Forms.Button();
      this.txtResult = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtPackageName = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtPackageFile = new System.Windows.Forms.TextBox();
      this.cmdGeneratePackage = new System.Windows.Forms.Button();
      this.cmdOpenOutDir = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.cmdClose = new System.Windows.Forms.Button();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabLatex.SuspendLayout();
      this.tabCompile.SuspendLayout();
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
      this.txtOutDir.Size = new System.Drawing.Size(473, 20);
      this.txtOutDir.TabIndex = 1;
      // 
      // cmdBrowseDir
      // 
      this.cmdBrowseDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdBrowseDir.Location = new System.Drawing.Point(578, 15);
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
      this.tableLayoutPanel1.Size = new System.Drawing.Size(663, 491);
      this.tableLayoutPanel1.TabIndex = 3;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.tabControl1);
      this.panel1.Controls.Add(this.txtResult);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.txtPackageName);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.txtPackageFile);
      this.panel1.Controls.Add(this.cmdGeneratePackage);
      this.panel1.Controls.Add(this.cmdOpenOutDir);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.cmdBrowseDir);
      this.panel1.Controls.Add(this.txtOutDir);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(657, 450);
      this.panel1.TabIndex = 0;
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.tabLatex);
      this.tabControl1.Controls.Add(this.tabCompile);
      this.tabControl1.Location = new System.Drawing.Point(159, 102);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(494, 95);
      this.tabControl1.TabIndex = 7;
      // 
      // tabLatex
      // 
      this.tabLatex.Controls.Add(this.cmdGenerateTex);
      this.tabLatex.Controls.Add(this.cmdCompileTex);
      this.tabLatex.Location = new System.Drawing.Point(4, 22);
      this.tabLatex.Name = "tabLatex";
      this.tabLatex.Padding = new System.Windows.Forms.Padding(3);
      this.tabLatex.Size = new System.Drawing.Size(486, 69);
      this.tabLatex.TabIndex = 0;
      this.tabLatex.Text = "LaTeX generation";
      this.tabLatex.UseVisualStyleBackColor = true;
      // 
      // cmdGenerateTex
      // 
      this.cmdGenerateTex.Location = new System.Drawing.Point(6, 6);
      this.cmdGenerateTex.Name = "cmdGenerateTex";
      this.cmdGenerateTex.Size = new System.Drawing.Size(88, 23);
      this.cmdGenerateTex.TabIndex = 4;
      this.cmdGenerateTex.Text = "Generate Latex";
      this.toolTip1.SetToolTip(this.cmdGenerateTex, "generates the latex sources");
      this.cmdGenerateTex.UseVisualStyleBackColor = true;
      this.cmdGenerateTex.Click += new System.EventHandler(this.cmdGenerateTex_Click);
      // 
      // cmdCompileTex
      // 
      this.cmdCompileTex.Location = new System.Drawing.Point(100, 6);
      this.cmdCompileTex.Name = "cmdCompileTex";
      this.cmdCompileTex.Size = new System.Drawing.Size(75, 23);
      this.cmdCompileTex.TabIndex = 6;
      this.cmdCompileTex.Text = "Compile TeX";
      this.toolTip1.SetToolTip(this.cmdCompileTex, "compiles the latex sources");
      this.cmdCompileTex.UseVisualStyleBackColor = true;
      this.cmdCompileTex.Click += new System.EventHandler(this.cmdCompileTex_Click);
      // 
      // tabCompile
      // 
      this.tabCompile.Controls.Add(this.cmdCompileDependencies);
      this.tabCompile.Controls.Add(this.cmdCompilePackage);
      this.tabCompile.Controls.Add(this.cmdRemovePackageFromSource);
      this.tabCompile.Controls.Add(this.cmdTest);
      this.tabCompile.Controls.Add(this.cmdAddPackageToSource);
      this.tabCompile.Location = new System.Drawing.Point(4, 22);
      this.tabCompile.Name = "tabCompile";
      this.tabCompile.Padding = new System.Windows.Forms.Padding(3);
      this.tabCompile.Size = new System.Drawing.Size(486, 69);
      this.tabCompile.TabIndex = 1;
      this.tabCompile.Text = "Integration and Testing";
      this.tabCompile.UseVisualStyleBackColor = true;
      // 
      // cmdCompileDependencies
      // 
      this.cmdCompileDependencies.Location = new System.Drawing.Point(6, 6);
      this.cmdCompileDependencies.Name = "cmdCompileDependencies";
      this.cmdCompileDependencies.Size = new System.Drawing.Size(128, 23);
      this.cmdCompileDependencies.TabIndex = 7;
      this.cmdCompileDependencies.Text = "Compile Dependencies";
      this.toolTip1.SetToolTip(this.cmdCompileDependencies, "compiles the dependencies");
      this.cmdCompileDependencies.UseVisualStyleBackColor = true;
      this.cmdCompileDependencies.Click += new System.EventHandler(this.cmdCompileDependencies_Click);
      // 
      // cmdCompilePackage
      // 
      this.cmdCompilePackage.Location = new System.Drawing.Point(6, 35);
      this.cmdCompilePackage.Name = "cmdCompilePackage";
      this.cmdCompilePackage.Size = new System.Drawing.Size(234, 23);
      this.cmdCompilePackage.TabIndex = 10;
      this.cmdCompilePackage.Text = "Compile libSBML with package";
      this.toolTip1.SetToolTip(this.cmdCompilePackage, "compiles the package");
      this.cmdCompilePackage.UseVisualStyleBackColor = true;
      this.cmdCompilePackage.Click += new System.EventHandler(this.cmdCompilePackage_Click);
      // 
      // cmdRemovePackageFromSource
      // 
      this.cmdRemovePackageFromSource.Location = new System.Drawing.Point(295, 6);
      this.cmdRemovePackageFromSource.Name = "cmdRemovePackageFromSource";
      this.cmdRemovePackageFromSource.Size = new System.Drawing.Size(188, 23);
      this.cmdRemovePackageFromSource.TabIndex = 9;
      this.cmdRemovePackageFromSource.Text = "Remove Code From Source Dir";
      this.toolTip1.SetToolTip(this.cmdRemovePackageFromSource, "removes the package from the libsbml source dir");
      this.cmdRemovePackageFromSource.UseVisualStyleBackColor = true;
      this.cmdRemovePackageFromSource.Click += new System.EventHandler(this.cmdRemovePackageFromSource_Click);
      // 
      // cmdTest
      // 
      this.cmdTest.Location = new System.Drawing.Point(246, 35);
      this.cmdTest.Name = "cmdTest";
      this.cmdTest.Size = new System.Drawing.Size(237, 23);
      this.cmdTest.TabIndex = 12;
      this.cmdTest.Text = "Test libSBML";
      this.cmdTest.UseVisualStyleBackColor = true;
      this.cmdTest.Click += new System.EventHandler(this.cmdTest_Click);
      // 
      // cmdAddPackageToSource
      // 
      this.cmdAddPackageToSource.Location = new System.Drawing.Point(140, 6);
      this.cmdAddPackageToSource.Name = "cmdAddPackageToSource";
      this.cmdAddPackageToSource.Size = new System.Drawing.Size(153, 23);
      this.cmdAddPackageToSource.TabIndex = 8;
      this.cmdAddPackageToSource.Text = "Add Code To Source Dir";
      this.toolTip1.SetToolTip(this.cmdAddPackageToSource, "adds the package to the libsbml source dir");
      this.cmdAddPackageToSource.UseVisualStyleBackColor = true;
      this.cmdAddPackageToSource.Click += new System.EventHandler(this.cmdAddPackageToSource_Click);
      // 
      // txtResult
      // 
      this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtResult.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtResult.Location = new System.Drawing.Point(3, 203);
      this.txtResult.Multiline = true;
      this.txtResult.Name = "txtResult";
      this.txtResult.ReadOnly = true;
      this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtResult.Size = new System.Drawing.Size(651, 244);
      this.txtResult.TabIndex = 11;
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
      this.txtPackageName.Size = new System.Drawing.Size(444, 20);
      this.txtPackageName.TabIndex = 4;
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
      this.txtPackageFile.Size = new System.Drawing.Size(473, 20);
      this.txtPackageFile.TabIndex = 3;
      // 
      // cmdGeneratePackage
      // 
      this.cmdGeneratePackage.Location = new System.Drawing.Point(9, 102);
      this.cmdGeneratePackage.Name = "cmdGeneratePackage";
      this.cmdGeneratePackage.Size = new System.Drawing.Size(139, 23);
      this.cmdGeneratePackage.TabIndex = 6;
      this.cmdGeneratePackage.Text = "Generate Package Code";
      this.toolTip1.SetToolTip(this.cmdGeneratePackage, "generates the package sources");
      this.cmdGeneratePackage.UseVisualStyleBackColor = true;
      this.cmdGeneratePackage.Click += new System.EventHandler(this.cmdGeneratePackage_Click);
      // 
      // cmdOpenOutDir
      // 
      this.cmdOpenOutDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdOpenOutDir.Location = new System.Drawing.Point(549, 67);
      this.cmdOpenOutDir.Name = "cmdOpenOutDir";
      this.cmdOpenOutDir.Size = new System.Drawing.Size(104, 23);
      this.cmdOpenOutDir.TabIndex = 5;
      this.cmdOpenOutDir.Text = "Open Output Dir";
      this.toolTip1.SetToolTip(this.cmdOpenOutDir, "opens the specified output dir");
      this.cmdOpenOutDir.UseVisualStyleBackColor = true;
      this.cmdOpenOutDir.Click += new System.EventHandler(this.cmdOpenOutDir_Click);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.cmdClose);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(3, 459);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(657, 29);
      this.panel2.TabIndex = 1;
      // 
      // cmdClose
      // 
      this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.cmdClose.Location = new System.Drawing.Point(578, 3);
      this.cmdClose.Name = "cmdClose";
      this.cmdClose.Size = new System.Drawing.Size(75, 23);
      this.cmdClose.TabIndex = 0;
      this.cmdClose.Text = "&Close";
      this.cmdClose.UseVisualStyleBackColor = true;
      // 
      // FormGenerate
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.cmdClose;
      this.ClientSize = new System.Drawing.Size(663, 491);
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
      this.tabControl1.ResumeLayout(false);
      this.tabLatex.ResumeLayout(false);
      this.tabCompile.ResumeLayout(false);
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
    private System.Windows.Forms.Button cmdRemovePackageFromSource;
    private System.Windows.Forms.Button cmdAddPackageToSource;
    private System.Windows.Forms.Button cmdCompilePackage;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.Button cmdCompileDependencies;
    private System.Windows.Forms.Button cmdTest;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabLatex;
    private System.Windows.Forms.TabPage tabCompile;
  }
}