﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAircraftcarrier
{
    public partial class FormCarConfig : Form
    {
        WaterITransport Ship = null;
        private event Action<WaterITransport> eventAddWarship;
        public FormCarConfig()
        {
            InitializeComponent();
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
            panelColor1.MouseDown += panelColor_MouseDown;
            panelColor2.MouseDown += panelColor_MouseDown;
            panelColor3.MouseDown += panelColor_MouseDown;
            panelColor4.MouseDown += panelColor_MouseDown;
            panelColor5.MouseDown += panelColor_MouseDown;
            panelColor6.MouseDown += panelColor_MouseDown;
            panelColor7.MouseDown += panelColor_MouseDown;
            panelColor8.MouseDown += panelColor_MouseDown;
            buttonAdd.Click += (object sender, EventArgs e) => { eventAddWarship.Invoke(Ship); Close(); };
        }
        private void Drawship()
        {
            if (Ship != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                Ship.SetPosition(5, 5, pictureBox1.Width, pictureBox1.Height);
                Ship.Drawship(gr);
                pictureBox1.Image = bmp;
            }
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void panelAircraftcarrier_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "labelAircraftcarrier":
                    Ship = new Warship((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White);

                    break;
                case "Warship":
                    Ship = new Aircraft_carrier((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black,

                    checkBoxplaines.Checked, Aerodrom.Checked);

                    break;
            }
            Drawship();
        }
        private void labelAircraftcarrier_MouseDown(object sender, MouseEventArgs e)
        {
            labelAircraftcarrier.DoDragDrop(labelAircraftcarrier.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelWarship_MouseDown(object sender, MouseEventArgs e)
        {
            labelWarship.DoDragDrop(labelWarship.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void panelAircraftcarrier_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (Ship != null)
            {
                Ship.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                Drawship();
            }
        }
        private void labelColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else e.Effect = DragDropEffects.None;
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (Ship is Aircraft_carrier && Ship != null)
            {
                ((Aircraft_carrier)Ship).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                Drawship();
            }
        }
        public void AddEvent(Action<WaterITransport> ev)
        {
            if (eventAddWarship == null)
            {
                eventAddWarship = ev;
            }
            else
            {
                eventAddWarship += ev;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
