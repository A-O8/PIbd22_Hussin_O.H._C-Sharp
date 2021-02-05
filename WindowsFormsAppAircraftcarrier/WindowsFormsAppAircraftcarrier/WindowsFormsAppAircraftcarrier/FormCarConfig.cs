using System;
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
            Cancel.Click += (object sender, EventArgs e) => { Close(); };
            colorred.MouseDown += panelColor_MouseDown;
            colorlime.MouseDown += panelColor_MouseDown;
            colorblack.MouseDown += panelColor_MouseDown;
            coloryellow.MouseDown += panelColor_MouseDown;
            colorblue.MouseDown += panelColor_MouseDown;
            colorwhite.MouseDown += panelColor_MouseDown;
            colorteal.MouseDown += panelColor_MouseDown;
            colorfuchsia.MouseDown += panelColor_MouseDown;
            Add.Click += (object sender, EventArgs e) => { eventAddWarship.Invoke(Ship); Close(); };
        }
        private void Drawship()
        {
            if (Ship != null)
            {
                Bitmap bmp = new Bitmap(display.Width, display.Height);
                Graphics gr = Graphics.FromImage(bmp);
                Ship.SetPosition(5, 5, display.Width, display.Height);
                Ship.Drawship(gr);
                display.Image = bmp;
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

                    plaines.Checked, Aerodrom.Checked);

                    break;
            }
            Drawship();
        }
        private void labelAircraftcarrier_MouseDown(object sender, MouseEventArgs e)
        {
            Aircraftcarrier.DoDragDrop(Aircraftcarrier.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelWarship_MouseDown(object sender, MouseEventArgs e)
        {
            Warship.DoDragDrop(Warship.Text, DragDropEffects.Move | DragDropEffects.Copy);
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

        private void Add_Click(object sender, EventArgs e)
        {

        }
    }
}
