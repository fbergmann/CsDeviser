using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibDeviser;

namespace CsDeviser.Forms
{
  public partial class FormPreferences : Form
  {
    public FormPreferences()
    {
      InitializeComponent();
      InitializeCompilers();

      if (cmbCompilers.Items.Count > 0)
        cmbCompilers.SelectedIndex = 0;

    }

    public void LoadSettings(DeviserSettings settings)
    {
      PythonInterpreter = settings.PythonInterpreter;
      DeviserRepo = settings.DeviserRepository;
      DefaultOutputDir = settings.DefaultOutputDir;
      MikTexDir = settings.MikTexDir;
      SBMLPkgSpecDir = settings.SBMLPkgSpecDir;
      CMake = settings.CMake;
      LibSBMLSourceDir = settings.LibSBMLSourceDir;
      DependenciesSourceDir = settings.DependenciesSourceDir;
      SWIG = settings.Swig;
      VSBatch = settings.VSBatchFile;
    }

    public void WriteToSettings(DeviserSettings settings)
    {
      settings.PythonInterpreter = PythonInterpreter;
      settings.DeviserRepository = DeviserRepo;
      settings.DefaultOutputDir = DefaultOutputDir;
      settings.SBMLPkgSpecDir = SBMLPkgSpecDir;
      settings.MikTexDir = MikTexDir;
      settings.CMake = CMake;
      settings.LibSBMLSourceDir = LibSBMLSourceDir;
      settings.DependenciesSourceDir = DependenciesSourceDir;
      settings.Swig = SWIG;
      settings.VSBatchFile = VSBatch;
    }

    public string VSBatch
    {
      get
      {
        string id = cmbCompilers.SelectedItem as string;
        if (string.IsNullOrWhiteSpace(id) || !Compilers.ContainsKey(id))
          return "";

        return Compilers[id];

      }
      set
      {
        var entry = Compilers.FirstOrDefault(e => e.Value == value);
        cmbCompilers.SelectedItem = entry.Key;
      }
    }
    public string SWIG { get { return txtSwig.Text; } set { txtSwig.Text = value; } }
    public string CMake { get { return txtCmake.Text; } set { txtCmake.Text = value; } }
    public string LibSBMLSourceDir { get { return txtlibSBMLSource.Text; } set { txtlibSBMLSource.Text = value; } }
    public string DependenciesSourceDir { get { return txtDependenciesSourceDir.Text; } set { txtDependenciesSourceDir.Text = value; } }
    public string SBMLPkgSpecDir { get { return txtSBMLPkgSpeciDir.Text; } set { txtSBMLPkgSpeciDir.Text = value; } }
    public string MikTexDir { get { return txtMikTex.Text; } set { txtMikTex.Text = value; } }
    public string DefaultOutputDir { get { return txtDefaultDir.Text; } set { txtDefaultDir.Text = value; } }
    public string PythonInterpreter { get { return txtPython.Text; } set { txtPython.Text = value; } }
    public string DeviserRepo { get { return txtDeviserRepo.Text; } set { txtDeviserRepo.Text = value; } }

    private void cmdBrowsePython_Click(object sender, EventArgs e)
    {
      string defaultPath = !string.IsNullOrWhiteSpace(txtPython.Text) ? Path.GetFullPath(txtPython.Text)
       : null;
      string defaultFile = !string.IsNullOrWhiteSpace(txtPython.Text) ? Path.GetFileName(txtPython.Text)
       : null;
      using (var dialog = new OpenFileDialog { Title = "Locate Python interpreter", Filter = Util.ExecutableFilter, InitialDirectory = defaultPath, FileName = defaultFile })
      {
        if (dialog.ShowDialog() == DialogResult.OK)
          txtPython.Text = dialog.FileName;
      }
    }

    private void cmdBrowseRepo_Click(object sender, EventArgs e)
    {
      string defaultPath = !string.IsNullOrWhiteSpace(txtDeviserRepo.Text) ? Path.GetFullPath(txtDeviserRepo.Text)
       : null;
      using (var dialog = new FolderBrowserDialog
      {
        Description = "Locate DeviserRepository",
        SelectedPath = defaultPath
      })
      {
        if (dialog.ShowDialog() == DialogResult.OK)
          txtDeviserRepo.Text = dialog.SelectedPath;
      }
    }

    private void cmdBrowseOutput_Click(object sender, EventArgs e)
    {

      string defaultPath = !string.IsNullOrWhiteSpace(txtDefaultDir.Text) ? Path.GetFullPath(txtDefaultDir.Text)
       : null;
      using (var dialog = new FolderBrowserDialog
      {
        Description = "Locate Default Output Dir",
        SelectedPath = defaultPath
      })
      {
        if (dialog.ShowDialog() == DialogResult.OK)
          txtDefaultDir.Text = dialog.SelectedPath;
      }
    }

    private void cmdBrowsePkgSpec_Click(object sender, EventArgs e)
    {

      string defaultPath = !string.IsNullOrWhiteSpace(txtSBMLPkgSpeciDir.Text) ? Path.GetFullPath(txtSBMLPkgSpeciDir.Text)
       : null;
      using (var dialog = new FolderBrowserDialog
      {
        Description = "Locate sbmlpkgspec Dir",
        SelectedPath = defaultPath
      })
      {
        if (dialog.ShowDialog() == DialogResult.OK)
          txtSBMLPkgSpeciDir.Text = dialog.SelectedPath;
      }
    }

    private void cmdBrowseMikTex_Click(object sender, EventArgs e)
    {
      string defaultPath = !string.IsNullOrWhiteSpace(txtMikTex.Text) ? Path.GetFullPath(txtMikTex.Text)
       : null;
      using (var dialog = new FolderBrowserDialog
      {
        Description = "Locate MikTeX bin Dir",
        SelectedPath = defaultPath
      })
      {
        if (dialog.ShowDialog() == DialogResult.OK)
          txtMikTex.Text = dialog.SelectedPath;
      }
    }

    private Dictionary<string, string> Compilers { get; set; }

    private void InitializeCompilers()
    {
      Compilers = new Dictionary<string, string>();

      if (Util.IsWindows)
      {
        string vs12 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
          @"Microsoft Visual Studio 12.0\VC\vcvarsall.bat");
        string vs11 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
          @"Microsoft Visual Studio 11.0\VC\vcvarsall.bat");
        string vs10 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
          @"Microsoft Visual Studio 10.0\VC\vcvarsall.bat");
        string vs09 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
          @"Microsoft Visual Studio 9.0\VC\vcvarsall.bat");
        if (File.Exists(vs12)) Compilers["Microsoft Visual Studio 2013"] = vs12;
        if (File.Exists(vs11)) Compilers["Microsoft Visual Studio 2012"] = vs11;
        if (File.Exists(vs10)) Compilers["Microsoft Visual Studio 2010"] = vs10;
        if (File.Exists(vs09)) Compilers["Microsoft Visual Studio 2008"] = vs09;
      }
      else
      {
        try
        {
          Process.Start("g++", "--version");
          Compilers["G++"] = "g++";
        }
        catch
        {
        }

        try
        {
          Process.Start("clang", "--version");
          Compilers["CLANG"] = "clang";
        }
        catch
        {
        }
      }
      cmbCompilers.Items.Clear();
      foreach (var key in Compilers.Keys)
        cmbCompilers.Items.Add(key);
    }

    private void cmdBrowseSource_Click(object sender, EventArgs e)
    {
      string defaultPath = !string.IsNullOrWhiteSpace(txtlibSBMLSource.Text) ? Path.GetFullPath(txtlibSBMLSource.Text)
       : null;
      using (var dialog = new FolderBrowserDialog
      {
        Description = "Locate SBML source Dir",
        SelectedPath = defaultPath
      })
      {
        if (dialog.ShowDialog() == DialogResult.OK)
          txtlibSBMLSource.Text = dialog.SelectedPath;
      }
    }

    private void cmdBrowseCMake_Click(object sender, EventArgs e)
    {
      string defaultPath = !string.IsNullOrWhiteSpace(txtCmake.Text) ? Path.GetFullPath(txtCmake.Text)
             : null;
      string defaultFile = !string.IsNullOrWhiteSpace(txtCmake.Text) ? Path.GetFileName(txtCmake.Text)
       : null;
      using (var dialog = new OpenFileDialog { Title = "Locate CMake Executable", Filter = Util.ExecutableFilter, InitialDirectory = defaultPath, FileName = defaultFile })
      {
        if (dialog.ShowDialog() == DialogResult.OK)
          txtCmake.Text = dialog.FileName;
      }
    }

    private void cmdBrowseDependencies_Click(object sender, EventArgs e)
    {
      string defaultPath = !string.IsNullOrWhiteSpace(txtDependenciesSourceDir.Text) ? Path.GetFullPath(txtDependenciesSourceDir.Text)
       : null;
      using (var dialog = new FolderBrowserDialog
      {
        Description = "Locate Dependencies source dir",
        SelectedPath = defaultPath
      })
      {
        if (dialog.ShowDialog() == DialogResult.OK)
          txtDependenciesSourceDir.Text = dialog.SelectedPath;
      }
    }

    private void cmdBrowseSwig_Click(object sender, EventArgs e)
    {
      string defaultPath = !string.IsNullOrWhiteSpace(txtSwig.Text) ? Path.GetFullPath(txtSwig.Text)
             : null;
      string defaultFile = !string.IsNullOrWhiteSpace(txtSwig.Text) ? Path.GetFileName(txtSwig.Text)
       : null;
      using (var dialog = new OpenFileDialog { Title = "Locate SWIG Executable", Filter = Util.ExecutableFilter, InitialDirectory = defaultPath, FileName = defaultFile })
      {
        if (dialog.ShowDialog() == DialogResult.OK)
          txtSwig.Text = dialog.FileName;
      }
    }
  }
}
