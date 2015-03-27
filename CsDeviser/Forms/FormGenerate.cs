using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibDeviser;

namespace CsDeviser.Forms
{
  public partial class FormGenerate : Form
  {
    public FormGenerate()
    {
      InitializeComponent();
    }

    private void cmdBrowseDir_Click(object sender, EventArgs e)
    {

      string defaultPath = !string.IsNullOrWhiteSpace(OutDir) ? Path.GetFullPath(OutDir)
        : null;
      using (var dialog = new FolderBrowserDialog
      {
        Description = "Locate Output Dir",
        SelectedPath = defaultPath
      })
      {
        if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
          txtOutDir.Text = dialog.SelectedPath;
      }
    }

    private void cmdOpenOutDir_Click(object sender, EventArgs e)
    {
      Deviser.OpenDir(txtOutDir.Text);
      txtResult.Text = "Opened output dir";
    }

    public string OutDir
    {
      get
      {
        return txtOutDir.Text;
      }
    }

    public string Package
    {
      get { return txtPackageFile.Text; }
      set { txtPackageFile.Text = value; }
    }

    public string PackageName {
      get { return txtPackageName.Text; }
      set { txtPackageName.Text = value; }
    }

    private void cmdGenerateTex_Click(object sender, EventArgs e)
    {
      txtResult.Text = 
      Deviser.GenerateLatex(DeviserSettings.Instance.PythonInterpreter,
        DeviserSettings.Instance.DeviserRepository,
        OutDir, Package, PackageName
        );
    }

    private void cmdGeneratePackage_Click(object sender, EventArgs e)
    {
      txtResult.Text = 
      Deviser.GeneratePackage(DeviserSettings.Instance.PythonInterpreter,
        DeviserSettings.Instance.DeviserRepository,
        txtOutDir.Text, Package, PackageName
        );
    }

    private void FormGenerate_Load(object sender, EventArgs e)
    {
      txtOutDir.Text = DeviserSettings.Instance.DefaultOutputDir;

      cmdGeneratePackage.Enabled = DeviserSettings.Instance.CanGenerate;
      cmdGenerateTex.Enabled = DeviserSettings.Instance.CanGenerate;
      cmdCompileTex.Enabled = DeviserSettings.Instance.CanCompileTeX;

    }

    private void cmdCompileTex_Click(object sender, EventArgs e)
    {
      txtResult.Text =
      Deviser.CompileTex(DeviserSettings.Instance.MikTexDir,
        DeviserSettings.Instance.SBMLPkgSpecDir,
        txtOutDir.Text, Package, PackageName
        );
    }
  }
}
