namespace CsDeviser.Forms
{
  partial class FormPreferences
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.cmdBrowseDependencies = new System.Windows.Forms.Button();
      this.txtDependenciesSourceDir = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.cmdBrowseCMake = new System.Windows.Forms.Button();
      this.txtCmake = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.cmbCompilers = new System.Windows.Forms.ComboBox();
      this.label7 = new System.Windows.Forms.Label();
      this.cmdBrowseSource = new System.Windows.Forms.Button();
      this.txtlibSBMLSource = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.cmdBrowseMikTex = new System.Windows.Forms.Button();
      this.txtMikTex = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.cmdBrowsePkgSpec = new System.Windows.Forms.Button();
      this.txtSBMLPkgSpeciDir = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.cmdBrowseOutput = new System.Windows.Forms.Button();
      this.txtDefaultDir = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.cmdBrowseRepo = new System.Windows.Forms.Button();
      this.txtDeviserRepo = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.cmdBrowsePython = new System.Windows.Forms.Button();
      this.txtPython = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.cmdOK = new System.Windows.Forms.Button();
      this.cmdCancel = new System.Windows.Forms.Button();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.cmdBrowseSwig = new System.Windows.Forms.Button();
      this.txtSwig = new System.Windows.Forms.TextBox();
      this.label13 = new System.Windows.Forms.Label();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
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
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.cmdBrowseSwig);
      this.panel1.Controls.Add(this.txtSwig);
      this.panel1.Controls.Add(this.label13);
      this.panel1.Controls.Add(this.cmdBrowseDependencies);
      this.panel1.Controls.Add(this.txtDependenciesSourceDir);
      this.panel1.Controls.Add(this.label12);
      this.panel1.Controls.Add(this.label11);
      this.panel1.Controls.Add(this.label10);
      this.panel1.Controls.Add(this.label9);
      this.panel1.Controls.Add(this.cmdBrowseCMake);
      this.panel1.Controls.Add(this.txtCmake);
      this.panel1.Controls.Add(this.label8);
      this.panel1.Controls.Add(this.cmbCompilers);
      this.panel1.Controls.Add(this.label7);
      this.panel1.Controls.Add(this.cmdBrowseSource);
      this.panel1.Controls.Add(this.txtlibSBMLSource);
      this.panel1.Controls.Add(this.label6);
      this.panel1.Controls.Add(this.cmdBrowseMikTex);
      this.panel1.Controls.Add(this.txtMikTex);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.cmdBrowsePkgSpec);
      this.panel1.Controls.Add(this.txtSBMLPkgSpeciDir);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.cmdBrowseOutput);
      this.panel1.Controls.Add(this.txtDefaultDir);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.cmdBrowseRepo);
      this.panel1.Controls.Add(this.txtDeviserRepo);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.cmdBrowsePython);
      this.panel1.Controls.Add(this.txtPython);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(618, 400);
      this.panel1.TabIndex = 0;
      // 
      // cmdBrowseDependencies
      // 
      this.cmdBrowseDependencies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdBrowseDependencies.Location = new System.Drawing.Point(540, 287);
      this.cmdBrowseDependencies.Name = "cmdBrowseDependencies";
      this.cmdBrowseDependencies.Size = new System.Drawing.Size(75, 23);
      this.cmdBrowseDependencies.TabIndex = 30;
      this.cmdBrowseDependencies.Text = "...";
      this.cmdBrowseDependencies.UseVisualStyleBackColor = true;
      this.cmdBrowseDependencies.Click += new System.EventHandler(this.cmdBrowseDependencies_Click);
      // 
      // txtDependenciesSourceDir
      // 
      this.txtDependenciesSourceDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtDependenciesSourceDir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.txtDependenciesSourceDir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
      this.txtDependenciesSourceDir.Location = new System.Drawing.Point(142, 289);
      this.txtDependenciesSourceDir.Name = "txtDependenciesSourceDir";
      this.txtDependenciesSourceDir.Size = new System.Drawing.Size(392, 20);
      this.txtDependenciesSourceDir.TabIndex = 29;
      this.toolTip1.SetToolTip(this.txtDependenciesSourceDir, "full path to libsbml dependencies sources");
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(5, 292);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(130, 13);
      this.label12.TabIndex = 28;
      this.label12.Text = "Dependencies Source dir:";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(9, 194);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(345, 13);
      this.label11.TabIndex = 27;
      this.label11.Text = "The next four entries are needed, to compile the package with libSBML:";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(9, 118);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(341, 13);
      this.label10.TabIndex = 26;
      this.label10.Text = "The next two entries are needed, in order to compile the latex sources: ";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(9, 16);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(366, 13);
      this.label9.TabIndex = 25;
      this.label9.Text = "The next three entries are needed, to generate the package / latex sources:";
      // 
      // cmdBrowseCMake
      // 
      this.cmdBrowseCMake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdBrowseCMake.Location = new System.Drawing.Point(540, 261);
      this.cmdBrowseCMake.Name = "cmdBrowseCMake";
      this.cmdBrowseCMake.Size = new System.Drawing.Size(75, 23);
      this.cmdBrowseCMake.TabIndex = 24;
      this.cmdBrowseCMake.Text = "...";
      this.cmdBrowseCMake.UseVisualStyleBackColor = true;
      this.cmdBrowseCMake.Click += new System.EventHandler(this.cmdBrowseCMake_Click);
      // 
      // txtCmake
      // 
      this.txtCmake.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtCmake.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.txtCmake.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
      this.txtCmake.Location = new System.Drawing.Point(142, 263);
      this.txtCmake.Name = "txtCmake";
      this.txtCmake.Size = new System.Drawing.Size(392, 20);
      this.txtCmake.TabIndex = 23;
      this.toolTip1.SetToolTip(this.txtCmake, "full path to cmake executable");
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(32, 266);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(103, 13);
      this.label8.TabIndex = 22;
      this.label8.Text = "CMake Executable: ";
      // 
      // cmbCompilers
      // 
      this.cmbCompilers.FormattingEnabled = true;
      this.cmbCompilers.Location = new System.Drawing.Point(142, 236);
      this.cmbCompilers.Name = "cmbCompilers";
      this.cmbCompilers.Size = new System.Drawing.Size(392, 21);
      this.cmbCompilers.TabIndex = 21;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(24, 239);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(112, 13);
      this.label7.TabIndex = 18;
      this.label7.Text = "Visual Studio Version: ";
      // 
      // cmdBrowseSource
      // 
      this.cmdBrowseSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdBrowseSource.Location = new System.Drawing.Point(540, 208);
      this.cmdBrowseSource.Name = "cmdBrowseSource";
      this.cmdBrowseSource.Size = new System.Drawing.Size(75, 23);
      this.cmdBrowseSource.TabIndex = 17;
      this.cmdBrowseSource.Text = "...";
      this.cmdBrowseSource.UseVisualStyleBackColor = true;
      this.cmdBrowseSource.Click += new System.EventHandler(this.cmdBrowseSource_Click);
      // 
      // txtlibSBMLSource
      // 
      this.txtlibSBMLSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtlibSBMLSource.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.txtlibSBMLSource.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
      this.txtlibSBMLSource.Location = new System.Drawing.Point(142, 210);
      this.txtlibSBMLSource.Name = "txtlibSBMLSource";
      this.txtlibSBMLSource.Size = new System.Drawing.Size(392, 20);
      this.txtlibSBMLSource.TabIndex = 16;
      this.toolTip1.SetToolTip(this.txtlibSBMLSource, "A libSBML source dir, either a checkout, or the release archive without many pack" +
        "ages.");
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(45, 213);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(90, 13);
      this.label6.TabIndex = 15;
      this.label6.Text = "SBML Source dir:";
      // 
      // cmdBrowseMikTex
      // 
      this.cmdBrowseMikTex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdBrowseMikTex.Location = new System.Drawing.Point(540, 158);
      this.cmdBrowseMikTex.Name = "cmdBrowseMikTex";
      this.cmdBrowseMikTex.Size = new System.Drawing.Size(75, 23);
      this.cmdBrowseMikTex.TabIndex = 14;
      this.cmdBrowseMikTex.Text = "...";
      this.cmdBrowseMikTex.UseVisualStyleBackColor = true;
      this.cmdBrowseMikTex.Click += new System.EventHandler(this.cmdBrowseMikTex_Click);
      // 
      // txtMikTex
      // 
      this.txtMikTex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtMikTex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.txtMikTex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
      this.txtMikTex.Location = new System.Drawing.Point(142, 160);
      this.txtMikTex.Name = "txtMikTex";
      this.txtMikTex.Size = new System.Drawing.Size(392, 20);
      this.txtMikTex.TabIndex = 13;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(58, 163);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(78, 13);
      this.label5.TabIndex = 12;
      this.label5.Text = "MikTeX bin dir:";
      // 
      // cmdBrowsePkgSpec
      // 
      this.cmdBrowsePkgSpec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdBrowsePkgSpec.Location = new System.Drawing.Point(540, 132);
      this.cmdBrowsePkgSpec.Name = "cmdBrowsePkgSpec";
      this.cmdBrowsePkgSpec.Size = new System.Drawing.Size(75, 23);
      this.cmdBrowsePkgSpec.TabIndex = 11;
      this.cmdBrowsePkgSpec.Text = "...";
      this.cmdBrowsePkgSpec.UseVisualStyleBackColor = true;
      this.cmdBrowsePkgSpec.Click += new System.EventHandler(this.cmdBrowsePkgSpec_Click);
      // 
      // txtSBMLPkgSpeciDir
      // 
      this.txtSBMLPkgSpeciDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtSBMLPkgSpeciDir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.txtSBMLPkgSpeciDir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
      this.txtSBMLPkgSpeciDir.Location = new System.Drawing.Point(142, 134);
      this.txtSBMLPkgSpeciDir.Name = "txtSBMLPkgSpeciDir";
      this.txtSBMLPkgSpeciDir.Size = new System.Drawing.Size(392, 20);
      this.txtSBMLPkgSpeciDir.TabIndex = 10;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(45, 137);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(91, 13);
      this.label4.TabIndex = 9;
      this.label4.Text = "sbmlpkgspec Dir: ";
      // 
      // cmdBrowseOutput
      // 
      this.cmdBrowseOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdBrowseOutput.Location = new System.Drawing.Point(540, 83);
      this.cmdBrowseOutput.Name = "cmdBrowseOutput";
      this.cmdBrowseOutput.Size = new System.Drawing.Size(75, 23);
      this.cmdBrowseOutput.TabIndex = 8;
      this.cmdBrowseOutput.Text = "...";
      this.cmdBrowseOutput.UseVisualStyleBackColor = true;
      this.cmdBrowseOutput.Click += new System.EventHandler(this.cmdBrowseOutput_Click);
      // 
      // txtDefaultDir
      // 
      this.txtDefaultDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtDefaultDir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.txtDefaultDir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
      this.txtDefaultDir.Location = new System.Drawing.Point(142, 85);
      this.txtDefaultDir.Name = "txtDefaultDir";
      this.txtDefaultDir.Size = new System.Drawing.Size(392, 20);
      this.txtDefaultDir.TabIndex = 7;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(35, 88);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(101, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Default Output Dir:  ";
      // 
      // cmdBrowseRepo
      // 
      this.cmdBrowseRepo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdBrowseRepo.Location = new System.Drawing.Point(540, 56);
      this.cmdBrowseRepo.Name = "cmdBrowseRepo";
      this.cmdBrowseRepo.Size = new System.Drawing.Size(75, 23);
      this.cmdBrowseRepo.TabIndex = 5;
      this.cmdBrowseRepo.Text = "...";
      this.cmdBrowseRepo.UseVisualStyleBackColor = true;
      this.cmdBrowseRepo.Click += new System.EventHandler(this.cmdBrowseRepo_Click);
      // 
      // txtDeviserRepo
      // 
      this.txtDeviserRepo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtDeviserRepo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.txtDeviserRepo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
      this.txtDeviserRepo.Location = new System.Drawing.Point(142, 58);
      this.txtDeviserRepo.Name = "txtDeviserRepo";
      this.txtDeviserRepo.Size = new System.Drawing.Size(392, 20);
      this.txtDeviserRepo.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(23, 61);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(113, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "DEVISER Repository: ";
      // 
      // cmdBrowsePython
      // 
      this.cmdBrowsePython.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdBrowsePython.Location = new System.Drawing.Point(540, 30);
      this.cmdBrowsePython.Name = "cmdBrowsePython";
      this.cmdBrowsePython.Size = new System.Drawing.Size(75, 23);
      this.cmdBrowsePython.TabIndex = 2;
      this.cmdBrowsePython.Text = "...";
      this.cmdBrowsePython.UseVisualStyleBackColor = true;
      this.cmdBrowsePython.Click += new System.EventHandler(this.cmdBrowsePython_Click);
      // 
      // txtPython
      // 
      this.txtPython.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPython.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.txtPython.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
      this.txtPython.Location = new System.Drawing.Point(142, 32);
      this.txtPython.Name = "txtPython";
      this.txtPython.Size = new System.Drawing.Size(392, 20);
      this.txtPython.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(39, 35);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(97, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Python Interpreter: ";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.cmdOK);
      this.panel2.Controls.Add(this.cmdCancel);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(3, 409);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(618, 29);
      this.panel2.TabIndex = 1;
      // 
      // cmdOK
      // 
      this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.cmdOK.Location = new System.Drawing.Point(459, 3);
      this.cmdOK.Name = "cmdOK";
      this.cmdOK.Size = new System.Drawing.Size(75, 23);
      this.cmdOK.TabIndex = 1;
      this.cmdOK.Text = "&OK";
      this.cmdOK.UseVisualStyleBackColor = true;
      // 
      // cmdCancel
      // 
      this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdCancel.Location = new System.Drawing.Point(540, 3);
      this.cmdCancel.Name = "cmdCancel";
      this.cmdCancel.Size = new System.Drawing.Size(75, 23);
      this.cmdCancel.TabIndex = 0;
      this.cmdCancel.Text = "&Cancel";
      this.cmdCancel.UseVisualStyleBackColor = true;
      // 
      // cmdBrowseSwig
      // 
      this.cmdBrowseSwig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdBrowseSwig.Location = new System.Drawing.Point(540, 313);
      this.cmdBrowseSwig.Name = "cmdBrowseSwig";
      this.cmdBrowseSwig.Size = new System.Drawing.Size(75, 23);
      this.cmdBrowseSwig.TabIndex = 33;
      this.cmdBrowseSwig.Text = "...";
      this.cmdBrowseSwig.UseVisualStyleBackColor = true;
      this.cmdBrowseSwig.Click += new System.EventHandler(this.cmdBrowseSwig_Click);
      // 
      // txtSwig
      // 
      this.txtSwig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtSwig.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.txtSwig.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
      this.txtSwig.Location = new System.Drawing.Point(142, 315);
      this.txtSwig.Name = "txtSwig";
      this.txtSwig.Size = new System.Drawing.Size(392, 20);
      this.txtSwig.TabIndex = 32;
      this.toolTip1.SetToolTip(this.txtSwig, "full path to cmake executable");
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(32, 318);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(92, 13);
      this.label13.TabIndex = 31;
      this.label13.Text = "Swig Executable: ";
      // 
      // FormPreferences
      // 
      this.AcceptButton = this.cmdOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.cmdCancel;
      this.ClientSize = new System.Drawing.Size(624, 441);
      this.Controls.Add(this.tableLayoutPanel1);
      this.MinimumSize = new System.Drawing.Size(640, 480);
      this.Name = "FormPreferences";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Preferences";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button cmdOK;
    private System.Windows.Forms.Button cmdCancel;
    private System.Windows.Forms.Button cmdBrowsePython;
    private System.Windows.Forms.TextBox txtPython;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button cmdBrowseRepo;
    private System.Windows.Forms.TextBox txtDeviserRepo;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button cmdBrowseOutput;
    private System.Windows.Forms.TextBox txtDefaultDir;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button cmdBrowsePkgSpec;
    private System.Windows.Forms.TextBox txtSBMLPkgSpeciDir;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button cmdBrowseMikTex;
    private System.Windows.Forms.TextBox txtMikTex;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox cmbCompilers;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button cmdBrowseSource;
    private System.Windows.Forms.TextBox txtlibSBMLSource;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button cmdBrowseCMake;
    private System.Windows.Forms.TextBox txtCmake;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button cmdBrowseDependencies;
    private System.Windows.Forms.TextBox txtDependenciesSourceDir;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.Button cmdBrowseSwig;
    private System.Windows.Forms.TextBox txtSwig;
    private System.Windows.Forms.Label label13;
  }
}