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
            this.group_ship = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.placeparking = new System.Windows.Forms.TextBox();
            this.bTake = new System.Windows.Forms.Button();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Nameparking = new System.Windows.Forms.TextBox();
            this.ADD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сахранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Sort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boxParkimg)).BeginInit();
            this.group_ship.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxParkimg
            // 
            this.boxParkimg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxParkimg.Location = new System.Drawing.Point(0, 24);
            this.boxParkimg.Name = "boxParkimg";
            this.boxParkimg.Size = new System.Drawing.Size(1158, 674);
            this.boxParkimg.TabIndex = 0;
            this.boxParkimg.TabStop = false;
            // 
            // Warship
            // 
            this.Warship.Location = new System.Drawing.Point(944, 81);
            this.Warship.Name = "Warship";
            this.Warship.Size = new System.Drawing.Size(202, 69);
            this.Warship.TabIndex = 1;
            this.Warship.Text = "the Warship";
            this.Warship.UseVisualStyleBackColor = true;
            this.Warship.Click += new System.EventHandler(this.WArship_Click);
            // 
            // group_ship
            // 
            this.group_ship.Controls.Add(this.label1);
            this.group_ship.Controls.Add(this.placeparking);
            this.group_ship.Controls.Add(this.bTake);
            this.group_ship.Location = new System.Drawing.Point(944, 220);
            this.group_ship.Name = "group_ship";
            this.group_ship.Size = new System.Drawing.Size(202, 191);
            this.group_ship.TabIndex = 2;
            this.group_ship.TabStop = false;
            this.group_ship.Text = "the  Ship";
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
            // placeparking
            // 
            this.placeparking.Location = new System.Drawing.Point(77, 88);
            this.placeparking.Name = "placeparking";
            this.placeparking.Size = new System.Drawing.Size(43, 20);
            this.placeparking.TabIndex = 1;
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
            this.listBoxParkings.Location = new System.Drawing.Point(937, 526);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(206, 95);
            this.listBoxParkings.TabIndex = 3;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(944, 627);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(199, 34);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.DelParking_Click);
            // 
            // Nameparking
            // 
            this.Nameparking.Location = new System.Drawing.Point(973, 461);
            this.Nameparking.Name = "Nameparking";
            this.Nameparking.Size = new System.Drawing.Size(142, 20);
            this.Nameparking.TabIndex = 5;
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(944, 487);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(190, 33);
            this.ADD.TabIndex = 6;
            this.ADD.Text = "Add";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.AddParking_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1019, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "parking:";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1158, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сахранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сахранитьToolStripMenuItem
            // 
            this.сахранитьToolStripMenuItem.Name = "сахранитьToolStripMenuItem";
            this.сахранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сахранитьToolStripMenuItem.Text = "Сахранить";
            this.сахранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(951, 164);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(191, 44);
            this.Sort.TabIndex = 9;
            this.Sort.Text = "Sort";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 698);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.Nameparking);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.group_ship);
            this.Controls.Add(this.Warship);
            this.Controls.Add(this.boxParkimg);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.boxParkimg)).EndInit();
            this.group_ship.ResumeLayout(false);
            this.group_ship.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox boxParkimg;
        private System.Windows.Forms.Button Warship;
        private System.Windows.Forms.GroupBox group_ship;
        private System.Windows.Forms.Button bTake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox placeparking;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox Nameparking;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сахранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button Sort;
    }
}