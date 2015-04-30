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
        if (dialog.ShowDialog() == DialogResult.OK)
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

    delegate void resultDelegate(string foo);
    void AppendResult(string result)
    {
      if (InvokeRequired)
      {
        Invoke(new resultDelegate(AppendResult), new object[] {result});
        return;
      }

      if (string.IsNullOrWhiteSpace(result)) return;
      if (IsDisposed) return;
      if (txtResult.IsDisposed) return;
      txtResult.AppendText(result + Environment.NewLine);
    }

    private void cmdGeneratePackage_Click(object sender, EventArgs e)
    {
      txtResult.Clear();
      Deviser.GeneratePackageWithReport(DeviserSettings.Instance.PythonInterpreter,
        DeviserSettings.Instance.DeviserRepository,
        txtOutDir.Text, Package, PackageName, AppendResult
        );
    }

    private void FormGenerate_Load(object sender, EventArgs e)
    {
      txtOutDir.Text = DeviserSettings.Instance.DefaultOutputDir;

      cmdGeneratePackage.Enabled = DeviserSettings.Instance.CanGenerate;
      cmdGenerateTex.Enabled = DeviserSettings.Instance.CanGenerate;
      cmdCompileTex.Enabled = DeviserSettings.Instance.CanCompileTeX;

      cmdAddPackageToSource.Enabled = DeviserSettings.Instance.CanCompilePackage;
      cmdRemovePackageFromSource.Enabled = DeviserSettings.Instance.CanCompilePackage;
      cmdCompileDependencies.Enabled = DeviserSettings.Instance.CanCompilePackage;
      cmdCompilePackage.Enabled = DeviserSettings.Instance.CanCompilePackage;
    }

    private void cmdCompileTex_Click(object sender, EventArgs e)
    {
      cmdCompileTex.Enabled = false;
      try
      {
        txtResult.Clear();
          Deviser.CompileTexWithProgress(DeviserSettings.Instance.MikTexDir,
            DeviserSettings.Instance.SBMLPkgSpecDir,
            txtOutDir.Text, Package, PackageName, AppendResult
            );
      }
      finally
      {
        cmdCompileTex.Enabled = true;
      }
    }

    private void cmdCompileDependencies_Click(object sender, EventArgs e)
    {
      cmdCompileDependencies.Enabled = false;
      try
      {
        txtResult.Clear();        
          Deviser.CompileDependenciesWithProgress(DeviserSettings.Instance.DependenciesSourceDir,
            DeviserSettings.Instance.CMake,
            DeviserSettings.Instance.VSBatchFile,
            txtOutDir.Text, AppendResult);
        
      }
      finally
      {
        cmdCompileDependencies.Enabled = true;
      }
        
    }

    private void cmdAddPackageToSource_Click(object sender, EventArgs e)
    {
      txtResult.Text = Deviser.AddPackageToSource(DeviserSettings.Instance.LibSBMLSourceDir,
        txtOutDir.Text,
        txtPackageName.Text);
    }

    private void cmdRemovePackageFromSource_Click(object sender, EventArgs e)
    {
      txtResult.Text = Deviser.RemovePackageFromSource(DeviserSettings.Instance.LibSBMLSourceDir,
        txtPackageName.Text);
    }

    private void cmdCompilePackage_Click(object sender, EventArgs e)
    {
      cmdCompilePackage.Enabled = false;
      try
      {
        txtResult.Clear();
          Deviser.CompilePackageWithProgress(DeviserSettings.Instance.LibSBMLSourceDir,
            DeviserSettings.Instance.CMake,
            DeviserSettings.Instance.VSBatchFile,
            DeviserSettings.Instance.Swig,
            DeviserSettings.Instance.PythonInterpreter,
            txtOutDir.Text, 
            txtPackageName.Text, AppendResult);

      }
      finally
      {
        cmdCompilePackage.Enabled = true;
      }
    }

    private void cmdTest_Click(object sender, EventArgs e)
    {
      txtResult.Text = Deviser.TestPackage(DeviserSettings.Instance.PythonInterpreter,
        txtOutDir.Text, txtPackageName.Text);
    }
  }
}
