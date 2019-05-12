namespace ShapeMaker
{
    partial class Scene
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.canvas = new System.Windows.Forms.Panel();
            this.lableForCanvas = new System.Windows.Forms.Label();
            this.addShapeButton = new System.Windows.Forms.Button();
            this.removeShapeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(12, 37);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(691, 388);
            this.canvas.TabIndex = 0;
            // 
            // lableForCanvas
            // 
            this.lableForCanvas.AutoSize = true;
            this.lableForCanvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableForCanvas.Location = new System.Drawing.Point(309, 10);
            this.lableForCanvas.Name = "lableForCanvas";
            this.lableForCanvas.Size = new System.Drawing.Size(78, 24);
            this.lableForCanvas.TabIndex = 1;
            this.lableForCanvas.Text = "Canvas";
            this.lableForCanvas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addShapeButton
            // 
            this.addShapeButton.Location = new System.Drawing.Point(12, 431);
            this.addShapeButton.Name = "addShapeButton";
            this.addShapeButton.Size = new System.Drawing.Size(168, 40);
            this.addShapeButton.TabIndex = 2;
            this.addShapeButton.Text = "Add Shape";
            this.addShapeButton.UseVisualStyleBackColor = true;
            this.addShapeButton.Click += new System.EventHandler(this.addShapeButton_Click);
            // 
            // removeShapeButton
            // 
            this.removeShapeButton.Location = new System.Drawing.Point(186, 431);
            this.removeShapeButton.Name = "removeShapeButton";
            this.removeShapeButton.Size = new System.Drawing.Size(168, 40);
            this.removeShapeButton.TabIndex = 3;
            this.removeShapeButton.Text = "Remove Shape";
            this.removeShapeButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(360, 431);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(168, 40);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save To File";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(535, 431);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(168, 40);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load From File";
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // Scene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 483);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.removeShapeButton);
            this.Controls.Add(this.addShapeButton);
            this.Controls.Add(this.lableForCanvas);
            this.Controls.Add(this.canvas);
            this.Name = "Scene";
            this.Text = "Scene";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Label lableForCanvas;
        private System.Windows.Forms.Button addShapeButton;
        private System.Windows.Forms.Button removeShapeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
    }
}

