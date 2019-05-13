namespace ShapeMaker
{
    partial class EditShape
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
            this.SelectColorButton = new System.Windows.Forms.Button();
            this.ShapeColorSelected = new System.Windows.Forms.PictureBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.RadiusNumber = new System.Windows.Forms.NumericUpDown();
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.CenterYNumber = new System.Windows.Forms.NumericUpDown();
            this.CenterYLabel = new System.Windows.Forms.Label();
            this.CenterXNumber = new System.Windows.Forms.NumericUpDown();
            this.CenterXLabel = new System.Windows.Forms.Label();
            this.HeightNumber = new System.Windows.Forms.NumericUpDown();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthNumber = new System.Windows.Forms.NumericUpDown();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.PointYNumber = new System.Windows.Forms.NumericUpDown();
            this.PointYLabel = new System.Windows.Forms.Label();
            this.PointXNumber = new System.Windows.Forms.NumericUpDown();
            this.PointXLabel = new System.Windows.Forms.Label();
            this.PointCYCoordinateNumber = new System.Windows.Forms.NumericUpDown();
            this.PointCYCoordinateLabel = new System.Windows.Forms.Label();
            this.PointCXCoordinateNumber = new System.Windows.Forms.NumericUpDown();
            this.PointCXCoordinateLabel = new System.Windows.Forms.Label();
            this.PointBYCoordinateNumber = new System.Windows.Forms.NumericUpDown();
            this.PointBYCoordinateLabel = new System.Windows.Forms.Label();
            this.PointBXCoordinateNumber = new System.Windows.Forms.NumericUpDown();
            this.PointBXCoordinateLabel = new System.Windows.Forms.Label();
            this.PointAYCoordinateNumber = new System.Windows.Forms.NumericUpDown();
            this.PointAYCoordinateLabel = new System.Windows.Forms.Label();
            this.FigureLabel = new System.Windows.Forms.Label();
            this.PointAXCoordinateNumber = new System.Windows.Forms.NumericUpDown();
            this.PointAXCoordinateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShapeColorSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CenterYNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CenterXNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointYNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointXNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointCYCoordinateNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointCXCoordinateNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointBYCoordinateNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointBXCoordinateNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointAYCoordinateNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointAXCoordinateNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectColorButton
            // 
            this.SelectColorButton.Location = new System.Drawing.Point(372, 206);
            this.SelectColorButton.Name = "SelectColorButton";
            this.SelectColorButton.Size = new System.Drawing.Size(81, 25);
            this.SelectColorButton.TabIndex = 71;
            this.SelectColorButton.Text = "Select Color";
            this.SelectColorButton.UseVisualStyleBackColor = true;
            this.SelectColorButton.Click += new System.EventHandler(this.SelectColorButton_Click);
            // 
            // ShapeColorSelected
            // 
            this.ShapeColorSelected.Location = new System.Drawing.Point(431, 187);
            this.ShapeColorSelected.Name = "ShapeColorSelected";
            this.ShapeColorSelected.Size = new System.Drawing.Size(22, 13);
            this.ShapeColorSelected.TabIndex = 70;
            this.ShapeColorSelected.TabStop = false;
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(372, 187);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(34, 13);
            this.ColorLabel.TabIndex = 69;
            this.ColorLabel.Text = "Color:";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(506, 264);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(168, 40);
            this.CancelButton.TabIndex = 68;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(121, 264);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(168, 40);
            this.SaveChangesButton.TabIndex = 67;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // RadiusNumber
            // 
            this.RadiusNumber.Location = new System.Drawing.Point(624, 128);
            this.RadiusNumber.Maximum = new decimal(new int[] {
            380,
            0,
            0,
            0});
            this.RadiusNumber.Name = "RadiusNumber";
            this.RadiusNumber.Size = new System.Drawing.Size(50, 20);
            this.RadiusNumber.TabIndex = 66;
            this.RadiusNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RadiusNumber.Visible = false;
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.Location = new System.Drawing.Point(575, 130);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(43, 13);
            this.RadiusLabel.TabIndex = 65;
            this.RadiusLabel.Text = "Radius:";
            this.RadiusLabel.Visible = false;
            // 
            // CenterYNumber
            // 
            this.CenterYNumber.Location = new System.Drawing.Point(397, 128);
            this.CenterYNumber.Maximum = new decimal(new int[] {
            380,
            0,
            0,
            0});
            this.CenterYNumber.Name = "CenterYNumber";
            this.CenterYNumber.Size = new System.Drawing.Size(50, 20);
            this.CenterYNumber.TabIndex = 64;
            this.CenterYNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CenterYNumber.Visible = false;
            // 
            // CenterYLabel
            // 
            this.CenterYLabel.AutoSize = true;
            this.CenterYLabel.Location = new System.Drawing.Point(345, 130);
            this.CenterYLabel.Name = "CenterYLabel";
            this.CenterYLabel.Size = new System.Drawing.Size(49, 13);
            this.CenterYLabel.TabIndex = 63;
            this.CenterYLabel.Text = "Center y:";
            this.CenterYLabel.Visible = false;
            // 
            // CenterXNumber
            // 
            this.CenterXNumber.Location = new System.Drawing.Point(170, 128);
            this.CenterXNumber.Maximum = new decimal(new int[] {
            690,
            0,
            0,
            0});
            this.CenterXNumber.Name = "CenterXNumber";
            this.CenterXNumber.Size = new System.Drawing.Size(50, 20);
            this.CenterXNumber.TabIndex = 62;
            this.CenterXNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CenterXNumber.Visible = false;
            // 
            // CenterXLabel
            // 
            this.CenterXLabel.AutoSize = true;
            this.CenterXLabel.Location = new System.Drawing.Point(118, 130);
            this.CenterXLabel.Name = "CenterXLabel";
            this.CenterXLabel.Size = new System.Drawing.Size(49, 13);
            this.CenterXLabel.TabIndex = 61;
            this.CenterXLabel.Text = "Center x:";
            this.CenterXLabel.Visible = false;
            // 
            // HeightNumber
            // 
            this.HeightNumber.Location = new System.Drawing.Point(507, 147);
            this.HeightNumber.Maximum = new decimal(new int[] {
            380,
            0,
            0,
            0});
            this.HeightNumber.Name = "HeightNumber";
            this.HeightNumber.Size = new System.Drawing.Size(50, 20);
            this.HeightNumber.TabIndex = 60;
            this.HeightNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HeightNumber.Visible = false;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(459, 149);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(41, 13);
            this.HeightLabel.TabIndex = 59;
            this.HeightLabel.Text = "Height:";
            this.HeightLabel.Visible = false;
            // 
            // WidthNumber
            // 
            this.WidthNumber.Location = new System.Drawing.Point(276, 147);
            this.WidthNumber.Maximum = new decimal(new int[] {
            690,
            0,
            0,
            0});
            this.WidthNumber.Name = "WidthNumber";
            this.WidthNumber.Size = new System.Drawing.Size(50, 20);
            this.WidthNumber.TabIndex = 58;
            this.WidthNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WidthNumber.Visible = false;
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(232, 149);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthLabel.TabIndex = 57;
            this.WidthLabel.Text = "Width:";
            this.WidthLabel.Visible = false;
            // 
            // PointYNumber
            // 
            this.PointYNumber.Location = new System.Drawing.Point(507, 107);
            this.PointYNumber.Maximum = new decimal(new int[] {
            380,
            0,
            0,
            0});
            this.PointYNumber.Name = "PointYNumber";
            this.PointYNumber.Size = new System.Drawing.Size(50, 20);
            this.PointYNumber.TabIndex = 56;
            this.PointYNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PointYNumber.Visible = false;
            // 
            // PointYLabel
            // 
            this.PointYLabel.AutoSize = true;
            this.PointYLabel.Location = new System.Drawing.Point(459, 109);
            this.PointYLabel.Name = "PointYLabel";
            this.PointYLabel.Size = new System.Drawing.Size(42, 13);
            this.PointYLabel.TabIndex = 55;
            this.PointYLabel.Text = "Point y:";
            this.PointYLabel.Visible = false;
            // 
            // PointXNumber
            // 
            this.PointXNumber.Location = new System.Drawing.Point(276, 107);
            this.PointXNumber.Maximum = new decimal(new int[] {
            690,
            0,
            0,
            0});
            this.PointXNumber.Name = "PointXNumber";
            this.PointXNumber.Size = new System.Drawing.Size(50, 20);
            this.PointXNumber.TabIndex = 54;
            this.PointXNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PointXNumber.Visible = false;
            // 
            // PointXLabel
            // 
            this.PointXLabel.AutoSize = true;
            this.PointXLabel.Location = new System.Drawing.Point(232, 109);
            this.PointXLabel.Name = "PointXLabel";
            this.PointXLabel.Size = new System.Drawing.Size(42, 13);
            this.PointXLabel.TabIndex = 53;
            this.PointXLabel.Text = "Point x:";
            this.PointXLabel.Visible = false;
            // 
            // PointCYCoordinateNumber
            // 
            this.PointCYCoordinateNumber.Location = new System.Drawing.Point(633, 147);
            this.PointCYCoordinateNumber.Maximum = new decimal(new int[] {
            380,
            0,
            0,
            0});
            this.PointCYCoordinateNumber.Name = "PointCYCoordinateNumber";
            this.PointCYCoordinateNumber.Size = new System.Drawing.Size(50, 20);
            this.PointCYCoordinateNumber.TabIndex = 52;
            this.PointCYCoordinateNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PointCYCoordinateLabel
            // 
            this.PointCYCoordinateLabel.AutoSize = true;
            this.PointCYCoordinateLabel.Location = new System.Drawing.Point(575, 149);
            this.PointCYCoordinateLabel.Name = "PointCYCoordinateLabel";
            this.PointCYCoordinateLabel.Size = new System.Drawing.Size(52, 13);
            this.PointCYCoordinateLabel.TabIndex = 51;
            this.PointCYCoordinateLabel.Text = "Point C y:";
            // 
            // PointCXCoordinateNumber
            // 
            this.PointCXCoordinateNumber.Location = new System.Drawing.Point(633, 107);
            this.PointCXCoordinateNumber.Maximum = new decimal(new int[] {
            690,
            0,
            0,
            0});
            this.PointCXCoordinateNumber.Name = "PointCXCoordinateNumber";
            this.PointCXCoordinateNumber.Size = new System.Drawing.Size(50, 20);
            this.PointCXCoordinateNumber.TabIndex = 50;
            this.PointCXCoordinateNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PointCXCoordinateLabel
            // 
            this.PointCXCoordinateLabel.AutoSize = true;
            this.PointCXCoordinateLabel.Location = new System.Drawing.Point(575, 109);
            this.PointCXCoordinateLabel.Name = "PointCXCoordinateLabel";
            this.PointCXCoordinateLabel.Size = new System.Drawing.Size(52, 13);
            this.PointCXCoordinateLabel.TabIndex = 49;
            this.PointCXCoordinateLabel.Text = "Point C x:";
            // 
            // PointBYCoordinateNumber
            // 
            this.PointBYCoordinateNumber.Location = new System.Drawing.Point(403, 147);
            this.PointBYCoordinateNumber.Maximum = new decimal(new int[] {
            380,
            0,
            0,
            0});
            this.PointBYCoordinateNumber.Name = "PointBYCoordinateNumber";
            this.PointBYCoordinateNumber.Size = new System.Drawing.Size(50, 20);
            this.PointBYCoordinateNumber.TabIndex = 48;
            this.PointBYCoordinateNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PointBYCoordinateLabel
            // 
            this.PointBYCoordinateLabel.AutoSize = true;
            this.PointBYCoordinateLabel.Location = new System.Drawing.Point(345, 149);
            this.PointBYCoordinateLabel.Name = "PointBYCoordinateLabel";
            this.PointBYCoordinateLabel.Size = new System.Drawing.Size(52, 13);
            this.PointBYCoordinateLabel.TabIndex = 47;
            this.PointBYCoordinateLabel.Text = "Point B y:";
            // 
            // PointBXCoordinateNumber
            // 
            this.PointBXCoordinateNumber.Location = new System.Drawing.Point(403, 107);
            this.PointBXCoordinateNumber.Maximum = new decimal(new int[] {
            690,
            0,
            0,
            0});
            this.PointBXCoordinateNumber.Name = "PointBXCoordinateNumber";
            this.PointBXCoordinateNumber.Size = new System.Drawing.Size(50, 20);
            this.PointBXCoordinateNumber.TabIndex = 46;
            this.PointBXCoordinateNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PointBXCoordinateLabel
            // 
            this.PointBXCoordinateLabel.AutoSize = true;
            this.PointBXCoordinateLabel.Location = new System.Drawing.Point(345, 109);
            this.PointBXCoordinateLabel.Name = "PointBXCoordinateLabel";
            this.PointBXCoordinateLabel.Size = new System.Drawing.Size(52, 13);
            this.PointBXCoordinateLabel.TabIndex = 45;
            this.PointBXCoordinateLabel.Text = "Point B x:";
            // 
            // PointAYCoordinateNumber
            // 
            this.PointAYCoordinateNumber.Location = new System.Drawing.Point(176, 147);
            this.PointAYCoordinateNumber.Maximum = new decimal(new int[] {
            380,
            0,
            0,
            0});
            this.PointAYCoordinateNumber.Name = "PointAYCoordinateNumber";
            this.PointAYCoordinateNumber.Size = new System.Drawing.Size(50, 20);
            this.PointAYCoordinateNumber.TabIndex = 44;
            this.PointAYCoordinateNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PointAYCoordinateLabel
            // 
            this.PointAYCoordinateLabel.AutoSize = true;
            this.PointAYCoordinateLabel.Location = new System.Drawing.Point(118, 149);
            this.PointAYCoordinateLabel.Name = "PointAYCoordinateLabel";
            this.PointAYCoordinateLabel.Size = new System.Drawing.Size(52, 13);
            this.PointAYCoordinateLabel.TabIndex = 43;
            this.PointAYCoordinateLabel.Text = "Point A y:";
            // 
            // FigureLabel
            // 
            this.FigureLabel.AutoSize = true;
            this.FigureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FigureLabel.Location = new System.Drawing.Point(362, 34);
            this.FigureLabel.Name = "FigureLabel";
            this.FigureLabel.Size = new System.Drawing.Size(54, 20);
            this.FigureLabel.TabIndex = 41;
            this.FigureLabel.Text = "Figure";
            this.FigureLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PointAXCoordinateNumber
            // 
            this.PointAXCoordinateNumber.Location = new System.Drawing.Point(176, 107);
            this.PointAXCoordinateNumber.Maximum = new decimal(new int[] {
            690,
            0,
            0,
            0});
            this.PointAXCoordinateNumber.Name = "PointAXCoordinateNumber";
            this.PointAXCoordinateNumber.Size = new System.Drawing.Size(50, 20);
            this.PointAXCoordinateNumber.TabIndex = 40;
            this.PointAXCoordinateNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PointAXCoordinateLabel
            // 
            this.PointAXCoordinateLabel.AutoSize = true;
            this.PointAXCoordinateLabel.Location = new System.Drawing.Point(118, 109);
            this.PointAXCoordinateLabel.Name = "PointAXCoordinateLabel";
            this.PointAXCoordinateLabel.Size = new System.Drawing.Size(52, 13);
            this.PointAXCoordinateLabel.TabIndex = 39;
            this.PointAXCoordinateLabel.Text = "Point A x:";
            // 
            // EditShape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectColorButton);
            this.Controls.Add(this.ShapeColorSelected);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.RadiusNumber);
            this.Controls.Add(this.RadiusLabel);
            this.Controls.Add(this.CenterYNumber);
            this.Controls.Add(this.CenterYLabel);
            this.Controls.Add(this.CenterXNumber);
            this.Controls.Add(this.CenterXLabel);
            this.Controls.Add(this.HeightNumber);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WidthNumber);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.PointYNumber);
            this.Controls.Add(this.PointYLabel);
            this.Controls.Add(this.PointXNumber);
            this.Controls.Add(this.PointXLabel);
            this.Controls.Add(this.PointCYCoordinateNumber);
            this.Controls.Add(this.PointCYCoordinateLabel);
            this.Controls.Add(this.PointCXCoordinateNumber);
            this.Controls.Add(this.PointCXCoordinateLabel);
            this.Controls.Add(this.PointBYCoordinateNumber);
            this.Controls.Add(this.PointBYCoordinateLabel);
            this.Controls.Add(this.PointBXCoordinateNumber);
            this.Controls.Add(this.PointBXCoordinateLabel);
            this.Controls.Add(this.PointAYCoordinateNumber);
            this.Controls.Add(this.PointAYCoordinateLabel);
            this.Controls.Add(this.FigureLabel);
            this.Controls.Add(this.PointAXCoordinateNumber);
            this.Controls.Add(this.PointAXCoordinateLabel);
            this.Name = "EditShape";
            this.Text = "Edit Shape";
            ((System.ComponentModel.ISupportInitialize)(this.ShapeColorSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CenterYNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CenterXNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointYNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointXNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointCYCoordinateNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointCXCoordinateNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointBYCoordinateNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointBXCoordinateNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointAYCoordinateNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointAXCoordinateNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectColorButton;
        private System.Windows.Forms.PictureBox ShapeColorSelected;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.NumericUpDown RadiusNumber;
        private System.Windows.Forms.Label RadiusLabel;
        private System.Windows.Forms.NumericUpDown CenterYNumber;
        private System.Windows.Forms.Label CenterYLabel;
        private System.Windows.Forms.NumericUpDown CenterXNumber;
        private System.Windows.Forms.Label CenterXLabel;
        private System.Windows.Forms.NumericUpDown HeightNumber;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.NumericUpDown WidthNumber;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.NumericUpDown PointYNumber;
        private System.Windows.Forms.Label PointYLabel;
        private System.Windows.Forms.NumericUpDown PointXNumber;
        private System.Windows.Forms.Label PointXLabel;
        private System.Windows.Forms.NumericUpDown PointCYCoordinateNumber;
        private System.Windows.Forms.Label PointCYCoordinateLabel;
        private System.Windows.Forms.NumericUpDown PointCXCoordinateNumber;
        private System.Windows.Forms.Label PointCXCoordinateLabel;
        private System.Windows.Forms.NumericUpDown PointBYCoordinateNumber;
        private System.Windows.Forms.Label PointBYCoordinateLabel;
        private System.Windows.Forms.NumericUpDown PointBXCoordinateNumber;
        private System.Windows.Forms.Label PointBXCoordinateLabel;
        private System.Windows.Forms.NumericUpDown PointAYCoordinateNumber;
        private System.Windows.Forms.Label PointAYCoordinateLabel;
        private System.Windows.Forms.Label FigureLabel;
        private System.Windows.Forms.NumericUpDown PointAXCoordinateNumber;
        private System.Windows.Forms.Label PointAXCoordinateLabel;
    }
}