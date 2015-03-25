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

namespace CsDeviser.Forms
{
  public partial class FormPreferences : Form
  {
    public FormPreferences()
    {
      InitializeComponent();
    }

    public string PythonInterpreter { get { return txtPython.Text; } set { txtPython.Text = value; } }
    
    public string DeviserRepo { get { return txtDeviserRepo.Text; } set { txtDeviserRepo.Text = value; } }

    private void cmdBrowsePython_Click(object sender, EventArgs e)
    {
      using (var dialog = new OpenFileDialog { Title = "Locate Python interpreter", Filter= "Executables|*.exe|All files|*.*", InitialDirectory = Path.GetFullPath(txtPython.Text), FileName = Path.GetFileName(txtPython.Text) })
      {
        if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
          txtPython.Text = dialog.FileName;
      }
    }

    private void cmdBrowseRepo_Click(object sender, EventArgs e)
    {
      using (var dialog = new FolderBrowserDialog { Description = "Locate DeviserRepository", 
        SelectedPath = Path.GetFullPath(txtDeviserRepo.Text)})
      {
        if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
          txtDeviserRepo.Text = dialog.SelectedPath;
      }
    }
  }
}
