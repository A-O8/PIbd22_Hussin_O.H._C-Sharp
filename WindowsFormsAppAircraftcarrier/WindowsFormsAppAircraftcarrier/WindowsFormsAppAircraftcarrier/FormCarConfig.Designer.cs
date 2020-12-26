namespace WindowsFormsAppAircraftcarrier
{
    partial class FormCarConfig
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
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.checkBoxplaines = new System.Windows.Forms.CheckBox();
            this.Aerodrom = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAircraftcarrier = new System.Windows.Forms.Label();
            this.labelWarship = new System.Windows.Forms.Label();
            this.panelWarship = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelColor1 = new System.Windows.Forms.PictureBox();
            this.panelColor2 = new System.Windows.Forms.PictureBox();
            this.panelColor3 = new System.Windows.Forms.PictureBox();
            this.panelColor4 = new System.Windows.Forms.PictureBox();
            this.panelColor8 = new System.Windows.Forms.PictureBox();
            this.panelColor7 = new System.Windows.Forms.PictureBox();
            this.panelColor5 = new System.Windows.Forms.PictureBox();
            this.panelColor6 = new System.Windows.Forms.PictureBox();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelWarship.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor6)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.Aerodrom);
            this.groupBoxParameters.Controls.Add(this.checkBoxplaines);
            this.groupBoxParameters.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParameters.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParameters.Controls.Add(this.labelWeight);
            this.groupBoxParameters.Controls.Add(this.labelMaxSpeed);
            this.groupBoxParameters.Location = new System.Drawing.Point(8, 276);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(502, 168);
            this.groupBoxParameters.TabIndex = 0;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Параметры";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(15, 52);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(140, 13);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Максимальная скорость: ";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(15, 117);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(161, 13);
            this.labelWeight.TabIndex = 0;
            this.labelWeight.Text = "Вес плавательного средства: ";
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.AutoSize = true;
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(161, 52);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownMaxSpeed.TabIndex = 1;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(182, 110);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownWeight.TabIndex = 1;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // checkBoxplaines
            // 
            this.checkBoxplaines.AutoSize = true;
            this.checkBoxplaines.Location = new System.Drawing.Point(287, 53);
            this.checkBoxplaines.Name = "checkBoxplaines";
            this.checkBoxplaines.Size = new System.Drawing.Size(59, 17);
            this.checkBoxplaines.TabIndex = 1;
            this.checkBoxplaines.Text = "plaines";
            this.checkBoxplaines.UseVisualStyleBackColor = true;
            // 
            // Aerodrom
            // 
            this.Aerodrom.AutoSize = true;
            this.Aerodrom.Location = new System.Drawing.Point(287, 91);
            this.Aerodrom.Name = "Aerodrom";
            this.Aerodrom.Size = new System.Drawing.Size(71, 17);
            this.Aerodrom.TabIndex = 1;
            this.Aerodrom.Text = "Aerodrom";
            this.Aerodrom.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelWarship);
            this.groupBox1.Controls.Add(this.labelAircraftcarrier);
            this.groupBox1.Location = new System.Drawing.Point(11, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 225);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // labelAircraftcarrier
            // 
            this.labelAircraftcarrier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAircraftcarrier.Location = new System.Drawing.Point(25, 32);
            this.labelAircraftcarrier.Name = "labelAircraftcarrier";
            this.labelAircraftcarrier.Size = new System.Drawing.Size(133, 81);
            this.labelAircraftcarrier.TabIndex = 0;
            this.labelAircraftcarrier.Text = "labelAircraftcarrier";
            this.labelAircraftcarrier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAircraftcarrier.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelAircraftcarrier_DragDrop);
            this.labelAircraftcarrier.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAircraftcarrier_MouseDown);
            // 
            // labelWarship
            // 
            this.labelWarship.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWarship.Location = new System.Drawing.Point(31, 129);
            this.labelWarship.Name = "labelWarship";
            this.labelWarship.Size = new System.Drawing.Size(127, 72);
            this.labelWarship.TabIndex = 0;
            this.labelWarship.Text = "Warship";
            this.labelWarship.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWarship.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelWarship_MouseDown);
            // 
            // panelWarship
            // 
            this.panelWarship.AllowDrop = true;
            this.panelWarship.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWarship.Controls.Add(this.pictureBox1);
            this.panelWarship.Location = new System.Drawing.Point(304, 44);
            this.panelWarship.Name = "panelWarship";
            this.panelWarship.Size = new System.Drawing.Size(407, 220);
            this.panelWarship.TabIndex = 2;
            this.panelWarship.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelAircraftcarrier_DragDrop);
            this.panelWarship.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelAircraftcarrier_DragEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 181);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelDopColor);
            this.groupBox2.Controls.Add(this.labelMainColor);
            this.groupBox2.Controls.Add(this.panelColor6);
            this.groupBox2.Controls.Add(this.panelColor5);
            this.groupBox2.Controls.Add(this.panelColor7);
            this.groupBox2.Controls.Add(this.panelColor8);
            this.groupBox2.Controls.Add(this.panelColor4);
            this.groupBox2.Controls.Add(this.panelColor3);
            this.groupBox2.Controls.Add(this.panelColor2);
            this.groupBox2.Controls.Add(this.panelColor1);
            this.groupBox2.Location = new System.Drawing.Point(731, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 194);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // panelColor1
            // 
            this.panelColor1.BackColor = System.Drawing.Color.Red;
            this.panelColor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor1.Location = new System.Drawing.Point(24, 87);
            this.panelColor1.Name = "panelColor1";
            this.panelColor1.Size = new System.Drawing.Size(50, 36);
            this.panelColor1.TabIndex = 0;
            this.panelColor1.TabStop = false;
            // 
            // panelColor2
            // 
            this.panelColor2.BackColor = System.Drawing.Color.Lime;
            this.panelColor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor2.Location = new System.Drawing.Point(80, 87);
            this.panelColor2.Name = "panelColor2";
            this.panelColor2.Size = new System.Drawing.Size(50, 36);
            this.panelColor2.TabIndex = 0;
            this.panelColor2.TabStop = false;
            // 
            // panelColor3
            // 
            this.panelColor3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelColor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor3.Location = new System.Drawing.Point(147, 87);
            this.panelColor3.Name = "panelColor3";
            this.panelColor3.Size = new System.Drawing.Size(50, 36);
            this.panelColor3.TabIndex = 0;
            this.panelColor3.TabStop = false;
            // 
            // panelColor4
            // 
            this.panelColor4.BackColor = System.Drawing.Color.Yellow;
            this.panelColor4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor4.Location = new System.Drawing.Point(233, 87);
            this.panelColor4.Name = "panelColor4";
            this.panelColor4.Size = new System.Drawing.Size(50, 36);
            this.panelColor4.TabIndex = 0;
            this.panelColor4.TabStop = false;
            // 
            // panelColor8
            // 
            this.panelColor8.BackColor = System.Drawing.Color.Fuchsia;
            this.panelColor8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor8.Location = new System.Drawing.Point(233, 129);
            this.panelColor8.Name = "panelColor8";
            this.panelColor8.Size = new System.Drawing.Size(50, 42);
            this.panelColor8.TabIndex = 0;
            this.panelColor8.TabStop = false;
            // 
            // panelColor7
            // 
            this.panelColor7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelColor7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor7.Location = new System.Drawing.Point(147, 130);
            this.panelColor7.Name = "panelColor7";
            this.panelColor7.Size = new System.Drawing.Size(50, 42);
            this.panelColor7.TabIndex = 0;
            this.panelColor7.TabStop = false;
            // 
            // panelColor5
            // 
            this.panelColor5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelColor5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor5.Location = new System.Drawing.Point(28, 130);
            this.panelColor5.Name = "panelColor5";
            this.panelColor5.Size = new System.Drawing.Size(50, 42);
            this.panelColor5.TabIndex = 0;
            this.panelColor5.TabStop = false;
            // 
            // panelColor6
            // 
            this.panelColor6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelColor6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor6.Location = new System.Drawing.Point(91, 130);
            this.panelColor6.Name = "panelColor6";
            this.panelColor6.Size = new System.Drawing.Size(50, 42);
            this.panelColor6.TabIndex = 0;
            this.panelColor6.TabStop = false;
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(28, 16);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(102, 38);
            this.labelMainColor.TabIndex = 1;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(144, 16);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(65, 34);
            this.labelDopColor.TabIndex = 1;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(761, 314);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(204, 44);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(761, 372);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(204, 44);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormCarConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelWarship);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxParameters);
            this.Name = "FormCarConfig";
            this.Text = "FormCarConfig";
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panelWarship.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelColor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.CheckBox Aerodrom;
        private System.Windows.Forms.CheckBox checkBoxplaines;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelWarship;
        private System.Windows.Forms.Label labelAircraftcarrier;
        private System.Windows.Forms.Panel panelWarship;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.PictureBox panelColor6;
        private System.Windows.Forms.PictureBox panelColor5;
        private System.Windows.Forms.PictureBox panelColor7;
        private System.Windows.Forms.PictureBox panelColor8;
        private System.Windows.Forms.PictureBox panelColor4;
        private System.Windows.Forms.PictureBox panelColor3;
        private System.Windows.Forms.PictureBox panelColor2;
        private System.Windows.Forms.PictureBox panelColor1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}