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
            this.Warship = new System.Windows.Forms.Label();
            this.Aircraftcarrier = new System.Windows.Forms.Label();
            this.panelWarship = new System.Windows.Forms.Panel();
            this.display = new System.Windows.Forms.PictureBox();
            this.Colour = new System.Windows.Forms.GroupBox();
            this.DopColor = new System.Windows.Forms.Label();
            this.MainColor = new System.Windows.Forms.Label();
            this.colorpurple = new System.Windows.Forms.PictureBox();
            this.colorblue = new System.Windows.Forms.PictureBox();
            this.colorwhite = new System.Windows.Forms.PictureBox();
            this.colorfuchsia = new System.Windows.Forms.PictureBox();
            this.coloryellow = new System.Windows.Forms.PictureBox();
            this.colorblack = new System.Windows.Forms.PictureBox();
            this.colorgreen = new System.Windows.Forms.PictureBox();
            this.colorred = new System.Windows.Forms.PictureBox();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Parameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            this.body.SuspendLayout();
            this.panelWarship.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
            this.Colour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorpurple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorblue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorwhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorfuchsia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloryellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorblack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorgreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorred)).BeginInit();
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
            this.body.Controls.Add(this.Warship);
            this.body.Controls.Add(this.Aircraftcarrier);
            this.body.Location = new System.Drawing.Point(11, 40);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(265, 225);
            this.body.TabIndex = 1;
            this.body.TabStop = false;
            this.body.Text = "body";
            // 
            // Warship
            // 
            this.Warship.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Warship.Location = new System.Drawing.Point(25, 129);
            this.Warship.Name = "Warship";
            this.Warship.Size = new System.Drawing.Size(133, 72);
            this.Warship.TabIndex = 0;
            this.Warship.Text = "Warship";
            this.Warship.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Warship.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelWarship_MouseDown);
            // 
            // Aircraftcarrier
            // 
            this.Aircraftcarrier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Aircraftcarrier.Location = new System.Drawing.Point(25, 45);
            this.Aircraftcarrier.Name = "Aircraftcarrier";
            this.Aircraftcarrier.Size = new System.Drawing.Size(133, 68);
            this.Aircraftcarrier.TabIndex = 0;
            this.Aircraftcarrier.Text = "labelAircraftcarrier";
            this.Aircraftcarrier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Aircraftcarrier.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelAircraftcarrier_DragDrop);
            this.Aircraftcarrier.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAircraftcarrier_MouseDown);
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
            this.display.Location = new System.Drawing.Point(3, 3);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(399, 212);
            this.display.TabIndex = 0;
            this.display.TabStop = false;
            // 
            // Colour
            // 
            this.Colour.Controls.Add(this.DopColor);
            this.Colour.Controls.Add(this.MainColor);
            this.Colour.Controls.Add(this.colorpurple);
            this.Colour.Controls.Add(this.colorblue);
            this.Colour.Controls.Add(this.colorwhite);
            this.Colour.Controls.Add(this.colorfuchsia);
            this.Colour.Controls.Add(this.coloryellow);
            this.Colour.Controls.Add(this.colorblack);
            this.Colour.Controls.Add(this.colorgreen);
            this.Colour.Controls.Add(this.colorred);
            this.Colour.Location = new System.Drawing.Point(731, 69);
            this.Colour.Name = "Colour";
            this.Colour.Size = new System.Drawing.Size(325, 194);
            this.Colour.TabIndex = 3;
            this.Colour.TabStop = false;
            this.Colour.Text = "Colour";
            // 
            // DopColor
            // 
            this.DopColor.AllowDrop = true;
            this.DopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DopColor.Location = new System.Drawing.Point(181, 16);
            this.DopColor.Name = "DopColor";
            this.DopColor.Size = new System.Drawing.Size(102, 34);
            this.DopColor.TabIndex = 1;
            this.DopColor.Text = "Доп. цвет";
            this.DopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.DopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // MainColor
            // 
            this.MainColor.AllowDrop = true;
            this.MainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainColor.Location = new System.Drawing.Point(28, 16);
            this.MainColor.Name = "MainColor";
            this.MainColor.Size = new System.Drawing.Size(113, 38);
            this.MainColor.TabIndex = 1;
            this.MainColor.Text = "Основной цвет";
            this.MainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.MainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // colorpurple
            // 
            this.colorpurple.BackColor = System.Drawing.Color.Purple;
            this.colorpurple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorpurple.Location = new System.Drawing.Point(91, 130);
            this.colorpurple.Name = "colorpurple";
            this.colorpurple.Size = new System.Drawing.Size(50, 42);
            this.colorpurple.TabIndex = 0;
            this.colorpurple.TabStop = false;
            // 
            // colorblue
            // 
            this.colorblue.BackColor = System.Drawing.Color.Blue;
            this.colorblue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorblue.Location = new System.Drawing.Point(28, 130);
            this.colorblue.Name = "colorblue";
            this.colorblue.Size = new System.Drawing.Size(50, 42);
            this.colorblue.TabIndex = 0;
            this.colorblue.TabStop = false;
            // 
            // colorwhite
            // 
            this.colorwhite.BackColor = System.Drawing.Color.White;
            this.colorwhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorwhite.Location = new System.Drawing.Point(159, 129);
            this.colorwhite.Name = "colorwhite";
            this.colorwhite.Size = new System.Drawing.Size(50, 42);
            this.colorwhite.TabIndex = 0;
            this.colorwhite.TabStop = false;
            // 
            // colorfuchsia
            // 
            this.colorfuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.colorfuchsia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorfuchsia.Location = new System.Drawing.Point(233, 129);
            this.colorfuchsia.Name = "colorfuchsia";
            this.colorfuchsia.Size = new System.Drawing.Size(50, 42);
            this.colorfuchsia.TabIndex = 0;
            this.colorfuchsia.TabStop = false;
            // 
            // coloryellow
            // 
            this.coloryellow.BackColor = System.Drawing.Color.Yellow;
            this.coloryellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.coloryellow.Location = new System.Drawing.Point(233, 87);
            this.coloryellow.Name = "coloryellow";
            this.coloryellow.Size = new System.Drawing.Size(50, 36);
            this.coloryellow.TabIndex = 0;
            this.coloryellow.TabStop = false;
            // 
            // colorblack
            // 
            this.colorblack.BackColor = System.Drawing.Color.Black;
            this.colorblack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorblack.Location = new System.Drawing.Point(159, 87);
            this.colorblack.Name = "colorblack";
            this.colorblack.Size = new System.Drawing.Size(50, 36);
            this.colorblack.TabIndex = 0;
            this.colorblack.TabStop = false;
            // 
            // colorgreen
            // 
            this.colorgreen.BackColor = System.Drawing.Color.Lime;
            this.colorgreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorgreen.Location = new System.Drawing.Point(91, 87);
            this.colorgreen.Name = "colorgreen";
            this.colorgreen.Size = new System.Drawing.Size(50, 36);
            this.colorgreen.TabIndex = 0;
            this.colorgreen.TabStop = false;
            // 
            // colorred
            // 
            this.colorred.BackColor = System.Drawing.Color.Red;
            this.colorred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorred.Location = new System.Drawing.Point(24, 87);
            this.colorred.Name = "colorred";
            this.colorred.Size = new System.Drawing.Size(50, 36);
            this.colorred.TabIndex = 0;
            this.colorred.TabStop = false;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(761, 314);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(204, 44);
            this.Add.TabIndex = 4;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.colorpurple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorblue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorwhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorfuchsia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloryellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorblack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorgreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorred)).EndInit();
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
        private System.Windows.Forms.Label Warship;
        private System.Windows.Forms.Label Aircraftcarrier;
        private System.Windows.Forms.Panel panelWarship;
        private System.Windows.Forms.PictureBox display;
        private System.Windows.Forms.GroupBox Colour;
        private System.Windows.Forms.Label DopColor;
        private System.Windows.Forms.Label MainColor;
        private System.Windows.Forms.PictureBox colorpurple;
        private System.Windows.Forms.PictureBox colorblue;
        private System.Windows.Forms.PictureBox colorwhite;
        private System.Windows.Forms.PictureBox colorfuchsia;
        private System.Windows.Forms.PictureBox coloryellow;
        private System.Windows.Forms.PictureBox colorblack;
        private System.Windows.Forms.PictureBox colorgreen;
        private System.Windows.Forms.PictureBox colorred;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
    }
}