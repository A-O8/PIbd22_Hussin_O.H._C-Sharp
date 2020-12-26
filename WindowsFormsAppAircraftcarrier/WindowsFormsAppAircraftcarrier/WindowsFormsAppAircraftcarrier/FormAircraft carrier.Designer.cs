namespace WindowsFormsAppAircraftcarrier
{
    partial class FormAircraft_carrier
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
          this.Warship = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.pictureBoxAircraft_carrier = new System.Windows.Forms.PictureBox();
            this.Aircraftcarrier = new System.Windows.Forms.Button();
            this.Aircraftcamier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAircraft_carrier)).BeginInit();
            this.SuspendLayout();
            // 
            // Warship
            // 
            this.Warship.Location = new System.Drawing.Point(0, 0);
            this.Warship.Name = "Warship";
            this.Warship.Size = new System.Drawing.Size(104, 46);
            this.Warship.TabIndex = 1;
            this.Warship.Text = "Warship";
            this.Warship.UseVisualStyleBackColor = true;
            this.Warship.Click += new System.EventHandler(this.Warship_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::WindowsFormsAppAircraftcarrier.Properties.Resources.Скриншот_02_08_2020_094237;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(750, 404);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(50, 46);
            this.buttonRight.TabIndex = 1;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.MoveAircraftcarrier_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::WindowsFormsAppAircraftcarrier.Properties.Resources.Скриншот_02_08_2020_094108;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(631, 404);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(56, 40);
            this.buttonLeft.TabIndex = 1;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.MoveAircraftcarrier_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::WindowsFormsAppAircraftcarrier.Properties.Resources.Скриншот_02_08_2020_094316;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(693, 352);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(51, 46);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.MoveAircraftcarrier_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::WindowsFormsAppAircraftcarrier.Properties.Resources.Скриншот_02_08_2020_093703;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(693, 404);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(51, 46);
            this.buttonDown.TabIndex = 1;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.MoveAircraftcarrier_Click);
            // 
            // pictureBoxAircraft_carrier
            // 
            this.pictureBoxAircraft_carrier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAircraft_carrier.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAircraft_carrier.Name = "pictureBoxAircraft_carrier";
            this.pictureBoxAircraft_carrier.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxAircraft_carrier.TabIndex = 0;
            this.pictureBoxAircraft_carrier.TabStop = false;
            // 
            // Aircraftcarrier
            // 
            this.Aircraftcarrier.Location = new System.Drawing.Point(123, 7);
            this.Aircraftcarrier.Name = "Aircraftcarrier";
            this.Aircraftcarrier.Size = new System.Drawing.Size(93, 38);
            this.Aircraftcarrier.TabIndex = 2;
            this.Aircraftcarrier.Text = "Aircraftcarrier";
            this.Aircraftcarrier.UseVisualStyleBackColor = true;
            this.Aircraftcarrier.Click += new System.EventHandler(this.Aircraftcarrier_Click);
            // 
            // Aircraftcamier
            // 
            this.Aircraftcamier.Location = new System.Drawing.Point(110, 0);
            this.Aircraftcamier.Name = "Aircraftcamier";
            this.Aircraftcamier.Size = new System.Drawing.Size(95, 48);
            this.Aircraftcamier.TabIndex = 2;
            this.Aircraftcamier.Text = "Aircraftcarrier";
            this.Aircraftcamier.UseVisualStyleBackColor = true;
            this.Aircraftcamier.Click += new System.EventHandler(this.Aircraftcarrier_Click);
            // 
            // FormAircraft_carrier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Aircraftcamier);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.Warship);
            this.Controls.Add(this.pictureBoxAircraft_carrier);
            this.Name = "FormAircraft_carrier";
            this.Text = "FormAircraft_carrier";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAircraft_carrier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAircraft_carrier;
        private System.Windows.Forms.Button Warship;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button Aircraftcarrier;
        private System.Windows.Forms.Button Aircraftcamier;
    }
}