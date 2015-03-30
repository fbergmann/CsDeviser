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
  public partial class FormPreferences : Form
  {
    public FormPreferences()
    {
      InitializeComponent();
    }

    public void LoadSettings(DeviserSettings settings)
    {
      PythonInterpreter = settings.PythonInterpreter;
      DeviserRepo = settings.DeviserRepository;
      DefaultOutputDir = settings.DefaultOutputDir;
      MikTexDir = settings.MikTexDir;
      SBMLPkgSpecDir = settings.SBMLPkgSpecDir;
    }

    public void WriteToSettings(DeviserSettings settings)
    {
      settings.PythonInterpreter = PythonInterpreter;
      settings.DeviserRepository = DeviserRepo;
      settings.DefaultOutputDir = DefaultOutputDir;
      settings.SBMLPkgSpecDir = SBMLPkgSpecDir;
      settings.MikTexDir = MikTexDir;
    }

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
      using (var dialog = new OpenFileDialog { Title = "Locate Python interpreter", Filter = "Executables|*.exe|All files|*.*", InitialDirectory = defaultPath, FileName = defaultFile })
      {
        if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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
        if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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
        if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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
        if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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
        if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
          txtMikTex.Text = dialog.SelectedPath;
      }
    }
  }
}
