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
            this.Parameters = new System.Windows.Forms.GroupBox();
            this.Aerodrom = new System.Windows.Forms.CheckBox();
            this.plaines = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.GroupBox();
            this.labelWarship = new System.Windows.Forms.Label();
            this.labelAircraftcarrier = new System.Windows.Forms.Label();
            this.panelWarship = new System.Windows.Forms.Panel();
            this.display = new System.Windows.Forms.PictureBox();
            this.Colour = new System.Windows.Forms.GroupBox();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.panelColor6 = new System.Windows.Forms.PictureBox();
            this.panelColor5 = new System.Windows.Forms.PictureBox();
            this.panelColor7 = new System.Windows.Forms.PictureBox();
            this.panelColor8 = new System.Windows.Forms.PictureBox();
            this.panelColor4 = new System.Windows.Forms.PictureBox();
            this.panelColor3 = new System.Windows.Forms.PictureBox();
            this.panelColor2 = new System.Windows.Forms.PictureBox();
            this.panelColor1 = new System.Windows.Forms.PictureBox();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Parameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            this.body.SuspendLayout();
            this.panelWarship.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
            this.Colour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor1)).BeginInit();
            this.SuspendLayout();
            // 
            // Parameters
            // 
            this.Parameters.Controls.Add(this.Aerodrom);
            this.Parameters.Controls.Add(this.plaines);
            this.Parameters.Controls.Add(this.numericUpDownWeight);
            this.Parameters.Controls.Add(this.numericUpDownMaxSpeed);
            this.Parameters.Controls.Add(this.labelWeight);
            this.Parameters.Controls.Add(this.labelMaxSpeed);
            this.Parameters.Location = new System.Drawing.Point(8, 276);
            this.Parameters.Name = "Parameters";
            this.Parameters.Size = new System.Drawing.Size(502, 168);
            this.Parameters.TabIndex = 0;
            this.Parameters.TabStop = false;
            this.Parameters.Text = "Параметры";
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
            // plaines
            // 
            this.plaines.AutoSize = true;
            this.plaines.Location = new System.Drawing.Point(287, 53);
            this.plaines.Name = "plaines";
            this.plaines.Size = new System.Drawing.Size(59, 17);
            this.plaines.TabIndex = 1;
            this.plaines.Text = "plaines";
            this.plaines.UseVisualStyleBackColor = true;
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
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(15, 117);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(161, 13);
            this.labelWeight.TabIndex = 0;
            this.labelWeight.Text = "Вес плавательного средства: ";
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
            // body
            // 
            this.body.Controls.Add(this.labelWarship);
            this.body.Controls.Add(this.labelAircraftcarrier);
            this.body.Location = new System.Drawing.Point(11, 40);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(265, 225);
            this.body.TabIndex = 1;
            this.body.TabStop = false;
            this.body.Text = "body";
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
            // panelWarship
            // 
            this.panelWarship.AllowDrop = true;
            this.panelWarship.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWarship.Controls.Add(this.display);
            this.panelWarship.Location = new System.Drawing.Point(304, 44);
            this.panelWarship.Name = "panelWarship";
            this.panelWarship.Size = new System.Drawing.Size(407, 220);
            this.panelWarship.TabIndex = 2;
            this.panelWarship.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelAircraftcarrier_DragDrop);
            this.panelWarship.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelAircraftcarrier_DragEnter);
            // 
            // display
            // 
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display.Location = new System.Drawing.Point(3, 24);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(394, 181);
            this.display.TabIndex = 0;
            this.display.TabStop = false;
            // 
            // Colour
            // 
            this.Colour.Controls.Add(this.labelDopColor);
            this.Colour.Controls.Add(this.labelMainColor);
            this.Colour.Controls.Add(this.panelColor6);
            this.Colour.Controls.Add(this.panelColor5);
            this.Colour.Controls.Add(this.panelColor7);
            this.Colour.Controls.Add(this.panelColor8);
            this.Colour.Controls.Add(this.panelColor4);
            this.Colour.Controls.Add(this.panelColor3);
            this.Colour.Controls.Add(this.panelColor2);
            this.Colour.Controls.Add(this.panelColor1);
            this.Colour.Location = new System.Drawing.Point(731, 69);
            this.Colour.Name = "Colour";
            this.Colour.Size = new System.Drawing.Size(325, 194);
            this.Colour.TabIndex = 3;
            this.Colour.TabStop = false;
            this.Colour.Text = "Colour";
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
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(761, 314);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(204, 44);
            this.Add.TabIndex = 4;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(761, 372);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(204, 44);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // FormCarConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Colour);
            this.Controls.Add(this.panelWarship);
            this.Controls.Add(this.body);
            this.Controls.Add(this.Parameters);
            this.Name = "FormCarConfig";
            this.Text = "FormCarConfig";
            this.Parameters.ResumeLayout(false);
            this.Parameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            this.body.ResumeLayout(false);
            this.panelWarship.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.display)).EndInit();
            this.Colour.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelColor6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColor1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Parameters;
        private System.Windows.Forms.CheckBox Aerodrom;
        private System.Windows.Forms.CheckBox plaines;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.GroupBox body;
        private System.Windows.Forms.Label labelWarship;
        private System.Windows.Forms.Label labelAircraftcarrier;
        private System.Windows.Forms.Panel panelWarship;
        private System.Windows.Forms.PictureBox display;
        private System.Windows.Forms.GroupBox Colour;
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
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
    }
}