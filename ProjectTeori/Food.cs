using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeori
{
    public partial class Food : Form
    {
        public Food()
        {
            InitializeComponent();
        }

        private void btnNoodles_Click(object sender, EventArgs e)
        {
            Ramen mie = new Ramen();
            mie.Show();
        }
    }
}
