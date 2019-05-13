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
            this.Canvas = new System.Windows.Forms.Panel();
            this.LableForCanvas = new System.Windows.Forms.Label();
            this.addShapeButton = new System.Windows.Forms.Button();
            this.removeShapeButton = new System.Windows.Forms.Button();
            this.SaveToFileButton = new System.Windows.Forms.Button();
            this.LoadFromFileButton = new System.Windows.Forms.Button();
            this.NewShapeAreaLabel = new System.Windows.Forms.Label();
            this.NewShapeAreaNumber = new System.Windows.Forms.Label();
            this.TotalAreaTakenNumber = new System.Windows.Forms.Label();
            this.TotalAreaTakenLablel = new System.Windows.Forms.Label();
            this.EditShapeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Canvas.Location = new System.Drawing.Point(12, 37);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(691, 388);
            this.Canvas.TabIndex = 0;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // LableForCanvas
            // 
            this.LableForCanvas.AutoSize = true;
            this.LableForCanvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableForCanvas.Location = new System.Drawing.Point(316, 10);
            this.LableForCanvas.Name = "LableForCanvas";
            this.LableForCanvas.Size = new System.Drawing.Size(78, 24);
            this.LableForCanvas.TabIndex = 1;
            this.LableForCanvas.Text = "Canvas";
            this.LableForCanvas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addShapeButton
            // 
            this.addShapeButton.Location = new System.Drawing.Point(12, 431);
            this.addShapeButton.Name = "addShapeButton";
            this.addShapeButton.Size = new System.Drawing.Size(134, 40);
            this.addShapeButton.TabIndex = 2;
            this.addShapeButton.Text = "Add Shape";
            this.addShapeButton.UseVisualStyleBackColor = true;
            this.addShapeButton.Click += new System.EventHandler(this.AddShapeButton_Click);
            // 
            // removeShapeButton
            // 
            this.removeShapeButton.Location = new System.Drawing.Point(152, 431);
            this.removeShapeButton.Name = "removeShapeButton";
            this.removeShapeButton.Size = new System.Drawing.Size(133, 40);
            this.removeShapeButton.TabIndex = 3;
            this.removeShapeButton.Text = "Remove Shape";
            this.removeShapeButton.UseVisualStyleBackColor = true;
            this.removeShapeButton.Click += new System.EventHandler(this.RemoveShapeButton_Click);
            // 
            // SaveToFileButton
            // 
            this.SaveToFileButton.Location = new System.Drawing.Point(430, 431);
            this.SaveToFileButton.Name = "SaveToFileButton";
            this.SaveToFileButton.Size = new System.Drawing.Size(133, 40);
            this.SaveToFileButton.TabIndex = 4;
            this.SaveToFileButton.Text = "Save To File";
            this.SaveToFileButton.UseVisualStyleBackColor = true;
            this.SaveToFileButton.Click += new System.EventHandler(this.SaveToFileButton_Click);
            // 
            // LoadFromFileButton
            // 
            this.LoadFromFileButton.Location = new System.Drawing.Point(569, 431);
            this.LoadFromFileButton.Name = "LoadFromFileButton";
            this.LoadFromFileButton.Size = new System.Drawing.Size(134, 40);
            this.LoadFromFileButton.TabIndex = 5;
            this.LoadFromFileButton.Text = "Load From File";
            this.LoadFromFileButton.UseVisualStyleBackColor = true;
            this.LoadFromFileButton.Click += new System.EventHandler(this.LoadFromFileButton_Click);
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
            this.Controls.Add(this.LoadFromFileButton);
            this.Controls.Add(this.SaveToFileButton);
            this.Controls.Add(this.removeShapeButton);
            this.Controls.Add(this.addShapeButton);
            this.Controls.Add(this.LableForCanvas);
            this.Controls.Add(this.Canvas);
            this.Name = "Scene";
            this.Text = "Scene";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.Label LableForCanvas;
        private System.Windows.Forms.Button addShapeButton;
        private System.Windows.Forms.Button removeShapeButton;
        private System.Windows.Forms.Button SaveToFileButton;
        private System.Windows.Forms.Button LoadFromFileButton;
        private System.Windows.Forms.Label NewShapeAreaLabel;
        private System.Windows.Forms.Label NewShapeAreaNumber;
        private System.Windows.Forms.Label TotalAreaTakenNumber;
        private System.Windows.Forms.Label TotalAreaTakenLablel;
        private System.Windows.Forms.Button EditShapeButton;
    }
}

