namespace WindowsFormsAppAircraftcarrier
{
    partial class FormParking
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
            this.boxParkimg = new System.Windows.Forms.PictureBox();
            this.Warship = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.TextBox();
            this.bTake = new System.Windows.Forms.Button();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.Delete = new System.Windows.Forms.Button();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.buttonAddParking_Click = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boxParkimg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxParkimg
            // 
            this.boxParkimg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxParkimg.Location = new System.Drawing.Point(0, 0);
            this.boxParkimg.Name = "boxParkimg";
            this.boxParkimg.Size = new System.Drawing.Size(1015, 698);
            this.boxParkimg.TabIndex = 0;
            this.boxParkimg.TabStop = false;
            // 
            // Warship
            // 
            this.Warship.Location = new System.Drawing.Point(812, 105);
            this.Warship.Name = "Warship";
            this.Warship.Size = new System.Drawing.Size(202, 69);
            this.Warship.TabIndex = 1;
            this.Warship.Text = "the Warship";
            this.Warship.UseVisualStyleBackColor = true;
            this.Warship.Click += new System.EventHandler(this.WArship_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.bTake);
            this.groupBox1.Location = new System.Drawing.Point(808, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 194);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "the  Ship";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Place: ";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(77, 88);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(43, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // bTake
            // 
            this.bTake.Location = new System.Drawing.Point(66, 146);
            this.bTake.Name = "bTake";
            this.bTake.Size = new System.Drawing.Size(86, 42);
            this.bTake.TabIndex = 0;
            this.bTake.Text = "Take";
            this.bTake.UseVisualStyleBackColor = true;
            this.bTake.Click += new System.EventHandler(this.bTake_Click);
            // 
            // listBoxParkings
            // 
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.Location = new System.Drawing.Point(809, 553);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(206, 95);
            this.listBoxParkings.TabIndex = 3;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(812, 654);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(199, 34);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.DelParking_Click);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(844, 472);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(142, 20);
            this.textBoxNewLevelName.TabIndex = 5;
            // 
            // buttonAddParking_Click
            // 
            this.buttonAddParking_Click.Location = new System.Drawing.Point(812, 509);
            this.buttonAddParking_Click.Name = "buttonAddParking_Click";
            this.buttonAddParking_Click.Size = new System.Drawing.Size(190, 33);
            this.buttonAddParking_Click.TabIndex = 6;
            this.buttonAddParking_Click.Text = "Add";
            this.buttonAddParking_Click.UseVisualStyleBackColor = true;
            this.buttonAddParking_Click.Click += new System.EventHandler(this.AddParking_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(893, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "parking:";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 698);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddParking_Click);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Warship);
            this.Controls.Add(this.boxParkimg);
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.boxParkimg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox boxParkimg;
        private System.Windows.Forms.Button Warship;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bTake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maskedTextBox1;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button buttonAddParking_Click;
        private System.Windows.Forms.Label label2;
    }
}