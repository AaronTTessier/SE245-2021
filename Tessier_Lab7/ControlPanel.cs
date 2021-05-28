using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tessier_Lab7
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form1 add = new Form1();
            add.ShowDialog();
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            PersonSearch temp = new PersonSearch();
            temp.ShowDialog();
        }
    }
}
