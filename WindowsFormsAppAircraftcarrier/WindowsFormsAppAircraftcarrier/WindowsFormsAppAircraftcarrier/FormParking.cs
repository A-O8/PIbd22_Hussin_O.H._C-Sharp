using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
namespace WindowsFormsAppAircraftcarrier
{
    public partial class FormParking : Form
    {
        private readonly ParkingCollection parkingCollection;
        private readonly Logger logger;
        public FormParking()
        {
            InitializeComponent();
            parkingCollection = new ParkingCollection(boxParkimg.Width, boxParkimg.Height);
            logger = LogManager.GetCurrentClassLogger();
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
        private void AddAircraftcarrier(Ship Ship)
        {
            if (Ship != null && listBoxParkings.SelectedIndex > -1)
            {
                try { 
                if ((parkingCollection[listBoxParkings.SelectedItem.ToString()]) + Ship)
                {
                    Draw();
                        logger.Info($"Добавлена Ship{Ship}");
                    }
                else
                {
                    MessageBox.Show("поставить не удалось");
                }
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    logger.Warn(ex.Message);
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn(ex.Message);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void bTake_Click(object sender, EventArgs e)
            {
                if (listBoxParkings.SelectedIndex > -1 && placeparking.Text != "")
                {
                    try
                    {
                        var Aircraftcarrier = parkingCollection[listBoxParkings.SelectedItem.ToString()] - Convert.ToInt32(placeparking.Text);
                if (Aircraftcarrier != null)
                {
                    FormAircraft_carrier form = new FormAircraft_carrier();
                    form.SetWarship(Aircraftcarrier);
                    form.ShowDialog();
                        logger.Info($"Изъята ship {Aircraftcarrier} с места {placeparking.Text}");
                        Draw();
                    }
                }
                catch (ParkingNotFoundException ex)
                {
                    logger.Warn(ex.Message);
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn(ex.Message);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на парковку {listBoxParkings.SelectedItem.ToString()}");
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
            if (string.IsNullOrEmpty(Nameparking.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            parkingCollection.AddParking(Nameparking.Text);
            logger.Info($"Добавили парковку {Nameparking.Text}");
            ReloadLevels();
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    logger.Warn(ex.Message);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (ParkingOccupiedPlaceException ex)
                {
                    logger.Warn(ex.Message);
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn(ex.Message);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Sort_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                parkingCollection[listBoxParkings.SelectedItem.ToString()].Sort();
                Draw();
                logger.Info("Сортировка уровней");
            }
        }
    }
}


