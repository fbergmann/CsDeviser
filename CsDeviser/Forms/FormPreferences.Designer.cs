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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.cmdCancel = new System.Windows.Forms.Button();
      this.cmdOK = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtPython = new System.Windows.Forms.TextBox();
      this.cmdBrowsePython = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.txtDeviserRepo = new System.Windows.Forms.TextBox();
      this.cmdBrowseRepo = new System.Windows.Forms.Button();
      this.cmdBrowseOutput = new System.Windows.Forms.Button();
      this.txtDefaultDir = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
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
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(25, 35);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(97, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Python Interpreter: ";
      // 
      // txtPython
      // 
      this.txtPython.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPython.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.txtPython.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
      this.txtPython.Location = new System.Drawing.Point(128, 32);
      this.txtPython.Name = "txtPython";
      this.txtPython.Size = new System.Drawing.Size(406, 20);
      this.txtPython.TabIndex = 1;
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
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(9, 61);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(113, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "DEVISER Repository: ";
      // 
      // txtDeviserRepo
      // 
      this.txtDeviserRepo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtDeviserRepo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.txtDeviserRepo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
      this.txtDeviserRepo.Location = new System.Drawing.Point(128, 58);
      this.txtDeviserRepo.Name = "txtDeviserRepo";
      this.txtDeviserRepo.Size = new System.Drawing.Size(406, 20);
      this.txtDeviserRepo.TabIndex = 4;
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
      this.txtDefaultDir.Location = new System.Drawing.Point(128, 85);
      this.txtDefaultDir.Name = "txtDefaultDir";
      this.txtDefaultDir.Size = new System.Drawing.Size(406, 20);
      this.txtDefaultDir.TabIndex = 7;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(21, 88);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(101, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Default Output Dir:  ";
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
  }
}