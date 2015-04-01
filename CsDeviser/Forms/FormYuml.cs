using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibDeviser;

namespace CsDeviser.Forms
{
  public partial class FormYuml : Form
  {
    public FormYuml()
    {
      InitializeComponent();
      FitDrawing(true);
    }

    public DeviserPackage Package { get; set; }
    public string RawYuml {
      get { return txtYuml.Text; }
      set { txtYuml.Text = value; }
    }

    public string Style { get { return cmpStyle.SelectedItem as string; } }

    public void InitializeFrom(DeviserPackage package)
    {
      Package = package;
      RawYuml = Package.ToYuml();
      OnUpdateClick(this, EventArgs.Empty);

    }

    private void OnUpdateClick(object sender, EventArgs e)
    {
      string baseUri = "http://yuml.me/diagram/"+ Style+ "/class/";
      using(WebClient client = new WebClient())
      {
        try
        {

          byte[] response =
          client.UploadValues(baseUri, new NameValueCollection()
       {
           { "dsl_text", RawYuml.Replace(Environment.NewLine, ",") + ".png" },
       });

          string result = System.Text.Encoding.UTF8.GetString(response);
          var data = client.DownloadData("http://yuml.me/" + result);
          using (MemoryStream stream = new MemoryStream(data))
          {
            var image = Image.FromStream(stream);
            pictureBox1.Image = image;
          }

        }
        catch
        {
          pictureBox1.Image = Properties.Resources.invalid;
        }
      }
      tabControl1.SelectedIndex = 0;
    }

    private void SaveAs(string filename)
    {
      var extension = Path.GetExtension(filename).ToLowerInvariant();
      switch(extension)
      {
        case ".png":
        case ".pdf":
        case ".jpg":
        case ".svg":
        {

          string baseUri = "http://yuml.me/diagram/" + Style + "/class/";
          using (WebClient client = new WebClient())
          {
            byte[] response =
          client.UploadValues(baseUri, new NameValueCollection()
       {
           { "dsl_text", RawYuml.Replace(Environment.NewLine, ",") + extension },
       });

            string result = System.Text.Encoding.UTF8.GetString(response);
            client.DownloadFile("http://yuml.me/" + result, filename);
            
            //client.DownloadFile(baseUri + RawYuml.Replace(Environment.NewLine, ",") + extension, filename);
          }
          break;
        }
        default:
          File.WriteAllText(filename, RawYuml);
          break;
      }
    }
    private void OnSaveAsClick(object sender, EventArgs e)
    {
      using (var dlg = new SaveFileDialog { Title = "Save UML diagram", Filter = "PNG files|*.png|JPG files|*.jpg|PDF files|*.pdf|SVG files|*.svg|YuML files|*.txt"})
      {
        if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        {
          var filename = dlg.FileName;
          this.Enabled = false;
          SaveAs(filename);
          this.Enabled = true;
        }
      }
    }

    private void OnFitDrawingCheckedChanged(object sender, EventArgs e)
    {
      FitDrawing(chkFitDrawing.Checked);
    }

    private void FitDrawing(bool doFit)
    {
      if (doFit)
      {
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.Dock = DockStyle.Fill;
        pnlPicture.AutoScroll = false;
      }
      else
      {
        pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        pictureBox1.Dock = DockStyle.None;
        pnlPicture.AutoScroll = true;
        pnlPicture.Location = new Point(0, 0);
      }
    }

    private void OnStyleIndexChanged(object sender, EventArgs e)
    {
      OnUpdateClick (this, e);
    }

    private void OnKeyDown(object sender, KeyEventArgs e)
    {
      if (e.Control & e.KeyCode == Keys.A)
        txtYuml.SelectAll();
      //else if (e.Control & e.KeyCode == Keys.C)
      //  txtYuml.Copy();
      //else if (e.Control & e.KeyCode == Keys.X)
      //  txtYuml.Cut();
      //else if (e.Control & e.KeyCode == Keys.V)
      //  txtYuml.Paste();
    }

    private void pnlPicture_MouseEnter(object sender, EventArgs e)
    {
      pnlPicture.Focus();
    }
  }
}
