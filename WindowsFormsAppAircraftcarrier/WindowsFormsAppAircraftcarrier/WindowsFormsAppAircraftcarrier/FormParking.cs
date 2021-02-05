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
            private void WArship_Click(object sender, EventArgs e)
            {
            var formCarConfig = new FormCarConfig();
            formCarConfig.AddEvent(AddAircraftcarrier);
            formCarConfig.Show();
        }
        private void AddAircraftcarrier(WaterITransport Ship)
        {
            if (Ship != null && listBoxParkings.SelectedIndex > -1)
            {
                if ((parkingCollection[listBoxParkings.SelectedItem.ToString()]) + Ship)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("поставить не удалось");
                }
            }
        }
        private void bTake_Click(object sender, EventArgs e)
            {

            if (maskedTextBox.Text != "")
            {
                var Aircraftcarrier = parkingCollection[listBoxParkings.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);

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
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (parkingCollection.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (parkingCollection.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    } 


