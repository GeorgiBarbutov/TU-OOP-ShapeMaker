﻿using ShapeMaker.Models.Contracts;
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
    public partial class Scene : Form
    {
        private IList<IShape> shapes;

        public Scene()
        {
            InitializeComponent();
        }

        private void addShapeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddShape addShapeForm = new AddShape();
            addShapeForm.ShowDialog();
        }
    }
}
