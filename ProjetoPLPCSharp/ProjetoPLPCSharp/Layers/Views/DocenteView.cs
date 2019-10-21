using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPLPCSharp.Layers.Views
{
    public partial class DocenteView : Form
    {
        public DocenteView()
        {
            InitializeComponent();
            
           // button1.Width = 77;
        }
      
        private void DocenteView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

    }
}
