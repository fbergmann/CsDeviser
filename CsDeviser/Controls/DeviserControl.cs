using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsDeviser.Controls
{
  public partial class DeviserControl : UserControl
  {
    public DeviserControl()
    {
      InitializeComponent();
    }

    public bool Initializing { get; set; }

    public event EventHandler RenamedEvent;

    protected virtual void OnRenamedEvent()
    {
      var handler = RenamedEvent;
      if (handler != null) handler(this, EventArgs.Empty);
    }

    public virtual void OnCommitChanges()
    {
      
    }

  }
}
