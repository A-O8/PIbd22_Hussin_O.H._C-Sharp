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
        private readonly ParkingCollection parkingCollection;
        public FormParking()
        {
            InitializeComponent();
            parkingCollection = new ParkingCollection(boxParkimg.Width, boxParkimg.Height); 
        }
        private void ReloadLevels()
        {
            int index = listBoxParkings.SelectedIndex;
            listBoxParkings.Items.Clear();
            for (int i = 0; i < parkingCollection.Keys.Count; i++)
            {
                listBoxParkings.Items.Add(parkingCollection.Keys[i]);
            }
            if (listBoxParkings.Items.Count > 0 && (index == -1 || index >= listBoxParkings.Items.Count))
            {
                listBoxParkings.SelectedIndex = 0;
            }
            else if (listBoxParkings.Items.Count > 0 && index > -1 && index < listBoxParkings.Items.Count)
            {
                listBoxParkings.SelectedIndex = index;
            }
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(boxParkimg.Width, boxParkimg.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parkingCollection[listBoxParkings.SelectedItem.ToString()].Draw(gr);
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
                        var ship = new Aircraft_carrier(100, 1000, dialog.Color, dialogDop.Color, true, true);
                        if (parkingCollection[listBoxParkings.SelectedItem.ToString()] + ship)
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
                var ship = new Warship(100, 1000, dialog.Color);

                if (parkingCollection[listBoxParkings.SelectedItem.ToString()] + ship)
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
                var Aircraftcarrier = parkingCollection[listBoxParkings.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox1.Text);

                if (Aircraftcarrier != null)
                {
                    FormAircraft_carrier form = new FormAircraft_carrier();
                    form.SetWarship(Aircraftcarrier);
                    form.ShowDialog();
                }

                Draw();
            }
        }

        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void DelParking_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку {listBoxParkings.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    parkingCollection.DelParking(listBoxParkings.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }

        private void AddParking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            parkingCollection.AddParking(textBoxNewLevelName.Text);
            ReloadLevels();
        }
    }
    } 


