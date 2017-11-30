using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Internalization
{
    public partial class Grid : Form
    {
        public Grid()
        {
            InitializeComponent();
            this.CenterToParent();
            
            //this.listBox1.Show();

        }

        private void Grid_Load(object sender, EventArgs e)
        {
            //
        }
    }
}
