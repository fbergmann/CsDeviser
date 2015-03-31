namespace CsDeviser.Forms
{
  partial class FormYuml
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
      this.cmpStyle = new System.Windows.Forms.ComboBox();
      this.chkFitDrawing = new System.Windows.Forms.CheckBox();
      this.cmdSaveAs = new System.Windows.Forms.Button();
      this.cmdUpdateImage = new System.Windows.Forms.Button();
      this.cmdClose = new System.Windows.Forms.Button();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabImage = new System.Windows.Forms.TabPage();
      this.pnlPicture = new System.Windows.Forms.Panel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.tabYuml = new System.Windows.Forms.TabPage();
      this.txtYuml = new System.Windows.Forms.TextBox();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabImage.SuspendLayout();
      this.pnlPicture.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.tabYuml.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 441);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.cmpStyle);
      this.panel1.Controls.Add(this.chkFitDrawing);
      this.panel1.Controls.Add(this.cmdSaveAs);
      this.panel1.Controls.Add(this.cmdUpdateImage);
      this.panel1.Controls.Add(this.cmdClose);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 408);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(618, 30);
      this.panel1.TabIndex = 0;
      // 
      // cmpStyle
      // 
      this.cmpStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmpStyle.FormattingEnabled = true;
      this.cmpStyle.Items.AddRange(new object[] {
            "plain",
            "nofunky",
            "scruffy"});
      this.cmpStyle.Location = new System.Drawing.Point(385, 5);
      this.cmpStyle.Name = "cmpStyle";
      this.cmpStyle.Size = new System.Drawing.Size(80, 21);
      this.cmpStyle.TabIndex = 4;
      this.cmpStyle.Text = "plain";
      this.toolTip1.SetToolTip(this.cmpStyle, "Choose the style of the drawing");
      this.cmpStyle.SelectedIndexChanged += new System.EventHandler(this.OnStyleIndexChanged);
      // 
      // chkFitDrawing
      // 
      this.chkFitDrawing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.chkFitDrawing.AutoSize = true;
      this.chkFitDrawing.Checked = true;
      this.chkFitDrawing.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkFitDrawing.Location = new System.Drawing.Point(471, 7);
      this.chkFitDrawing.Name = "chkFitDrawing";
      this.chkFitDrawing.Size = new System.Drawing.Size(63, 17);
      this.chkFitDrawing.TabIndex = 3;
      this.chkFitDrawing.Text = "Fit UML";
      this.toolTip1.SetToolTip(this.chkFitDrawing, "If checked, the whole diagram will be sized to fit the dialog.");
      this.chkFitDrawing.UseVisualStyleBackColor = true;
      this.chkFitDrawing.CheckedChanged += new System.EventHandler(this.OnFitDrawingCheckedChanged);
      // 
      // cmdSaveAs
      // 
      this.cmdSaveAs.Location = new System.Drawing.Point(84, 3);
      this.cmdSaveAs.Name = "cmdSaveAs";
      this.cmdSaveAs.Size = new System.Drawing.Size(75, 23);
      this.cmdSaveAs.TabIndex = 2;
      this.cmdSaveAs.Text = "&Save As";
      this.cmdSaveAs.UseVisualStyleBackColor = true;
      this.cmdSaveAs.Click += new System.EventHandler(this.OnSaveAsClick);
      // 
      // cmdUpdateImage
      // 
      this.cmdUpdateImage.Location = new System.Drawing.Point(3, 3);
      this.cmdUpdateImage.Name = "cmdUpdateImage";
      this.cmdUpdateImage.Size = new System.Drawing.Size(75, 23);
      this.cmdUpdateImage.TabIndex = 1;
      this.cmdUpdateImage.Text = "&Update";
      this.toolTip1.SetToolTip(this.cmdUpdateImage, "Generates a new Image from the Description");
      this.cmdUpdateImage.UseVisualStyleBackColor = true;
      this.cmdUpdateImage.Click += new System.EventHandler(this.OnUpdateClick);
      // 
      // cmdClose
      // 
      this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdClose.Location = new System.Drawing.Point(540, 3);
      this.cmdClose.Name = "cmdClose";
      this.cmdClose.Size = new System.Drawing.Size(75, 23);
      this.cmdClose.TabIndex = 0;
      this.cmdClose.Text = "&Close";
      this.cmdClose.UseVisualStyleBackColor = true;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabImage);
      this.tabControl1.Controls.Add(this.tabYuml);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(3, 3);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(618, 399);
      this.tabControl1.TabIndex = 1;
      // 
      // tabImage
      // 
      this.tabImage.Controls.Add(this.pnlPicture);
      this.tabImage.Location = new System.Drawing.Point(4, 22);
      this.tabImage.Name = "tabImage";
      this.tabImage.Padding = new System.Windows.Forms.Padding(3);
      this.tabImage.Size = new System.Drawing.Size(610, 373);
      this.tabImage.TabIndex = 0;
      this.tabImage.Text = "YuML Display";
      this.tabImage.UseVisualStyleBackColor = true;
      // 
      // pnlPicture
      // 
      this.pnlPicture.AutoScroll = true;
      this.pnlPicture.Controls.Add(this.pictureBox1);
      this.pnlPicture.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlPicture.Location = new System.Drawing.Point(3, 3);
      this.pnlPicture.Name = "pnlPicture";
      this.pnlPicture.Size = new System.Drawing.Size(604, 367);
      this.pnlPicture.TabIndex = 1;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(0, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(604, 367);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // tabYuml
      // 
      this.tabYuml.Controls.Add(this.txtYuml);
      this.tabYuml.Location = new System.Drawing.Point(4, 22);
      this.tabYuml.Name = "tabYuml";
      this.tabYuml.Padding = new System.Windows.Forms.Padding(3);
      this.tabYuml.Size = new System.Drawing.Size(610, 373);
      this.tabYuml.TabIndex = 1;
      this.tabYuml.Text = "Edit";
      this.tabYuml.UseVisualStyleBackColor = true;
      // 
      // txtYuml
      // 
      this.txtYuml.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtYuml.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtYuml.Location = new System.Drawing.Point(3, 3);
      this.txtYuml.Multiline = true;
      this.txtYuml.Name = "txtYuml";
      this.txtYuml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtYuml.Size = new System.Drawing.Size(604, 367);
      this.txtYuml.TabIndex = 0;
      this.txtYuml.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
      // 
      // FormYuml
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.cmdClose;
      this.ClientSize = new System.Drawing.Size(624, 441);
      this.Controls.Add(this.tableLayoutPanel1);
      this.MinimumSize = new System.Drawing.Size(640, 480);
      this.Name = "FormYuml";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "UML";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabImage.ResumeLayout(false);
      this.pnlPicture.ResumeLayout(false);
      this.pnlPicture.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.tabYuml.ResumeLayout(false);
      this.tabYuml.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button cmdUpdateImage;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.Button cmdClose;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabImage;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.TabPage tabYuml;
    private System.Windows.Forms.TextBox txtYuml;
    private System.Windows.Forms.Panel pnlPicture;
    private System.Windows.Forms.Button cmdSaveAs;
    private System.Windows.Forms.CheckBox chkFitDrawing;
    private System.Windows.Forms.ComboBox cmpStyle;
  }
}