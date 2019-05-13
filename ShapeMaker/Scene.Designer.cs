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
            this.NewShapeAreaLabel = new System.Windows.Forms.Label();
            this.NewShapeAreaNumber = new System.Windows.Forms.Label();
            this.TotalAreaTakenNumber = new System.Windows.Forms.Label();
            this.TotalAreaTakenLablel = new System.Windows.Forms.Label();
            this.EditShapeButton = new System.Windows.Forms.Button();
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
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            // 
            // lableForCanvas
            // 
            this.lableForCanvas.AutoSize = true;
            this.lableForCanvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableForCanvas.Location = new System.Drawing.Point(322, 10);
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
            this.addShapeButton.Size = new System.Drawing.Size(134, 40);
            this.addShapeButton.TabIndex = 2;
            this.addShapeButton.Text = "Add Shape";
            this.addShapeButton.UseVisualStyleBackColor = true;
            this.addShapeButton.Click += new System.EventHandler(this.addShapeButton_Click);
            // 
            // removeShapeButton
            // 
            this.removeShapeButton.Location = new System.Drawing.Point(152, 431);
            this.removeShapeButton.Name = "removeShapeButton";
            this.removeShapeButton.Size = new System.Drawing.Size(133, 40);
            this.removeShapeButton.TabIndex = 3;
            this.removeShapeButton.Text = "Remove Shape";
            this.removeShapeButton.UseVisualStyleBackColor = true;
            this.removeShapeButton.Click += new System.EventHandler(this.removeShapeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(430, 431);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(133, 40);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save To File";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(569, 431);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(134, 40);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load From File";
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // NewShapeAreaLabel
            // 
            this.NewShapeAreaLabel.AutoSize = true;
            this.NewShapeAreaLabel.Location = new System.Drawing.Point(12, 18);
            this.NewShapeAreaLabel.Name = "NewShapeAreaLabel";
            this.NewShapeAreaLabel.Size = new System.Drawing.Size(91, 13);
            this.NewShapeAreaLabel.TabIndex = 6;
            this.NewShapeAreaLabel.Text = "New Shape Area:";
            // 
            // NewShapeAreaNumber
            // 
            this.NewShapeAreaNumber.AutoSize = true;
            this.NewShapeAreaNumber.Location = new System.Drawing.Point(109, 18);
            this.NewShapeAreaNumber.Name = "NewShapeAreaNumber";
            this.NewShapeAreaNumber.Size = new System.Drawing.Size(22, 13);
            this.NewShapeAreaNumber.TabIndex = 7;
            this.NewShapeAreaNumber.Text = "0.0";
            // 
            // TotalAreaTakenNumber
            // 
            this.TotalAreaTakenNumber.AutoSize = true;
            this.TotalAreaTakenNumber.Location = new System.Drawing.Point(597, 18);
            this.TotalAreaTakenNumber.Name = "TotalAreaTakenNumber";
            this.TotalAreaTakenNumber.Size = new System.Drawing.Size(22, 13);
            this.TotalAreaTakenNumber.TabIndex = 9;
            this.TotalAreaTakenNumber.Text = "0.0";
            // 
            // TotalAreaTakenLablel
            // 
            this.TotalAreaTakenLablel.AutoSize = true;
            this.TotalAreaTakenLablel.Location = new System.Drawing.Point(498, 18);
            this.TotalAreaTakenLablel.Name = "TotalAreaTakenLablel";
            this.TotalAreaTakenLablel.Size = new System.Drawing.Size(93, 13);
            this.TotalAreaTakenLablel.TabIndex = 8;
            this.TotalAreaTakenLablel.Text = "Total Area Taken:";
            // 
            // EditShapeButton
            // 
            this.EditShapeButton.Location = new System.Drawing.Point(291, 431);
            this.EditShapeButton.Name = "EditShapeButton";
            this.EditShapeButton.Size = new System.Drawing.Size(133, 40);
            this.EditShapeButton.TabIndex = 10;
            this.EditShapeButton.Text = "Edit Shape";
            this.EditShapeButton.UseVisualStyleBackColor = true;
            this.EditShapeButton.Click += new System.EventHandler(this.EditShapeButton_Click);
            // 
            // Scene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 483);
            this.Controls.Add(this.EditShapeButton);
            this.Controls.Add(this.TotalAreaTakenNumber);
            this.Controls.Add(this.TotalAreaTakenLablel);
            this.Controls.Add(this.NewShapeAreaNumber);
            this.Controls.Add(this.NewShapeAreaLabel);
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
        private System.Windows.Forms.Label NewShapeAreaLabel;
        private System.Windows.Forms.Label NewShapeAreaNumber;
        private System.Windows.Forms.Label TotalAreaTakenNumber;
        private System.Windows.Forms.Label TotalAreaTakenLablel;
        private System.Windows.Forms.Button EditShapeButton;
    }
}

