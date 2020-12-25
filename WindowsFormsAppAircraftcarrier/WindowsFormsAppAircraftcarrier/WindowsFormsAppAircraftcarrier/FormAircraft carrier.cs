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
    public partial class FormAircraft_carrier : Form
    {

        private WaterITransport ship;
        public FormAircraft_carrier()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAircraft_carrier.Width, pictureBoxAircraft_carrier.Height);
            Graphics gr = Graphics.FromImage(bmp);
            ship.Drawship(gr);
            pictureBoxAircraft_carrier.Image = bmp;
        }

        private void Aircraftcarrier_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new Aircraft_carrier(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Yellow, true, true);
            ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAircraft_carrier.Width, pictureBoxAircraft_carrier.Height);
            Draw();
        }

        private void MoveAircraftcarrier_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    ship.MoveShip(Direction.Up);
                    break;
                case "buttonDown":
                    ship.MoveShip(Direction.Down);
                    break;
                case "buttonLeft":
                    ship.MoveShip(Direction.Left);
                    break;
                case "buttonRight":
                    ship.MoveShip(Direction.Right);
                    break;
            }
            Draw();
        }

        private void Warship_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new Warship(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green);
           ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAircraft_carrier.Width,
          pictureBoxAircraft_carrier.Height);
            Draw();
        }
    }
}
