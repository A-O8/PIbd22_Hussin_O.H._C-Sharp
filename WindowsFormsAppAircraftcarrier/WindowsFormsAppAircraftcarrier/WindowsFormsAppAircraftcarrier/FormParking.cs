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
    public partial class FormParking : Form
    {

        private readonly Parking<Warship> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<Warship>(boxParkimg.Width, boxParkimg.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(boxParkimg.Width, boxParkimg.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            boxParkimg.Image = bmp;
        }
        private void Aircraftcamier_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var а1 = new Aircraft_carrier(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    if (parking + а1)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }
            private void WArship_Click(object sender, EventArgs e)
            {

            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var car = new Warship(100, 1000, dialog.Color);

                if (parking + car)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }
            private void bTake_Click(object sender, EventArgs e)
            {

            if (maskedTextBox1.Text != "")
            {
                var Aircraftcarrier = parking - Convert.ToInt32(maskedTextBox1.Text);

                if (Aircraftcarrier != null)
                {
                    FormAircraft_carrier form = new FormAircraft_carrier();
                    form.SetWarship(Aircraftcarrier);
                    form.ShowDialog();
                }

                Draw();
            }

        }
    }
    } 


