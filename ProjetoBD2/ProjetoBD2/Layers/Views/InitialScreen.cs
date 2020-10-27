using ProjetoPLPCSharp.Layers.DataBases;
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
    public partial class InitialScreen : Form
    {
        public InitialScreen()
        {
            InitializeComponent();
        }

        private void InitialScreen_Load(object sender, EventArgs e)
        { 
            FacBanco fac = new FacBanco();
            IBanco banco = fac.CriarBanco("SQLServer");
            DataSet dt = banco.ExecutaSelect("select * from Products");
            BindingSource binding = new BindingSource();
            binding.DataSource = dt.Tables[0];
            binding.ResetBindings(true);
            dataGridView1.DataSource = binding;
        }
    }
}
