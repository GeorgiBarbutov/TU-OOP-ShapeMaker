using ShapeMaker.Models;
using ShapeMaker.Models.Contracts;
using System.Collections.Generic;

namespace ShapeMaker
{
    partial class Scene
    {
        private IList<IShape> shapes;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Scene(IList<IShape> shapes)
        {
            this.shapes = shapes;
        }

        public IList<IShape> Shapes => this.shapes;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Scene";
        }

        #endregion
    }
}

