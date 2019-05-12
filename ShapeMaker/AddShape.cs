using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeMaker
{
    public partial class AddShape : Form
    {
        public AddShape()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Scene sceneForm = new Scene();
            sceneForm.ShowDialog();
        }
    }
}
